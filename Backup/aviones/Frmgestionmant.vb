Imports System.Data.OleDb
Public Class Frmgestionmant
    Dim CM As New OleDb.OleDbConnection("Provider=SQLNCLI10;Server=YOHANA-HP\SQLEXPRESS;Database=Aviones;Trusted_Connection=yes;")
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Frmprincipal.PictureBox1.Visible = True
        Me.Hide()
    End Sub

    Private Sub picboxnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxnuevo.Click


        Dim CMD As New OleDb.OleDbCommand("SELECT MAX(Num_report) from Report_mant ", CM)
        Dim dm As OleDbDataReader
        Dim contador As Integer
        CM.Close()
        CM.Open()
        dm = CMD.ExecuteReader
        If dm.Read Then
            contador = dm(0) + 1
            Frmnuevoreporte.txtnumreporte.Text = Format(contador, "000000")
        End If
        Frmnuevoreporte.ShowDialog()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frmcorrecion.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frmcertificado.Show()
    End Sub

    Private Sub picboxbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxbuscar.Click

        Frmconsultar.cmbfecha.Visible = True
        Frmconsultar.lblmatricula.Visible = True
        Frmconsultar.cmbmatricula.Visible = True
        Frmconsultar.lblfabricante.Visible = True
        Frmconsultar.txtnombre.Visible = True
        Frmconsultar.cmbconsultar.Visible = True
        Frmconsultar.DataGridView1.Visible = True


        Frmconsultar.cmbmatricula.Text = ""
        Frmconsultar.txtnombre.Text = ""
        Frmconsultar.cmbfecha.Value = Now
        Frmconsultar.DataGridView1.DataSource = Nothing
        Frmconsultar.ShowDialog()
    End Sub

   

    Private Sub picboxnuevo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxnuevo.MouseHover
        picboxnuevo.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxnuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxnuevo.MouseLeave
        picboxnuevo.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub Frmgestionmant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picboxbuscar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxbuscar.MouseHover
        picboxbuscar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxbuscar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxbuscar.MouseLeave
        picboxbuscar.Size = New Size(Width:=53, Height:=53)
    End Sub
End Class