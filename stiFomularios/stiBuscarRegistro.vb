Imports Utilerias.Genericas

Public Class stiBuscarRegistro

    Public STIConn As Conectividad.Funciones
    Public Columnas As String = ""
    Public ColAlias As String = ""
    Public Filtro As String = ""
    Public Tabla As String = ""
    Private Datos As DataSet

    Private Sub CargarDatos()
        Try
            If Columnas <> "" Then
                Dim sql As String = ""
                sql = " select " & Columnas & " from " & Tabla
                If Filtro <> "" Then sql &= " where " & Filtro
                Datos = STIConn.ObtenerDataset(sql)

                GridBuscar.DataSource = Datos.Tables(0)

                Try
                    'ahora si hay alias validamos
                    If Me.ColAlias <> "" Then
                        Dim NumCol As Integer = CuentaCar(Me.ColAlias, ","), ColNombre As String = ""
                        For i As Integer = 0 To NumCol
                            ColNombre = stiSplit(Me.ColAlias, "G" & i & ",1").Trim
                            If ColNombre <> "" Then
                                VistaBuscar.Columns(i).Caption = ColNombre
                            End If
                        Next
                    End If

                Catch ex As Exception

                End Try

                GridBuscar.Refresh()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub stiBuscarRegistro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call CargarDatos()
        Me.VistaBuscar.Focus()
        VistaBuscar.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
    End Sub

    Private Sub GridBuscar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridBuscar.DoubleClick
        'regresamos los campos llaves que se seleccionó
        Dim res As String = ""
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn
        For Each Col In Me.VistaBuscar.Columns
            Dim Tipo As String = Col.ColumnType.Name.ToLower

            If Tipo Like "*int*" Or Tipo Like "*long*" Or Tipo Like "*nume*" Or Tipo Like "*deci*" Or Tipo Like "*float*" Or Tipo Like "*curre*" Or Tipo Like "*money*" Then
                res &= " and " & Col.FieldName & " = " & dbNum(VistaBuscar.GetRowCellValue(Me.VistaBuscar.FocusedRowHandle, Col.FieldName))
            ElseIf Tipo Like "*string*" Or Tipo Like "*char*" Or Tipo Like "*text*" Or Tipo Like "*memo*" Then
                res &= " and " & Col.FieldName & " = " & dbStr(VistaBuscar.GetRowCellValue(Me.VistaBuscar.FocusedRowHandle, Col.FieldName))
            ElseIf Tipo Like "*date*" Then
                res &= " and " & Col.FieldName & " = " & dbFec(VistaBuscar.GetRowCellValue(Me.VistaBuscar.FocusedRowHandle, Col.FieldName))
            End If
        Next
        If res <> "" Then res = res.Substring(5)
        Me.Tag = res
        Me.Close()
    End Sub

    Private Function CuentaCar(ByVal Cadena As String, ByVal CAR As String) As Integer
        'esta funcion devuelve la cantidad de caracteres encontrados en
        'una cadena.

        Dim Cont As Long, ULT As Integer
        Cont = 0 : ULT = 1
        Do While 1
            ULT = InStr(ULT, Cadena, CAR)
            If ULT <> 0 Then
                ULT = ULT + 1 : Cont = Cont + 1
            Else
                Exit Do
            End If
        Loop
        Return Cont
    End Function

    Private Function stiSplit(ByVal ID As String, ByVal Param As String) As String
        'EL PARAM ES G#?# es usado para calcular substring especiales, separados por 
        'un caracter especial.

        Dim Car As String = "", INICIO As Integer, ITEMS As Integer, I As Long
        Dim INI As Integer, FIN As Integer, ITEMT As Integer, ITEMC As Integer
        Dim TOTITEMS As Integer

        Select Case Param.ToUpper.Substring(0, 1)
            Case "G"
                For I = 1 To Param.Length - 1
                    If Not IsNumeric(Param.Substring(I, 1)) Then
                        INICIO = Val(Param.Substring(1, I - 1))
                        ITEMS = Val(Param.Substring(I + 1, Param.Length - (I + 1)))
                        Car = Param.Substring(I, 1)
                        Exit For
                    End If
                Next
                TOTITEMS = CuentaCar(ID, Car)
                ITEMT = 0 : INI = 0 : ITEMC = -1
                If TOTITEMS = 0 Then
                    'NO EXISTEN CARATERES ESPECIALES, SE REGRESA TODO EL TEXTO
                    Return ID
                Else
                    For I = 0 To ID.Length - 1
                        If ID.Substring(I, 1) = Car Or I = ID.Length Then
                            If ITEMT <> INICIO Then
                                If ITEMC = -1 Then INI = I + 1
                            Else
                                ITEMC = 0
                            End If
                            If ITEMC >= 0 Then ITEMC = ITEMC + 1
                            If ITEMC = ITEMS Then
                                FIN = I - 1
                                Exit For
                            End If
                            ITEMT = ITEMT + 1
                        End If
                    Next
                    If ITEMT = INICIO Then ITEMC = 0
                    If ITEMC = -1 Then
                        Return ""
                    Else
                        If FIN = 0 And I = ID.Length Then FIN = ID.Length - 1
                        Return ID.Substring(INI, (FIN - INI) + 1)
                    End If
                End If
        End Select

        'si llega hasta aqui el formato esta mal mandamos vacio
        Return ""
    End Function

End Class