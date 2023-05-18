Imports Utilerias.Genericas

Public Class PreCertificacionesMan

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Try
            Dim fbus As New BusquedaCertReclamo
            fbus.dbFiltro = ""
            fbus.ShowDialog()

            If busCodigo <> "" Then
                txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
                cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
                txtIdCertificado.Valor = stiSplit(busCodigo, "G2|1")
                txtIdBien.Valor = Val(stiSplit(busCodigo, "G3|1"))
                'txtNombreContratante.Valor = stiSplit(busCodigo, "G4|1")
                Me.txtNombreAsegurado.Valor = stiSplit(busCodigo, "G5|1")
                Me.txtNombrePaciente.Valor = stiSplit(busCodigo, "G6|1")
                Me.txtNombreAsegurado.Focus()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PreCertificacionesMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        'generamos el correlativo
        If txtIdAutorizacion.Text = "-" And Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            txtIdAutorizacion.Valor = clSeguros.ObtenerID("PreAutoriza.Num." & Date.Today.Year) & "-" & Date.Today.Year
            Me.ActualizarLlavesGrid(Me, "IdAutorizacion", txtIdAutorizacion.Valor)
        End If
    End Sub

    Private Sub PreCertificacionesMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            'valores default
            Me.txtIdAutorizacion.Valor = "-"
            Me.txtFechaRecibida.Valor = Date.Today
            Me.cboEstado.Valor = "PENDIENTE"
            txtIdAutorizacion.SoloLectura = True
        End If

        If Me.EstadoRegistro = enEstadoRegistro.Modificando Then
            Call IncluirDocumentosAutomaticos()
        End If
    End Sub

    Private Sub btnQuitarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDoc.Click
        Try
            Me.EliminarFilaGrid(VistaArchivos)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCarpeta.Click
        Try
            FolderBrowserDialog1.SelectedPath = ""
            Dim Carpeta As String = ""
            FolderBrowserDialog1.ShowDialog()
            Carpeta = FolderBrowserDialog1.SelectedPath
            If Carpeta <> "" Then
                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaArchivos)
                Dim Fila As Integer = VistaArchivos.FocusedRowHandle
                Me.VistaArchivos.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaArchivos.SetRowCellValue(Fila, "Documento", Carpeta)
                Me.VistaArchivos.UpdateCurrentRow()
            End If
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDDoc() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaArchivos.DataRowCount - 1
            Try
                If CInt(VistaArchivos.GetRowCellValue(I, "IdDocumento")) > Id Then
                    Id = CInt(VistaArchivos.GetRowCellValue(I, "IdDocumento"))
                End If
            Catch ex As Exception

            End Try

        Next
        If Id = 0 Then
            Id = 1
        Else
            Id += 1
        End If
        Return Id
    End Function

    Private Sub btnAgregarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDoc.Click
        Try
            OpenFileDialog1.FileName = ""
            Dim Documento As String = ""
            OpenFileDialog1.ShowDialog()
            Documento = OpenFileDialog1.FileName
            If Documento <> "" Then
                'si existe un parametro que indique la ruta global de los documentos validamos
                Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.PreCertifica")
                Dim resRuta As String = ""
                If txtIdAutorizacion.Text = "-" And RutaBase <> "" Then
                    MsgBox("Se ha especificado una ruta base para los documentos pero primero debe almacenar la pre-certificación.")
                    Exit Sub
                End If

                If RutaBase <> "" And txtIdAutorizacion.Text <> "" And txtIdAutorizacion.Text <> "-" Then
                    RutaBase = RutaBase & "\" & txtIdAutorizacion.Text & "\"
                    'creamos la carpeta si no existe
                    resRuta = CreaRuta(RutaBase)
                    If resRuta = "" Then
                        'movemos el archivo a la nueva carpeta
                        RutaBase &= System.IO.Path.GetFileName(Documento)
                        If System.IO.File.Exists(RutaBase) = False Then
                            System.IO.File.Copy(Documento, RutaBase)
                        Else
                            MsgBox("Ya existe un archivo con el mismo nombre en el repositorio de documentos de Pre-Certificaciones.", MsgBoxStyle.Information, "AVISO...")
                            Exit Sub
                        End If
                        Documento = RutaBase
                    End If
                End If

                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaArchivos)
                Dim Fila As Integer = VistaArchivos.FocusedRowHandle
                Me.VistaArchivos.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaArchivos.SetRowCellValue(Fila, "Documento", Documento)
                Me.VistaArchivos.UpdateCurrentRow()
            End If
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub IncluirDocumentosAutomaticos()
        'rutina que incluye los documentos automaticos de una ruta.
        Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.PreCertifica")
        Dim existe As Boolean
        If txtIdAutorizacion.Text <> "" And RutaBase <> "" Then
            Dim Archivos As DataTable = ObtenerArchivosCarpeta(RutaBase & "\" & txtIdAutorizacion.Text)
            Dim FilArchivo As DataRow
            For Each FilArchivo In Archivos.Rows
                'verificamos si ya existe
                existe = False
                For NA As Integer = 0 To Me.VistaArchivos.DataRowCount - 1
                    If Trim(UCase(VistaArchivos.GetRowCellValue(NA, "Documento"))) = Trim(UCase(dbData(FilArchivo, "Archivo"))) Then
                        existe = True
                    End If
                Next
                If existe = False Then
                    Dim Id As Integer = ObtenerIDDoc()
                    Me.AgregarFilaGrid(VistaArchivos, True, False)
                    Dim Fila As Integer = VistaArchivos.FocusedRowHandle
                    Me.VistaArchivos.SetRowCellValue(Fila, "IdDocumento", Id)
                    Me.VistaArchivos.SetRowCellValue(Fila, "Documento", dbData(FilArchivo, "Archivo"))
                    Me.VistaArchivos.UpdateCurrentRow()
                End If
            Next

            '17/01/2012
            'los documentos que ya no existen los removemos
            Try
                Dim RutaArchivo As String = "", Atributos As System.IO.FileAttributes
INICIO_VALIDA:
                For NDO As Integer = 0 To VistaArchivos.DataRowCount - 1
                    Try
                        RutaArchivo = VistaArchivos.GetRowCellValue(NDO, "Documento")
                        If System.IO.Path.GetExtension(RutaArchivo) = "" Then
                            If System.IO.Directory.Exists(RutaArchivo) = False Then
                                VistaArchivos.DeleteRow(NDO)
                                GoTo INICIO_VALIDA
                            End If
                        Else
                            If System.IO.File.Exists(RutaArchivo) = False Then
                                VistaArchivos.DeleteRow(NDO)
                                GoTo INICIO_VALIDA
                            Else
                                ''verificamos que no sea un archivo oculto o del sistema
                                Atributos = System.IO.File.GetAttributes(RutaArchivo)
                                If (Atributos And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Or (Atributos And IO.FileAttributes.System) = IO.FileAttributes.System Then
                                    VistaArchivos.DeleteRow(NDO)
                                    GoTo INICIO_VALIDA
                                End If
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                Next
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtIdAutorizacion.Valor = "-"
        Me.txtFechaRecibida.Valor = Date.Today
        Me.cboEstado.Valor = "PENDIENTE"
        txtIdAutorizacion.SoloLectura = True
    End Sub

    Private Sub VistaArchivos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaArchivos.DoubleClick
        Try
            Dim fila As Integer = VistaArchivos.FocusedRowHandle
            If fila >= 0 Then
                Dim Doc As String = Me.VistaArchivos.GetRowCellValue(fila, "Documento")
                If Doc <> "" Then
                    Dim esCarpeta As String = ""
                    Try
                        esCarpeta = System.IO.Path.GetExtension(Doc)
                    Catch ex As Exception
                        esCarpeta = ""
                    End Try
                    If esCarpeta = "" Then
                        System.Diagnostics.Process.Start(Doc)
                    Else
                        If System.IO.File.Exists(Doc) = True Then
                            System.Diagnostics.Process.Start(Doc)
                        Else
                            MsgBox("El documentos no se encuentra en la ruta especificada.", MsgBoxStyle.Information, "AVISO...")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
