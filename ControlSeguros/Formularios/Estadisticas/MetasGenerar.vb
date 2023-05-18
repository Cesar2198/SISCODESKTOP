Imports Utilerias.Genericas
Imports System.Text.RegularExpressions

Public Class MetasGenerar

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub MetasGenerar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''cargaremos los ramos y ejecutivos de cuenta
        Dim sql As String = ""

        sql = "  select IdRamo"
        sql &= " , NombreRamo"
        sql &= " , 0.0 as Meta"
        sql &= " , 0.0 as Comision"
        sql &= " , cast(1 as bit) as Incluir"
        sql &= " from RamoSeguros"

        Dim Ramos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        Me.GridRamos.DataSource = Ramos
        Me.GridRamos.Refresh()

        sql = "  select idusuario as Usuario"
        sql &= " ,NombreUsuario  as Nombre"
        sql &= " , cast(1 as bit) as Incluir"
        sql &= " from Usuarios"
        sql &= " where EsEjecutivo = 'S'"

        Dim Ejecutivos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        Me.GridEjecutivos.DataSource = Ejecutivos
        Me.GridEjecutivos.Refresh()

        Me.txtAnio.Valor = Year(Date.Today)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        If Me.txtAnio.Text = "" Then
            MsgBox("Debe Especificar el Año.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        ''generaremos las metas
        Dim NumEjecutivos As Integer = 0
        For NE As Integer = 0 To Me.VistaEjecutivos.DataRowCount - 1
            If Me.VistaEjecutivos.GetRowCellValue(NE, "Incluir") = True Then
                NumEjecutivos += 1
            End If
        Next
        'If NumEjecutivos = 0 Then
        '    MsgBox("Debe seleccionar al menos un ejecutivo de cuenta.", MsgBoxStyle.Information, "AVISO...")
        '    Exit Sub
        'End If

        Dim MetaPrima As Double = 0, MetaComi As Double = 0, sql As String = ""
        Try

            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")
            ''por cada ramo
            For NR As Integer = 0 To Me.VistaRamos.DataRowCount - 1
                If Me.VistaRamos.GetRowCellValue(NR, "Incluir") = True And Val(Me.VistaRamos.GetRowCellValue(NR, "Meta")) > 0 Then
                    'por cada mes
                    For NM As Integer = 1 To 12
                        ''por cada ejecutivo
                        If NumEjecutivos = 0 Then
                            MetaPrima = (Val(Me.VistaRamos.GetRowCellValue(NR, "Meta")) / 12)
                            MetaComi = (Val(Me.VistaRamos.GetRowCellValue(NR, "Comision")) / 12)

                            sql = "  insert into Metas "
                            sql &= " (Anio, Mes, Primas, Comisiones, IdRamo, EjecutivoCta) values ("
                            sql &= dbInt(Me.txtAnio.Valor) & C & dbInt(NM) & C & dbNum(MetaPrima) & C & dbNum(MetaComi) & C & dbStr(Me.VistaRamos.GetRowCellValue(NR, "IdRamo")) & C & dbStr("") & ")"
                            StiGlobalConn.SQLExecute(sql)

                        Else
                            MetaPrima = (Val(Me.VistaRamos.GetRowCellValue(NR, "Meta")) / 12) / NumEjecutivos
                            MetaComi = (Val(Me.VistaRamos.GetRowCellValue(NR, "Comision")) / 12) / NumEjecutivos

                            For NE As Integer = 0 To Me.VistaEjecutivos.DataRowCount - 1
                                If Me.VistaEjecutivos.GetRowCellValue(NE, "Incluir") = True Then
                                    sql = "  insert into Metas "
                                    sql &= " (Anio, Mes, Primas, Comisiones, IdRamo, EjecutivoCta) values ("
                                    sql &= dbInt(Me.txtAnio.Valor) & C & dbInt(NM) & C & dbNum(MetaPrima) & C & dbNum(MetaComi) & C & dbStr(Me.VistaRamos.GetRowCellValue(NR, "IdRamo")) & C & dbStr(Me.VistaEjecutivos.GetRowCellValue(NE, "Usuario")) & ")"
                                    StiGlobalConn.SQLExecute(sql)
                                End If
                            Next
                        End If
                    Next
                End If
            Next
            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            MsgBox("Las metas han sido generadas con éxito.", MsgBoxStyle.Information, "AVISO...")
        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            MsgBox("Error al generar las metas, la operación ha sido cancelada." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "ERROR...")
        End Try
    End Sub

    Private Sub VistaRamos_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaRamos.CellValueChanged
        If e.Column.FieldName = "Meta" Then
            Try
                Me.VistaRamos.SetRowCellValue(e.RowHandle, "Comision", Math.Round(Val(e.Value) * 0.1, 2))
            Catch ex As Exception

            End Try
        End If
    End Sub

End Class
