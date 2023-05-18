Imports Utilerias.Genericas

Public Class ClientesNav

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'generaremos un reporte de los clientes que esten seleccionados.
        Dim lstClientes As String = ""
        For NC As Integer = 0 To Me.VistaNav.DataRowCount - 1
            If lstClientes = "" Then
                lstClientes = dbStr(CStr(VistaNav.GetRowCellValue(NC, "IdCliente")).Trim)
            Else
                lstClientes &= ", " & dbStr(CStr(VistaNav.GetRowCellValue(NC, "IdCliente")).Trim)
            End If
        Next

        Dim dtCliente As DataTable = StiGlobalConn.ObtenerDataset("select * from Clientes where idcliente in (" & lstClientes & ")").Tables(0)
        dtCliente.TableName = "Clientes"

        Dim dtDire As DataTable = StiGlobalConn.ObtenerDataset("select * from ClientesContactos where idcliente in (" & lstClientes & ")").Tables(0)
        dtDire.TableName = "ClientesContactos"

        Dim sql As String = ""
        sql = " select IdCliente, IdCampo, Nombre, Descripcion from ClientesCamposJuridica where idcliente in (" & lstClientes & ") "
        sql &= " union select IdCliente, IdCampo, Nombre, Descripcion from ClientesCamposNatural where idcliente in (" & lstClientes & ") "
        Dim dtCampos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        dtCampos.TableName = "ClientesCampos"


        Dim dsClientes As New DataSet
        dsClientes.Tables.Add(dtCliente.Copy)
        dsClientes.Tables.Add(dtDire.Copy)
        dsClientes.Tables.Add(dtCampos.Copy)
        dsClientes.Tables.Add(tblLogo.Copy)

        Dim rep As New frmReportes
        Dim Reporte As New RepFichaCliente
        Reporte.SetDataSource(dsClientes)

        ''Definiremos algunos datos del reporte
        'SetRepFormulaString(Reporte,"NombreEmpresa",ObtenerParametro("Cliente"))
        'SetRepFormulaString(Reporte,"Titulo1","Reporte de Pagos Registrados")
        'SetRepFormulaString(Reporte,"Titulo2","Pagos entre el " & Format(txtFechaDesde.Valor, "dd/MMM/yyyy") & " y el " & Format(txtFechaHasta.Valor, "dd/MMM/yyyy"))
        'SetRepFormulaString(Reporte,"Titulo3","Reporte al " & Format(Date.Today, "Long Date"))
        'SetRepFormulaString(Reporte,"UserLog",ObtenerLogUser())

        rep.CRViewer.ReportSource = Reporte
        rep.MdiParent = Me.MdiParent
        rep.Show()

    End Sub

    Private Sub ClientesNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros

        'SI HAY CAMPOS PERSONALIZADOS LOS AGREGAMOS COMO OCULTOS
        Dim Campo As String = "", Existe As Boolean = False
        Dim Campos As String = clSeguros.ObtenerDBParametros("Clientes.Natural.Campos")
        If Campos <> "" Then
            For I As Integer = 0 To CuentaCar(Campos, ",")
                Campo = Campos.Split(",")(I).Trim
                If Campo <> "" Then
                    Me.ListaCamposOcultos &= "," & Campo.ToUpper.Replace(" ", "")
                    Me.ListaAliasCampos &= ", " & Campo
                    Me.ListaCampos &= ", isnull((select top 1 Descripcion from ClientesCamposNatural where ClientesCamposNatural.IdCliente = Clientes.IdCliente and ClientesCamposNatural.Nombre = " & dbStr(Campo) & "),'') as " & Campo.ToUpper.Replace(" ", "")
                End If
            Next
        End If


        Campos = clSeguros.ObtenerDBParametros("Clientes.Juridico.Campos")
        If Campos <> "" Then
            For I As Integer = 0 To CuentaCar(Campos, ",")
                Campo = Campos.Split(",")(I).Trim
                If Campo <> "" Then
                    Me.ListaCamposOcultos &= "," & Campo.ToUpper.Replace(" ", "")
                    Me.ListaAliasCampos &= ", " & Campo
                    Me.ListaCampos &= ", isnull((select top 1 Descripcion from ClientesCamposNatural where ClientesCamposNatural.IdCliente = Clientes.IdCliente and ClientesCamposNatural.Nombre = " & dbStr(Campo) & "),'') as " & Campo.ToUpper.Replace(" ", "")
                End If
            Next
        End If

        If VisibilidadUsuario() = "D" Then
            Me.Filtro = " (select count(*) from polizas where polizas.idcliente = clientes.idcliente and polizas.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If

    End Sub

    Private Sub ClientesNav_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ClientesNav_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FixGridSize()
        Try
            Me.GridNav.Width = Me.Width - 20
            Me.GridNav.Height = Me.Height - 105
            Me.GridNav.Anchor = AnchorStyles.Top + AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
        Catch ex As Exception

        End Try
    End Sub

End Class
