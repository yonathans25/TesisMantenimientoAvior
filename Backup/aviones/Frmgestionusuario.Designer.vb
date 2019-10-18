<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmgestionusuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmgestionusuario))
        Me.lblagregar = New System.Windows.Forms.Label
        Me.lblmodificar = New System.Windows.Forms.Label
        Me.lbleliminar = New System.Windows.Forms.Label
        Me.cmbtipo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtcontrasena1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtcontrasena = New System.Windows.Forms.TextBox
        Me.Txtusuario = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtlicencia = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtcedula = New System.Windows.Forms.TextBox
        Me.cmbusuario = New System.Windows.Forms.ComboBox
        Me.picboxretornar = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.cmbagregar = New System.Windows.Forms.PictureBox
        Me.cmbmodificar = New System.Windows.Forms.PictureBox
        Me.cmbeliminar = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        CType(Me.picboxretornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbagregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmodificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbeliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblagregar
        '
        Me.lblagregar.BackColor = System.Drawing.Color.DarkRed
        Me.lblagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblagregar.ForeColor = System.Drawing.Color.White
        Me.lblagregar.Location = New System.Drawing.Point(97, 53)
        Me.lblagregar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lblagregar.Name = "lblagregar"
        Me.lblagregar.Size = New System.Drawing.Size(170, 40)
        Me.lblagregar.TabIndex = 225
        Me.lblagregar.Text = "AGREGAR"
        Me.lblagregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmodificar
        '
        Me.lblmodificar.BackColor = System.Drawing.Color.DarkGray
        Me.lblmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodificar.ForeColor = System.Drawing.Color.White
        Me.lblmodificar.Location = New System.Drawing.Point(273, 53)
        Me.lblmodificar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lblmodificar.Name = "lblmodificar"
        Me.lblmodificar.Size = New System.Drawing.Size(170, 40)
        Me.lblmodificar.TabIndex = 224
        Me.lblmodificar.Text = "MODIFICAR"
        Me.lblmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbleliminar
        '
        Me.lbleliminar.BackColor = System.Drawing.Color.DarkGray
        Me.lbleliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbleliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleliminar.ForeColor = System.Drawing.Color.White
        Me.lbleliminar.Location = New System.Drawing.Point(459, 53)
        Me.lbleliminar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lbleliminar.Name = "lbleliminar"
        Me.lbleliminar.Size = New System.Drawing.Size(170, 40)
        Me.lbleliminar.TabIndex = 227
        Me.lbleliminar.Text = "ELIMINAR"
        Me.lbleliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbtipo
        '
        Me.cmbtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"USUARIO", "ADMINISTRADOR"})
        Me.cmbtipo.Location = New System.Drawing.Point(436, 184)
        Me.cmbtipo.MaxLength = 15
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(132, 28)
        Me.cmbtipo.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(377, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 239
        Me.Label7.Text = "Tipo:"
        '
        'txtcontrasena1
        '
        Me.txtcontrasena1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrasena1.Location = New System.Drawing.Point(436, 240)
        Me.txtcontrasena1.MaxLength = 20
        Me.txtcontrasena1.Name = "txtcontrasena1"
        Me.txtcontrasena1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontrasena1.Size = New System.Drawing.Size(143, 26)
        Me.txtcontrasena1.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(330, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 238
        Me.Label6.Text = "Verificar"
        '
        'txtcontrasena
        '
        Me.txtcontrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrasena.Location = New System.Drawing.Point(135, 240)
        Me.txtcontrasena.MaxLength = 20
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontrasena.Size = New System.Drawing.Size(143, 26)
        Me.txtcontrasena.TabIndex = 15
        '
        'Txtusuario
        '
        Me.Txtusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtusuario.Location = New System.Drawing.Point(135, 136)
        Me.Txtusuario.MaxLength = 15
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(143, 26)
        Me.Txtusuario.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(33, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 237
        Me.Label4.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(63, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 236
        Me.Label5.Text = "Usuario:"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(436, 136)
        Me.txtnombre.MaxLength = 25
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(179, 26)
        Me.txtnombre.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(354, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 235
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(63, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 234
        Me.Label2.Text = "Cédula:"
        '
        'txtlicencia
        '
        Me.txtlicencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlicencia.Location = New System.Drawing.Point(135, 293)
        Me.txtlicencia.MaxLength = 8
        Me.txtlicencia.Name = "txtlicencia"
        Me.txtlicencia.Size = New System.Drawing.Size(117, 26)
        Me.txtlicencia.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(54, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "Licencia:"
        '
        'txtcedula
        '
        Me.txtcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedula.Location = New System.Drawing.Point(135, 184)
        Me.txtcedula.MaxLength = 9
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(117, 26)
        Me.txtcedula.TabIndex = 13
        '
        'cmbusuario
        '
        Me.cmbusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbusuario.FormattingEnabled = True
        Me.cmbusuario.Items.AddRange(New Object() {"USUARIO", "ADMINISTRADOR"})
        Me.cmbusuario.Location = New System.Drawing.Point(135, 136)
        Me.cmbusuario.MaxLength = 15
        Me.cmbusuario.Name = "cmbusuario"
        Me.cmbusuario.Size = New System.Drawing.Size(144, 28)
        Me.cmbusuario.TabIndex = 10
        '
        'picboxretornar
        '
        Me.picboxretornar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxretornar.Image = CType(resources.GetObject("picboxretornar.Image"), System.Drawing.Image)
        Me.picboxretornar.Location = New System.Drawing.Point(21, 12)
        Me.picboxretornar.Name = "picboxretornar"
        Me.picboxretornar.Size = New System.Drawing.Size(53, 53)
        Me.picboxretornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxretornar.TabIndex = 247
        Me.picboxretornar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(410, 293)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 248
        Me.PictureBox2.TabStop = False
        '
        'cmbagregar
        '
        Me.cmbagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbagregar.Image = CType(resources.GetObject("cmbagregar.Image"), System.Drawing.Image)
        Me.cmbagregar.Location = New System.Drawing.Point(287, 299)
        Me.cmbagregar.Name = "cmbagregar"
        Me.cmbagregar.Size = New System.Drawing.Size(53, 53)
        Me.cmbagregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbagregar.TabIndex = 249
        Me.cmbagregar.TabStop = False
        '
        'cmbmodificar
        '
        Me.cmbmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbmodificar.Image = CType(resources.GetObject("cmbmodificar.Image"), System.Drawing.Image)
        Me.cmbmodificar.Location = New System.Drawing.Point(288, 299)
        Me.cmbmodificar.Name = "cmbmodificar"
        Me.cmbmodificar.Size = New System.Drawing.Size(53, 53)
        Me.cmbmodificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbmodificar.TabIndex = 250
        Me.cmbmodificar.TabStop = False
        '
        'cmbeliminar
        '
        Me.cmbeliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbeliminar.Image = CType(resources.GetObject("cmbeliminar.Image"), System.Drawing.Image)
        Me.cmbeliminar.Location = New System.Drawing.Point(288, 311)
        Me.cmbeliminar.Name = "cmbeliminar"
        Me.cmbeliminar.Size = New System.Drawing.Size(41, 41)
        Me.cmbeliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbeliminar.TabIndex = 251
        Me.cmbeliminar.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(330, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 252
        Me.Label8.Text = "Contraseña:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(518, 349)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 253
        Me.Label12.Text = "J-30209784-3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(284, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 254
        Me.Label9.Text = "Usuarios"
        '
        'Frmgestionusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(635, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbeliminar)
        Me.Controls.Add(Me.cmbmodificar)
        Me.Controls.Add(Me.cmbagregar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picboxretornar)
        Me.Controls.Add(Me.cmbusuario)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.txtlicencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcontrasena1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcontrasena)
        Me.Controls.Add(Me.Txtusuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbleliminar)
        Me.Controls.Add(Me.lblagregar)
        Me.Controls.Add(Me.lblmodificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmgestionusuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmgestionusuario"
        CType(Me.picboxretornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbagregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmodificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbeliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblagregar As System.Windows.Forms.Label
    Friend WithEvents lblmodificar As System.Windows.Forms.Label
    Friend WithEvents lbleliminar As System.Windows.Forms.Label
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcontrasena1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcontrasena As System.Windows.Forms.TextBox
    Friend WithEvents Txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtlicencia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
    Friend WithEvents picboxretornar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbagregar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbmodificar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbeliminar As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
