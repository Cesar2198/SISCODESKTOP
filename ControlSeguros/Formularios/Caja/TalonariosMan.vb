
Imports Utilerias.Genericas

Public Class TalonariosMan

    Private Sub TalonariosMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        If (txtFechaAsignado.Text = "" And txtResponsable.Text <> "") Or (txtFechaAsignado.Text <> "" And txtResponsable.Text = "") Then
            MsgBox("Debe especificar al mismo tiempo El responsable y fecha se asignación.", MsgBoxStyle.Information, "AVISO...")
            Cancel = True
        End If

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            If Val(txtReciboInicial.Valor) > Val(Me.txtReciboFinal.Valor) Then
                MsgBox("El número de recibo inicial no puede ser mayor que el final.", MsgBoxStyle.Information, "AVISO...")
                Cancel = True
            End If

            'validamos si el correlativo no se intersectan
            Dim NumRecI As Integer = StiGlobalConn.ObtenerDataset("select count(*) from Talonario where fecha is not null and ((" & dbInt(txtReciboInicial.Valor) & " between ReciboInicial and ReciboFinal) or (" & dbInt(txtReciboFinal.Valor) & " between ReciboInicial and ReciboFinal)) ").Tables(0).Rows(0).Item(0)
            If NumRecI > 0 Then
                MsgBox("Ya existe un Talonario que incluye los números de recibo especificado.", MsgBoxStyle.Information, "AVISO...")
                Cancel = True
            End If
        End If


    End Sub

    Private Sub TalonariosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.EstadoRegistro = enEstadoRegistro.Modificando Then
            If txtFechaAsignado.Text <> "" And Me.txtResponsable.Text <> "" Then
                txtFechaAsignado.SoloLectura = True
                txtResponsable.SoloLectura = True
            End If
        End If
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtFecha.Valor = Date.Today
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtFecha.Valor = Date.Today
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtFecha.Valor = Date.Today
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try
            'Generaremos la impresion las cartas de cobro a los clientes
            Dim Reporte As Object
            Reporte = New repTalonario
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Caja.Talonario")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Dim Rep As New frmReportes
            Dim sql As String = ""

            sql = "  select "
            sql &= " a.Fecha"
            sql &= " , a.ReciboInicial"
            sql &= " , a.ReciboFinal"
            sql &= " , a.FechaAsignado"
            sql &= " , b.NombreUsuario as Responsable"
            sql &= " from Talonario as a "
            sql &= " left join Usuarios as b on b.idusuario = a.responsable"
            sql &= " where Fecha = " & dbFec(txtFecha.Valor)
            sql &= " and ReciboInicial = " & dbInt(txtReciboInicial.Valor)
            sql &= " and ReciboFinal = " & dbInt(txtReciboFinal.Valor)

            

            Dim dtFA As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFA.TableName = "Talonario"

            Dim dsRep As New DataSet
            dsRep.Tables.Add(dtFA.Copy)
            dsRep.Tables.Add(tblLogo.Copy)
            Reporte.SetDataSource(dsRep)

            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Titulo1", "Comprobante de Talonario de Cobro")
            SetRepFormulaString(Reporte, "Titulo2", "")
            SetRepFormulaString(Reporte, "Titulo3", "")

            Rep.CRViewer.ReportSource = Reporte
            Rep.MdiParent = frmPrincipal
            Rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

End Class


