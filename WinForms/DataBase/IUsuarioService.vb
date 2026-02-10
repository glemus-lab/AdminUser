Imports DataBase.Models

Public Interface IUsuarioService
    Function ListarUsuariosAsync() As Task(Of List(Of Usuario))
    Function GuardarUsuarioAsync(user As Usuario) As Task
    Function ActualizarUsuarioAsync(user As Usuario) As Task
    Function EliminarUsuarioAsync(idUsuario As Integer) As Task
End Interface
