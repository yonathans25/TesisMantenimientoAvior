<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmgestionmant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmgestionmant))
        Me.Label1 = New System.Windows.Forms.Label
        Me.picboxnuevo = New System.Windows.Forms.PictureBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picboxbuscar = New System.Windows.Forms.PictureBox
        Me.lbl_usu = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.picboxnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "X"
        '
        'picboxnuevo
        '
        Me.picboxnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxnuevo.Image = CType(resources.GetObject("picboxnuevo.Image"), System.Drawing.Image)
        Me.picboxnuevo.Location = New System.Drawing.Point(34, 25)
        Me.picboxnuevo.Name = "picboxnuevo"
        Me.picboxnuevo.Size = New System.Drawing.Size(53, 53)
        Me.picboxnuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxnuevo.TabIndex = 123
        Me.picboxnuevo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picboxnuevo, "Nuevo")
        '
        'picboxbuscar
        '
        Me.picboxbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxbuscar.Image = CType(resources.GetObject("picboxbuscar.Image"), System.Drawing.Image)
        Me.picboxbuscar.Location = New System.Drawing.Point(149, 25)
        Me.picboxbuscar.Name = "picboxbuscar"
        Me.picboxbuscar.Size = New System.Drawing.Size(53, 53)
        Me.picboxbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxbuscar.TabIndex = 126
        Me.picboxbuscar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picboxbuscar, "Consulta")
        '
        'lbl_usu
        '
        Me.lbl_usu.AutoSize = True
        Me.lbl_usu.BackColor = System.Drawing.Color.White
        Me.lbl_usu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usu.ForeColor = System.Drawing.Color.Black
        Me.lbl_usu.Location = New System.Drawing.Point(39, 4)
        Me.lbl_usu.Name = "lbl_usu"
        Me.lbl_usu.Size = New System.Drawing.Size(56, 18)
        Me.lbl_usu.TabIndex = 127
        Me.lbl_usu.Text = "Nuevo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(149, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Buscar"
        '
        'Frmgestionmant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(279, 90)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_usu)
        Me.Controls.Add(Me.picboxbuscar)
        Me.Controls.Add(Me.picboxnuevo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(470, 208)
        Me.Name = "Frmgestionmant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmgestionmant"
        CType(Me.picboxnuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picboxnuevo As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents picboxbuscar As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_usu As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
