Imports System.Data.OleDb

Public Class Frmvuelos
    Dim CM As New OleDb.OleDbConnection("Provider=SQLNCLI10;Server=YOHANA-HP\SQLEXPRESS;Database=Aviones;Trusted_Connection=yes;")

    Private d_table As DataTable

    Private Sub Frmvuelos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As New OleDb.OleDbDataAdapter("Select * from Vuelos", CM)
        Dim ds As New DataSet
        da.Fill(ds, "Vuelos")
        cmbserial.DataSource = ds.Tables("Vuelos")
        cmbserial.DisplayMember = "Mod_avion"
        cmbserial.Text = ""
    End Sub

    Private Sub cmbserial_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbserial.LostFocus
        Dim CMD As New OleDb.OleDbCommand("SELECT * FROM Vuelos where Mod_avion='" & cmbserial.Text & "'", CM)
        Dim dm As OleDbDataReader
        CM.Close()
        CM.Open()
        If cmbserial.Text = "" Then
            Exit Sub
        Else
            dm = CMD.ExecuteReader
        End If
    End Sub

    Private Sub picboxretornar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxretornar.Click
        Hide()
        Frmprincipal.Show()

    End Sub

    Private Sub picboxretornar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxretornar.MouseHover
        picboxretornar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxretornar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxretornar.MouseLeave
        picboxretornar.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub cmbconsultar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbconsultar1.Click
        If cmbserial.Text <> "" Then
            Dim da As New OleDb.OleDbDataAdapter("Select * from Vuelos where Mod_avion='" & cmbserial.Text & "'and Fecha_vuelo='" & txtfecha.Value.ToString("dd/MM/yyyy") & "'", CM)
            Dim ds As New DataSet
            d_table = New DataTable
            da.Fill(d_table)
            DataGridView2.DataSource = d_table
        Else
            Dim da As New OleDb.OleDbDataAdapter("Select * from Vuelos where Fecha_vuelo='" & txtfecha.Value.ToString("dd/MM/yyyy") & "'", CM)
            Dim ds As New DataSet
            d_table = New DataTable
            da.Fill(d_table)
            DataGridView2.DataSource = d_table
        End If
    End Sub

    Private Sub cmbconsultar1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbconsultar1.MouseHover
        cmbconsultar1.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub cmbconsultar1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbconsultar1.MouseLeave
        cmbconsultar1.Size = New Size(Width:=53, Height:=53)
    End Sub
End Class