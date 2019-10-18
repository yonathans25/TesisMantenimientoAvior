<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmconsultar
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmconsultar))
        Me.cmbfecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblmatricula = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cmbmatricula = New System.Windows.Forms.ComboBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.lblfabricante = New System.Windows.Forms.Label
        Me.lblmodificar = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.picboxretornar = New System.Windows.Forms.PictureBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblconsultar = New System.Windows.Forms.Label
        Me.lblnumero = New System.Windows.Forms.Label
        Me.lblmantenimiento = New System.Windows.Forms.Label
        Me.txtnunmant1 = New System.Windows.Forms.TextBox
        Me.cmbconsultar = New System.Windows.Forms.PictureBox
        Me.cmbmodificar = New System.Windows.Forms.PictureBox
        Me.cmbeliminar = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxretornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbconsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmodificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbeliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbfecha
        '
        Me.cmbfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbfecha.Location = New System.Drawing.Point(90, 121)
        Me.cmbfecha.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.cmbfecha.Name = "cmbfecha"
        Me.cmbfecha.Size = New System.Drawing.Size(220, 26)
        Me.cmbfecha.TabIndex = 1
        Me.cmbfecha.Value = New Date(2015, 2, 19, 13, 45, 43, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Fecha:"
        '
        'lblmatricula
        '
        Me.lblmatricula.AutoSize = True
        Me.lblmatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatricula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmatricula.Location = New System.Drawing.Point(338, 125)
        Me.lblmatricula.Name = "lblmatricula"
        Me.lblmatricula.Size = New System.Drawing.Size(118, 16)
        Me.lblmatricula.TabIndex = 113
        Me.lblmatricula.Text = "Matrícula Avión:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(674, 157)
        Me.DataGridView1.TabIndex = 115
        '
        'cmbmatricula
        '
        Me.cmbmatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmatricula.FormattingEnabled = True
        Me.cmbmatricula.Items.AddRange(New Object() {"USUARIO", "ADMINISTRADOR"})
        Me.cmbmatricula.Location = New System.Drawing.Point(462, 119)
        Me.cmbmatricula.MaxLength = 6
        Me.cmbmatricula.Name = "cmbmatricula"
        Me.cmbmatricula.Size = New System.Drawing.Size(89, 28)
        Me.cmbmatricula.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(462, 170)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(77, 26)
        Me.txtnombre.TabIndex = 3
        '
        'lblfabricante
        '
        Me.lblfabricante.AutoSize = True
        Me.lblfabricante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfabricante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblfabricante.Location = New System.Drawing.Point(370, 174)
        Me.lblfabricante.Name = "lblfabricante"
        Me.lblfabricante.Size = New System.Drawing.Size(86, 16)
        Me.lblfabricante.TabIndex = 120
        Me.lblfabricante.Text = "Fabricante:"
        '
        'lblmodificar
        '
        Me.lblmodificar.BackColor = System.Drawing.Color.DarkGray
        Me.lblmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodificar.ForeColor = System.Drawing.Color.White
        Me.lblmodificar.Location = New System.Drawing.Point(283, 56)
        Me.lblmodificar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lblmodificar.Name = "lblmodificar"
        Me.lblmodificar.Size = New System.Drawing.Size(180, 40)
        Me.lblmodificar.TabIndex = 125
        Me.lblmodificar.Text = "MODIFICAR / ELIMINAR"
        Me.lblmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(596, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 213
        Me.Label12.Text = "J-30209784-3"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(490, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(199, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 212
        Me.PictureBox2.TabStop = False
        '
        'picboxretornar
        '
        Me.picboxretornar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxretornar.Image = CType(resources.GetObject("picboxretornar.Image"), System.Drawing.Image)
        Me.picboxretornar.Location = New System.Drawing.Point(30, 12)
        Me.picboxretornar.Name = "picboxretornar"
        Me.picboxretornar.Size = New System.Drawing.Size(53, 53)
        Me.picboxretornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxretornar.TabIndex = 221
        Me.picboxretornar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picboxretornar, "Regresar")
        '
        'lblconsultar
        '
        Me.lblconsultar.BackColor = System.Drawing.Color.DarkRed
        Me.lblconsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblconsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconsultar.ForeColor = System.Drawing.Color.White
        Me.lblconsultar.Location = New System.Drawing.Point(107, 56)
        Me.lblconsultar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lblconsultar.Name = "lblconsultar"
        Me.lblconsultar.Size = New System.Drawing.Size(170, 40)
        Me.lblconsultar.TabIndex = 223
        Me.lblconsultar.Text = "CONSULTAR"
        Me.lblconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblnumero.Location = New System.Drawing.Point(244, 197)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(24, 16)
        Me.lblnumero.TabIndex = 227
        Me.lblnumero.Text = "N°"
        '
        'lblmantenimiento
        '
        Me.lblmantenimiento.AutoSize = True
        Me.lblmantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmantenimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmantenimiento.Location = New System.Drawing.Point(281, 163)
        Me.lblmantenimiento.Name = "lblmantenimiento"
        Me.lblmantenimiento.Size = New System.Drawing.Size(108, 16)
        Me.lblmantenimiento.TabIndex = 226
        Me.lblmantenimiento.Text = "Mantenimiento"
        '
        'txtnunmant1
        '
        Me.txtnunmant1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnunmant1.Location = New System.Drawing.Point(274, 193)
        Me.txtnunmant1.Name = "txtnunmant1"
        Me.txtnunmant1.Size = New System.Drawing.Size(115, 26)
        Me.txtnunmant1.TabIndex = 4
        '
        'cmbconsultar
        '
        Me.cmbconsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbconsultar.Image = CType(resources.GetObject("cmbconsultar.Image"), System.Drawing.Image)
        Me.cmbconsultar.Location = New System.Drawing.Point(224, 157)
        Me.cmbconsultar.Name = "cmbconsultar"
        Me.cmbconsultar.Size = New System.Drawing.Size(53, 53)
        Me.cmbconsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbconsultar.TabIndex = 229
        Me.cmbconsultar.TabStop = False
        '
        'cmbmodificar
        '
        Me.cmbmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbmodificar.Image = CType(resources.GetObject("cmbmodificar.Image"), System.Drawing.Image)
        Me.cmbmodificar.Location = New System.Drawing.Point(237, 242)
        Me.cmbmodificar.Name = "cmbmodificar"
        Me.cmbmodificar.Size = New System.Drawing.Size(53, 53)
        Me.cmbmodificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbmodificar.TabIndex = 230
        Me.cmbmodificar.TabStop = False
        '
        'cmbeliminar
        '
        Me.cmbeliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbeliminar.Image = CType(resources.GetObject("cmbeliminar.Image"), System.Drawing.Image)
        Me.cmbeliminar.Location = New System.Drawing.Point(360, 254)
        Me.cmbeliminar.Name = "cmbeliminar"
        Me.cmbeliminar.Size = New System.Drawing.Size(41, 41)
        Me.cmbeliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbeliminar.TabIndex = 252
        Me.cmbeliminar.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(168, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(209, 20)
        Me.Label10.TabIndex = 253
        Me.Label10.Text = "Inspecciones Realizadas"
        '
        'Frmconsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(698, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbeliminar)
        Me.Controls.Add(Me.cmbmodificar)
        Me.Controls.Add(Me.cmbconsultar)
        Me.Controls.Add(Me.lblnumero)
        Me.Controls.Add(Me.lblmantenimiento)
        Me.Controls.Add(Me.txtnunmant1)
        Me.Controls.Add(Me.lblconsultar)
        Me.Controls.Add(Me.picboxretornar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblmodificar)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.lblfabricante)
        Me.Controls.Add(Me.cmbmatricula)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblmatricula)
        Me.Controls.Add(Me.cmbfecha)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmconsultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas de Mantenimientos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxretornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbconsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmodificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbeliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblmatricula As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbmatricula As System.Windows.Forms.ComboBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblfabricante As System.Windows.Forms.Label
    Friend WithEvents lblmodificar As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picboxretornar As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblconsultar As System.Windows.Forms.Label
    Friend WithEvents lblnumero As System.Windows.Forms.Label
    Friend WithEvents lblmantenimiento As System.Windows.Forms.Label
    Friend WithEvents txtnunmant1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbconsultar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbmodificar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbeliminar As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
