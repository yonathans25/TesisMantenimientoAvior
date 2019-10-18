<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmgestionaviones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmgestionaviones))
        Me.cmbeliminar = New System.Windows.Forms.PictureBox
        Me.cmbmodificar = New System.Windows.Forms.PictureBox
        Me.cmbagregar = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.picboxretornar = New System.Windows.Forms.PictureBox
        Me.cmbmatricula = New System.Windows.Forms.ComboBox
        Me.txtfabricante = New System.Windows.Forms.TextBox
        Me.txtpais = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtsituacion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtmodelo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtserial = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbleliminar = New System.Windows.Forms.Label
        Me.lblagregar = New System.Windows.Forms.Label
        Me.lblmodificar = New System.Windows.Forms.Label
        Me.txtmatricula = New System.Windows.Forms.MaskedTextBox
        Me.cmbcompania = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        CType(Me.cmbeliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmodificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbagregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxretornar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbeliminar
        '
        Me.cmbeliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbeliminar.Image = CType(resources.GetObject("cmbeliminar.Image"), System.Drawing.Image)
        Me.cmbeliminar.Location = New System.Drawing.Point(276, 305)
        Me.cmbeliminar.Name = "cmbeliminar"
        Me.cmbeliminar.Size = New System.Drawing.Size(41, 41)
        Me.cmbeliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbeliminar.TabIndex = 275
        Me.cmbeliminar.TabStop = False
        '
        'cmbmodificar
        '
        Me.cmbmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbmodificar.Image = CType(resources.GetObject("cmbmodificar.Image"), System.Drawing.Image)
        Me.cmbmodificar.Location = New System.Drawing.Point(276, 293)
        Me.cmbmodificar.Name = "cmbmodificar"
        Me.cmbmodificar.Size = New System.Drawing.Size(53, 53)
        Me.cmbmodificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbmodificar.TabIndex = 274
        Me.cmbmodificar.TabStop = False
        '
        'cmbagregar
        '
        Me.cmbagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbagregar.Image = CType(resources.GetObject("cmbagregar.Image"), System.Drawing.Image)
        Me.cmbagregar.Location = New System.Drawing.Point(276, 293)
        Me.cmbagregar.Name = "cmbagregar"
        Me.cmbagregar.Size = New System.Drawing.Size(53, 53)
        Me.cmbagregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbagregar.TabIndex = 273
        Me.cmbagregar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(411, 295)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 272
        Me.PictureBox2.TabStop = False
        '
        'picboxretornar
        '
        Me.picboxretornar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxretornar.Image = CType(resources.GetObject("picboxretornar.Image"), System.Drawing.Image)
        Me.picboxretornar.Location = New System.Drawing.Point(23, 24)
        Me.picboxretornar.Name = "picboxretornar"
        Me.picboxretornar.Size = New System.Drawing.Size(53, 53)
        Me.picboxretornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxretornar.TabIndex = 271
        Me.picboxretornar.TabStop = False
        '
        'cmbmatricula
        '
        Me.cmbmatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmatricula.FormattingEnabled = True
        Me.cmbmatricula.Items.AddRange(New Object() {"USUARIO", "ADMINISTRADOR"})
        Me.cmbmatricula.Location = New System.Drawing.Point(138, 141)
        Me.cmbmatricula.MaxLength = 15
        Me.cmbmatricula.Name = "cmbmatricula"
        Me.cmbmatricula.Size = New System.Drawing.Size(93, 28)
        Me.cmbmatricula.TabIndex = 2
        '
        'txtfabricante
        '
        Me.txtfabricante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfabricante.Location = New System.Drawing.Point(138, 192)
        Me.txtfabricante.MaxLength = 18
        Me.txtfabricante.Name = "txtfabricante"
        Me.txtfabricante.Size = New System.Drawing.Size(121, 26)
        Me.txtfabricante.TabIndex = 4
        '
        'txtpais
        '
        Me.txtpais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpais.Location = New System.Drawing.Point(138, 289)
        Me.txtpais.MaxLength = 10
        Me.txtpais.Name = "txtpais"
        Me.txtpais.Size = New System.Drawing.Size(105, 26)
        Me.txtpais.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(75, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "País:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(332, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 269
        Me.Label7.Text = "Compañía:"
        '
        'txtsituacion
        '
        Me.txtsituacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsituacion.Location = New System.Drawing.Point(137, 236)
        Me.txtsituacion.MaxLength = 10
        Me.txtsituacion.Name = "txtsituacion"
        Me.txtsituacion.Size = New System.Drawing.Size(105, 26)
        Me.txtsituacion.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(42, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 268
        Me.Label6.Text = "Situación:"
        '
        'txtmodelo
        '
        Me.txtmodelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodelo.Location = New System.Drawing.Point(417, 188)
        Me.txtmodelo.MaxLength = 25
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(222, 26)
        Me.txtmodelo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(350, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 267
        Me.Label4.Text = "Modelo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(43, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 266
        Me.Label5.Text = "Matrícula:"
        '
        'txtserial
        '
        Me.txtserial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial.Location = New System.Drawing.Point(417, 135)
        Me.txtserial.MaxLength = 8
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(134, 26)
        Me.txtserial.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(350, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 265
        Me.Label3.Text = "Serial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 264
        Me.Label2.Text = "Fabricante:"
        '
        'lbleliminar
        '
        Me.lbleliminar.BackColor = System.Drawing.Color.DarkGray
        Me.lbleliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbleliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleliminar.ForeColor = System.Drawing.Color.White
        Me.lbleliminar.Location = New System.Drawing.Point(463, 60)
        Me.lbleliminar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lbleliminar.Name = "lbleliminar"
        Me.lbleliminar.Size = New System.Drawing.Size(170, 40)
        Me.lbleliminar.TabIndex = 263
        Me.lbleliminar.Text = "ELIMINAR"
        Me.lbleliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblagregar
        '
        Me.lblagregar.BackColor = System.Drawing.Color.DarkRed
        Me.lblagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblagregar.ForeColor = System.Drawing.Color.White
        Me.lblagregar.Location = New System.Drawing.Point(101, 60)
        Me.lblagregar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lblagregar.Name = "lblagregar"
        Me.lblagregar.Size = New System.Drawing.Size(170, 40)
        Me.lblagregar.TabIndex = 262
        Me.lblagregar.Text = "AGREGAR"
        Me.lblagregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmodificar
        '
        Me.lblmodificar.BackColor = System.Drawing.Color.DarkGray
        Me.lblmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodificar.ForeColor = System.Drawing.Color.White
        Me.lblmodificar.Location = New System.Drawing.Point(277, 60)
        Me.lblmodificar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lblmodificar.Name = "lblmodificar"
        Me.lblmodificar.Size = New System.Drawing.Size(170, 40)
        Me.lblmodificar.TabIndex = 261
        Me.lblmodificar.Text = "MODIFICAR"
        Me.lblmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtmatricula
        '
        Me.txtmatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmatricula.Location = New System.Drawing.Point(138, 143)
        Me.txtmatricula.Mask = "?? 0000"
        Me.txtmatricula.Name = "txtmatricula"
        Me.txtmatricula.Size = New System.Drawing.Size(83, 26)
        Me.txtmatricula.TabIndex = 1
        '
        'cmbcompania
        '
        Me.cmbcompania.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcompania.Location = New System.Drawing.Point(420, 242)
        Me.cmbcompania.MaxLength = 50
        Me.cmbcompania.Name = "cmbcompania"
        Me.cmbcompania.Size = New System.Drawing.Size(143, 26)
        Me.cmbcompania.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(519, 351)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 276
        Me.Label12.Text = "J-30209784-3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(272, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 277
        Me.Label9.Text = "Aviones"
        '
        'Frmgestionaviones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(651, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbcompania)
        Me.Controls.Add(Me.txtmatricula)
        Me.Controls.Add(Me.cmbeliminar)
        Me.Controls.Add(Me.cmbmodificar)
        Me.Controls.Add(Me.cmbagregar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picboxretornar)
        Me.Controls.Add(Me.cmbmatricula)
        Me.Controls.Add(Me.txtfabricante)
        Me.Controls.Add(Me.txtpais)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsituacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtmodelo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtserial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbleliminar)
        Me.Controls.Add(Me.lblagregar)
        Me.Controls.Add(Me.lblmodificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmgestionaviones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmgestionaviones"
        CType(Me.cmbeliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmodificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbagregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxretornar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbeliminar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbmodificar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbagregar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picboxretornar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbmatricula As System.Windows.Forms.ComboBox
    Friend WithEvents txtfabricante As System.Windows.Forms.TextBox
    Friend WithEvents txtpais As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsituacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtmodelo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtserial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbleliminar As System.Windows.Forms.Label
    Friend WithEvents lblagregar As System.Windows.Forms.Label
    Friend WithEvents lblmodificar As System.Windows.Forms.Label
    Friend WithEvents txtmatricula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbcompania As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
