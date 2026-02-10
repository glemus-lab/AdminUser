<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormularioUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblUserName = New Label()
        lblNombreCompleto = New Label()
        lblCorreo = New Label()
        lblPassword = New Label()
        txtUserName = New TextBox()
        txtNombreCompleto = New TextBox()
        txtCorreo = New TextBox()
        txtPassword = New TextBox()
        btnCancelar = New Button()
        btnGuardar = New Button()
        txtConfirmarPassword = New TextBox()
        lblConfirmarPassword = New Label()
        epCorreo = New ErrorProvider(components)
        epUserName = New ErrorProvider(components)
        epNombreCompleto = New ErrorProvider(components)
        epPassword = New ErrorProvider(components)
        epConfirmarPassword = New ErrorProvider(components)
        lblNotaPassword = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        CType(epCorreo, ComponentModel.ISupportInitialize).BeginInit()
        CType(epUserName, ComponentModel.ISupportInitialize).BeginInit()
        CType(epNombreCompleto, ComponentModel.ISupportInitialize).BeginInit()
        CType(epPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(epConfirmarPassword, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblUserName
        ' 
        lblUserName.Anchor = AnchorStyles.Right
        lblUserName.AutoSize = True
        lblUserName.Location = New Point(57, 7)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(63, 15)
        lblUserName.TabIndex = 0
        lblUserName.Text = "Username:"
        ' 
        ' lblNombreCompleto
        ' 
        lblNombreCompleto.Anchor = AnchorStyles.Right
        lblNombreCompleto.AutoSize = True
        lblNombreCompleto.Location = New Point(10, 36)
        lblNombreCompleto.Name = "lblNombreCompleto"
        lblNombreCompleto.Size = New Size(110, 15)
        lblNombreCompleto.TabIndex = 1
        lblNombreCompleto.Text = "Nombre Completo:"
        ' 
        ' lblCorreo
        ' 
        lblCorreo.Anchor = AnchorStyles.Right
        lblCorreo.AutoSize = True
        lblCorreo.Location = New Point(74, 65)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(46, 15)
        lblCorreo.TabIndex = 2
        lblCorreo.Text = "Correo:"
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.Right
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(60, 94)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(60, 15)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password:"
        ' 
        ' txtUserName
        ' 
        txtUserName.Anchor = AnchorStyles.Left
        txtUserName.BackColor = Color.White
        txtUserName.BorderStyle = BorderStyle.FixedSingle
        txtUserName.Location = New Point(126, 3)
        txtUserName.Margin = New Padding(3, 3, 20, 3)
        txtUserName.MaxLength = 20
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(223, 23)
        txtUserName.TabIndex = 0
        ' 
        ' txtNombreCompleto
        ' 
        txtNombreCompleto.BackColor = Color.White
        txtNombreCompleto.BorderStyle = BorderStyle.FixedSingle
        txtNombreCompleto.Location = New Point(126, 32)
        txtNombreCompleto.Margin = New Padding(3, 3, 20, 3)
        txtNombreCompleto.MaxLength = 100
        txtNombreCompleto.Name = "txtNombreCompleto"
        txtNombreCompleto.Size = New Size(223, 23)
        txtNombreCompleto.TabIndex = 1
        ' 
        ' txtCorreo
        ' 
        txtCorreo.BackColor = Color.White
        txtCorreo.BorderStyle = BorderStyle.FixedSingle
        txtCorreo.Location = New Point(126, 61)
        txtCorreo.Margin = New Padding(3, 3, 20, 3)
        txtCorreo.MaxLength = 100
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(223, 23)
        txtCorreo.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(126, 90)
        txtPassword.Margin = New Padding(3, 3, 20, 3)
        txtPassword.MaxLength = 100
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "."c
        txtPassword.Size = New Size(223, 23)
        txtPassword.TabIndex = 3
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnCancelar.CausesValidation = False
        btnCancelar.Location = New Point(125, 0)
        btnCancelar.Margin = New Padding(25, 0, 0, 0)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 30)
        btnCancelar.TabIndex = 8
        btnCancelar.Text = "&Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnGuardar.Location = New Point(0, 0)
        btnGuardar.Margin = New Padding(0, 0, 25, 0)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 31)
        btnGuardar.TabIndex = 5
        btnGuardar.Text = "&Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' txtConfirmarPassword
        ' 
        txtConfirmarPassword.BackColor = Color.White
        txtConfirmarPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmarPassword.Location = New Point(126, 119)
        txtConfirmarPassword.Margin = New Padding(3, 3, 20, 3)
        txtConfirmarPassword.MaxLength = 100
        txtConfirmarPassword.Name = "txtConfirmarPassword"
        txtConfirmarPassword.PasswordChar = "."c
        txtConfirmarPassword.Size = New Size(223, 23)
        txtConfirmarPassword.TabIndex = 4
        ' 
        ' lblConfirmarPassword
        ' 
        lblConfirmarPassword.Anchor = AnchorStyles.Right
        lblConfirmarPassword.AutoSize = True
        lblConfirmarPassword.Location = New Point(3, 123)
        lblConfirmarPassword.Name = "lblConfirmarPassword"
        lblConfirmarPassword.Size = New Size(117, 15)
        lblConfirmarPassword.TabIndex = 10
        lblConfirmarPassword.Text = "Confirmar Password:"
        ' 
        ' epCorreo
        ' 
        epCorreo.BlinkStyle = ErrorBlinkStyle.NeverBlink
        epCorreo.ContainerControl = Me
        ' 
        ' epUserName
        ' 
        epUserName.BlinkStyle = ErrorBlinkStyle.NeverBlink
        epUserName.ContainerControl = Me
        ' 
        ' epNombreCompleto
        ' 
        epNombreCompleto.BlinkStyle = ErrorBlinkStyle.NeverBlink
        epNombreCompleto.ContainerControl = Me
        ' 
        ' epPassword
        ' 
        epPassword.BlinkStyle = ErrorBlinkStyle.NeverBlink
        epPassword.ContainerControl = Me
        ' 
        ' epConfirmarPassword
        ' 
        epConfirmarPassword.BlinkStyle = ErrorBlinkStyle.NeverBlink
        epConfirmarPassword.ContainerControl = Me
        ' 
        ' lblNotaPassword
        ' 
        lblNotaPassword.Dock = DockStyle.Fill
        lblNotaPassword.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNotaPassword.ForeColor = SystemColors.ControlText
        lblNotaPassword.Location = New Point(126, 145)
        lblNotaPassword.Name = "lblNotaPassword"
        lblNotaPassword.RightToLeft = RightToLeft.No
        lblNotaPassword.Size = New Size(259, 30)
        lblNotaPassword.TabIndex = 11
        lblNotaPassword.Text = "Nota: Dejar el campo 'Password' en blanco si no se desea cambiar"
        lblNotaPassword.Visible = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(lblNotaPassword, 1, 5)
        TableLayoutPanel1.Controls.Add(lblUserName, 0, 0)
        TableLayoutPanel1.Controls.Add(lblNombreCompleto, 0, 1)
        TableLayoutPanel1.Controls.Add(txtConfirmarPassword, 1, 4)
        TableLayoutPanel1.Controls.Add(lblCorreo, 0, 2)
        TableLayoutPanel1.Controls.Add(lblConfirmarPassword, 0, 4)
        TableLayoutPanel1.Controls.Add(lblPassword, 0, 3)
        TableLayoutPanel1.Controls.Add(txtPassword, 1, 3)
        TableLayoutPanel1.Controls.Add(txtUserName, 1, 0)
        TableLayoutPanel1.Controls.Add(txtCorreo, 1, 2)
        TableLayoutPanel1.Controls.Add(txtNombreCompleto, 1, 1)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 0, 6)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 7
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(370, 211)
        TableLayoutPanel1.TabIndex = 13
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.None
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.SetColumnSpan(FlowLayoutPanel1, 2)
        FlowLayoutPanel1.Controls.Add(btnGuardar)
        FlowLayoutPanel1.Controls.Add(btnCancelar)
        FlowLayoutPanel1.Location = New Point(94, 178)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(200, 31)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' frmFormularioUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.White
        ClientSize = New Size(370, 211)
        Controls.Add(TableLayoutPanel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmFormularioUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agregar un usuario"
        CType(epCorreo, ComponentModel.ISupportInitialize).EndInit()
        CType(epUserName, ComponentModel.ISupportInitialize).EndInit()
        CType(epNombreCompleto, ComponentModel.ISupportInitialize).EndInit()
        CType(epPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(epConfirmarPassword, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUserName As Label
    Friend WithEvents lblNombreCompleto As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtConfirmarPassword As TextBox
    Friend WithEvents lblConfirmarPassword As Label
    Friend WithEvents epCorreo As ErrorProvider
    Friend WithEvents epUserName As ErrorProvider
    Friend WithEvents epNombreCompleto As ErrorProvider
    Friend WithEvents epPassword As ErrorProvider
    Friend WithEvents epConfirmarPassword As ErrorProvider
    Friend WithEvents lblNotaPassword As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
