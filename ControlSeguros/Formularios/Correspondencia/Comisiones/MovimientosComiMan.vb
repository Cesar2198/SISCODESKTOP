Public Class MovimientosComiMan

    Private Sub MovimientosComiMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        'generaremos el Id.
        txtIdMovimientoComi.Valor = clSeguros.ObtenerID("Comisiones.Mov.Id")

    End Sub

    Private Sub MovimientosComiMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboIdOperacion.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdOperacion.Llenar_Combo()

        Me.cboIdAseguradora.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdAseguradora.Llenar_Combo()

        Me.txtIdMovimientoComi.SoloLectura = True
    End Sub



End Class
