Imports Utilerias.Genericas

Public Class repRegistroAsegurados

    Private Sub btnBuscaPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Try
                txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
                cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")

                Call CargarClasesPoliza()


            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub CargarClasesPoliza()
        If Me.txtIdPoliza.Text <> "" And Me.cboIdProducto.Valor <> "" Then
            Dim sql As String = ""

            sql = "select distinct cast(DescripcionBien as varchar(max)) as Clase, cast(DescripcionBien as varchar(max)) as Valores from PolizasBienes where IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and NombreBien = 'PLAN'"
            Me.cboClase.Query = sql
            Me.cboClase.StringConection = StiGlobalConn.ObtenerOledbConnectionString
            Me.cboClase.Llenar_Combo()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            If Me.txtIdPoliza.Text = "" Then
                MsgBox("Debe especificar la póliza.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            If Me.cboIdProducto.Valor = "" Then
                MsgBox("Debe especificar el producto.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim sql As String = ""
            sql = "  select "
            sql &= " p.IdPoliza as IdPoliza"
            sql &= " , p.IdProducto"
            sql &= " , b.IdCertificado as IdCertificado"
            sql &= " , row_number() over ( partition by p.idpoliza, b.idcertificado order by p.idpoliza, b.idcertificado, b.IdBien)  as IdBien"
            sql &= " , B.DescripcionBien as Asegurado"
            sql &= " , (select top 1 DescripcionBien from PolizasBienes as d where d.IdPoliza = b.IdPoliza and d.IdProducto = b.IdProducto and d.IdCertificado = b.IdCertificado and d.NombreBien = 'FECHA NAC.' AND d.IdBien > b.idbien order by d.idbien ) as FechaNacimiento"
            sql &= " , (select top 1 DescripcionBien from PolizasBienes as d where d.IdPoliza = b.IdPoliza and d.IdProducto = b.IdProducto and d.IdCertificado = b.IdCertificado and d.NombreBien = 'PARENTESCO' AND d.IdBien > b.idbien order by d.idbien ) as Parentesco"

            sql &= " , (select top 1 DescripcionBien from PolizasBienes as d where d.IdPoliza = b.IdPoliza and d.IdProducto = b.IdProducto and d.IdCertificado = b.IdCertificado and d.NombreBien = 'DEDUCIBLE' order by d.idbien ) as Deducible"
            sql &= " , (select top 1 DescripcionBien from PolizasBienes as d where d.IdPoliza = b.IdPoliza and d.IdProducto = b.IdProducto and d.IdCertificado = b.IdCertificado and d.NombreBien = 'LIMITE COASEGURO' order by d.idbien ) as LimiteCoaseguro"
            sql &= " , (select top 1 DescripcionBien from PolizasBienes as d where d.IdPoliza = b.IdPoliza and d.IdProducto = b.IdProducto and d.IdCertificado = b.IdCertificado and d.NombreBien = 'MAXIMO VITALICIO' order by d.idbien ) as MaxVitalicio"
            sql &= " , (select top 1 DescripcionBien from PolizasBienes as d where d.IdPoliza = b.IdPoliza and d.IdProducto = b.IdProducto and d.IdCertificado = b.IdCertificado and d.NombreBien = 'PORCE REEMBOLSO' order by d.idbien ) as PorceReembolso"
            sql &= " , (select top 1 DescripcionBien from PolizasBienes as d where d.IdPoliza = b.IdPoliza and d.IdProducto = b.IdProducto and d.IdCertificado = b.IdCertificado and d.NombreBien = 'PLAN' order by d.idbien ) as [Plan]"

            sql &= " , (select top 1 ValorAsegurado from PolizasCertificados as ce where ce.idpoliza = b.idpoliza and ce.idproducto = b.idproducto and ce.idcertificado = b.idcertificado) SumaAsegurada "
            sql &= " , (select top 1 PrimaNeta from PolizasCertificados as ce where ce.idpoliza = b.idpoliza and ce.idproducto = b.idproducto and ce.idcertificado = b.idcertificado) PrimaNeta "
            sql &= " , p.NombreCliente as Contratante"
            sql &= " , 0.0 as  ValorReclamos"
            sql &= " from Polizas as p"
            sql &= " inner join PolizasBienes as b on p.IdPoliza = b.IdPoliza and p.IdProducto = b.IdProducto "
            sql &= " where b.NombreBien in ('DEPENDIENTE', 'DEPENDIENTES', 'BENEFICIARIO','BENEFICIARIOS') "
            if chkSimilares.Checked = True then
                sql &= " and p.idpoliza like " & dbStr(txtIdPoliza.Valor & "%")
            else
                sql &= " and p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            End If    
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)

            If cboClase.Valor <> "" Then
                sql &= " and (select count(*) from PolizasBienes as d where d.idpoliza = b.idpoliza and d.idproducto = b.idproducto and d.idcertificado = b.idcertificado and d.NombreBien = 'PLAN' and cast(d.DescripcionBien as varchar(max)) = " & dbStr(cboClase.Valor) & ") > 0 "
            End If

            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If

            Dim DtAsegurados As DataTable
            DtAsegurados = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            DtAsegurados.TableName = "Asegurados"

            'para encontrar el valor pagado de reclamos iteramos pues el IdBien almacenado en reclamos es un correlativo de ingreso
            Dim ValorPagado As Double = 0
            For Each Fila As DataRow In DtAsegurados.Rows
                Try
                    ValorPagado = StiGlobalConn.ObtenerDataset("select isnull(sum(TotalReembolso),0) from Siniestros as s where s.idproducto = " & dbStr(dbData(Fila, "IdProducto")) & " and s.idpoliza = " & dbStr(dbData(Fila, "IdPoliza")) & " and s.IdCertificado = " & dbStr(dbData(Fila, "IdCertificado")) & " and s.IdBien = " & dbInt(dbData(Fila, "IdBien"))).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    ValorPagado = 0
                End Try
                Fila("ValorReclamos") = ValorPagado
            Next

            Dim DsRep As New DataSet
            DsRep.Tables.Add(DtAsegurados.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            'Dim Reporte As New repCRRegistroAsegurados
            Dim Reporte As Object
            Reporte = New repCRRegistroAsegurados
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Siniestros.Asegurados")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Titulo1", "Listado de Asegurados")
            SetRepFormulaString(Reporte, "Titulo2", "Póliza: " & txtIdPoliza.Valor & ", Producto = " & Me.cboIdProducto.Valor)
            SetRepFormulaString(Reporte, "Titulo3", "Reporte al " & Format(Date.Today, "Long Date"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub repRegistroAsegurados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()
    End Sub

End Class
