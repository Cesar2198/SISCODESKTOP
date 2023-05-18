Imports Utilerias.Genericas

Public Class CGPolizasCotizacion

    Public NombreCliente As String = ""

    Private Sub CGPolizasCotizacion_DespuesDeGuardarFinal() Handles Me.DespuesDeGuardarFinal
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Call btnNuevo_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub CGPolizasCotizacion_DespuesDeGuardarSinTransaccion() Handles Me.DespuesDeGuardarSinTransaccion
        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                RegistrarLogOferta(Me.txtIdOferta.Text, Me.txtIdCotizacion.Text, "", "Nueva Cotización", NombreCliente, cboIdProducto.Valor)
            Case enEstadoRegistro.Modificando
                RegistrarLogOferta(Me.txtIdOferta.Text, Me.txtIdCotizacion.Text, "", "Modificación de Cotización", NombreCliente, cboIdProducto.Valor)
        End Select
    End Sub

    Private Sub CGPolizasCotizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                txtIdOferta.Valor = stiSplit(Me.ClavesNuevo, "G0|1")
                txtIdOferta.SoloLectura = True

                'creamos el númro de la cotizacion
                Dim NumCot As Integer = StiGlobalConn.ObtenerDataset("select count(*) from CGPolizasOfertas where IdOferta = " & dbStr(txtIdOferta.Valor)).Tables(0).Rows(0).Item(0)
                NumCot += 1
                txtIdCotizacion.Valor = txtIdOferta.Valor & "-" & PE(NumCot.ToString, 2, "0", TipoRelleno.RellenarIzquierda)
                txtIdCotizacion.SoloLectura = True

        End Select
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            Me.EstadoEntradas(True, Me)
            txtIdOferta.Valor = stiSplit(Me.ClavesNuevo, "G0|1")
            txtIdOferta.SoloLectura = True

            'creamos el númro de la cotizacion
            Dim NumCot As Integer = StiGlobalConn.ObtenerDataset("select count(*) from CGPolizasOfertas where IdOferta = " & dbStr(txtIdOferta.Valor)).Tables(0).Rows(0).Item(0)
            NumCot += 1
            txtIdCotizacion.Valor = txtIdOferta.Valor & "-" & PE(NumCot.ToString, 2, "0", TipoRelleno.RellenarIzquierda)
            txtIdCotizacion.SoloLectura = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboResumenFormaEnvio_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboResumenFormaEnvio.ValueChangeOnExit
        If cboResumenFormaEnvio.Valor = "C" Then
            txtResumenNumeroCartaEnvio.Obligatorio = True
        Else
            txtResumenNumeroCartaEnvio.Obligatorio = False
        End If
    End Sub

    Private Sub cboIdProducto_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboIdProducto.ValueChangeOnExit
        'obtenemos la aseguradora del producto
        Try
            If cboIdProducto.Text <> "" Then
                Dim IdAseg As String = StiGlobalConn.ObtenerDataset("select IdAseguradora from Productos where IdProducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
                cboIdAseguradora.Valor = IdAseg
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
