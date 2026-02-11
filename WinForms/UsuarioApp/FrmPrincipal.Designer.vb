<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        btnAgregarUsuario = New Button()
        btnEditarUsuario = New Button()
        btnEliminarUsuario = New Button()
        pnlBotones = New Panel()
        dgvListaUsuarios = New DataGridView()
        Panel1 = New Panel()
        pnlBotones.SuspendLayout()
        CType(dgvListaUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAgregarUsuario
        ' 
        btnAgregarUsuario.Anchor = AnchorStyles.None
        btnAgregarUsuario.Location = New Point(60, 11)
        btnAgregarUsuario.Name = "btnAgregarUsuario"
        btnAgregarUsuario.Size = New Size(108, 39)
        btnAgregarUsuario.TabIndex = 0
        btnAgregarUsuario.Text = "Agregar Usuario"
        btnAgregarUsuario.UseVisualStyleBackColor = True
        ' 
        ' btnEditarUsuario
        ' 
        btnEditarUsuario.Anchor = AnchorStyles.None
        btnEditarUsuario.Location = New Point(230, 11)
        btnEditarUsuario.Name = "btnEditarUsuario"
        btnEditarUsuario.Size = New Size(108, 39)
        btnEditarUsuario.TabIndex = 1
        btnEditarUsuario.Text = "Editar Usuario"
        btnEditarUsuario.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarUsuario
        ' 
        btnEliminarUsuario.Anchor = AnchorStyles.None
        btnEliminarUsuario.Location = New Point(400, 11)
        btnEliminarUsuario.Name = "btnEliminarUsuario"
        btnEliminarUsuario.Size = New Size(108, 39)
        btnEliminarUsuario.TabIndex = 2
        btnEliminarUsuario.Text = "Eliminar Usuario"
        btnEliminarUsuario.UseVisualStyleBackColor = True
        ' 
        ' pnlBotones
        ' 
        pnlBotones.Controls.Add(btnEliminarUsuario)
        pnlBotones.Controls.Add(btnAgregarUsuario)
        pnlBotones.Controls.Add(btnEditarUsuario)
        pnlBotones.Dock = DockStyle.Bottom
        pnlBotones.Location = New Point(0, 292)
        pnlBotones.Name = "pnlBotones"
        pnlBotones.Size = New Size(568, 60)
        pnlBotones.TabIndex = 4
        ' 
        ' dgvListaUsuarios
        ' 
        dgvListaUsuarios.AllowUserToAddRows = False
        dgvListaUsuarios.AllowUserToDeleteRows = False
        dgvListaUsuarios.AllowUserToResizeRows = False
        dgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListaUsuarios.BackgroundColor = Color.Silver
        dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListaUsuarios.Dock = DockStyle.Fill
        dgvListaUsuarios.Location = New Point(0, 0)
        dgvListaUsuarios.Name = "dgvListaUsuarios"
        dgvListaUsuarios.ReadOnly = True
        dgvListaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListaUsuarios.Size = New Size(568, 292)
        dgvListaUsuarios.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(dgvListaUsuarios)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(568, 292)
        Panel1.TabIndex = 5
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(568, 352)
        Controls.Add(Panel1)
        Controls.Add(pnlBotones)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimizeBox = False
        Name = "frmPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Administrador de usuario"
        pnlBotones.ResumeLayout(False)
        CType(dgvListaUsuarios, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents btnEditarUsuario As Button
    Friend WithEvents btnEliminarUsuario As Button
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents dgvListaUsuarios As DataGridView
    Friend WithEvents Panel1 As Panel

End Class
