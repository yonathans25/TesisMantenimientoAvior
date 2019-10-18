Imports System.Data.OleDb
Public Class Frmgestionmant2

    Private Sub picboxreparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxreparar.Click
        Frmcorrecion.ShowDialog()
    End Sub

    Private Sub picboxcertificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxcertificar.Click

        Frmcertificado.ShowDialog()
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

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Frmprincipal.PictureBox1.Visible = True
        Me.Hide()
    End Sub



    Private Sub picboxreparar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxreparar.MouseHover
        picboxreparar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxreparar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxreparar.MouseLeave
        picboxreparar.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub picboxcertificar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxcertificar.MouseHover
        picboxcertificar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxcertificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxcertificar.MouseLeave
        picboxcertificar.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub picboxbuscar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxbuscar.MouseHover
        picboxbuscar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxbuscar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxbuscar.MouseLeave
        picboxbuscar.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub Frmgestionmant2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class