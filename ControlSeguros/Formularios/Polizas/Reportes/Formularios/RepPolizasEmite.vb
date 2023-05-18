
Imports Utilerias.Genericas

Public Class RepPolizasEmite

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RepPolizasEmite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboEjecutivo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboEjecutivo.Llenar_Combo()
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()
        Me.cboRamo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboRamo.Llenar_Combo()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim sql As String = ""

            If txtFechaDesde.Text = "" Then
                MsgBox("Debe especificar la fecha desde.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            If txtFechaHasta.Text = "" Then
                MsgBox("Debe especificar la fecha hasta.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor
            Dim NomFiltro As String = ""

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto ) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= ", case pr.IdRamo when '702' then isnull((select top 1 DescripcionBien from PolizasBienes as b1 where b1.IdPoliza = p.IdPoliza and b1.IdProducto = p.IdProducto and b1.NombreBien = 'BENEFICIARIO'),(select top 1 Beneficiario from PolizasCesiones as e where e.IdPoliza = p.IdPoliza and e.IdProducto = p.IdProducto and e.FechaCancela is null )) else (select top 1 Beneficiario from PolizasCesiones as e where e.IdPoliza = p.IdPoliza and e.IdProducto = p.IdProducto and e.FechaCancela is null ) end as Cesionario"
            sql &= ",p.NumVigencia"
            sql &= ", (select isnull(v.NombreVendedor,'') from PolizasVendedores as pv inner join Vendedores as v on pv.IdVendedor = v.IdVendedor where pv.IdProducto = p.IdProducto and pv.IdPoliza = p.IdPoliza and pv.Orden = 1) as Vendedor"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.MotivoCancelacion is null"
            sql &= " and p.VigenciaDesde between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If

            If cboEjecutivo.Valor <> "" Then
                sql &= " and cl.EjecutivoCta = " & dbStr(cboEjecutivo.Valor)
                NomFiltro &= ",Ejecutivo: " & cboEjecutivo.Valor
            End If

            If cboProducto.Valor <> "" Then
                sql &= " and pr.idproducto = " & dbStr(cboProducto.Valor)
                NomFiltro &= ",Producto: " & cboProducto.Valor
            End If

            If cboRamo.Valor <> "" Then
                sql &= " and pr.idramo = " & dbStr(cboRamo.Valor)
                NomFiltro &= ",Ramo: " & cboRamo.Text
            End If

            Dim dtPolizas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPolizas.TableName = "Polizas"

            If dtPolizas.Rows.Count = 0 Then
                MsgBox("No se encontraron pólizas con las condiciones especificadas.", MsgBoxStyle.Information, "AVISO...")
            Else
                Dim DsRep As New DataSet
                DsRep.Tables.Add(dtPolizas.Copy)
                DsRep.Tables.Add(tblLogo.Copy)

                Dim rep As New frmReportes
                Dim Reporte As Object
                Reporte = New RepPolizasGeneral
                Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.GeneralPolizas")
                If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)


                Reporte.SetDataSource(DsRep)

                ''Definiremos algunos datos del reporte
                SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
                SetRepFormulaString(Reporte, "Titulo1", "Reporte de Pólizas Emitidas y Renovadas")
                SetRepFormulaString(Reporte, "Titulo2", "Pólizas Emitidas entre el " & Format(txtFechaDesde.Valor, "dd/MMM/yyyy") & " y el " & Format(txtFechaHasta.Valor, "dd/MMM/yyyy"))
                SetRepFormulaString(Reporte, "Titulo3", "Reporte al " & Format(Date.Today, "Long Date") & " " & NomFiltro)
                SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

                rep.CRViewer.ReportSource = Reporte
                rep.MdiParent = Me.MdiParent
                rep.Show()
            End If
        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

End Class
