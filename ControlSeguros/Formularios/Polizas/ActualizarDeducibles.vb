Imports Utilerias.Genericas

Public Class ActualizarDeducibles

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnBuscarPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        'Fbus.dbFiltro = " and p.MotivoCancelacion is null"
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtPoliza.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboProducto.Valor = stiSplit(busCodigo, "G1|1")
            'obtenemos el nombre del cliente
            Try
                Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset("select p.NombreCliente, p.EstadoPoliza, p.VigenciaDesde, p.VigenciaHasta, a.IdAseguradora as Aseguradora, (select count(*) from PolizasCertificados as c where c.idproducto = p.idproducto and c.idpoliza = p.idpoliza and c.FechaExclusion is null and c.RazonExclusion is null and c.EstadoCertificado = 'VIGENTE') as Certificados, (select top 1 Deducible from PolizasCertificados as c where c.idproducto = p.idproducto and c.idpoliza = p.idpoliza and c.FechaExclusion is null and c.RazonExclusion is null and c.EstadoCertificado = 'VIGENTE' order by c.idcertificado) as Deducible, (select count(*) from PolizasCertificados as c where c.idproducto = p.idproducto and c.idpoliza = p.idpoliza and c.FechaExclusion is null and c.RazonExclusion is null and c.EstadoCertificado = 'VIGENTE') as Certificados, (select top 1 Participacion from PolizasCertificados as c where c.idproducto = p.idproducto and c.idpoliza = p.idpoliza and c.FechaExclusion is null and c.RazonExclusion is null and c.EstadoCertificado = 'VIGENTE' order by c.idcertificado) as Participacion from Polizas as p inner join Productos as d on d.idproducto = p.idproducto inner join aseguradoras as a on a.idaseguradora = d.idaseguradora where p.IdPoliza =  " & dbStr(txtPoliza.Valor) & " and p.IdProducto = " & dbStr(cboProducto.Valor)).Tables(0).Rows(0)
                Me.txtCliente.Valor = dbData(FilPol, "NombreCliente")
                Me.txtVigenciaDesde.Valor = dbData(FilPol, "VigenciaDesde")
                Me.txtVigenciaHasta.Valor = dbData(FilPol, "VigenciaHasta")
                Me.cboAseguradora.Valor = dbData(FilPol, "Aseguradora")
                Me.txtCertificados.Valor = dbData(FilPol, "Certificados")
                Me.txtEstado.Valor = dbData(FilPol, "EstadoPoliza")
                Me.txtDeducible.Valor = dbData(FilPol, "Deducible")
                Me.txtParticipacion.Valor = dbData(FilPol, "Participacion")

            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub ActualizarDeducibles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()

        Me.cboAseguradora.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboAseguradora.Llenar_Combo()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        If Me.txtPoliza.Text = "" Or Me.cboProducto.Text = "" Then
            MsgBox("Debe especificar la póliza a la que se le actualizará el deducible y participación.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtEstado.Text = "CANCELADA" Then
            MsgBox("La póliza se encuentra cancelada no podrá hacer actualización de datos.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtDeducible.Text = "" Or Me.txtParticipacion.Text = "" Then
            MsgBox("Debe especificar los valores de deducible y participación.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If MsgBox("¿Desea actualizar los valores de Deducible y Participación en todos los Certificados Vigentes de la Póliza seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
            Try
                StiGlobalConn.SQLExecute("update PolizasCertificados set Deducible = " & dbStr(txtDeducible.Valor, 50) & ", Participacion = " & dbStr(txtParticipacion.Valor, 50) & " where idpoliza = " & dbStr(txtPoliza.Valor) & " and idproducto = " & dbStr(cboProducto.Valor) & " and FechaExclusion is null and RazonExclusion is null and EstadoCertificado = 'VIGENTE' ")
            Catch ex As Exception
                msgError(ex)
                Exit Sub
            End Try
            Me.LimpiarCampos(Me)
            MsgBox("La operación ha finalizado con éxito")
        End If

    End Sub

End Class
