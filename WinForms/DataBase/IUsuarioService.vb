Imports DataBase.Models

Public Interface IUsuarioService
    Function ListarUsuarios() As Task(Of List(Of Usuario))
    Function GuardarUsuario(user As Usuario) As Task
    Function ActualizarUsuario(user As Usuario) As Task
    Function EliminarUsuario(idUsuario As Integer) As Task
End Interface
