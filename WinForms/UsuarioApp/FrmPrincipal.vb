Imports DataBase
Imports DataBase.Models
Imports Microsoft.Extensions.DependencyInjection

Public Class frmPrincipal
    Public Sub New()
        InitializeComponent()
        CargarUsuarios()
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Using scope = Dependencias.CreateScope()
            Dim servicioUsuario = scope.ServiceProvider.GetRequiredService(Of IUsuarioService)()

            Using frm = New frmFormularioUsuario(servicioUsuario, Nothing)
                If frm.ShowDialog() = DialogResult.OK Then
                    CargarUsuarios()
                End If
            End Using
        End Using
    End Sub

    Private Sub btnEditarUsuario_Click(sender As Object, e As EventArgs) Handles btnEditarUsuario.Click
        If dgvListaUsuarios.SelectedRows.Count > 0 Then
            Dim usuario = TryCast(dgvListaUsuarios.SelectedRows(0).DataBoundItem, Usuario)

            If usuario IsNot Nothing Then
                Using scope = Dependencias.CreateScope()
                    Dim usuarioService = scope.ServiceProvider.GetRequiredService(Of IUsuarioService)()

                    Using frm = New frmFormularioUsuario(usuarioService, usuario)
                        If frm.ShowDialog() = DialogResult.OK Then
                            CargarUsuarios()
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("Error al obtener la información del usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe seleccionar un registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Async Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        If dgvListaUsuarios.SelectedRows.Count > 0 Then
            Dim usuario = TryCast(dgvListaUsuarios.SelectedRows(0).DataBoundItem, Usuario)
            Dim result = MessageBox.Show($"¿Está seguro que desea eliminar el usuario '{usuario.UserName}'?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    Using scope = Dependencias.CreateScope()
                        Dim usuarioService = scope.ServiceProvider.GetRequiredService(Of IUsuarioService)()
                        Await usuarioService.EliminarUsuarioAsync(usuario.Id)
                        MessageBox.Show("El usuario se borró correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarUsuarios()
                    End Using
                Catch ex As Exception
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Debe seleccionar un registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Async Sub CargarUsuarios()
        dgvListaUsuarios.DataSource = Nothing

        Dim listadoUsuario As New List(Of Usuario)
        Using scope = Dependencias.CreateScope()
            Dim usuarioService = scope.ServiceProvider.GetRequiredService(Of IUsuarioService)()
            listadoUsuario = Await usuarioService.ListarUsuariosAsync()
        End Using

        dgvListaUsuarios.DataSource = listadoUsuario

        If dgvListaUsuarios.Columns.Contains("Id") Then
            dgvListaUsuarios.Columns("Id").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            dgvListaUsuarios.Columns("Id").Width = 50
            dgvListaUsuarios.Columns("Id").HeaderText = "ID"
        End If
    End Sub
End Class
