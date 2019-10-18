Imports System.Data.OleDb
Public Class Frmnuevoreporte

    Dim CM As New OleDb.OleDbConnection("Provider=SQLNCLI10;Server=YOHANA-HP\SQLEXPRESS;Database=Aviones;Trusted_Connection=yes;")

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            txtvalorfase.Text = "PRE FL"

            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
        Else
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            txtvalorfase.Text = "TAXI"
            CheckBox1.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then
            txtvalorfase.Text = "T.OFF"
            CheckBox2.Enabled = False
            CheckBox1.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
        Else
            CheckBox2.Enabled = True
            CheckBox1.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then
            txtvalorfase.Text = "CLB"
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox1.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
        Else
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox1.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
        End If
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged

        If CheckBox5.Checked = True Then
            txtvalorfase.Text = "CRS"
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox1.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
        Else
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox1.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged

        If CheckBox6.Checked = True Then
            txtvalorfase.Text = "APP"
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox1.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
        Else
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox1.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
        End If
    End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged

        If CheckBox7.Checked = True Then
            txtvalorfase.Text = "LGD"
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox1.Enabled = False
            CheckBox8.Enabled = False
        Else
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox1.Enabled = True
            CheckBox8.Enabled = True
        End If
    End Sub
    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged

        If CheckBox8.Checked = True Then
            txtvalorfase.Text = "GRD"
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox1.Enabled = False
        Else
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeOfDay
    End Sub

    Private Sub Frmnuevoreporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As New OleDb.OleDbDataAdapter("Select * from Inspecciones_cond", CM)
        Dim ds As New DataSet
        da.Fill(ds, "Inspecciones_cond")
        cmbinspeccion.DataSource = ds.Tables("Inspecciones_cond")
        cmbinspeccion.DisplayMember = "Inspecciones"
        cmbinspeccion.Text = ""

        Dim daa As New OleDb.OleDbDataAdapter("Select * from Estaciones", CM)
        Dim dss As New DataSet
        daa.Fill(dss, "Estaciones")
        cmbestacion.DataSource = dss.Tables("Estaciones")
        cmbestacion.DisplayMember = "Estacion"
        cmbestacion.Text = ""

        Timer1.Start()

        txtfecha.Value = Now
        txtvuelo.Text = ""

        Maskedmatricula.Text = ""
        cmbestacion.Text = ""
        txtlicencia.Text = ""
        txtdescripcion.Text = ""
        Txtcodigoata.Text = ""
        cmbinspeccion.Text = ""
        cmbestacion.Text = ""
    End Sub

    Private Sub txtvuelo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvuelo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnumreporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumreporte.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtestacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtlicencia_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlicencia.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub picboxagregar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxagregar.MouseHover
        picboxagregar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxagregar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxagregar.MouseLeave
        picboxagregar.Size = New Size(Width:=53, Height:=53)
    End Sub

    Dim correccion As Integer
    Private Sub picboxagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxagregar.Click

        If txtvuelo.Text = "" Or cmbestacion.Text = "" Or txtlicencia.Text = "" Or txtdescripcion.Text = "" Or Txtcodigoata.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else
            correccion = 0
            Dim CMD As New OleDb.OleDbCommand("INSERT INTO Report_mant VALUES (" & txtnumreporte.Text & ",'" & txtfecha.Value.ToString("dd/MM/yyyy") & "','" & Maskedmatricula.Text & "'," & txtvuelo.Text & ",'" & cmbestacion.Text & "','" & Txtcodigoata.Text & "','" & txtfecha.Value.ToString("hh:MM:ss") & "','" & txtdescripcion.Text & "','" & txtvalorfase.Text & "'," & txtlicencia.Text & ", " & correccion & ", " & correccion & ",'" & cmbinspeccion.Text & "')", CM)

            CM.Close()
            CM.Open()
            CMD.ExecuteNonQuery()
            CM.Close()
            MsgBox("SU MANTENIMIENTO HA SIDO AGREGADO CORRECTAMENTE", MsgBoxStyle.Information, "MENSAJE")
            txtfecha.Value = Now
            txtvuelo.Text = ""
            Maskedmatricula.Text = ""
            cmbestacion.Text = ""
            txtlicencia.Text = ""
            txtdescripcion.Text = ""
            Txtcodigoata.Text = ""
            cmbinspeccion.Text = ""
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False

            Frmprincipal.cargar2()

            Frmgestionmant3.cargar3()

            Exit Sub
        End If
    End Sub

    Private Sub picboxmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub picboxretornar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxretornar.Click
        Me.Hide()
    End Sub


    Private Sub picboxretornar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxretornar.MouseHover
        picboxretornar.Size = New Size(Width:=60, Height:=60)
    End Sub


    Private Sub picboxretornar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxretornar.MouseLeave
        picboxretornar.Size = New Size(Width:=53, Height:=53)
    End Sub

End Class