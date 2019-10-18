Imports System.Data.OleDb
Public Class Frmcorrecion

    Dim CM As New OleDb.OleDbConnection("Provider=SQLNCLI10;Server=YOHANA-HP\SQLEXPRESS;Database=Aviones;Trusted_Connection=yes;")

    Public Sub cargar4()
        Dim dac As New OleDb.OleDbDataAdapter("Select * from Report_mant where Num_correccion =0", CM)
        Dim dsc As New DataSet
        dac.Fill(dsc, "Report_mant")
        cmbnumreport1.DataSource = dsc.Tables("Report_mant")
        cmbnumreport1.DisplayMember = "Num_report"
        cmbnumreport1.Text = ""
    End Sub

    Private Sub Frmcorrecion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        
        Dim da As New OleDb.OleDbDataAdapter("Select * from Trabajadores", CM)
        Dim ds As New DataSet
        da.Fill(ds, "Trabajadores")
        Cmbinspec.DataSource = ds.Tables("Trabajadores")
        Cmbinspec.DisplayMember = "Licencia"
        Cmbinspec.Text = ""
        Dim daa As New OleDb.OleDbDataAdapter("Select * from Trabajadores", CM)
        Dim dss As New DataSet
        daa.Fill(dss, "Trabajadores")
        cmbtecnico.DataSource = dss.Tables("Trabajadores")
        cmbtecnico.DisplayMember = "Licencia"
        cmbtecnico.Text = ""

        Dim daaa As New OleDb.OleDbDataAdapter("Select * from Estaciones", CM)
        Dim dsss As New DataSet
        daaa.Fill(dsss, "Estaciones")
        cmbestacion.DataSource = dsss.Tables("Estaciones")
        cmbestacion.DisplayMember = "Estacion"
        cmbestacion.Text = ""

        txtfecha.Value = Now
        txtdescripcion.Text = ""

        Textdmi.Text = ""
        Textmel.Text = ""
        Textcdl.Text = ""
        Textnef.Text = ""
        Textddg.Text = ""
        Textpn.Text = ""
        Textsn.Text = ""
        cmbnumreport1.Text = ""
        cmbestacion.Text = ""
        cmbtecnico.Text = ""
        Cmbinspec.Text = ""
        cargar4()
    End Sub

    Private Sub textsn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textsn.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Cmbinpect_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmbinspec.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cmbtecnico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtecnico.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub CheckBoxa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxa.CheckedChanged

        If CheckBoxa.Checked = True Then
            Textcat.Text = "A"

            CheckBoxb.Enabled = False
            CheckBoxc.Enabled = False
            CheckBoxd.Enabled = False
        Else
            CheckBoxb.Enabled = True
            CheckBoxc.Enabled = True
            CheckBoxd.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxb.CheckedChanged

        If CheckBoxb.Checked = True Then
            Textcat.Text = "B"

            CheckBoxa.Enabled = False
            CheckBoxc.Enabled = False
            CheckBoxd.Enabled = False
        Else
            CheckBoxa.Enabled = True
            CheckBoxc.Enabled = True
            CheckBoxd.Enabled = True
        End If
    End Sub
    Private Sub CheckBoxc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxc.CheckedChanged

        If CheckBoxc.Checked = True Then
            Textcat.Text = "C"

            CheckBoxb.Enabled = False
            CheckBoxa.Enabled = False
            CheckBoxd.Enabled = False
        Else
            CheckBoxb.Enabled = True
            CheckBoxa.Enabled = True
            CheckBoxd.Enabled = True
        End If
    End Sub
    Private Sub CheckBoxd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxd.CheckedChanged

        If CheckBoxd.Checked = True Then
            Textcat.Text = "D"

            CheckBoxb.Enabled = False
            CheckBoxc.Enabled = False
            CheckBoxa.Enabled = False
        Else
            CheckBoxb.Enabled = True
            CheckBoxc.Enabled = True
            CheckBoxa.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Text = "ENG 1"

            CheckBox2.Enabled = False
            
        Else
            CheckBox2.Enabled = True
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox1.Text = "ENG 2"

            CheckBox1.Enabled = False

        Else
            CheckBox1.Enabled = True
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox2.Text = "CSO 1"

            CheckBox4.Enabled = False

        Else
            CheckBox4.Enabled = True
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox2.Text = "CSO 2"
            CheckBox3.Enabled = False

        Else
            CheckBox3.Enabled = True
        End If
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            TextBox3.Text = "APU"
            CheckBox6.Enabled = False

        Else
            CheckBox6.Enabled = True
        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            TextBox3.Text = "HYD"
            CheckBox5.Enabled = False

        Else
            CheckBox5.Enabled = True
        End If
    End Sub
    Private Sub CheckBoxsi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxsi.CheckedChanged
        If CheckBoxsi.Checked = True Then
            TextBox4.Text = "SI"
            CheckBoxno.Enabled = False
            CheckBoxna.Enabled = False
        Else
            CheckBoxno.Enabled = True
            CheckBoxna.Enabled = True
        End If
    End Sub
    Private Sub CheckBoxno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxno.CheckedChanged
        If CheckBoxno.Checked = True Then
            TextBox4.Text = "NO"
            CheckBoxsi.Enabled = False
            CheckBoxna.Enabled = False
        Else
            CheckBoxsi.Enabled = True
            CheckBoxna.Enabled = True
        End If
    End Sub
    Private Sub CheckBoxna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxna.CheckedChanged
        If CheckBoxna.Checked = True Then
            TextBox4.Text = "N/A"
            CheckBoxsi.Enabled = False
            CheckBoxno.Enabled = False
        Else
            CheckBoxsi.Enabled = True
            CheckBoxno.Enabled = True
        End If
    End Sub

    Private Sub txttecnico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtinpec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeOfDay
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

    Private Sub cmbnumreport1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnumreport1.SelectedIndexChanged

    End Sub

    Dim correccion As Integer
    Private Sub picboxagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxagregar.Click

        Frmprincipal.Refresh()
        Frmprincipal.Update()

        If txtdescripcion.Text = "" Or Textdmi.Text = "" Or Textmel.Text = "" Or Textcdl.Text = "" Or Textnef.Text = "" Or Textddg.Text = "" Or Textpn.Text = "" Or Textsn.Text = "" Or cmbestacion.Text = "" Or Cmbinspec.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else
            correccion = 0
            Dim CMD As New OleDb.OleDbCommand("INSERT INTO Correc_mant VALUES (" & cmbnumreport1.Text & "," & Cmbinspec.Text & "," & cmbtecnico.Text & ",'" & Textdmi.Text & "','" & Textmel.Text & "','" & Textcdl.Text & "','" & Textnef.Text & "','" & Textddg.Text & "','" & Textcat.Text & "','" & Textpn.Text & "'," & Textsn.Text & ",'" & cmbestacion.Text & "','" & txtfecha.Value.ToString("dd/MM/yyyy") & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & txtfecha.Value.ToString("hh:mm:ss") & "'," & cmbnumreport1.Text & "," & correccion & ")", CM)

            Dim CMDD As New OleDb.OleDbCommand("UPDATE Report_mant SET Num_correccion = 1 WHERE Num_report =  " & cmbnumreport1.Text & "", CM)

            CM.Close()
            CM.Open()
            CMDD.ExecuteNonQuery()
            CMD.ExecuteNonQuery()

            CM.Close()
            MsgBox("SU REPARACION HA SIDO AGREGADA CORRECTAMENTE", MsgBoxStyle.Information, "MENSAJE")
            txtfecha.Value = Now
            txtdescripcion.Text = ""
            Textdmi.Text = ""
            Textmel.Text = ""
            Textcdl.Text = ""
            Textnef.Text = ""
            Textddg.Text = ""
            Textpn.Text = ""
            Textsn.Text = ""
            cmbestacion.Text = ""
            cmbtecnico.Text = ""
            Cmbinspec.Text = ""
            cmbnumreport1.Text = ""

            Frmprincipal.cargar2()
            cargar4()
            Exit Sub
        End If

        Me.Hide()
    End Sub

    Private Sub picboxagregar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxagregar.MouseHover
        picboxagregar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxagregar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxagregar.MouseLeave
        picboxagregar.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub Label36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label36.Click

    End Sub
    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Click

    End Sub
    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click

    End Sub
    Private Sub lblhora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhora.Click

    End Sub
    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub
    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click

    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label35.Click

    End Sub
    Private Sub Label34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label34.Click

    End Sub
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub
    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub
    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub
    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub
    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub
    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub
    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub
    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click

    End Sub
    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub
    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click

    End Sub
    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click

    End Sub
End Class