<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogOut = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btnGraficas = New FontAwesome.Sharp.IconButton()
        Me.btnRegistro = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.rol = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.btnGraficas)
        Me.Panel1.Controls.Add(Me.btnRegistro)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 798)
        Me.Panel1.TabIndex = 1
        '
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnLogOut.IconColor = System.Drawing.Color.Black
        Me.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogOut.IconSize = 40
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(12, 717)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(30, 2, 0, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(194, 49)
        Me.btnLogOut.TabIndex = 15
        Me.btnLogOut.Text = "Salir"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(12, 440)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(16, 2, 26, 0)
        Me.IconButton1.Size = New System.Drawing.Size(194, 49)
        Me.IconButton1.TabIndex = 14
        Me.IconButton1.Text = "Graficas"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'btnGraficas
        '
        Me.btnGraficas.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficas.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnGraficas.IconColor = System.Drawing.Color.Black
        Me.btnGraficas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGraficas.IconSize = 40
        Me.btnGraficas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGraficas.Location = New System.Drawing.Point(12, 351)
        Me.btnGraficas.Name = "btnGraficas"
        Me.btnGraficas.Padding = New System.Windows.Forms.Padding(16, 2, 26, 0)
        Me.btnGraficas.Size = New System.Drawing.Size(194, 49)
        Me.btnGraficas.TabIndex = 13
        Me.btnGraficas.Text = "Graficas"
        Me.btnGraficas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGraficas.UseVisualStyleBackColor = True
        '
        'btnRegistro
        '
        Me.btnRegistro.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.IconChar = FontAwesome.Sharp.IconChar.CloudUploadAlt
        Me.btnRegistro.IconColor = System.Drawing.Color.Black
        Me.btnRegistro.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistro.IconSize = 40
        Me.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistro.Location = New System.Drawing.Point(12, 263)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Padding = New System.Windows.Forms.Padding(16, 2, 26, 0)
        Me.btnRegistro.Size = New System.Drawing.Size(194, 49)
        Me.btnRegistro.TabIndex = 12
        Me.btnRegistro.Text = "Registro"
        Me.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_de_Registro.My.Resources.Resources.logoSinFondo1
        Me.PictureBox1.Location = New System.Drawing.Point(18, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.userName, Me.ToolStripStatusLabel3, Me.rol})
        Me.StatusStrip1.Location = New System.Drawing.Point(219, 766)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1329, 32)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(76, 25)
        Me.ToolStripStatusLabel1.Text = "Usuario:"
        '
        'userName
        '
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(180, 25)
        Me.userName.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(73, 25)
        Me.ToolStripStatusLabel3.Text = "   -  Rol:"
        '
        'rol
        '
        Me.rol.Name = "rol"
        Me.rol.Size = New System.Drawing.Size(180, 25)
        Me.rol.Text = "ToolStripStatusLabel4"
        '
        'IconButton2
        '
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 40
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(12, 528)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(16, 2, 26, 0)
        Me.IconButton2.Size = New System.Drawing.Size(194, 49)
        Me.IconButton2.TabIndex = 16
        Me.IconButton2.Text = "Graficas"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(219, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1329, 766)
        Me.Panel2.TabIndex = 3
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1548, 798)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents userName As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents rol As ToolStripStatusLabel
    Friend WithEvents btnRegistro As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGraficas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogOut As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
End Class
