Public Class Funciones

#Region "Constructores"
    Public Sub New(ByVal NombreServidor As String, ByVal NombreBaseDatos As String, byval Usuario as string, Password as string,  ByVal ConectarAhora As Boolean)
        Server = NombreServidor
        DB = NombreBaseDatos
        User = Usuario
        passw = Password
        If ConectarAhora Then
            Call Conectarse()
        End If
    End Sub

#End Region

#Region "Declaraciones"
    Public Conn As New SqlClient.SqlConnection
    Public Server As String = ""
    Public DB As String = ""
    public User as string = ""
    private passw as string = ""

#End Region

#Region "Metodos"

    Public Sub Conectarse()
        Try
            Conn.ConnectionString = "data source=" & Server & ";initial catalog=" & DB & ";User ID=" & User & ";Password=" & passw & ";packet size=4096;persist security info=True;Pooling=False"
            Conn.Open()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Desconectarse()
        Try
            Conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerOledbConnectionString() As String
        Dim strConn As String = ""
        Try
            strConn = "Provider=SQLOLEDB;data source=" & Server & ";initial catalog=" & DB & ";packet size=4096;persist security info=True;Pooling=False;User ID=" & User & ";Password=" & passw
        Catch ex As Exception
            strConn = ""
        End Try
        Return strConn
    End Function

    Public Function ObtenerDataset(ByVal Query As String) As DataSet
        Dim ds As New Data.DataSet
        Call VerificarEstadoConeccion()
        Try
            If Query.Trim <> "" Then
                Dim cmd As New SqlClient.SqlCommand(Query, Conn)
                cmd.CommandTimeout = 10000
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(ds)
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return ds
    End Function

    Public Sub SQLExecute(ByVal Query As String)
        Dim Tipo As String
        If Query.Trim = "" Then Exit Sub
        Call VerificarEstadoConeccion()
        Try
            Dim com = New SqlClient.SqlCommand(Query)
            com.CommandTimeout = 10000
            com.Connection = Conn
            'verificamos que tipo de sql es
            Tipo = Query.Trim.Substring(1, 6)
            Select Case Tipo.ToUpper
                Case "SELECT"
                    Dim re As SqlClient.SqlDataReader = com.ExecuteReader()
                Case "EXECUT"
                    Dim re1 As SqlClient.SqlDataReader = com.ExecuteReader()
                Case Else
                    com.ExecuteNonQuery()
            End Select
            'If Not UsarTransacciones Then Call DBDisconnect()
        Catch ex As SqlClient.SqlException
            Throw ex
        Catch ex2 As Exception
            Throw ex2
        End Try
    End Sub

    Public Function ObtenerEsquema(ByVal InfoEsquema As String) As DataTable
        Dim tbl As New DataTable
        Try
            'Ejemplos: Tables, DataBases, Columns, etc.
            tbl = Me.Conn.GetSchema(InfoEsquema)
        Catch ex As Exception

        End Try
        Return tbl
    End Function

    Private Sub VerificarEstadoConeccion()
        'verificamos si la conección esta cerrada, para proceder a restaurarla
        Try
            If Conn.State = ConnectionState.Closed Or Conn.State = ConnectionState.Broken Then
                Call Conectarse()
            End If
        Catch ex As Exception
            'no reportaremos el error, solo es un intento por restaurar la conección si ocurre un fallo.
        End Try
    End Sub

    Public Function UsuarioPerteneceAGrupo(ByVal Usuario As String, ByVal Grupo As String) As Boolean
        Dim res As Boolean = False
        Try
            Dim Cuenta As Integer = ObtenerDataset("select count(*) from UsuariosGrupos where IdUsuario = '" & Usuario & "' and IdGrupo = '" & Grupo & "' ").Tables(0).Rows(0).Item(0)
            If Cuenta > 0 Then
                res = True
            End If
        Catch ex As Exception
            res = False
        End Try
        Return res
    End Function

#End Region



End Class
