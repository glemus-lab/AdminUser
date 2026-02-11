Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports DataBase
Imports DataBase.Models
Imports Microsoft.IdentityModel.Tokens

Public Class frmFormularioUsuario
    Private ReadOnly _usuarioService As IUsuarioService
    Private ReadOnly _usuarioEditar As Usuario
    Private ReadOnly _esEdit = False

    Public Sub New(usuarioService As IUsuarioService, Optional usuario As Usuario = Nothing)
        InitializeComponent()
        _usuarioService = usuarioService
        _usuarioEditar = usuario

        If _usuarioEditar IsNot Nothing Then
            _esEdit = True
            Me.Text = "Editar usuario"
            lblNotaPassword.Visible = True

            _usuarioEditar = usuario
            txtUserName.Enabled = False
            txtUserName.Text = _usuarioEditar.UserName
            txtNombreCompleto.Text = _usuarioEditar.NombreCompleto
            txtCorreo.Text = _usuarioEditar.Correo
        Else
            Me.Text = "Crear usuario"
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren(ValidationConstraints.Enabled) Then
            Try
                Dim user = New Usuario() With {
                    .NombreCompleto = txtNombreCompleto.Text,
                    .Correo = txtCorreo.Text,
                    .Password = txtPassword.Text
                    }

                If _esEdit Then
                    user.Id = _usuarioEditar.Id
                    Await _usuarioService.ActualizarUsuarioAsync(user)
                Else
                    user.UserName = txtUserName.Text
                    Await _usuarioService.CrearUsuarioAsync(user)
                End If

                MessageBox.Show($"El usuario '{txtUserName.Text}' se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MessageBox.Show($"Error al guardar: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Por favor, corrija los errores marcados antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub txtUserName_Validating(sender As Object, e As CancelEventArgs) Handles txtUserName.Validating
        Select Case True
            Case txtUserName.Text.IsNullOrEmpty
                epUserName.SetError(txtUserName, "El campo es obligatorio.")
                e.Cancel = True
            Case txtUserName.Text.Length > 15
                epUserName.SetError(txtUserName, "EL campo no puede contener más de 15 caracteres.")
                e.Cancel = True
            Case Else
                epUserName.SetError(txtUserName, String.Empty)
                e.Cancel = False
        End Select
    End Sub

    Private Sub txtNombreCompleto_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreCompleto.Validating
        Select Case True
            Case txtNombreCompleto.Text.IsNullOrEmpty
                epNombreCompleto.SetError(txtNombreCompleto, "El campo es obligatorio.")
                e.Cancel = True
            Case txtNombreCompleto.Text.Length > 60
                epNombreCompleto.SetError(txtNombreCompleto, "El campo no puede contener más de 60 caracteres.")
                e.Cancel = True
            Case Else
                epNombreCompleto.SetError(txtNombreCompleto, String.Empty)
                e.Cancel = False
        End Select
    End Sub

    Private Sub txtCorreo_Validating(sender As Object, e As CancelEventArgs) Handles txtCorreo.Validating
        Dim emailRegex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")

        Select Case True
            Case txtCorreo.Text.IsNullOrEmpty
                epCorreo.SetError(txtCorreo, "El campo es obligatorio.")
                e.Cancel = True
            Case Not emailRegex.IsMatch(txtCorreo.Text)
                epCorreo.SetError(txtCorreo, "Debe ingresar un correo electrónico válido.")
                e.Cancel = True
            Case txtCorreo.Text.Length > 60
                epCorreo.SetError(txtCorreo, "El campo no puede contener más de 60 caracteres.")
                e.Cancel = True
            Case Else
                epCorreo.SetError(txtCorreo, String.Empty)
                e.Cancel = False
        End Select
    End Sub

    Private Sub txtPassword_Validating(sender As Object, e As CancelEventArgs) Handles txtPassword.Validating

        Select Case True
            Case Not _esEdit And txtPassword.Text.IsNullOrEmpty
                epPassword.SetError(txtPassword, "El campo es obligatorio.")
                e.Cancel = True
            Case Not txtPassword.Text.IsNullOrEmpty And txtPassword.Text.Length > 0 And txtPassword.Text.Length < 8
                epPassword.SetError(txtPassword, "El passowrd debe contener al menos 8 caracteres.")
                e.Cancel = True
            Case Not txtPassword.Text.IsNullOrEmpty And txtPassword.Text.Length > 100
                epPassword.SetError(txtPassword, "El campo no debe contener más de 100 caracteres.")
                e.Cancel = True
            Case Else
                epPassword.SetError(txtPassword, String.Empty)
                e.Cancel = False
        End Select
    End Sub

    Private Sub txtConfirmarPassword_Validating(sender As Object, e As CancelEventArgs) Handles txtConfirmarPassword.Validating
        Select Case True
            Case Not String.Equals(txtConfirmarPassword.Text, txtPassword.Text)
                epConfirmarPassword.SetError(txtConfirmarPassword, "No hay coincidencia con el password proporcionado.")
                e.Cancel = True
            Case Else
                epConfirmarPassword.SetError(txtConfirmarPassword, String.Empty)
                e.Cancel = False
        End Select
    End Sub
End Class