Imports Utilerias.Genericas

Public Class stiPersonalizaCampo

    Public Forma As String = ""
    Public Campo As String = ""
    Public Nombre As String = ""
    Public Obligatorio As String = ""
    Public STIConn As Conectividad.Funciones

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub stiPersonalizaCampo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboObligatorio.Llenar_Combo()
        txtNombre.Valor = Nombre
        cboObligatorio.Valor = Obligatorio
        Me.CenterToParent()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Nombre = Me.txtNombre.Valor
        If Nombre <> "" Then
            STIConn.SQLExecute("delete from VistasCampos where forma = " & dbStr(Forma) & " and campo = " & dbStr(Campo))
            STIConn.SQLExecute("insert into VistasCampos (Forma,Campo,Nombre,Obligatorio) values(" & dbStr(Forma) & "," & dbStr(Campo) & ", " & dbStr(Nombre) & ", " & dbStr(cboObligatorio.Valor) & ")")
            MsgBox("El cambio ha sido registrado con éxito.", MsgBoxStyle.Information, "AVISO...")
            Me.Close()
        End If
    End Sub

End Class