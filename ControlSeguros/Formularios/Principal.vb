Imports Utilerias.Genericas

Public Class Principal

    Private Enum enEstadoRegistro
        Nada = 0
        Adicionando = 1
        Modificando = 2
        Eliminando = 3
    End Enum

    Private Sub btnAseguradoras_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAseguradoras.ItemClick
        Dim frmAseg As New AseguradorasNav
        frmAseg.STIConn = StiGlobalConn
        frmAseg.MdiParent = Me
        frmAseg.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmAseg.Show()
    End Sub

    Private Sub Principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'verificamos si algún formulario del sistema tiene algún cambio sin confirmar
        Try
            For Each FormularioHijo As Object In Me.MdiChildren
                Try
                    If FormularioHijo.blnRegistroModificado = True And (FormularioHijo.EstadoRegistro = enEstadoRegistro.Adicionando Or FormularioHijo.EstadoRegistro = enEstadoRegistro.Modificando) Then
                        If MsgBox("El registro de " & FormularioHijo.lblNombreFormulario.Text & " no ha sido guardado, perdería los cambios realizados." & vbCrLf & "¿Desea Salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try

        If MsgBox("¿Deseas Salir del Sistema?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Try
                Select Case GlobalCodCliente
                    Case "2120000"
                        If Date.Now.Hour >= 17 Then
                            clSeguros.ActualizarDBParametros("Corr.Verif.DocPend", "S")
                            clSeguros.ActualizarDBParametros("Caja.Recibos.SinCerrar", "N")
                        End If
                End Select
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub barControl_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            MessageBox.Show("Right button pressed!" & sender.Name)
        End If
    End Sub

    Private Structure Botones
        Dim Orden As Integer
        Dim Boton As Object
    End Structure

    Private Function ReordenarBotones(ByVal Lista() As Botones) As Botones()
        Dim OrdenPropuesto As String = ""
        Dim HayCambio As Boolean = False
        For I As Integer = 0 To Lista.Count - 1
            If Not Lista(I).Boton Is Nothing Then
                Try
                    OrdenPropuesto = dbData(StiGlobalConn.ObtenerDataset("select Orden from GruposPermisos where IdGrupo = 'ADMINISTRADORES' and idmenu = " & dbStr(Lista(I).Boton.Name)).Tables(0).Rows(0), "Orden")
                Catch ex As Exception
                    OrdenPropuesto = ""
                End Try

                If OrdenPropuesto <> "" Then
                    CambiarOrden(Lista, I, Lista(I).Orden, CInt(OrdenPropuesto))
                    'Lista(I).Orden = CInt(OrdenPropuesto)
                    HayCambio = True
                End If
            End If
        Next
        Dim lstBotones() As Botones
        ReDim lstBotones(0)
        If HayCambio = True Then
            For I As Integer = 0 To Lista.Count - 1
                If Not Lista(I).Boton Is Nothing Then
                    For J As Integer = 0 To Lista.Count - 1
                        If Not Lista(J).Boton Is Nothing Then
                            If Lista(J).Orden = I Then
                                ReDim Preserve lstBotones(lstBotones.Count)
                                lstBotones(lstBotones.Count - 1) = Lista(J)
                                Exit For
                            End If
                        End If
                    Next
                End If
            Next
        Else
            lstBotones = Lista
        End If

        Return lstBotones
    End Function

    Private Sub CambiarOrden(ByRef Lista() As Botones, ByVal OrdenElemento As Integer, ByVal ValorAnterior As Integer, ByVal ValorNuevo As Integer)
        ''For I As Integer = 0 To Lista.Count - 1
        ''    If I = OrdenElemento Then
        ''        Lista(I).Orden = ValorNuevo
        ''    Else
        ''        If Lista(I).Orden >= ValorNuevo And Lista(I).Orden < ValorAnterior Then
        ''            Lista(I).Orden += 1
        ''        End If
        ''    End If
        ''Next

        For I As Integer = 0 To Lista.Count - 1
            If Lista(I).Orden = ValorNuevo Then
                Lista(I).Orden = ValorAnterior
                Exit For
            End If
        Next
        Lista(OrdenElemento).Orden = ValorNuevo

    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

        
            'lo primero que haremos es ordenar los iconos del menu según configuración
            ControlNotificacion = Me.lblNotificacion

            Dim lstBotones() As Botones, Elemento As Object, OrdenBtn As Integer = 0
            For Each Pagina As DevExpress.XtraBars.Ribbon.RibbonPage In Me.RibbonControl.Pages
                For Each Grupo As DevExpress.XtraBars.Ribbon.RibbonPageGroup In Pagina.Groups
                    'hacemos una lista con los items
                    ReDim lstBotones(0)
                    OrdenBtn = 0
                    For Each Elemento In Grupo.ItemLinks
                        ReDim Preserve lstBotones(lstBotones.Count)
                        OrdenBtn += 1
                        lstBotones(lstBotones.Count - 1).Orden = OrdenBtn
                        lstBotones(lstBotones.Count - 1).Boton = Elemento.Item
                    Next
                    'Luego les eliminamos los items
                    Grupo.ItemLinks.Clear()
                    lstBotones = ReordenarBotones(lstBotones)

                    'los ponemos en el orden que deseamos
                    For Each Elemento In lstBotones
                        If Not Elemento.Boton Is Nothing Then
                            Grupo.ItemLinks.Add(Elemento.Boton)
                        End If
                    Next
                Next
            Next

            ''Aca controlaremos los permisos sobre los elementos del usuario que logea
            ''1) llenamos una tabla con el nombre del control y su descripción
            ''2) ademas validamos la visibilidad de esa opcion para el usuario
            Dim tblMenuNombre As DataTable, FilMenuNombre As DataRow
            tblMenu = New DataTable
            Dim Fila As DataRow, res As String = ""
            tblMenu.Columns.Add("Id", System.Type.GetType("System.String"))
            tblMenu.Columns.Add("Modulo", System.Type.GetType("System.String"))
            tblMenu.Columns.Add("Descripcion", System.Type.GetType("System.String"))
            tblMenu.Columns.Add("DescripcionFull", System.Type.GetType("System.String"))
            tblMenu.TableName = "Menu"

            'Cargamos Globalmente el código del cliente del sistema
            GlobalCodCliente = StiGlobalConn.ObtenerDataset("select CodCliente from Actualizacion where Sistema = 'SISCO'").Tables(0).Rows(0).Item(0)

            Dim strBtnCliente As String = "", blnIncluir As Boolean = True
            For Each Control In Me.RibbonControl.Items
                If Control.ToString.Trim <> "" Then
                    Select Case Control.Name.Trim.ToUpper
                        Case "LBLLICENCIA", "LBLTEXTSTATUS"
                            'ESTOS ITEMS NO SE INCLUYEN
                        Case Else
                            blnIncluir = True
                            'validaremos si no es un boton especial solo para un cliente
                            Try
                                strBtnCliente = Control.AccessibleName
                            Catch ex As Exception
                                strBtnCliente = ""
                            End Try
                            If strBtnCliente <> "" Then
                                If InStr(strBtnCliente, "," & GlobalCodCliente & ",") <= 0 Then
                                    blnIncluir = False
                                    Control.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                                End If
                            End If

                            If blnIncluir = True Then
                                Fila = tblMenu.NewRow
                                Fila("Id") = Control.Name
                                Fila("Modulo") = Control.Tag
                                Fila("Descripcion") = Control.Description
                                Fila("DescripcionFull") = "[" & Control.Tag & "] " & Control.Description
                                tblMenu.Rows.Add(Fila)

                                'veremos si no han personalizado los campos
                                Try
                                    tblMenuNombre = StiGlobalConn.ObtenerDataset("select NombreOpcion from GruposPermisos where IdMenu = " & dbStr(Control.Name) & " and IdGrupo = 'ADMINISTRADORES' and NombreOpcion is not null").Tables(0)
                                    For Each FilMenuNombre In tblMenuNombre.Rows
                                        Control.Description = dbData(FilMenuNombre, "NombreOpcion")
                                        Control.Caption = dbData(FilMenuNombre, "NombreOpcion")
                                    Next
                                Catch ex As Exception

                                End Try

                                res = ObtenerVisibilidadMenu(StiGlobalConn.User, Control.Name)
                                If res = "" Then
                                    Select Case Control.GetType.ToString
                                        Case "DevExpress.XtraBars.BarButtonItem", "DevExpress.XtraBars.BarSubItem"
                                            Control.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                                    End Select
                                End If
                            End If

                    End Select
                End If
            Next
            Dim NumGruposVisibles As Integer = 0

            ''ahora verificaremos si existen algun item menu sin elementos
            For Each Pagina As DevExpress.XtraBars.Ribbon.RibbonPage In Me.RibbonControl.Pages
                For Each Grupo As DevExpress.XtraBars.Ribbon.RibbonPageGroup In Pagina.Groups
                    NumGruposVisibles = 0
                    For Each Item In Grupo.ItemLinks

                        If TypeOf Item Is DevExpress.XtraBars.BarSubItemLink Then
                            If CType(Item, DevExpress.XtraBars.BarSubItemLink).VisibleLinks.Count > 0 Then
                                NumGruposVisibles = 0
                                For Each ItemS In CType(Item, DevExpress.XtraBars.BarSubItemLink).VisibleLinks
                                    If TypeOf ItemS Is DevExpress.XtraBars.BarButtonItemLink Then
                                        If CType(ItemS.Item, DevExpress.XtraBars.BarButtonItem).Visibility <> DevExpress.XtraBars.BarItemVisibility.Never Then
                                            NumGruposVisibles += 1
                                        End If
                                    End If
                                    If TypeOf ItemS Is DevExpress.XtraBars.BarSubItemLink Then
                                        If CType(ItemS.Item, DevExpress.XtraBars.BarSubItem).Visibility <> DevExpress.XtraBars.BarItemVisibility.Never Then
                                            NumGruposVisibles += 1
                                        End If
                                    End If
                                Next
                                If NumGruposVisibles = 0 Then
                                    CType(Item, DevExpress.XtraBars.BarSubItemLink).Visible = False
                                End If
                            End If
                        End If
                    Next
                Next
            Next

            ''Primero Eliminamos las grupos de item que no tengan elementos visibles

            For Each Pagina As DevExpress.XtraBars.Ribbon.RibbonPage In Me.RibbonControl.Pages
                For Each Grupo As DevExpress.XtraBars.Ribbon.RibbonPageGroup In Pagina.Groups
                    NumGruposVisibles = 0
                    For Each Item In Grupo.ItemLinks
                        If TypeOf Item Is DevExpress.XtraBars.BarButtonItemLink Then
                            If CType(Item.Item, DevExpress.XtraBars.BarButtonItem).Visibility <> DevExpress.XtraBars.BarItemVisibility.Never Then
                                NumGruposVisibles += 1
                            End If
                        End If
                        If TypeOf Item Is DevExpress.XtraBars.BarSubItemLink Then
                            If CType(Item, DevExpress.XtraBars.BarSubItemLink).Visible = True Then
                                NumGruposVisibles += 1
                            End If
                        End If
                    Next
                    If NumGruposVisibles = 0 Then Grupo.Visible = False
                Next
            Next

            ''Ahora eliminaremos las Paginas que no tengan grupos visibles
            For Each Pagina As DevExpress.XtraBars.Ribbon.RibbonPage In Me.RibbonControl.Pages
                NumGruposVisibles = 0
                For Each Grupo As DevExpress.XtraBars.Ribbon.RibbonPageGroup In Pagina.Groups
                    If Grupo.Visible = True Then NumGruposVisibles += 1
                Next
                If NumGruposVisibles = 0 Then Pagina.Visible = False
            Next

            'preparamos el logo
            Try
                tblLogo = New Data.DataTable
                tblLogo.TableName = "Imagenes"
                tblLogo.Columns.Add("Logo", System.Type.GetType("System.Byte[]"))
                tblLogo.Columns.Add("Sello", System.Type.GetType("System.Byte[]"))
                tblLogo.Columns.Add("Logo2", System.Type.GetType("System.Byte[]"))

                Dim FilLogo As DataRow = tblLogo.NewRow

                If Dir(Application.StartupPath & "\Logo.bmp") <> "" Then
                    RutaLogo = Application.StartupPath & "\Logo.bmp"
                ElseIf Dir(Application.StartupPath & "\Logo.jpg") <> "" Then
                    RutaLogo = Application.StartupPath & "\Logo.jpg"
                ElseIf Dir(Application.StartupPath & "\Logo.png") <> "" Then
                    RutaLogo = Application.StartupPath & "\Logo.png"
                ElseIf Dir(Application.StartupPath & "\Logo.gif") <> "" Then
                    RutaLogo = Application.StartupPath & "\Logo.gif"
                End If
                If RutaLogo <> "" Then
                    Dim obtenArchivo As System.IO.FileStream = New System.IO.FileStream(RutaLogo, IO.FileMode.Open, IO.FileAccess.Read)
                    Dim br As System.IO.BinaryReader = New System.IO.BinaryReader(obtenArchivo)
                    Dim imagenBytes(obtenArchivo.Length) As Byte
                    br.Read(imagenBytes, 0, obtenArchivo.Length)
                    br.Close()
                    obtenArchivo.Close()
                    FilLogo("Logo") = imagenBytes
                End If

                RutaSello = ""
                If Dir(Application.StartupPath & "\Sello.bmp") <> "" Then
                    RutaSello = Application.StartupPath & "\Sello.bmp"
                ElseIf Dir(Application.StartupPath & "\Sello.jpg") <> "" Then
                    RutaSello = Application.StartupPath & "\Sello.jpg"
                ElseIf Dir(Application.StartupPath & "\Sello.png") <> "" Then
                    RutaSello = Application.StartupPath & "\Sello.png"
                ElseIf Dir(Application.StartupPath & "\Sello.gif") <> "" Then
                    RutaSello = Application.StartupPath & "\Sello.gif"
                End If
                If RutaSello <> "" Then
                    Dim obtenArchivo As System.IO.FileStream = New System.IO.FileStream(RutaSello, IO.FileMode.Open, IO.FileAccess.Read)
                    Dim br As System.IO.BinaryReader = New System.IO.BinaryReader(obtenArchivo)
                    Dim imagenBytes(obtenArchivo.Length) As Byte
                    br.Read(imagenBytes, 0, obtenArchivo.Length)
                    br.Close()
                    obtenArchivo.Close()
                    FilLogo("Sello") = imagenBytes
                End If

                'incluiremos un segundo logo
                RutaLogo = ""
                If Dir(Application.StartupPath & "\Logo2.bmp") <> "" Then
                    RutaLogo = Application.StartupPath & "\Logo2.bmp"
                ElseIf Dir(Application.StartupPath & "\Logo2.jpg") <> "" Then
                    RutaLogo = Application.StartupPath & "\Logo2.jpg"
                ElseIf Dir(Application.StartupPath & "\Logo2.png") <> "" Then
                    RutaLogo = Application.StartupPath & "\Logo2.png"
                ElseIf Dir(Application.StartupPath & "\Logo2.gif") <> "" Then
                    RutaLogo = Application.StartupPath & "\Logo2.gif"
                End If
                If RutaLogo <> "" Then
                    Dim obtenArchivo As System.IO.FileStream = New System.IO.FileStream(RutaLogo, IO.FileMode.Open, IO.FileAccess.Read)
                    Dim br As System.IO.BinaryReader = New System.IO.BinaryReader(obtenArchivo)
                    Dim imagenBytes(obtenArchivo.Length) As Byte
                    br.Read(imagenBytes, 0, obtenArchivo.Length)
                    br.Close()
                    obtenArchivo.Close()
                    FilLogo("Logo2") = imagenBytes
                End If

                tblLogo.Rows.Add(FilLogo)
            Catch ex As Exception
                'MsgBox("No se puede obtener el logo." & vbCrLf & ex.Message)
            End Try

            Me.lblLicencia.Caption = MENSAJE_DEMO
            Try
                If ObtenerParametro("SKIN") <> "" Then
                    Me.DefaultLookAndFeel1.LookAndFeel.SkinName = ObtenerParametro("SKIN")
                End If
            Catch ex As Exception

            End Try

            Me.Text = "[SISCO] - " & ObtenerParametro("Cliente")
            Me.lblTextStatus.Caption = UCase(StiGlobalConn.Server & ":" & StiGlobalConn.DB & ":" & StiGlobalConn.User & "  |  " & Format(Date.Today, "dd/MMM/yyyy"))

            Try
                'llenaremos el combo con los años disponibles de produccion

                Dim tblAnio As DataTable = StiGlobalConn.ObtenerDataset("select distinct year(FechaMovimiento) as anio from FacturasMovimientos order by 1 desc").Tables(0)

                For Each Fila In tblAnio.Rows
                    cboEstAnio.Items.Add(Fila("anio"))
                    If AnioAnalisis = 0 Then
                        AnioAnalisis = Val(Fila("anio"))
                    End If
                Next
                btnEstAnio.EditValue = AnioAnalisis


            Catch ex As Exception

            End Try

            'validacion para las versiones de SISCO
            Try
                Dim Version As String = clSeguros.ObtenerVersion()
                Select Case Version
                    Case "ESTANDAR"
                        'BLOQUEMOAS CAJA Y CORRESPONDENCIA
                        mnuRecibos.Visible = False
                        mnuCorrespondencia.Visible = False
                        grpDirecciones.Visible = False

                    Case "EMPRESARIAL"
                        'NO BLOQUEMOS NADA

                    Case "DEMOPOL"
                        mnuSeguridad.Visible = False
                        mnuTablas.Visible = False
                        mnuCartera.Visible = False
                        mnuRecibos.Visible = False
                        'mnuPolizas.Visible = False
                        mnuComisiones.Visible = False
                        mnuEstaditicas.Visible = False
                        mnuSiniestros.Visible = False
                        mnuCorrespondencia.Visible = False
                        grpDirecciones.Visible = False

                    Case "DEMOPOLCAR"
                        mnuSeguridad.Visible = False
                        mnuTablas.Visible = False
                        'mnuCartera.Visible = False
                        mnuRecibos.Visible = False
                        'mnuPolizas.Visible = False
                        mnuComisiones.Visible = False
                        mnuEstaditicas.Visible = False
                        mnuSiniestros.Visible = False
                        mnuCorrespondencia.Visible = False
                        grpDirecciones.Visible = False

                    Case "EMPCAJA"
                        'BLOQUEAMOS UNICAMENTE CORRESPONDENCIA
                        mnuCorrespondencia.Visible = False
                        grpDirecciones.Visible = False

                    Case "EMPCORRES"
                        'BLOQUEAMOS UNICAMENTE CAJA
                        mnuRecibos.Visible = False


                    Case Else
                        If MODALIDAD_DEMO = False Then
                            'BLOQUEMOS TODOS LOS MODULOS
                            mnuSeguridad.Visible = False
                            mnuTablas.Visible = False
                            mnuCartera.Visible = False
                            mnuRecibos.Visible = False
                            mnuPolizas.Visible = False
                            mnuComisiones.Visible = False
                            mnuEstaditicas.Visible = False
                            mnuSiniestros.Visible = False
                            mnuCorrespondencia.Visible = False
                            grpDirecciones.Visible = False
                        End If

                End Select

            Catch ex As Exception

            End Try

            Try
                'clientes con una versión de office en otro idioma
                Dim CultureID As String = clSeguros.ObtenerDBParametros("CultureInfo.Id")
                If CultureID <> "" Then
                    System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(CultureID)
                End If
            Catch ex As Exception

            End Try

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Private Sub btnTipoVendedores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTipoVendedores.ItemClick
        Dim frmTVen As New TipoVendedorNav
        frmTVen.STIConn = StiGlobalConn
        frmTVen.MdiParent = Me
        frmTVen.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmTVen.Show()
    End Sub

    Private Sub btnEstado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstado.ItemClick
        Dim frmEst As New EstadosNav
        frmEst.STIConn = StiGlobalConn
        frmEst.MdiParent = Me
        frmEst.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmEst.Show()
    End Sub

    Private Sub btnVendedores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVendedores.ItemClick
        Dim frmVen As New VendedoresNav
        frmVen.STIConn = StiGlobalConn
        frmVen.MdiParent = Me
        frmVen.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmVen.Show()
    End Sub

    Private Sub btnGrupos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrupos.ItemClick
        Dim frmGrp As New GruposNav
        frmGrp.STIConn = StiGlobalConn
        frmGrp.MdiParent = Me
        frmGrp.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmGrp.Show()
    End Sub

    Private Sub btnUsuarios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUsuarios.ItemClick
        Dim frmUsu As New UsuariosNav
        frmUsu.STIConn = StiGlobalConn
        frmUsu.MdiParent = Me
        frmUsu.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmUsu.Show()
    End Sub

    Private Sub btnParametro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnParametro.ItemClick
        Dim frmPar As New ParametrosNav
        frmPar.STIConn = StiGlobalConn
        frmPar.MdiParent = Me
        frmPar.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmPar.Show()
    End Sub

    Private Sub btnProductos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProductos.ItemClick
        Dim frmPro As New ProductosNav
        frmPro.STIConn = StiGlobalConn
        frmPro.MdiParent = Me
        frmPro.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmPro.Show()
    End Sub

    Private Sub btnClientes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClientes.ItemClick


        'Dim Ruta As String = "D:\Archivos"

        'For I As Integer = 1 To 2000
        '    CreaRuta(Ruta & "\" & I.ToString & "\")
        '    System.IO.File.Copy(Ruta & "\12345.txt", Ruta & "\" & I.ToString & "\12345.txt")
        'Next
        'MsgBox("fin")

        'Dim lic As String = GeneraLicencia("2E0FEC04REUNION ASEGURADORA SALVADOREÑA, S.A. DE C.V.", "20103")
        'Debug.WriteLine(lic)


        Dim frmCli As New ClientesNav
        frmCli.STIConn = StiGlobalConn
        frmCli.MdiParent = Me
        frmCli.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCli.Show()

    End Sub

    Private Sub btnFormaPago_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFormaPago.ItemClick
        Dim frmFP As New FormasPagoNav
        frmFP.STIConn = StiGlobalConn
        frmFP.MdiParent = Me
        frmFP.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmFP.Show()
    End Sub

    Private Sub btnPago_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPago.ItemClick
        Dim frmPA As New PagosNav
        frmPA.STIConn = StiGlobalConn
        frmPA.MdiParent = Me
        frmPA.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmPA.Show()
    End Sub

    Private Sub btnPagos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPagos.ItemClick
        Dim frmPAGO As New Pagos
        frmPAGO.STIConn = StiGlobalConn
        frmPAGO.MdiParent = Me
        frmPAGO.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmPAGO.Show()
    End Sub

    Private Sub btnAnulaPago_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnulaPago.ItemClick
        Dim frmAPAGO As New PagosAnula
        frmAPAGO.STIConn = StiGlobalConn
        frmAPAGO.MdiParent = Me
        frmAPAGO.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmAPAGO.Show()
    End Sub

    Private Sub btnAnulacion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnulacion.ItemClick
        Dim frmAnula As New Anulaciones
        frmAnula.STIConn = StiGlobalConn
        frmAnula.MdiParent = Me
        frmAnula.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmAnula.Show()
    End Sub

    Private Sub barFacturar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barFacturar.ItemClick
        Dim frmFact As New AvisosCobrosNav ''  Facturacion
        frmFact.STIConn = StiGlobalConn
        frmFact.MdiParent = Me
        frmFact.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmFact.Show()
    End Sub

    Private Sub barRamos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barRamos.ItemClick
        Dim frmRamo As New RamosNav
        frmRamo.STIConn = StiGlobalConn
        frmRamo.MdiParent = Me
        frmRamo.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRamo.Show()
    End Sub

    Private Sub btnGastos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGastos.ItemClick
        Dim frmGas As New GastosNav
        frmGas.STIConn = StiGlobalConn
        frmGas.MdiParent = Me
        frmGas.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmGas.Show()
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = e.Item.Caption
        ActualizarParametro("SKIN", e.Item.Caption)
        GuardarParametros()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = e.Item.Caption
        ActualizarParametro("SKIN", e.Item.Caption)
        GuardarParametros()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = e.Item.Caption
        ActualizarParametro("SKIN", e.Item.Caption)
        GuardarParametros()
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = e.Item.Caption
        ActualizarParametro("SKIN", e.Item.Caption)
        GuardarParametros()
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = e.Item.Caption
        ActualizarParametro("SKIN", e.Item.Caption)
        GuardarParametros()
    End Sub

    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = e.Item.Caption
        ActualizarParametro("SKIN", e.Item.Caption)
        GuardarParametros()
    End Sub

    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = e.Item.Caption
        ActualizarParametro("SKIN", e.Item.Caption)
        GuardarParametros()
    End Sub

    Private Sub btnRepPrimasPend_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepPrimasPend.ItemClick
        Dim frmRepPP As New RepPrimasPendientes
        frmRepPP.MdiParent = Me
        frmRepPP.STIConn = StiGlobalConn
        frmRepPP.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRepPP.Show()
    End Sub

    Private Sub btnRepComi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepComi.ItemClick
        Dim frmRepCO As New RepComisiones
        frmRepCO.MdiParent = Me
        frmRepCO.STIConn = StiGlobalConn
        frmRepCO.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRepCO.Show()
    End Sub

    Private Sub btnTipoGestion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTipoGestion.ItemClick
        Dim frmTGES As New TipoGestionNav
        frmTGES.STIConn = StiGlobalConn
        frmTGES.MdiParent = Me
        frmTGES.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmTGES.Show()
    End Sub

    Private Sub btnEstcomi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstcomi.ItemClick
        Dim frmECC As New EstadosCuentaComiNav  ''EstadosCuentaComi
        frmECC.STIConn = StiGlobalConn
        frmECC.MdiParent = Me
        frmECC.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmECC.Show()
    End Sub

    Private Sub btnGestionCartera_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGestionCartera.ItemClick
        Dim frmGCAR As New LstPrimasPendientes '' GestionesCarteraNav
        ''frmGCAR.STIConn = StiGlobalConn
        frmGCAR.STIConn = StiGlobalConn
        frmGCAR.MdiParent = Me
        frmGCAR.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmGCAR.Show()
    End Sub

    Private Sub btnlstPagos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnlstPagos.ItemClick
        Dim fLstPagos As New LstPagos
        fLstPagos.MdiParent = Me
        fLstPagos.STIConn = StiGlobalConn
        fLstPagos.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        fLstPagos.Show()
    End Sub

    Private Sub btnGestPend_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGestPend.ItemClick
        Dim Frges As New RepGestionesCartera
        Frges.MdiParent = Me
        Frges.STIConn = StiGlobalConn
        Frges.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        Frges.Show()
    End Sub

    Private Sub btnNotasCredito_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNotasCredito.ItemClick
        Dim frmNC As New NotasCreditoNav
        frmNC.STIConn = StiGlobalConn
        frmNC.MdiParent = Me
        frmNC.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmNC.Show()
    End Sub

    Private Sub btnLstEmisiones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLstEmisiones.ItemClick
        Dim fLstEmi As New LstEmisiones
        fLstEmi.MdiParent = Me
        fLstEmi.STIConn = StiGlobalConn
        fLstEmi.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        fLstEmi.Show()
    End Sub

    Private Sub btnlstAnulaciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnlstAnulaciones.ItemClick
        Dim fLstAnu As New LstAnulaciones
        fLstAnu.MdiParent = Me
        fLstAnu.STIConn = StiGlobalConn
        fLstAnu.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        fLstAnu.Show()
    End Sub

    Private Sub btnRepEstCuentaCli_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepEstCuentaCli.ItemClick
        Dim frepEstCucli As New RepEstadosCuentaClientes
        frepEstCucli.MdiParent = Me
        frepEstCucli.STIConn = StiGlobalConn
        frepEstCucli.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frepEstCucli.Show()
    End Sub

    Private Sub btnBancos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBancos.ItemClick
        Dim frmBan As New BancosNav
        frmBan.STIConn = StiGlobalConn
        frmBan.MdiParent = Me
        frmBan.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmBan.Show()
    End Sub

    Private Sub btnRecibos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRecibos.ItemClick
        Dim frmRec As New RecibosNav
        frmRec.STIConn = StiGlobalConn
        frmRec.MdiParent = Me
        frmRec.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRec.Show()
    End Sub

    Private Sub btnAnulaRecibo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnulaRecibo.ItemClick
        Dim AnulaRec As New RecibosAnulacion
        AnulaRec.MdiParent = Me
        AnulaRec.STIConn = StiGlobalConn
        AnulaRec.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        AnulaRec.Show()
    End Sub

    Private Sub btnReciboAplicar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReciboAplicar.ItemClick
        Dim AplicaRec As New RecibosAplicar
        AplicaRec.MdiParent = Me
        AplicaRec.STIConn = StiGlobalConn
        AplicaRec.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        AplicaRec.Show()
    End Sub

    Private Sub btnDepositos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDepositos.ItemClick
        Dim frmDep As New DepositosNav
        frmDep.STIConn = StiGlobalConn
        frmDep.MdiParent = Me
        frmDep.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmDep.Show()
    End Sub

    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLstIngresos.ItemClick
        Dim fLstIng As New LstIngresos
        fLstIng.MdiParent = Me
        fLstIng.STIConn = StiGlobalConn
        fLstIng.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        fLstIng.Show()
    End Sub

    Private Sub btnRecNoAplica_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRecNoAplica.ItemClick
        Dim fLstRNA As New LstRecibosNoAplicados
        fLstRNA.MdiParent = Me
        fLstRNA.STIConn = StiGlobalConn
        fLstRNA.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        fLstRNA.Show()
    End Sub

    Private Sub btnCierreCaja_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCierreCaja.ItemClick
        Dim frmCC As New CierreCaja
        frmCC.STIConn = StiGlobalConn
        frmCC.MdiParent = Me
        frmCC.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCC.Show()
    End Sub

    Private Sub btnEnvioAseg_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnvioAseg.ItemClick
        Dim frmENV As New EnviosPago
        frmENV.MdiParent = Me
        frmENV.STIConn = StiGlobalConn
        frmENV.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmENV.Show()
    End Sub

    Private Sub btnPagosAseg_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPagosAseg.ItemClick
        Dim frmPagaseg As New PagosAsegNav
        frmPagaseg.STIConn = StiGlobalConn
        frmPagaseg.MdiParent = Me
        frmPagaseg.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmPagaseg.Show()
    End Sub

    Private Sub btnOperComi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOperComi.ItemClick
        Dim frmOperComi As New TipoOperacionesComiNav
        frmOperComi.STIConn = StiGlobalConn
        frmOperComi.MdiParent = Me
        frmOperComi.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmOperComi.Show()
    End Sub

    Private Sub btnLstComiProd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLstComiProd.ItemClick
        Dim fLstCP As New LstComiProductos
        fLstCP.MdiParent = Me
        fLstCP.STIConn = StiGlobalConn
        fLstCP.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        fLstCP.Show()
    End Sub

    Private Sub btnGesRea_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGesRea.ItemClick
        Dim FgesR As New RepGestionesRealizadas
        FgesR.MdiParent = Me
        FgesR.STIConn = StiGlobalConn
        FgesR.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        FgesR.Show()
    End Sub

    Private Sub btnCambioComi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCambioComi.ItemClick
        Dim FCamComi As New CambioComision
        FCamComi.MdiParent = Me
        FCamComi.STIConn = StiGlobalConn
        FCamComi.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        FCamComi.Show()
    End Sub

    Private Sub btnDetEnvio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetEnvio.ItemClick
        Dim frmDetEnv As New EnviosPagoNav
        frmDetEnv.STIConn = StiGlobalConn
        frmDetEnv.MdiParent = Me
        frmDetEnv.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmDetEnv.Show()
    End Sub

    Private Sub btnPolizas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPolizas.ItemClick
        Dim frmPol As New PolizasNav
        frmPol.STIConn = StiGlobalConn
        frmPol.MdiParent = Me
        frmPol.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmPol.Show()
    End Sub

    Private Sub btnCancelPol_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelPol.ItemClick
        Dim frmCanPol As New CancelaPoliza
        frmCanPol.STIConn = StiGlobalConn
        frmCanPol.MdiParent = Me
        frmCanPol.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCanPol.Show()
    End Sub

    Private Sub btnRenovarPol_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRenovarPol.ItemClick
        Dim frmRenPol As New RenovarPoliza
        frmRenPol.STIConn = StiGlobalConn
        frmRenPol.MdiParent = Me
        frmRenPol.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRenPol.Show()
    End Sub

    Private Sub btnReactivaPol_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReactivaPol.ItemClick
        Dim frmReaPol As New ReactivarPoliza
        frmReaPol.STIConn = StiGlobalConn
        frmReaPol.MdiParent = Me
        frmReaPol.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmReaPol.Show()
    End Sub

    Private Sub btnRepPolVenc_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepPolVenc.ItemClick
        Dim repPolVen As New RepPolizasVencer
        repPolVen.MdiParent = Me
        repPolVen.STIConn = StiGlobalConn
        repPolVen.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        repPolVen.Show()
    End Sub

    Private Sub btnRepPolCancela_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepPolCancela.ItemClick
        Dim repPolCan As New RepPolizasCancela
        repPolCan.MdiParent = Me
        repPolCan.STIConn = StiGlobalConn
        repPolCan.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        repPolCan.Show()
    End Sub

    Private Sub btnRepPolEmite_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepPolEmite.ItemClick
        Dim repPolEmi As New RepPolizasEmite
        repPolEmi.MdiParent = Me
        repPolEmi.STIConn = StiGlobalConn
        repPolEmi.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        repPolEmi.Show()
    End Sub

    Private Sub btnMovComi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMovComi.ItemClick
        Dim frmMovCom As New MovimientosComiNav
        frmMovCom.STIConn = StiGlobalConn
        frmMovCom.MdiParent = Me
        frmMovCom.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmMovCom.Show()
    End Sub

    Private Sub btnRepClieTar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepClieTar.ItemClick
        Dim repCliTar As New RepClienteTarjetas
        repCliTar.MdiParent = Me
        repCliTar.STIConn = StiGlobalConn
        repCliTar.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        repCliTar.Show()
    End Sub

    Private Sub btnPolBusBien_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPolBusBien.ItemClick
        Dim frmBusBie As New PolBuscarBienes
        frmBusBie.MdiParent = Me
        frmBusBie.STIConn = StiGlobalConn
        frmBusBie.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmBusBie.Show()
    End Sub

    Private Sub btnEstGraGen_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstGraGen.ItemClick
        Dim frmGraGen As New ProduccionGrafica
        frmGraGen.MdiParent = Me
        'frmGraGen.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmGraGen.Show()
    End Sub

    Private Sub cboEstAnio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEstAnio.SelectedIndexChanged
        Try
            Me.Cursor = Cursors.WaitCursor
            AnioAnalisis = sender.EditValue
            Dim Forma As Object
            For Each Forma In Me.MdiChildren
                Try
                    Forma.ActualizarDatos()
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception
            'no controlamos el error
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnEstExportar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstExportar.ItemClick
        Try
            Dim frm As Object = Nothing
            frm = Me.ActiveMdiChild
            If frm Is Nothing Then
                MsgBox("Debe abrir un cuadro estadístico para exportar.", MsgBoxStyle.Information, "AVISO...")
            Else
                frm.Exportar()   'cada formulario debe tener implementado este método público
            End If

        Catch ex As Exception
            'MsgBox("Error al exportar los datos a excel" & vbCrLf & ex.Message, MsgBoxStyle.Information, "Error...")
        End Try
    End Sub

    Private Sub btnEstMetas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstMetas.ItemClick
        Dim frmMetas As New MetasNav
        frmMetas.STIConn = StiGlobalConn
        frmMetas.MdiParent = Me
        frmMetas.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmMetas.Show()
    End Sub

    Private Sub btnEstAjus_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstAjus.ItemClick
        Try
            Dim frm As Object = Nothing
            frm = Me.ActiveMdiChild
            frm.BestFit() 'cada formulario debe tener implementado este método público
        Catch ex As Exception
            'no controlamos el error..
        End Try
    End Sub

    Private Sub btnEstResGen_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstResGen.ItemClick
        Dim frmProRes As New ProduccionResumen
        frmProRes.MdiParent = Me
        'frmProRes.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmProRes.Show()
    End Sub

    Private Sub btnEstProCli_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstProCli.ItemClick
        Dim frmProCli As New ProduccionClientes
        frmProCli.MdiParent = Me
        'frmProCli.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmProCli.Show()
    End Sub

    Private Sub btnEstMetaGrp_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstMetaGrp.ItemClick
        Dim frmEstMeta As New EjecutivosMetas
        frmEstMeta.MdiParent = Me
        'frmEstMeta.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmEstMeta.Show()
    End Sub

    Private Sub btnEstTec_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstTec.ItemClick
        Dim frmEstTec As New EstadisticaTecnica
        frmEstTec.MdiParent = Me
        'frmEstTec.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmEstTec.Show()
    End Sub

    Private Sub btnLog_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLog.ItemClick
        Dim frmLog As New RepLog
        frmLog.MdiParent = Me
        frmLog.STIConn = StiGlobalConn
        frmLog.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmLog.Show()
    End Sub

    Private Sub btnNotaAbono_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNotaAbono.ItemClick
        Dim frmNotas As New NotasAbonoNav
        frmNotas.STIConn = StiGlobalConn
        frmNotas.MdiParent = Me
        frmNotas.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmNotas.Show()
    End Sub

    Private Sub btnCondEsp_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCondEsp.ItemClick
        Dim frmCE As New CondicionesEspNav
        frmCE.STIConn = StiGlobalConn
        frmCE.MdiParent = Me
        frmCE.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCE.Show()
    End Sub

    Private Sub btnHisPol_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHisPol.ItemClick
        Dim frmHis As New PolizasHistorico
        frmHis.MdiParent = Me
        frmHis.STIConn = StiGlobalConn
        frmHis.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmHis.Show()
    End Sub

    Private Sub btnParentescos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnParentescos.ItemClick
        Dim frmParen As New ParentescosNav
        frmParen.STIConn = StiGlobalConn
        frmParen.MdiParent = Me
        frmParen.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmParen.Show()
    End Sub

    Private Sub btnPolBorrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPolBorrar.ItemClick
        Dim frmBPol As New PolizasEliminar
        frmBPol.MdiParent = Me
        frmBPol.STIConn = StiGlobalConn
        frmBPol.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmBPol.Show()
    End Sub

    Private Sub btnOfertaComp_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOfertaComp.ItemClick
        Dim frmOfertaComp As New OfertasComparativoNav
        frmOfertaComp.STIConn = StiGlobalConn
        frmOfertaComp.MdiParent = Me
        frmOfertaComp.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmOfertaComp.Show()
    End Sub

    Private Sub btnDetCliente_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetCliente.ItemClick
        Dim frmDetCli As New RepClientesAnalisis
        frmDetCli.MdiParent = Me
        frmDetCli.STIConn = StiGlobalConn
        frmDetCli.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmDetCli.Show()
    End Sub

    Private Sub btnDetSiniestro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetSiniestro.ItemClick
        Dim frmSin As New SiniestrosNav
        frmSin.STIConn = StiGlobalConn
        frmSin.MdiParent = Me
        frmSin.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmSin.Show()
    End Sub

    Private Sub btnRepSiniestros_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepSiniestros.ItemClick
        Dim repSin As New repFrmSiniestros
        repSin.MdiParent = Me
        repSin.STIConn = StiGlobalConn
        repSin.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        repSin.Show()
    End Sub

    Private Sub btnPagoSini_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPagoSini.ItemClick
        Dim frmPagSin As New PagoSiniestros
        frmPagSin.STIConn = StiGlobalConn
        frmPagSin.MdiParent = Me
        frmPagSin.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmPagSin.Show()
    End Sub

    Private Sub btnEstGraComi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstGraComi.ItemClick
        Dim frmGraComi As New ComisionGrafica
        frmGraComi.MdiParent = Me
        'frmGraComi.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmGraComi.Show()
    End Sub

    Private Sub btnCambiarFactura_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCambiarFactura.ItemClick
        Dim frmCamFact As New CambioFactura
        frmCamFact.STIConn = StiGlobalConn
        frmCamFact.MdiParent = Me
        frmCamFact.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCamFact.Show()
    End Sub

    Private Sub btnPlanes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPlanes.ItemClick
        Dim frmPl As New PlanesNav
        frmPl.STIConn = StiGlobalConn
        frmPl.MdiParent = Me
        frmPl.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmPl.Show()
    End Sub

    Private Sub btnImportPol_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportPol.ItemClick
        Dim frmImpCert As New ImportarCertificados
        frmImpCert.STIConn = StiGlobalConn
        frmImpCert.MdiParent = Me
        frmImpCert.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmImpCert.Show()
    End Sub

    Private Sub btnRepDepositos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepDepositos.ItemClick
        Dim repDep As New RepDepositos
        repDep.MdiParent = Me
        repDep.STIConn = StiGlobalConn
        repDep.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        repDep.Show()
    End Sub

    Private Sub btnDecSini_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDecSini.ItemClick
        Dim Decsin As New DeclaracionSiniestros
        Decsin.MdiParent = Me
        Decsin.STIConn = StiGlobalConn
        Decsin.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        Decsin.dbTabla = "Siniestros"
        Decsin.Show()
    End Sub

    Private Sub btnDetPolVence_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetPolVence.ItemClick
        Dim frmDetVen As New LstPolizasVencimiento
        frmDetVen.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmDetVen.STIConn = StiGlobalConn
        frmDetVen.MdiParent = Me
        frmDetVen.Show()
    End Sub

    Private Sub btnSinPlanes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSinPlanes.ItemClick
        Dim PlanSin As New PlanSiniestrosNav
        PlanSin.STIConn = StiGlobalConn
        PlanSin.MdiParent = Me
        PlanSin.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        PlanSin.Show()
    End Sub

    Private Sub btnEnvioSini_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnvioSini.ItemClick
        Dim frmEnvsini As New EnviosSiniestrosNav
        frmEnvsini.STIConn = StiGlobalConn
        frmEnvsini.MdiParent = Me
        frmEnvsini.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmEnvsini.Show()
    End Sub

    Private Sub btnConSiniestros_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConSiniestros.ItemClick
        Dim frmConSin As New conReclamos
        frmConSin.MdiParent = Me
        frmConSin.STIConn = StiGlobalConn
        frmConSin.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmConSin.Show()
    End Sub

    Private Sub btnRepGMRegAseg_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepGMRegAseg.ItemClick
        Dim RegAseg As New repRegistroAsegurados
        RegAseg.MdiParent = Me
        RegAseg.STIConn = StiGlobalConn
        RegAseg.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        RegAseg.Show()
    End Sub

    Private Sub btnAnalisisIng_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnalisisIng.ItemClick
        Dim RepAnIng As New RepIngresosCaja
        RepAnIng.MdiParent = Me
        RepAnIng.STIConn = StiGlobalConn
        RepAnIng.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        RepAnIng.Show()
    End Sub

    Private Sub btnRepRecMora_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepRecMora.ItemClick
        Dim RepRM As New RepRecuperacionMora
        RepRM.MdiParent = Me
        RepRM.STIConn = StiGlobalConn
        RepRM.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        RepRM.Show()
    End Sub

    Private Sub btnRepRecGM_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepRecGM.ItemClick
        Dim RepRGM As New repReportesGM
        RepRGM.MdiParent = Me
        RepRGM.STIConn = StiGlobalConn
        RepRGM.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        RepRGM.Show()
    End Sub

    Private Sub btnCertBorrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCertBorrar.ItemClick
        Dim frmBCert As New PolizasCertificadosEliminar
        frmBCert.MdiParent = Me
        frmBCert.STIConn = StiGlobalConn
        frmBCert.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmBCert.Show()
    End Sub

    Private Sub btnComiVendedor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnComiVendedor.ItemClick
        Dim frmEstComiVen As New EstadosCuentaVendedoresNav
        frmEstComiVen.STIConn = StiGlobalConn
        frmEstComiVen.MdiParent = Me
        frmEstComiVen.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmEstComiVen.Show()
    End Sub

    Private Sub btnFormularios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFormularios.ItemClick
        Dim frmForm As New FormulariosNav
        frmForm.STIConn = StiGlobalConn
        frmForm.MdiParent = Me
        frmForm.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmForm.Show()
    End Sub

    Private Sub btnGestionSin_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGestionSin.ItemClick
        Dim frmlgs As New LstGestionSiniestros
        frmlgs.MdiParent = Me
        frmlgs.STIConn = StiGlobalConn
        frmlgs.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmlgs.Show()
    End Sub

    Private Sub btnRepGesSinPen_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepGesSinPen.ItemClick
        Dim frmrgsp As New repGestionesSiniestros
        frmrgsp.MdiParent = Me
        frmrgsp.STIConn = StiGlobalConn
        frmrgsp.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmrgsp.Show()
    End Sub

    Private Sub btnRepGesSinRea_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepGesSinRea.ItemClick
        Dim frmrgsr As New repGestionesSinRealizadas
        frmrgsr.MdiParent = Me
        frmrgsr.STIConn = StiGlobalConn
        frmrgsr.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmrgsr.Show()
    End Sub

    Private Sub btnAnulaSini_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnulaSini.ItemClick
        Dim frmAS As New SiniestrosAnulacion
        frmAS.MdiParent = Me
        frmAS.STIConn = StiGlobalConn
        frmAS.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmAS.Show()
    End Sub

    Private Sub btnTrasCarClie_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTrasCarClie.ItemClick
        Dim frmTraClie As New ClientesTraslados
        frmTraClie.MdiParent = Me
        frmTraClie.STIConn = StiGlobalConn
        frmTraClie.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmTraClie.Show()
    End Sub

    Private Sub btnRepSinSalDeud_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepSinSalDeud.ItemClick
        Dim frmRepDeud As New repDeudores
        frmRepDeud.MdiParent = Me
        frmRepDeud.STIConn = StiGlobalConn
        frmRepDeud.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRepDeud.Show()
    End Sub

    Private Sub btnSinPagoDeudor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSinPagoDeudor.ItemClick
        Dim frmPagDeud As New PagoDeudores
        frmPagDeud.MdiParent = Me
        frmPagDeud.STIConn = StiGlobalConn
        frmPagDeud.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmPagDeud.Show()
    End Sub

    Private Sub btnImpFacturas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpFacturas.ItemClick
        Dim frmImpFact As New ImportarFacturas
        frmImpFact.MdiParent = Me
        frmImpFact.STIConn = StiGlobalConn
        frmImpFact.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmImpFact.Show()
    End Sub

    Private Sub btnRepOferPend_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepOferPend.ItemClick
        Dim repOfertaPend As New repOfertasPendientes
        repOfertaPend.MdiParent = Me
        repOfertaPend.STIConn = StiGlobalConn
        repOfertaPend.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        repOfertaPend.Show()
    End Sub

    Private Sub btnEstCuentaPol_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstCuentaPol.ItemClick
        Dim repECP As New RepEstadoCuentaPol
        repECP.MdiParent = Me
        repECP.STIConn = StiGlobalConn
        repECP.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        repECP.Show()
    End Sub

    Private Sub btnCartaVenceTarjetas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCartaVenceTarjetas.ItemClick
        Dim repVT As New RepVencimientosTarjetas
        repVT.MdiParent = Me
        repVT.STIConn = StiGlobalConn
        repVT.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        repVT.Show()
    End Sub

    Private Sub btnRepPolRutaDig_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepPolRutaDig.ItemClick
        Dim repAD As New RepPolizasArchivosDigitales
        repAD.MdiParent = Me
        repAD.STIConn = StiGlobalConn
        repAD.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        repAD.Show()
    End Sub

    Private Sub btnEstPolizas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstPolizas.ItemClick
        Dim EstPol As New EstadisticasPolizas
        EstPol.MdiParent = Me
        ''EstPol.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        EstPol.Show()
    End Sub

    Private Sub btnImpPolizas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpPolizas.ItemClick
        Dim ImpPol As New ImportarPolizas
        ImpPol.MdiParent = Me
        ImpPol.STIConn = StiGlobalConn
        ImpPol.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        ImpPol.Show()
    End Sub

    Private Sub btnRepCierresCaja_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepCierresCaja.ItemClick
        Dim frmRepCCaja As New repCierresCaja
        frmRepCCaja.MdiParent = Me
        frmRepCCaja.STIConn = StiGlobalConn
        frmRepCCaja.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRepCCaja.Show()
    End Sub

    Private Sub btnImportarSiniestros_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportarSiniestros.ItemClick
        Dim ImpSin As New ImportarReclamos
        ImpSin.MdiParent = Me
        ImpSin.STIConn = StiGlobalConn
        ImpSin.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        ImpSin.Show()
    End Sub

    Private Sub btnPreCertifica_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPreCertifica.ItemClick
        Dim frmPreCert As New PreCertificacionesNav
        frmPreCert.STIConn = StiGlobalConn
        frmPreCert.MdiParent = Me
        frmPreCert.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmPreCert.Show()
    End Sub

    Private Sub btnRepPReCert_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepPReCert.ItemClick
        Dim frmRepPC As New repPreAutorizaciones
        frmRepPC.MdiParent = Me
        frmRepPC.STIConn = StiGlobalConn
        frmRepPC.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRepPC.Show()
    End Sub

    Private Sub btnOfertas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOfertas.ItemClick
        Dim frmOfertas As New CPolizasNav
        frmOfertas.STIConn = StiGlobalConn
        frmOfertas.MdiParent = Me
        frmOfertas.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmOfertas.Show()
    End Sub

    Private Sub btnUnificarProductos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUnificarProductos.ItemClick
        Dim frmUnProd As New ProductosTraslados
        frmUnProd.MdiParent = Me
        frmUnProd.STIConn = StiGlobalConn
        frmUnProd.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmUnProd.Show()
    End Sub

    Private Sub btnGestionPol_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGestionPol.ItemClick
        Dim frmGesPol As New LstGestionesPolizas
        frmGesPol.MdiParent = Me
        frmGesPol.STIConn = StiGlobalConn
        frmGesPol.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmGesPol.Show()
    End Sub

    Private Sub btnRepGesPolPen_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepGesPolPen.ItemClick
        Dim frmGPP As New RepGestionesPolizas
        frmGPP.MdiParent = Me
        frmGPP.STIConn = StiGlobalConn
        frmGPP.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmGPP.Show()
    End Sub

    Private Sub btnRepGesPolRea_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepGesPolRea.ItemClick
        Dim frmGPPR As New RepGestionesPolizasRealizadas
        frmGPPR.MdiParent = Me
        frmGPPR.STIConn = StiGlobalConn
        frmGPPR.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmGPPR.Show()
    End Sub

    Private Sub btnDepartamentos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDepartamentos.ItemClick
        Dim frmDeptos As New DepartamentosNav
        frmDeptos.STIConn = StiGlobalConn
        frmDeptos.MdiParent = Me
        frmDeptos.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmDeptos.Show()
    End Sub

    Private Sub btnMunicipios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMunicipios.ItemClick
        Dim frmMuni As New MunicipiosNav
        frmMuni.STIConn = StiGlobalConn
        frmMuni.MdiParent = Me
        frmMuni.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmMuni.Show()
    End Sub

    Private Sub brnCiudades_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles brnCiudades.ItemClick
        Dim frmCiudad As New CiudadesNav
        frmCiudad.STIConn = StiGlobalConn
        frmCiudad.MdiParent = Me
        frmCiudad.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCiudad.Show()
    End Sub

    Private Sub btnFlujos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFlujos.ItemClick
        Dim frmFlujo As New FlujosNav
        frmFlujo.STIConn = StiGlobalConn
        frmFlujo.MdiParent = Me
        frmFlujo.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmFlujo.Show()
    End Sub

    Private Sub btnDetCorrespondencia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetCorrespondencia.ItemClick
        Dim frmDetFlujo As New CorrespondenciaNav
        frmDetFlujo.STIConn = StiGlobalConn
        frmDetFlujo.MdiParent = Me
        frmDetFlujo.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmDetFlujo.Show()
    End Sub

    Private Sub btnIniciarFlujo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIniciarFlujo.ItemClick
        Dim frmNuevoFl As New NuevoFlujo
        frmNuevoFl.STIConn = StiGlobalConn
        frmNuevoFl.MdiParent = Me
        frmNuevoFl.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmNuevoFl.Show()
    End Sub

    Private Sub btnContinuarFlujo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnContinuarFlujo.ItemClick
        Dim frmContFl As New ContinuarFlujoNav
        frmContFl.STIConn = StiGlobalConn
        frmContFl.MdiParent = Me
        frmContFl.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmContFl.Show()
    End Sub

    Private Sub btnUbicaciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUbicaciones.ItemClick
        Dim frmUBI As New UbicacionesNav
        frmUBI.STIConn = StiGlobalConn
        frmUBI.MdiParent = Me
        frmUBI.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmUBI.Show()
    End Sub

    Private Sub btnZonas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnZonas.ItemClick
        Dim frmZona As New ZonasNav
        frmZona.STIConn = StiGlobalConn
        frmZona.MdiParent = Me
        frmZona.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmZona.Show()
    End Sub

    Private Sub btnRepAnaFlujos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepAnaFlujos.ItemClick
        Dim frmRepFl As New LstFlujos
        frmRepFl.MdiParent = Me
        frmRepFl.STIConn = StiGlobalConn
        frmRepFl.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRepFl.Show()
    End Sub

    Private Sub btnRepCorrSalida_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepCorrSalida.ItemClick
        Dim frmRepCRS As New repCorrespondenciaSalida
        frmRepCRS.MdiParent = Me
        frmRepCRS.STIConn = StiGlobalConn
        frmRepCRS.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRepCRS.Show()
    End Sub

    Private Sub btnGenDocumento_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGenDocumento.ItemClick
        Dim frmGenDoc As New GeneracionDocumentos
        frmGenDoc.MdiParent = Me
        frmGenDoc.STIConn = StiGlobalConn
        frmGenDoc.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmGenDoc.Show()
    End Sub

    Private Sub btnSinCalcLiq_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSinCalcLiq.ItemClick
        Dim frmPreLiq As New PreLiquidacion
        frmPreLiq.MdiParent = Me
        frmPreLiq.STIConn = StiGlobalConn
        frmPreLiq.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmPreLiq.Show()
    End Sub

    Private Sub btnAsignarFlujo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAsignarFlujo.ItemClick
        Dim frmAsignar As New AsignarFlujoNav
        frmAsignar.STIConn = StiGlobalConn
        frmAsignar.MdiParent = Me
        frmAsignar.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmAsignar.Show()
    End Sub

    Private Sub btnReAsignarFlujo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReAsignarFlujo.ItemClick
        Dim frmReAsignar As New ReAsignarFlujoNav
        frmReAsignar.STIConn = StiGlobalConn
        frmReAsignar.MdiParent = Me
        frmReAsignar.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmReAsignar.Show()
    End Sub

    Private Sub btnCatFlujos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCatFlujos.ItemClick
        Dim frmCatFL As New CategoriasFlujoNav
        frmCatFL.STIConn = StiGlobalConn
        frmCatFL.MdiParent = Me
        frmCatFL.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCatFL.Show()
    End Sub

    Private Sub btnDetPolEmite_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetPolEmite.ItemClick
        Dim frmDetEmi As New LstPolizasEmisiones
        frmDetEmi.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmDetEmi.STIConn = StiGlobalConn
        frmDetEmi.MdiParent = Me
        frmDetEmi.Show()
    End Sub

    Private Sub btnCamNumPol_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCamNumPol.ItemClick
        Dim frmCambPol As New CambiarNumeroPoliza
        frmCambPol.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCambPol.STIConn = StiGlobalConn
        frmCambPol.MdiParent = Me
        frmCambPol.Show()
    End Sub

    Private Sub btnEstSiniClie_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstSiniClie.ItemClick
        Dim frmSiniCli As New SiniestralidadClientes
        frmSiniCli.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmSiniCli.STIConn = StiGlobalConn
        frmSiniCli.MdiParent = Me
        frmSiniCli.Show()
    End Sub

    Private Sub btnCorrAgenda_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCorrAgenda.ItemClick
        Dim frmAgenda As New LstAgendaTrabajo
        frmAgenda.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmAgenda.STIConn = StiGlobalConn
        frmAgenda.MdiParent = Me
        frmAgenda.Show()
    End Sub

    Private Sub btnControlCorr_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnControlCorr.ItemClick
        Dim frmConCC As New LstControlCorrespondencia
        frmConCC.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmConCC.STIConn = StiGlobalConn
        frmConCC.MdiParent = Me
        frmConCC.Show()
    End Sub

    Private Sub btnAnulaCorr_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnulaCorr.ItemClick
        Dim frmAnulaDoc As New ImpresionesCorrNav
        frmAnulaDoc.STIConn = StiGlobalConn
        frmAnulaDoc.MdiParent = Me
        frmAnulaDoc.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmAnulaDoc.Show()
    End Sub

    Private Sub btnRecibeDoc_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRecibeDoc.ItemClick

        dim opcRecibir as string = clSeguros.ObtenerDBParametros("Corr.Verif.DocPend")
        if opcRecibir.Trim.ToUpper = "S" then
            dim DocPendientes as string = ObtenerListaDocumentosPendientes()
            if DocPendientes <> "" then
                MsgBox("No se pueden ingresar nuevos documentos, existen Flujos pendientes del día anterior por marginar: "  & vbcrlf & DocPendientes , MsgBoxStyle.Information, "AVISO...")
                exit sub 
            End If
        End If
            
        Dim frmRecDoc As New RecibirDocumentos
        frmRecDoc.MdiParent = Me
        frmRecDoc.STIConn = StiGlobalConn
        frmRecDoc.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRecDoc.Show()
    End Sub

    Private Sub btnRutearDoc_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRutearDoc.ItemClick
        Dim frmRutDoc As New RutearDocumentosNav
        frmRutDoc.STIConn = StiGlobalConn
        frmRutDoc.MdiParent = Me
        frmRutDoc.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRutDoc.Show()
    End Sub

    Private Sub btnResCorr_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResCorr.ItemClick
        Dim frmResDoc As New LstResumenCorrespondencia
        frmResDoc.MdiParent = Me
        frmResDoc.STIConn = StiGlobalConn
        frmResDoc.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmResDoc.Show()
    End Sub

    Private Sub btnDRutDoc_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDRutDoc.ItemClick
        Dim frmdRutDoc As New DesRutearDocumentoNav
        frmdRutDoc.STIConn = StiGlobalConn
        frmdRutDoc.MdiParent = Me
        frmdRutDoc.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmdRutDoc.Show()
    End Sub

    Private Sub btnRepPPCliente_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepPPCliente.ItemClick
        Dim frmRepPP As New RepPrimasPendientesClientes
        frmRepPP.MdiParent = Me
        frmRepPP.STIConn = StiGlobalConn
        frmRepPP.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRepPP.Show()
    End Sub

    Private Sub btnTiposPago_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTiposPago.ItemClick
        Dim frmTPago As New TipoPagoNav
        frmTPago.STIConn = StiGlobalConn
        frmTPago.MdiParent = Me
        frmTPago.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmTPago.Show()
    End Sub

    Private Sub btnCambiarReclamo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCambiarReclamo.ItemClick
        Dim frmCamRec As New CambiarNumeroReclamo
        frmCamRec.MdiParent = Me
        frmCamRec.STIConn = StiGlobalConn
        frmCamRec.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCamRec.Show()
    End Sub

    Private Sub btnNotificaciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNotificaciones.ItemClick
        Dim frmNoti As New NotificacionesNav
        frmNoti.STIConn = StiGlobalConn
        frmNoti.MdiParent = Me
        frmNoti.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmNoti.Show()
    End Sub

    Private Sub btnRepCorrDes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepCorrDes.ItemClick
        Dim frmCorrDes As New LstDocumentosDesruteados
        frmCorrDes.MdiParent = Me
        frmCorrDes.STIConn = StiGlobalConn
        frmCorrDes.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCorrDes.Show()
    End Sub

    Private Sub btnSegSiniestros_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSegSiniestros.ItemClick
        Dim frmSegSini As New SeguimientoSiniestros
        frmSegSini.MdiParent = Me
        frmSegSini.STIConn = StiGlobalConn
        frmSegSini.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmSegSini.Show()
    End Sub

    Private Sub btnRepSegSiniestros_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepSegSiniestros.ItemClick
        Dim frmRSegSini As New repSeguimientoSinistros
        frmRSegSini.MdiParent = Me
        frmRSegSini.STIConn = StiGlobalConn
        frmRSegSini.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRSegSini.Show()
    End Sub

    Private Sub btnImportarClientes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportarClientes.ItemClick
        Dim frmImpClie As New ImportarClientes
        frmImpClie.MdiParent = Me
        frmImpClie.STIConn = StiGlobalConn
        frmImpClie.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmImpClie.Show()
    End Sub

    Private Sub btnClientesProdComi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClientesProdComi.ItemClick
        Dim frmCliProdComi As New RepComiClientesVendedor
        frmCliProdComi.MdiParent = Me
        frmCliProdComi.STIConn = StiGlobalConn
        frmCliProdComi.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCliProdComi.Show()
    End Sub

    Private Sub btnEnviarDocSimple_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviarDocSimple.ItemClick
        Dim frmDocSimple As New EnvioDocumentoSimple
        frmDocSimple.MdiParent = Me
        frmDocSimple.STIConn = StiGlobalConn
        frmDocSimple.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmDocSimple.Show()
    End Sub

    Private Sub btnRecibeDocSimple_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRecibeDocSimple.ItemClick
        Dim frmDocSimple As New RecibeDocumentoSimple
        frmDocSimple.MdiParent = Me
        frmDocSimple.STIConn = StiGlobalConn
        frmDocSimple.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmDocSimple.Show()
    End Sub

    Private Sub btnTipoCancela_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTipoCancela.ItemClick
        Dim frmTCan As New TiposCancelaNav
        frmTCan.STIConn = StiGlobalConn
        frmTCan.MdiParent = Me
        frmTCan.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmTCan.Show()
    End Sub

    Private Sub btnReporteTarjetas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReporteTarjetas.ItemClick
        Dim LstVT As New LstVencimientosTarjetas
        LstVT.MdiParent = Me
        LstVT.STIConn = StiGlobalConn
        LstVT.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        LstVT.Show()
    End Sub

    Private Sub btnRepMovPol_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepMovPol.ItemClick
        Dim LstMovPol As New repMovimientosPolizas
        LstMovPol.MdiParent = Me
        LstMovPol.STIConn = StiGlobalConn
        LstMovPol.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        LstMovPol.Show()
    End Sub

    Private Sub PersonalizarBotonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextPersonalizar.ItemPress
        Try
            Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)
            Dim Control As Object = cms.SourceControl
            MsgBox(Control.Name)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnContactosCategorias_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnContactosCategorias.ItemClick
        Dim frmCatCon As New CategoriaContactosNav
        frmCatCon.STIConn = StiGlobalConn
        frmCatCon.MdiParent = Me
        frmCatCon.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCatCon.Show()
    End Sub

    Private Sub btnRegistroContactos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRegistroContactos.ItemClick
        Dim frmRegCon As New ContactosGeneralesNav
        frmRegCon.STIConn = StiGlobalConn
        frmRegCon.MdiParent = Me
        frmRegCon.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRegCon.Show()
    End Sub

    Private Sub btnFinalizarFlujos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFinalizarFlujos.ItemClick
        Dim frmFinFlujos As New FinalizarFlujosNav
        frmFinFlujos.STIConn = StiGlobalConn
        frmFinFlujos.MdiParent = Me
        frmFinFlujos.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmFinFlujos.Show()
    End Sub

    Private Sub btnGestionTeleCartera_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGestionTeleCartera.ItemClick
        Dim frmGTC As New GestionTelefonicaCartera
        frmGTC.STIConn = StiGlobalConn
        frmGTC.MdiParent = Me
        frmGTC.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmGTC.Show()
    End Sub

    Private Sub btnConPorceComi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConPorceComi.ItemClick
        Dim frmRcc As New RepComiComparativo
        frmRcc.STIConn = StiGlobalConn
        frmRcc.MdiParent = Me
        frmRcc.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRcc.Show()
    End Sub

    Private Sub btnActualizarDeducible_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnActualizarDeducible.ItemClick
        Dim frmAccDed As New ActualizarDeducibles
        frmAccDed.STIConn = StiGlobalConn
        frmAccDed.MdiParent = Me
        frmAccDed.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmAccDed.Show()
    End Sub

    Private Sub btnDiagnosticos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDiagnosticos.ItemClick
        Dim frmDiag As New DiagnosticosNav
        frmDiag.STIConn = StiGlobalConn
        frmDiag.MdiParent = Me
        frmDiag.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmDiag.Show()
    End Sub

    Private Sub btnAnexoCobro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnexoCobro.ItemClick
        Dim frmAnexo As New RecalcularAnexo
        frmAnexo.STIConn = StiGlobalConn
        frmAnexo.MdiParent = Me
        frmAnexo.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmAnexo.Show()
    End Sub

    Private Sub btnRepAnexosPoliza_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepAnexosPoliza.ItemClick
        Dim frmRepAnexo As New RepAnexosPoliza
        frmRepAnexo.STIConn = StiGlobalConn
        frmRepAnexo.MdiParent = Me
        frmRepAnexo.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRepAnexo.Show()

    End Sub

    Private Sub btnRepAnalisisSiniestros_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepAnalisisSiniestros.ItemClick
        Dim frmSinPre As New LstSiniestrosPresentados
        frmSinPre.STIConn = StiGlobalConn
        frmSinPre.MdiParent = Me
        frmSinPre.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmSinPre.Show()
    End Sub

    Private Sub btnEliminarAC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarAC.ItemClick
        Dim frmBAC As New AvisosCobroEliminar
        frmBAC.MdiParent = Me
        frmBAC.STIConn = StiGlobalConn
        frmBAC.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmBAC.Show()
    End Sub

    Private Sub btnAnalisisPolizas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnalisisPolizas.ItemClick
        Dim LstAPol As New LstAnalisisPolizas
        LstAPol.MdiParent = Me
        LstAPol.STIConn = StiGlobalConn
        LstAPol.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        LstAPol.Show()
    End Sub

    Private Sub btnMarcarCorrSal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarcarCorrSal.ItemClick
        Dim LstMcorr As New LstMarcarCorrSalida
        LstMcorr.MdiParent = Me
        LstMcorr.STIConn = StiGlobalConn
        LstMcorr.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        LstMcorr.Show()
    End Sub

    Private Sub btnAnalisisFecRec_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnalisisFecRec.ItemClick
        Dim lstRecFec As New repReclamosFechas
        lstRecFec.MdiParent = Me
        lstRecFec.STIConn = StiGlobalConn
        lstRecFec.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        lstRecFec.Show()
    End Sub

    Private Sub btnRegLlamadas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRegLlamadas.ItemClick
        Dim lstRecLlam As New RegistroLlamadas
        lstRecLlam.MdiParent = Me
        lstRecLlam.STIConn = StiGlobalConn
        lstRecLlam.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        lstRecLlam.Show()
    End Sub

    Private Sub btnLstLlamadas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLstLlamadas.ItemClick
        Dim lstLlam As New LstLlamadas
        lstLlam.MdiParent = Me
        lstLlam.STIConn = StiGlobalConn
        lstLlam.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        lstLlam.Show()
    End Sub

    Private Sub btnCambiarCertificado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCambiarCertificado.ItemClick
        Dim lstCamCer As New CertificadosCambiarNumero
        lstCamCer.MdiParent = Me
        lstCamCer.STIConn = StiGlobalConn
        lstCamCer.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        lstCamCer.Show()
    End Sub

    Private Sub btnEntregaSinMsg_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEntregaSinMsg.ItemClick
        Dim lstEntregaMsg As New LstEntregaSinMensajero
        lstEntregaMsg.MdiParent = Me
        lstEntregaMsg.STIConn = StiGlobalConn
        lstEntregaMsg.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        lstEntregaMsg.Show()
    End Sub

    Private Sub btnExcRehabCert_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcRehabCert.ItemClick
        Dim frmExcREh As New CambiosEnCertificados
        frmExcREh.STIConn = StiGlobalConn
        frmExcREh.MdiParent = Me
        frmExcREh.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmExcREh.Show()
    End Sub

    Private Sub btnTrasCert_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTrasCert.ItemClick
        Dim frmTrasCer As New TrasladoCertificados
        frmTrasCer.STIConn = StiGlobalConn
        frmTrasCer.MdiParent = Me
        frmTrasCer.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmTrasCer.Show()
    End Sub

    Private Sub btnRenAuto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRenAuto.ItemClick
        Dim frmRenAuto As New RenovacionAutomatica
        frmRenAuto.STIConn = StiGlobalConn
        frmRenAuto.MdiParent = Me
        frmRenAuto.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRenAuto.Show()
    End Sub

    Private Sub btnImpDocRecibidos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpDocRecibidos.ItemClick
        Dim frmDocImp As New ADRImpresionDocRecibidos
        frmDocImp.STIConn = StiGlobalConn
        frmDocImp.MdiParent = Me
        frmDocImp.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmDocImp.Show()
    End Sub

    Private Sub btnAnaDocRecibe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnaDocRecibe.ItemClick
        Dim frmADocImp As New ADRAnalisisDocRecibidos
        frmADocImp.STIConn = StiGlobalConn
        frmADocImp.MdiParent = Me
        frmADocImp.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmADocImp.Show()
    End Sub

    Private Sub btnActNumFac_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnActNumFac.ItemClick
        Dim frmActFact As New ActualizarNumFacturas
        frmActFact.STIConn = StiGlobalConn
        frmActFact.MdiParent = Me
        frmActFact.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmActFact.Show()
    End Sub

    Private Sub btnRepEstCuentaMatriz_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepEstCuentaMatriz.ItemClick
        Dim frmEstMatriz As New RepFacturasMatriz
        frmEstMatriz.STIConn = StiGlobalConn
        frmEstMatriz.MdiParent = Me
        frmEstMatriz.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmEstMatriz.Show()
    End Sub

    Private Sub btnTalonarios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTalonarios.ItemClick
        Dim frmTalonario As New TalonariosNav
        frmTalonario.STIConn = StiGlobalConn
        frmTalonario.MdiParent = Me
        frmTalonario.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmTalonario.Show()
    End Sub

    Private Sub btnActClaseSiniestro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnActClaseSiniestro.ItemClick
        Dim frmActClaSin As New SiniestroActClase
        frmActClaSin.STIConn = StiGlobalConn
        frmActClaSin.MdiParent = Me
        frmActClaSin.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmActClaSin.Show()
    End Sub

    Private Sub btnCotizaciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCotizaciones.ItemClick
        Dim frmCot As New CGPolizasNav
        frmCot.STIConn = StiGlobalConn
        frmCot.MdiParent = Me
        frmCot.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmCot.Show()
    End Sub

    Private Sub btnRepGestionOfertas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepGestionOfertas.ItemClick
        Dim frmGPPR As New RepGestionesOfertasRealizadas
        frmGPPR.MdiParent = Me
        frmGPPR.STIConn = StiGlobalConn
        frmGPPR.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmGPPR.Show()
    End Sub

    Private Sub btnAnalisisOfertas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnalisisOfertas.ItemClick
        Dim frmAnOfe As New LstAnalisisOfertas
        frmAnOfe.MdiParent = Me
        frmAnOfe.STIConn = StiGlobalConn
        frmAnOfe.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmAnOfe.Show()
    End Sub

    Private Sub btnActividadesOfertas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnActividadesOfertas.ItemClick
        Dim frmAnOfe As New LstActividadesOfertas
        frmAnOfe.MdiParent = Me
        frmAnOfe.STIConn = StiGlobalConn
        frmAnOfe.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmAnOfe.Show()
    End Sub

    Private Sub btnRepChequeIngreso_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepChequeIngreso.ItemClick
        Dim frmChIng As New LstChequesIngreso
        frmChIng.MdiParent = Me
        frmChIng.STIConn = StiGlobalConn
        frmChIng.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmChIng.Show()
    End Sub

    Private Sub btnConfirmaEntregaDoc_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConfirmaEntregaDoc.ItemClick
        Dim frmConfEntrega As New ConfirmaEntregaDocNav
        frmConfEntrega.MdiParent = Me
        frmConfEntrega.STIConn = StiGlobalConn
        frmConfEntrega.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmConfEntrega.Show()
    End Sub

    Private Sub btnRepDiarioOfertas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRepDiarioOfertas.ItemClick
        Dim frmRepOf As New CGPolizasCierre
        frmRepOf.MdiParent = Me
        frmRepOf.STIConn = StiGlobalConn
        frmRepOf.Permiso = ObtenerPermiso(StiGlobalConn.User, e.Item.Name)
        frmRepOf.Show()
    End Sub

End Class

