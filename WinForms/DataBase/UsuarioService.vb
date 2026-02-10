Imports DataBase.Models
Imports Microsoft.Data.SqlClient
Imports Microsoft.Extensions.Configuration

Public Class UsuarioService
    Implements IUsuarioService

    Private ReadOnly _connectionString As String
    Private ReadOnly _config As IConfiguration

    Public Sub New(config As IConfiguration)
        _config = config
        _connectionString = config.GetConnectionString("connectionString")
    End Sub

    Public Async Function ListarUsuarios() As Task(Of List(Of Usuario)) Implements IUsuarioService.ListarUsuarios
        Dim users = New List(Of Usuario)

        Using conn As New SqlConnection(_connectionString)
            Dim cmd As New SqlCommand(_config("ProcedimientosAlmacenados:SP_Listado"), conn)
            cmd.CommandType = CommandType.StoredProcedure
            Await conn.OpenAsync()
            Using reader = Await cmd.ExecuteReaderAsync()
                While Await reader.ReadAsync()
                    users.Add(New Usuario() With {
                        .Id = reader("Id"),
                        .UserName = reader("UserName"),
                        .NombreCompleto = reader("NombreCompleto"),
                        .Correo = reader("Correo")
                    })
                End While
            End Using
        End Using

        Return users
    End Function

    Public Async Function GuardarUsuario(user As Usuario) As Task Implements IUsuarioService.GuardarUsuario
        Using conn = New SqlConnection(_connectionString)
            Dim cmd = New SqlCommand(_config("ProcedimientosAlmacenados:SP_Insert"), conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pUsername", user.UserName)
            cmd.Parameters.AddWithValue("@pNombreCompleto", user.NombreCompleto)
            cmd.Parameters.AddWithValue("@pCorreo", user.Correo)
            cmd.Parameters.AddWithValue("@pPassword", user.Password)
            Await conn.OpenAsync()
            Await cmd.ExecuteNonQueryAsync()
        End Using
    End Function

    Public Async Function ActualizarUsuario(user As Usuario) As Task Implements IUsuarioService.ActualizarUsuario
        Using conn = New SqlConnection(_connectionString)
            Dim cmd = New SqlCommand(_config("ProcedimientosAlmacenados:SP_Update"), conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pId", user.Id)
            cmd.Parameters.AddWithValue("@pNombreCompleto", user.NombreCompleto)
            cmd.Parameters.AddWithValue("@pCorreo", user.Correo)
            cmd.Parameters.AddWithValue("@pPassword", user.Password)
            Await conn.OpenAsync()
            Await cmd.ExecuteNonQueryAsync()
        End Using
    End Function

    Public Async Function EliminarUsuario(idUsuario As Integer) As Task Implements IUsuarioService.EliminarUsuario
        Using conn = New SqlConnection(_connectionString)
            Dim cmd = New SqlCommand(_config("ProcedimientosAlmacenados:SP_Delete"), conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pId", idUsuario)
            Await conn.OpenAsync()
            Await cmd.ExecuteNonQueryAsync()
        End Using
    End Function
End Class
