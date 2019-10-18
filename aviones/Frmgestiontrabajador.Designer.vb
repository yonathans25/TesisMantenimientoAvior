<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmgestiontrabajador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmgestiontrabajador))
        Me.picboxretornar = New System.Windows.Forms.PictureBox
        Me.cmblicencia = New System.Windows.Forms.ComboBox
        Me.txtcedula = New System.Windows.Forms.TextBox
        Me.cmbcargo = New System.Windows.Forms.ComboBox
        Me.lbldeparta = New System.Windows.Forms.Label
        Me.txttelefono = New System.Windows.Forms.TextBox
        Me.lbltelefono = New System.Windows.Forms.Label
        Me.txtdepartamento = New System.Windows.Forms.TextBox
        Me.Txtlicencia = New System.Windows.Forms.TextBox
        Me.lblcargo = New System.Windows.Forms.Label
        Me.lbllicencia = New System.Windows.Forms.Label
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.lblnombre = New System.Windows.Forms.Label
        Me.lblcedula = New System.Windows.Forms.Label
        Me.lbleliminar = New System.Windows.Forms.Label
        Me.lblagregar = New System.Windows.Forms.Label
        Me.lblmodificar = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.cmbagregar = New System.Windows.Forms.PictureBox
        Me.cmbmodificar = New System.Windows.Forms.PictureBox
        Me.cmbeliminar = New System.Windows.Forms.PictureBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        CType(Me.picboxretornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbagregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmodificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbeliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picboxretornar
        '
        Me.picboxretornar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxretornar.Image = CType(resources.GetObject("picboxretornar.Image"), System.Drawing.Image)
        Me.picboxretornar.Location = New System.Drawing.Point(16, 11)
        Me.picboxretornar.Name = "picboxretornar"
        Me.picboxretornar.Size = New System.Drawing.Size(53, 53)
        Me.picboxretornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxretornar.TabIndex = 269
        Me.picboxretornar.TabStop = False
        '
        'cmblicencia
        '
        Me.cmblicencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblicencia.FormattingEnabled = True
        Me.cmblicencia.Items.AddRange(New Object() {"USUARIO", "ADMINISTRADOR"})
        Me.cmblicencia.Location = New System.Drawing.Point(136, 126)
        Me.cmblicencia.MaxLength = 8
        Me.cmblicencia.Name = "cmblicencia"
        Me.cmblicencia.Size = New System.Drawing.Size(106, 28)
        Me.cmblicencia.TabIndex = 10
        '
        'txtcedula
        '
        Me.txtcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedula.Location = New System.Drawing.Point(135, 173)
        Me.txtcedula.MaxLength = 9
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(107, 26)
        Me.txtcedula.TabIndex = 13
        '
        'cmbcargo
        '
        Me.cmbcargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcargo.FormattingEnabled = True
        Me.cmbcargo.Items.AddRange(New Object() {"USUARIO", "ADMINISTRADOR"})
        Me.cmbcargo.Location = New System.Drawing.Point(472, 165)
        Me.cmbcargo.MaxLength = 15
        Me.cmbcargo.Name = "cmbcargo"
        Me.cmbcargo.Size = New System.Drawing.Size(137, 28)
        Me.cmbcargo.TabIndex = 14
        '
        'lbldeparta
        '
        Me.lbldeparta.AutoSize = True
        Me.lbldeparta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldeparta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbldeparta.Location = New System.Drawing.Point(348, 219)
        Me.lbldeparta.Name = "lbldeparta"
        Me.lbldeparta.Size = New System.Drawing.Size(110, 16)
        Me.lbldeparta.TabIndex = 261
        Me.lbldeparta.Text = "Departamento:"
        '
        'txttelefono
        '
        Me.txttelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(135, 219)
        Me.txttelefono.MaxLength = 11
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(125, 26)
        Me.txttelefono.TabIndex = 15
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltelefono.Location = New System.Drawing.Point(46, 225)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(74, 16)
        Me.lbltelefono.TabIndex = 260
        Me.lbltelefono.Text = "Teléfono:"
        '
        'txtdepartamento
        '
        Me.txtdepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepartamento.Location = New System.Drawing.Point(472, 211)
        Me.txtdepartamento.MaxLength = 15
        Me.txtdepartamento.Name = "txtdepartamento"
        Me.txtdepartamento.Size = New System.Drawing.Size(154, 26)
        Me.txtdepartamento.TabIndex = 16
        '
        'Txtlicencia
        '
        Me.Txtlicencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtlicencia.Location = New System.Drawing.Point(137, 128)
        Me.Txtlicencia.MaxLength = 8
        Me.Txtlicencia.Name = "Txtlicencia"
        Me.Txtlicencia.Size = New System.Drawing.Size(106, 26)
        Me.Txtlicencia.TabIndex = 11
        '
        'lblcargo
        '
        Me.lblcargo.AutoSize = True
        Me.lblcargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcargo.Location = New System.Drawing.Point(404, 177)
        Me.lblcargo.Name = "lblcargo"
        Me.lblcargo.Size = New System.Drawing.Size(54, 16)
        Me.lblcargo.TabIndex = 259
        Me.lblcargo.Text = "Cargo:"
        '
        'lbllicencia
        '
        Me.lbllicencia.AutoSize = True
        Me.lbllicencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllicencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbllicencia.Location = New System.Drawing.Point(50, 138)
        Me.lbllicencia.Name = "lbllicencia"
        Me.lbllicencia.Size = New System.Drawing.Size(70, 16)
        Me.lbllicencia.TabIndex = 258
        Me.lbllicencia.Text = "Licencia:"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(472, 121)
        Me.txtnombre.MaxLength = 25
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(179, 26)
        Me.txtnombre.TabIndex = 12
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblnombre.Location = New System.Drawing.Point(318, 132)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(140, 16)
        Me.lblnombre.TabIndex = 257
        Me.lblnombre.Text = "Nombre y apellido:"
        '
        'lblcedula
        '
        Me.lblcedula.AutoSize = True
        Me.lblcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcedula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcedula.Location = New System.Drawing.Point(59, 183)
        Me.lblcedula.Name = "lblcedula"
        Me.lblcedula.Size = New System.Drawing.Size(61, 16)
        Me.lblcedula.TabIndex = 256
        Me.lblcedula.Text = "Cédula:"
        '
        'lbleliminar
        '
        Me.lbleliminar.BackColor = System.Drawing.Color.DarkGray
        Me.lbleliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbleliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleliminar.ForeColor = System.Drawing.Color.White
        Me.lbleliminar.Location = New System.Drawing.Point(456, 53)
        Me.lbleliminar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lbleliminar.Name = "lbleliminar"
        Me.lbleliminar.Size = New System.Drawing.Size(170, 40)
        Me.lbleliminar.TabIndex = 250
        Me.lbleliminar.Text = "ELIMINAR"
        Me.lbleliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblagregar
        '
        Me.lblagregar.BackColor = System.Drawing.Color.DarkRed
        Me.lblagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblagregar.ForeColor = System.Drawing.Color.White
        Me.lblagregar.Location = New System.Drawing.Point(94, 53)
        Me.lblagregar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lblagregar.Name = "lblagregar"
        Me.lblagregar.Size = New System.Drawing.Size(170, 40)
        Me.lblagregar.TabIndex = 249
        Me.lblagregar.Text = "AGREGAR"
        Me.lblagregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmodificar
        '
        Me.lblmodificar.BackColor = System.Drawing.Color.DarkGray
        Me.lblmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodificar.ForeColor = System.Drawing.Color.White
        Me.lblmodificar.Location = New System.Drawing.Point(270, 53)
        Me.lblmodificar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lblmodificar.Name = "lblmodificar"
        Me.lblmodificar.Size = New System.Drawing.Size(170, 40)
        Me.lblmodificar.TabIndex = 248
        Me.lblmodificar.Text = "MODIFICAR"
        Me.lblmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(458, 263)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 270
        Me.PictureBox2.TabStop = False
        '
        'cmbagregar
        '
        Me.cmbagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbagregar.Image = CType(resources.GetObject("cmbagregar.Image"), System.Drawing.Image)
        Me.cmbagregar.Location = New System.Drawing.Point(249, 263)
        Me.cmbagregar.Name = "cmbagregar"
        Me.cmbagregar.Size = New System.Drawing.Size(53, 53)
        Me.cmbagregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbagregar.TabIndex = 271
        Me.cmbagregar.TabStop = False
        '
        'cmbmodificar
        '
        Me.cmbmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbmodificar.Image = CType(resources.GetObject("cmbmodificar.Image"), System.Drawing.Image)
        Me.cmbmodificar.Location = New System.Drawing.Point(249, 263)
        Me.cmbmodificar.Name = "cmbmodificar"
        Me.cmbmodificar.Size = New System.Drawing.Size(53, 53)
        Me.cmbmodificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbmodificar.TabIndex = 272
        Me.cmbmodificar.TabStop = False
        '
        'cmbeliminar
        '
        Me.cmbeliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbeliminar.Image = CType(resources.GetObject("cmbeliminar.Image"), System.Drawing.Image)
        Me.cmbeliminar.Location = New System.Drawing.Point(249, 274)
        Me.cmbeliminar.Name = "cmbeliminar"
        Me.cmbeliminar.Size = New System.Drawing.Size(41, 42)
        Me.cmbeliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbeliminar.TabIndex = 273
        Me.cmbeliminar.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(569, 319)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 274
        Me.Label12.Text = "J-30209784-3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(282, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 275
        Me.Label9.Text = "Trabajadores"
        '
        'Frmgestiontrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(668, 355)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbeliminar)
        Me.Controls.Add(Me.cmbmodificar)
        Me.Controls.Add(Me.cmbagregar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picboxretornar)
        Me.Controls.Add(Me.cmblicencia)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.cmbcargo)
        Me.Controls.Add(Me.lbldeparta)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.lbltelefono)
        Me.Controls.Add(Me.txtdepartamento)
        Me.Controls.Add(Me.Txtlicencia)
        Me.Controls.Add(Me.lblcargo)
        Me.Controls.Add(Me.lbllicencia)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblcedula)
        Me.Controls.Add(Me.lbleliminar)
        Me.Controls.Add(Me.lblagregar)
        Me.Controls.Add(Me.lblmodificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmgestiontrabajador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmgestiontrabajador"
        CType(Me.picboxretornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbagregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmodificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbeliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picboxretornar As System.Windows.Forms.PictureBox
    Friend WithEvents cmblicencia As System.Windows.Forms.ComboBox
    Friend WithEvents txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents cmbcargo As System.Windows.Forms.ComboBox
    Friend WithEvents lbldeparta As System.Windows.Forms.Label
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents lbltelefono As System.Windows.Forms.Label
    Friend WithEvents txtdepartamento As System.Windows.Forms.TextBox
    Friend WithEvents Txtlicencia As System.Windows.Forms.TextBox
    Friend WithEvents lblcargo As System.Windows.Forms.Label
    Friend WithEvents lbllicencia As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblcedula As System.Windows.Forms.Label
    Friend WithEvents lbleliminar As System.Windows.Forms.Label
    Friend WithEvents lblagregar As System.Windows.Forms.Label
    Friend WithEvents lblmodificar As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbagregar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbmodificar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbeliminar As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
