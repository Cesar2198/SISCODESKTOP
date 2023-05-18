
Imports Utilerias.Genericas

Public Class PolBuscarBienes

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub PolBuscarBienes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboRamo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboRamo.Llenar_Combo()
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()
        Me.cboDatosTec.StringConection = StiGlobalConn.ObtenerOledbConnectionString
    End Sub

    Private Sub PrepararCombos()
        If cboRamo.Valor <> "" Then
            'llenamos los productos de ese ramo
            Me.cboProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos where IdRamo = " & dbStr(cboRamo.Valor) & " order by Descripcion"
            Me.cboProducto.Llenar_Combo()
        End If

        'trataremos de determinar los datos tecnicos más relacionados.
        Dim FilDato As DataTable
        If Me.cboProducto.Valor <> "" Or Me.cboRamo.Valor <> "" Then
            If Me.cboProducto.Valor <> "" Then
                'listamos los datos tecnicos del producto
                FilDato = StiGlobalConn.ObtenerDataset("select IdBien, NombreBien from ProductosBienes where idproducto = " & dbStr(Me.cboProducto.Valor)).Tables(0)
                Call LlenarDatosTecnicos(FilDato)
            Else
                FilDato = StiGlobalConn.ObtenerDataset("select IdBien, NombreBien from ProductosBienes where idproducto = (select top 1 idproducto from productos where idramo = " & dbStr(cboRamo.Valor) & " )").Tables(0)
                Call LlenarDatosTecnicos(FilDato)
            End If
        End If
    End Sub

    Private Sub LlenarDatosTecnicos(ByVal FilaDatos As DataTable)
        Try
            Dim LISTA As String = ""
            For NF As Integer = 0 To FilaDatos.Rows.Count - 1
                If LISTA = "" Then
                    LISTA = dbData(FilaDatos.Rows(NF), "IdBien") & " " & dbData(FilaDatos.Rows(NF), "NombreBien")
                Else
                    LISTA &= "|" & dbData(FilaDatos.Rows(NF), "IdBien") & " " & dbData(FilaDatos.Rows(NF), "NombreBien")
                End If
                Select Case NF
                    Case 0
                        ColDatoTec1.Caption = dbData(FilaDatos.Rows(NF), "NombreBien")
                    Case 1
                        ColDatoTec2.Caption = dbData(FilaDatos.Rows(NF), "NombreBien")
                    Case 2
                        ColDatoTec3.Caption = dbData(FilaDatos.Rows(NF), "NombreBien")
                    Case 3
                        ColDatoTec4.Caption = dbData(FilaDatos.Rows(NF), "NombreBien")
                    Case 4
                        ColDatoTec5.Caption = dbData(FilaDatos.Rows(NF), "NombreBien")
                End Select
            Next
            Me.cboDatosTec.Lista = LISTA
            Me.cboDatosTec.Llenar_Combo()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboProducto_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboProducto.ValueChangeOnExit
        Call PrepararCombos()
        Me.GridBienes.DataSource = Nothing
        Me.GridBienes.Refresh()
    End Sub

    Private Sub cboRamo_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboRamo.ValueChangeOnExit
        Call PrepararCombos()
        Me.GridBienes.DataSource = Nothing
        Me.GridBienes.Refresh()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Me.cboRamo.Valor = "" And Me.cboProducto.Valor = "" Then
                MsgBox("Debe seleccionar el ramo o el producto de los bienes que busca.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            If Me.cboDatosTec.Valor = "" Then
                MsgBox("Debe seleccionar el dato de busqueda.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            If Me.txtBusqueda.Valor = "" Then
                MsgBox("Debe especificar el texto de busqueda", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim sql As String = ""

            sql = "  select "
            sql &= " p.idpoliza as Poliza"
            sql &= " ,c.IdCertificado as Certificado"
            sql &= " ,c.NombreCliente as Asegurado"
            sql &= " ,r.Descripcion as Producto"
            sql &= " ,(select top 1 b.DescripcionBien from PolizasBienes as b where b.IdPoliza = c.IdPoliza and b.IdProducto = c.IdProducto and b.IdCertificado = c.IdCertificado and b.NombreBien = " & dbStr(ColDatoTec1.Caption) & ") as DatoTec1" 'and b.IdBien = 1
            sql &= " ,(select top 1 b.DescripcionBien from PolizasBienes as b where b.IdPoliza = c.IdPoliza and b.IdProducto = c.IdProducto and b.IdCertificado = c.IdCertificado and b.NombreBien = " & dbStr(ColDatoTec2.Caption) & ") as DatoTec2"
            sql &= " ,(select top 1 b.DescripcionBien from PolizasBienes as b where b.IdPoliza = c.IdPoliza and b.IdProducto = c.IdProducto and b.IdCertificado = c.IdCertificado and b.NombreBien = " & dbStr(ColDatoTec3.Caption) & ") as DatoTec3"
            sql &= " ,(select top 1 b.DescripcionBien from PolizasBienes as b where b.IdPoliza = c.IdPoliza and b.IdProducto = c.IdProducto and b.IdCertificado = c.IdCertificado and b.NombreBien = " & dbStr(ColDatoTec4.Caption) & ") as DatoTec4"
            sql &= " ,(select top 1 b.DescripcionBien from PolizasBienes as b where b.IdPoliza = c.IdPoliza and b.IdProducto = c.IdProducto and b.IdCertificado = c.IdCertificado and b.NombreBien = " & dbStr(ColDatoTec5.Caption) & ") as DatoTec5"
            sql &= " ,p.IdProducto"
            sql &= " from Polizas as p"
            sql &= " inner join PolizasCertificados as c on p.IdPoliza = c.IdPoliza and p.IdProducto = c.IdProducto "
            sql &= " inner join Productos as r on r.idproducto = p.idproducto"
            sql &= " where p.idpoliza is not null"
            sql &= " and exists ( select IdBien from PolizasBienes as b where b.IdPoliza = c.IdPoliza and b.IdProducto = c.IdProducto and b.IdCertificado = c.IdCertificado and b.NombreBien = " & dbStr(cboDatosTec.Descripcion.Trim)
            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If
            
            Dim NumPalabras As Integer = CuentaCar(txtBusqueda.Valor, " ")
            Dim Palabra As String = ""
            For I As Integer = 0 To NumPalabras
                Palabra = stiSplit(Me.txtBusqueda.Valor, "G" & I & " 1")
                If Palabra.Trim <> "" Then
                    sql &= " and b.DescripcionBien like " & dbStr("%" & Palabra & "%")
                End If
            Next
            sql &= " )"

            Dim Datos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.GridBienes.DataSource = Datos
            Me.GridBienes.Refresh()

            If Datos.Rows.Count = 0 Then
                MsgBox("No se encontraron bienes con las caracteristicas especificadas", MsgBoxStyle.Information, "AVISO...")
            End If
            
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Bienes" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridBienes.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "Reporte de Busqueda de Bienes", "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, Me.cboDatosTec.Descripcion & " = " & Me.txtBusqueda.Text, clSeguros.ObtenerDBParametros("Password.Documentos"))
            ''AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub VistaBienes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaBienes.DoubleClick
        Try
            Dim fila As Integer = Me.VistaBienes.FocusedRowHandle
            Dim Poliza As String = Me.VistaBienes.GetRowCellValue(fila, "Poliza")
            Dim Cert As String = Me.VistaBienes.GetRowCellValue(fila, "Certificado")
            Dim Producto As String = Me.VistaBienes.GetRowCellValue(fila, "IdProducto")

            Dim frmCert As New PolizasCertificadosMan
            frmCert.dbTabla = "PolizasCertificados"
            frmCert.STIConn = StiGlobalConn
            frmCert.Permiso = "L"
            frmCert.dbCondicion = "IdPoliza = " & dbStr(Poliza) & " and IdProducto = " & dbStr(Producto) & " and IdCertificado = " & dbStr(Cert)
            frmCert.ClavesNuevo = ""
            frmCert.ShowDialog(Me)

        Catch ex As Exception

        End Try
    End Sub

End Class
