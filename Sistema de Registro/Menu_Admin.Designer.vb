<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Admin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btnLogOut = New FontAwesome.Sharp.IconButton()
        Me.btnRegistro = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.rol = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnRegistro)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 822)
        Me.Panel1.TabIndex = 0
        '
        'IconButton2
        '
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 40
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(12, 418)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(5, 2, 5, 0)
        Me.IconButton2.Size = New System.Drawing.Size(194, 49)
        Me.IconButton2.TabIndex = 18
        Me.IconButton2.Text = "Datos"
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.UserGear
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(12, 330)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(5, 2, 5, 0)
        Me.IconButton1.Size = New System.Drawing.Size(194, 49)
        Me.IconButton1.TabIndex = 17
        Me.IconButton1.Text = "Conf. Usuario"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnLogOut.IconColor = System.Drawing.Color.Black
        Me.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogOut.IconSize = 40
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(12, 761)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(30, 2, 0, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(194, 49)
        Me.btnLogOut.TabIndex = 16
        Me.btnLogOut.Text = "Salir"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnRegistro
        '
        Me.btnRegistro.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistro.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btnRegistro.IconColor = System.Drawing.Color.Black
        Me.btnRegistro.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistro.IconSize = 40
        Me.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistro.Location = New System.Drawing.Point(12, 252)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Padding = New System.Windows.Forms.Padding(5, 2, 5, 0)
        Me.btnRegistro.Size = New System.Drawing.Size(194, 49)
        Me.btnRegistro.TabIndex = 13
        Me.btnRegistro.Text = "Crear Usuario"
        Me.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_de_Registro.My.Resources.Resources.logoSinFondo1
        Me.PictureBox1.Location = New System.Drawing.Point(26, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(220, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1037, 822)
        Me.Panel2.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.userName, Me.ToolStripStatusLabel3, Me.rol})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 790)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1037, 32)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(81, 25)
        Me.ToolStripStatusLabel1.Text = "Usuario: "
        '
        'userName
        '
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(92, 25)
        Me.userName.Text = "userName"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(78, 25)
        Me.ToolStripStatusLabel3.Text = "   -   Rol:"
        '
        'rol
        '
        Me.rol.Name = "rol"
        Me.rol.Size = New System.Drawing.Size(33, 25)
        Me.rol.Text = "rol"
        '
        'Menu_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1257, 822)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Admin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents userName As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents rol As ToolStripStatusLabel
    Friend WithEvents btnRegistro As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogOut As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
