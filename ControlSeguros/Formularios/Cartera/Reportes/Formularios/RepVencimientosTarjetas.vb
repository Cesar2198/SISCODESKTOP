Imports Utilerias.Genericas

Public Class RepVencimientosTarjetas

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.txtFechaDesde.Text = "" Then
            MsgBox("Debe especificar la fecha inicial de vencimientos de tarjetas.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtFechaHasta.Text = "" Then
            MsgBox("Debe especificar la fecha final de vencimientos de tarjetas.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        'haremos una lista de los avisos de cobro con tarjeta que tengan facturas pendientes
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim sql As String = ""

            sql = "  select distinct a.NombreCliente, a.IdAvisoCobro"
            sql &= " , a.IdPoliza as Poliza, a.numerotarjeta as Tarjeta"
            sql &= " , a.vencimientotarjeta as VenceTarjeta, p.descripcion as Producto"
            sql &= " , ase.nombre as Aseguradora"
            sql &= " ,a.IdCliente"
            sql &= " , '' as Anexo"
            sql &= " , isnull((select top 1 Direccion from ClientesContactos as cc where cc.idcliente = c.idcliente order by IdContacto asc),'') as Direccion"
            sql &= " , isnull((select top 1 Ciudad from ClientesContactos as cc where cc.idcliente = c.idcliente order by IdContacto asc),'') as Ciudad"
            sql &= " , isnull((select top 1 Telefono from ClientesContactos as cc where cc.idcliente = c.idcliente order by IdContacto asc),'') as Telefono"
            sql &= " , '' as IdImpresion"
            sql &= " , isnull(B.NombreBanco,'') as Banco, a.Observaciones"
            sql &= " from avisoscobro as a"
            sql &= " left join Clientes as c on c.idcliente = a.idcliente"
            sql &= " left join Bancos as b on b.IdBanco = a.idbanco"
            sql &= " inner join productos as p on p.idproducto = a.idproducto"
            sql &= " inner join Aseguradoras as ase on ase.idaseguradora  = p.idaseguradora"
            sql &= " where a.numerotarjeta Is Not null And a.vencimientotarjeta Is Not null "
            sql &= " and (select sum(m.Total) from FacturasMovimientos as m inner join AvisosCobroFacturas as f on "
            sql &= " m.IdPoliza = f.IdPoliza and m.IdProducto = f.IdProducto  and m.NumeroFactura = f.NumeroFactura and m.IdRamo = f.IdRamo and f.IdAvisoCobro = a.IdAvisoCobro ) > 0 "
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p where p.idpoliza = a.idpoliza and p.idproducto = a.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            Dim AvisosCobro As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            AvisosCobro.TableName = "AvisoCobro"
            Dim Fecha As DateTime, strFecha As String = "", HayTarjetas As Boolean = False
            Dim FilAC As DataRow

            Dim IncluirEnEvioSimple As String = CStr(clSeguros.ObtenerDBParametros("Flujo.Simple.AC")).Trim.ToUpper
            Dim IdFlujoDefault As String = "", IdImpresion As String = ""


            For Each FilAC In AvisosCobro.Rows
                strFecha = Replace(Replace(Replace(dbData(FilAC, "VenceTarjeta"), " ", ""), "/", ""), "-", "")
                If Len(strFecha) = 6 Or Len(strFecha) = 4 Then strFecha = "01" & strFecha
                Try
                    Fecha = CDate(ConvertirFecha(strFecha, FormatoFecha.FechaCorta))
                Catch ex As Exception
                    Fecha = Nothing
                End Try
                If Fecha <> Nothing Then
                    If Fecha >= CDate(txtFechaDesde.Valor) And Fecha <= CDate(txtFechaHasta.Valor) Then
                        FilAC("Anexo") = "1"

                        'como es un registro valido vamos a registrar un flujo al cliente
                        If IncluirEnEvioSimple = "S" Then
                            clFlujos.IniciarFlujoDocumentoCliente(dbData(FilAC, "idcliente"), "Carta de Vencimiento de Tarjeta de Crédito", IdFlujoDefault)
                            Call clFlujos.RegistrarDocumento(IdFlujoDefault, "Carta de Vencimiento de Tarjeta de Crédito", "", dbData(FilAC, "Poliza"), "SALIDA", IdImpresion, "", Date.Today, dbData(FilAC, "NombreCliente"), EsDocumentoDeCobro:=True, CodigoImpresionDocumento:="VA")
                            FilAC("IdImpresion") = IdImpresion
                        End If

                        FilAC.AcceptChanges()
                        HayTarjetas = True
                    End If
                End If
            Next
            AvisosCobro.AcceptChanges()

            If AvisosCobro.Rows.Count = 0 Or HayTarjetas = False Then
                MsgBox("No se encontraron registros de tarjetas por vencer para las fechas especificadas.", MsgBoxStyle.Information, "AVISO..")
                Exit Sub
            End If

            Dim Reporte As Object
            Reporte = New repCRVencimientosTarjeta
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.VenceTarjeta")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)


            Dim Rep As New frmReportes
            Dim dsRep As New DataSet
            dsRep.Tables.Add(AvisosCobro.Copy)
            dsRep.Tables.Add(tblLogo.Copy)
            Reporte.SetDataSource(dsRep)

            'SetRepFormulaString(Reporte,"ResponsableAC",clSeguros.ObtenerDBParametros("Responsable.Gestion.AC"))
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.VencTarjetas"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.VencTarjetas"))
            'SetRepFormulaString(Reporte,"UserLog",ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            
            'If IncluirEnEvioSimple = "S" Then
            '    Try
            '        IdFlujoDefault = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
            '    Catch ex As Exception
            '        IdFlujoDefault = ""
            '    End Try
            '    If IdFlujoDefault <> "" Then
            '        Call clFlujos.RegistrarDocumento(IdFlujoDefault, "Carta de Vencimiento de Tarjeta de Crédito", "", dbData(AvisosCobro.Rows(0), "Poliza"), "SALIDA", IdImpresion, "", Date.Today, dbData(AvisosCobro.Rows(0), "NombreCliente"), EsDocumentoDeCobro:=True, CodigoImpresionDocumento:="VA")
            '    End If
            'End If
            'SetRepFormulaString(Reporte, "NumeroSecuencia", IdImpresion)

            Rep.CRViewer.ReportSource = Reporte
            Rep.Show()

        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

End Class
