<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmgestionmant2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmgestionmant2))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.picboxbuscar = New System.Windows.Forms.PictureBox
        Me.picboxcertificar = New System.Windows.Forms.PictureBox
        Me.picboxreparar = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.picboxbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxcertificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxreparar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(225, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Buscar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(116, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Certificado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Reparación"
        '
        'picboxbuscar
        '
        Me.picboxbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxbuscar.Image = CType(resources.GetObject("picboxbuscar.Image"), System.Drawing.Image)
        Me.picboxbuscar.Location = New System.Drawing.Point(225, 25)
        Me.picboxbuscar.Name = "picboxbuscar"
        Me.picboxbuscar.Size = New System.Drawing.Size(53, 53)
        Me.picboxbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxbuscar.TabIndex = 133
        Me.picboxbuscar.TabStop = False
        '
        'picboxcertificar
        '
        Me.picboxcertificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxcertificar.Image = CType(resources.GetObject("picboxcertificar.Image"), System.Drawing.Image)
        Me.picboxcertificar.Location = New System.Drawing.Point(132, 25)
        Me.picboxcertificar.Name = "picboxcertificar"
        Me.picboxcertificar.Size = New System.Drawing.Size(53, 53)
        Me.picboxcertificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxcertificar.TabIndex = 132
        Me.picboxcertificar.TabStop = False
        '
        'picboxreparar
        '
        Me.picboxreparar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxreparar.Image = CType(resources.GetObject("picboxreparar.Image"), System.Drawing.Image)
        Me.picboxreparar.Location = New System.Drawing.Point(32, 25)
        Me.picboxreparar.Name = "picboxreparar"
        Me.picboxreparar.Size = New System.Drawing.Size(53, 53)
        Me.picboxreparar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxreparar.TabIndex = 131
        Me.picboxreparar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "X"
        '
        'Frmgestionmant2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(335, 90)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picboxbuscar)
        Me.Controls.Add(Me.picboxcertificar)
        Me.Controls.Add(Me.picboxreparar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(470, 208)
        Me.Name = "Frmgestionmant2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmgestionmant2"
        CType(Me.picboxbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxcertificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxreparar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picboxbuscar As System.Windows.Forms.PictureBox
    Friend WithEvents picboxcertificar As System.Windows.Forms.PictureBox
    Friend WithEvents picboxreparar As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
