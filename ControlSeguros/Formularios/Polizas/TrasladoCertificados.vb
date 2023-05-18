Imports Utilerias.Genericas

Public Class TrasladoCertificados

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarPolizaOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPolizaOrigen.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas Vigentes"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtPolizaOrigen.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboProductoOrigen.Valor = stiSplit(busCodigo, "G1|1")
            'obtenemos el nombre del cliente
            Try
                Dim filPol As DataRow = StiGlobalConn.ObtenerDataset("select NombreCliente from Polizas where IdPoliza =  " & dbStr(txtPolizaOrigen.Valor) & " and IdProducto = " & dbStr(cboProductoOrigen.Valor)).Tables(0).Rows(0)
                Me.txtClienteOrigen.Valor = dbData(filPol, "NombreCliente")
                Call CargarCertificados()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnBuscarPolizaDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPolizaDestino.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas Vigentes"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtPolizaDestino.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboProductoDestino.Valor = stiSplit(busCodigo, "G1|1")
            'obtenemos el nombre del cliente
            Try
                Dim filPol As DataRow = StiGlobalConn.ObtenerDataset("select NombreCliente from Polizas where IdPoliza =  " & dbStr(txtPolizaDestino.Valor) & " and IdProducto = " & dbStr(cboProductoDestino.Valor)).Tables(0).Rows(0)
                Me.txtClienteDestino.Valor = dbData(filPol, "NombreCliente")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub CargarCertificados()
        Try
            Dim sql As String = ""

            sql = "  select "
            sql &= " IdCertificado"
            sql &= " ,IdCertificadoAseguradora"
            sql &= " ,VigenciaDesde"
            sql &= " ,FechaExclusion"
            sql &= " ,NombreCliente"
            sql &= " ,cast(0 as bit) as Incluir"
            sql &= " from PolizasCertificados"
            sql &= " where IdPoliza = " & dbStr(txtPolizaOrigen.Valor)
            sql &= " and IdProducto = " & dbStr(cboProductoOrigen.Valor)
            sql &= " Order By IdCertificado"
            Dim dtCert As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.GridCertificados.DataSource = dtCert
            Me.GridCertificados.Refresh()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.txtPolizaOrigen.Text = "" Then
            MsgBox("Debe especificar la póliza origen.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtPolizaDestino.Text = "" Then
            MsgBox("Debe especificar la póliza destino.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim lstCert As String = ""
        For I As Integer = 0 To Me.VistaCertificados.RowCount - 1
            If Me.VistaCertificados.GetRowCellValue(I, "Incluir") = True Then
                If lstCert = "" Then
                    lstCert &= dbStr(VistaCertificados.GetRowCellValue(I, "IdCertificado"))
                Else
                    lstCert &= "," & dbStr(VistaCertificados.GetRowCellValue(I, "IdCertificado"))
                End If
            End If
        Next

        If lstCert = "" Then
            MsgBox("Debe seleccionar los certificados que desea trasladar.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.cboProductoOrigen.Valor.ToString.Trim.ToUpper <> Me.cboProductoDestino.Valor.ToString.Trim.ToUpper Then
            If MsgBox("Los productos de las polizas no son iguales esto puede ocasionar inconsistencia en los bienes de los certificados " & vbCrLf & "¿Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then Exit Sub
        End If


        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")
            Dim sql As String = ""

            sql = "  INSERT INTO PolizasCertificados"
            sql &= " (IdPoliza,IdProducto,IdCertificado,IdCliente,NombreCliente,FechaInclusion,VigenciaDesde,VigenciaHasta,ValorAsegurado,PrimaNeta,GastosEmi"
            sql &= " ,GastosFrac,GastosBomb,GastosOtros,Iva,Total,EstadoCertificado,FechaExclusion,RazonExclusion,Deducible,Participacion"
            sql &= " ,IdVendedor,UsuarioModifica,FechaModifica,PorceDescuento,ValorDescuento,PrimaBruta,IdPlan,PorceDepreciacion,IdCertificadoAseguradora,PrimaExenta,PrimaMinima) "
            sql &= " select " & dbStr(txtPolizaDestino.Valor) & ", " & dbStr(cboProductoDestino.Valor) & ",IdCertificado,IdCliente,NombreCliente,FechaInclusion,VigenciaDesde,VigenciaHasta,ValorAsegurado,PrimaNeta,GastosEmi"
            sql &= " ,GastosFrac,GastosBomb,GastosOtros,Iva,Total,EstadoCertificado,FechaExclusion,RazonExclusion,Deducible,Participacion"
            sql &= " ,IdVendedor,UsuarioModifica,FechaModifica,PorceDescuento,ValorDescuento,PrimaBruta,IdPlan,PorceDepreciacion,IdCertificadoAseguradora,PrimaExenta,PrimaMinima "
            sql &= " from PolizasCertificados where IdPoliza = " & dbStr(txtPolizaOrigen.Valor) & " and idproducto = " & dbStr(cboProductoOrigen.Valor)
            sql &= " and idcertificado in (" & lstCert & ") "
            StiGlobalConn.SQLExecute(sql)

            sql = "  INSERT INTO PolizasBienes (IdPoliza,IdProducto,IdCertificado,IdBien,NombreBien,DescripcionBien,SumaAsegurada,Prima)"
            sql &= " select " & dbStr(txtPolizaDestino.Valor) & ", " & dbStr(cboProductoDestino.Valor) & ",IdCertificado,IdBien,NombreBien,DescripcionBien,SumaAsegurada,Prima"
            sql &= " from PolizasBienes where IdPoliza = " & dbStr(txtPolizaOrigen.Valor) & " and idproducto = " & dbStr(cboProductoOrigen.Valor)
            sql &= " and idcertificado in (" & lstCert & ") "
            StiGlobalConn.SQLExecute(sql)

            sql = "  INSERT INTO PolizasBeneficiarios (IdPoliza,IdProducto,IdCertificado,IdBeneficiario,NombreBeneficiario,Parentesco,FechaNacimiento,Porcentaje)"
            sql &= " select " & dbStr(txtPolizaDestino.Valor) & ", " & dbStr(cboProductoDestino.Valor) & ",IdCertificado,IdBeneficiario,NombreBeneficiario,Parentesco,FechaNacimiento,Porcentaje"
            sql &= " from PolizasBeneficiarios where IdPoliza = " & dbStr(txtPolizaOrigen.Valor) & " and idproducto = " & dbStr(cboProductoOrigen.Valor)
            sql &= " and idcertificado in (" & lstCert & ") "
            StiGlobalConn.SQLExecute(sql)

            sql = "  INSERT INTO PolizasCesiones (IdPoliza,IdProducto,IdCertificado,IdCesion,Beneficiario,FechaVigente,FechaCancela,SumaCedida,Observaciones,Propietario)"
            sql &= " select " & dbStr(txtPolizaDestino.Valor) & ", " & dbStr(cboProductoDestino.Valor) & ",IdCertificado,IdCesion,Beneficiario,FechaVigente,FechaCancela,SumaCedida,Observaciones,Propietario"
            sql &= " from PolizasCesiones where IdPoliza = " & dbStr(txtPolizaOrigen.Valor) & " and idproducto = " & dbStr(cboProductoOrigen.Valor)
            sql &= " and idcertificado in (" & lstCert & ") "
            StiGlobalConn.SQLExecute(sql)

            sql = "  INSERT INTO PolizasCoberturas (IdPoliza,IdProducto,IdCertificado,IdCobertura,SumaAsegurada,Tasa,Deducible,Prima,PorceSuma,AplicarDescuento"
            sql &= " ,Participacion,CoberturaAdicional,AplicarIva,PrimaMinima,PrimaMaxima,DeducibleMinimo,DeducibleMaximo,PorceDeducible,PrimaAnual)"
            sql &= " Select " & dbStr(txtPolizaDestino.Valor) & ", " & dbStr(cboProductoDestino.Valor) & ",IdCertificado,IdCobertura,SumaAsegurada,Tasa,Deducible,Prima,PorceSuma,AplicarDescuento"
            sql &= " ,Participacion,CoberturaAdicional,AplicarIva,PrimaMinima,PrimaMaxima,DeducibleMinimo,DeducibleMaximo,PorceDeducible,PrimaAnual "
            sql &= " from PolizasCoberturas where IdPoliza = " & dbStr(txtPolizaOrigen.Valor) & " and idproducto = " & dbStr(cboProductoOrigen.Valor)
            sql &= " and idcertificado in (" & lstCert & ") "
            StiGlobalConn.SQLExecute(sql)

            sql = "  INSERT INTO PolizasCoberturasAdicional (IdPoliza,IdProducto,IdCertificado,IdCobertura,Descripcion)"
            sql &= " select " & dbStr(txtPolizaDestino.Valor) & ", " & dbStr(cboProductoDestino.Valor) & ",IdCertificado,IdCobertura,Descripcion"
            sql &= " from PolizasCoberturasAdicional where IdPoliza = " & dbStr(txtPolizaOrigen.Valor) & " and idproducto = " & dbStr(cboProductoOrigen.Valor)
            sql &= " and idcertificado in (" & lstCert & ") "
            StiGlobalConn.SQLExecute(sql)

            'ahora cambiamos la vigencia de los certificados a la vigencia de la póliza
            sql = " update PolizasCertificados set PolizasCertificados.VigenciaDesde = Polizas.VigenciaDesde, PolizasCertificados.VigenciaHasta = Polizas.VigenciaHasta "
            sql &= " from PolizasCertificados "
            sql &= " inner join Polizas on Polizas.idpoliza = PolizasCertificados.idpoliza and Polizas.idproducto = PolizasCertificados.idproducto"
            sql &= " where PolizasCertificados.idpoliza = " & dbStr(txtPolizaDestino.Valor) & " and PolizasCertificados.idproducto = " & dbStr(cboProductoDestino.Valor)
            sql &= " and PolizasCertificados.idcertificado in (" & lstCert & ") "
            StiGlobalConn.SQLExecute(sql)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

            MsgBox("La operación de traslado ha finalizado con éxito.", MsgBoxStyle.Information, "AVISO...")

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            MsgBox("Error al realizar el traslado, la operación ha sido cancelada: " & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try

    End Sub

    Private Sub TrasladoCertificados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboProductoOrigen.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboProductoOrigen.Llenar_Combo()

        cboProductoDestino.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboProductoDestino.Llenar_Combo()
    End Sub

End Class
