Imports System.Data.OleDb

Public Class Frmcertificado
    Dim CM As New OleDb.OleDbConnection("Provider=SQLNCLI10;Server=YOHANA-HP\SQLEXPRESS;Database=Aviones;Trusted_Connection=yes;")

    Public Sub cargar5()
        Dim dac As New OleDb.OleDbDataAdapter("Select * from Correc_mant where Num_certificado =0", CM)
        Dim dsc As New DataSet
        dac.Fill(dsc, "Correc_mant")
        cmbnumreport1.DataSource = dsc.Tables("Correc_mant")
        cmbnumreport1.DisplayMember = "Num_report"
        cmbnumreport1.Text = ""

        Txtserial.Text = ""
        cmbnumreport1.Text = ""
        txtmodelo.Text = ""
        txtmatricula.Text = ""
        txtmarca.Text = ""
        txtestacion.Text = ""
        Txtlicencia.Text = ""
    End Sub

    Private Sub Frmcertificado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        cargar5()

    End Sub

    Private Sub txtlicencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtlicencia.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtmatricula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmatricula.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cmbnumreport1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbnumreport1.LostFocus
        Dim CMD As New OleDb.OleDbCommand("SELECT * FROM Report_mant where Num_report='" & cmbnumreport1.Text & "'", CM)
        Dim dm As OleDbDataReader
        CM.Close()
        CM.Open()
        If cmbnumreport1.Text = "" Then

            Exit Sub
        Else
            dm = CMD.ExecuteReader
            If dm.Read Then
                txtmatricula.Text = dm(2)
                txtestacion.Text = dm(4)

            End If
        End If

        Dim CME As New OleDb.OleDbCommand("SELECT * FROM Avion where Matricula='" & txtmatricula.Text & "'", CM)
        Dim dmm As OleDbDataReader
        CM.Close()
        CM.Open()
        If cmbnumreport1.Text = "" Then

            Exit Sub
        Else
            dmm = CME.ExecuteReader
            If dmm.Read Then
                Txtserial.Text = dmm(1)
                txtmarca.Text = dmm(2)
                txtmodelo.Text = dmm(3)

            End If
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            txttipomant.Text = "Reemplazo de componente"
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
        Else
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            txttipomant.Text = "Modificacion"
            CheckBox1.Enabled = False
            CheckBox3.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox3.Enabled = True
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then
            txttipomant.Text = "Reparacion"
            CheckBox2.Enabled = False
            CheckBox1.Enabled = False
        Else
            CheckBox2.Enabled = True
            CheckBox1.Enabled = True
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

    Private Sub txtnumreport_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub picboxagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxagregar.Click
        If txtmarca.Text = "" Or txtmodelo.Text = "" Or txtmatricula.Text = "" Or Txtserial.Text = "" Or txtestacion.Text = "" Or txttipomant.Text = "" Or Txtlicencia.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else
            Dim CMD As New OleDb.OleDbCommand("INSERT INTO Cert_mant VALUES (" & cmbnumreport1.Text & ",'" & txtmarca.Text & "','" & txtmodelo.Text & "','" & txtmatricula.Text & "','" & Txtserial.Text & "','" & txttipomant.Text & "','" & txtestacion.Text & "','" & txtfecha.Value.ToString("dd/MM/yyyy") & "','" & txtfecha.Value.ToString("hh:mm:ss") & "'," & Txtlicencia.Text & ")", CM)
            Dim CMDD As New OleDb.OleDbCommand("UPDATE Correc_mant SET Num_certificado = 1 WHERE Num_report =  " & cmbnumreport1.Text & "", CM)

            CM.Close()
            CM.Open()
            CMD.ExecuteNonQuery()
            CMDD.ExecuteNonQuery()
            CM.Close()
            MsgBox("SU CERTIFICADO HA SIDO AGREGADO CORRECTAMENTE", MsgBoxStyle.Information, "MENSAJE")
            txtfecha.Value = Now
            txtmarca.Text = ""
            txtmodelo.Text = ""
            txtmatricula.Text = ""
            Txtserial.Text = ""
            txtestacion.Text = ""
            cmbnumreport1.Text = ""

            cargar5()
            Exit Sub
        End If
    End Sub

    Private Sub picboxagregar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxagregar.MouseHover
        picboxagregar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxagregar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxagregar.MouseLeave
        picboxagregar.Size = New Size(Width:=53, Height:=53)
    End Sub
End Class