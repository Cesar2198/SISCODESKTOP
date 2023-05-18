Imports Utilerias.Genericas

Public Class LstComiProductos

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim sql As String = ""

            sql = "  select a.Nombre as Aseguradora, p.IdProducto, p.Descripcion as Producto, r.NombreRamo as Ramo, p.TipoProducto"
            sql &= " ,(select PorceComi from ProductosComisionesExternas as c where c.idproducto = p.idproducto and c.IdComision = 1) as Comi1"
            sql &= " ,(select PorceComi from ProductosComisionesExternas as c where c.idproducto = p.idproducto and c.IdComision = 2) as Comi2"
            sql &= " ,(select PorceComi from ProductosComisionesExternas as c where c.idproducto = p.idproducto and c.IdComision = 3) as Comi3"
            sql &= " from Productos as p"
            sql &= " inner join Aseguradoras as a on p.idaseguradora = a.idaseguradora "
            sql &= " inner join RamoSeguros as r on r.idramo = p.idramo "
            If Me.cboAseguradora.Valor <> "" Then
                sql &= " where a.idaseguradora = " & dbStr(cboAseguradora.Valor)
            End If

            Dim dtProductos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtProductos.TableName = "ComiProductos"

            If dtProductos.Rows.Count = 0 Then
                MsgBox("No existen productos.", MsgBoxStyle.Information, "AVISO...")
            Else
                Dim DsRep As New DataSet
                DsRep.Tables.Add(dtProductos.Copy)
                DsRep.Tables.Add(tblLogo.Copy)

                Dim rep As New frmReportes
                Dim Reporte As New RepComiProductos
                Reporte.SetDataSource(DsRep)

                ''Definiremos algunos datos del reporte
                SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
                SetRepFormulaString(Reporte, "Titulo1", "Reporte de Comisiones por Producto")
                SetRepFormulaString(Reporte, "Titulo2", "Reporte al " & Format(Date.Today, "Long Date"))
                SetRepFormulaString(Reporte, "Titulo3", "")
                SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

                rep.CRViewer.ReportSource = Reporte
                rep.MdiParent = Me.MdiParent
                rep.Show()
            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub LstComiProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboAseguradora.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboAseguradora.Llenar_Combo()
    End Sub
End Class
