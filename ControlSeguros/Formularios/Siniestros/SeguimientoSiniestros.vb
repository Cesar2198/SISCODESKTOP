Imports Utilerias.Genericas

Public Class SeguimientoSiniestros

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscaSiniestro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaSiniestro.Click
        Dim Fbus As New BusquedaSiniestros
        Fbus.Text = "Búsqueda de Siniestros"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
            Me.txtIdCertificado.Valor = stiSplit(busCodigo, "G2|1")
            Me.txtIdSiniestro.Valor = stiSplit(busCodigo, "G3|1")
            Me.txtNota.Focus()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtNota.Valor = ""
        Me.txtIdPoliza.Valor = ""
        Me.txtIdSiniestro.Valor = ""
        Me.cboIdProducto.Valor = ""
        Me.txtIdCertificado.Valor = ""
        Me.txtFecha.Valor = Date.Today
    End Sub

    Private Sub SeguimientoSiniestros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFecha.Valor = Date.Today
        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim CamposObligatorios As String = Me.ValidarCamposObligatorios(Me)
        If CamposObligatorios <> "" Then
            MsgBox("Debe completar los datos obligatorios: " & vbCrLf & CamposObligatorios)
            Exit Sub
        End If

        Try
            'grabaremos manualmente la gestion

            Dim sql As String = ""
            sql = "  insert into Gestiones "
            sql &= "  (IdGestion, IdTipoGestion, IdAccionTomar, NumeroFactura, IdProducto, IdPoliza, IdSiniestro, FechaGestion, FechaProximaGestion, Comentarios, TipoGestion, IdUsuario, IdCertificado) values("
            sql &= dbInt(clSeguros.ObtenerID("Gestion.Id")) & C & dbStr("") & C & dbStr("") & C & dbInt("") & C & dbStr(Me.cboIdProducto.Valor) & C & dbStr(Me.txtIdPoliza.Valor) & C & dbStr(Me.txtIdSiniestro.Valor) & C & dbFec(Me.txtFecha.Valor) & C & dbFec("") & C & dbStr(txtNota.Valor, 250) & C & dbStr("S") & C & dbStr(StiGlobalConn.User) & C & dbStr(txtIdCertificado.Valor, 25) & ")"
            StiGlobalConn.SQLExecute(sql)

            MsgBox("El seguimiento ha sido ingresado.", MsgBoxStyle.Exclamation, "AVISO...")

            Me.txtNota.Valor = ""
            Me.txtIdPoliza.Valor = ""
            Me.txtIdSiniestro.Valor = ""
            Me.cboIdProducto.Valor = ""
            Me.txtFecha.Valor = Date.Today

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

End Class
