Imports System.Data.OleDb

Public Class Frmgestionaviones
    Dim CM As New OleDb.OleDbConnection("Provider=SQLNCLI10;Server=YOHANA-HP\SQLEXPRESS;Database=Aviones;Trusted_Connection=yes;")

    Private Sub Frmgestionaviones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR6()
    End Sub

    Sub CARGAR6()
        Dim da As New OleDb.OleDbDataAdapter("Select * from Avion", CM)
        Dim ds As New DataSet
        da.Fill(ds, "Avion")
        cmbmatricula.DataSource = ds.Tables("Avion")
        cmbmatricula.DisplayMember = "Matricula"
        cmbmatricula.Text = ""

    End Sub

    Private Sub cmbmatricula_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbmatricula.LostFocus
        Dim CMD As New OleDb.OleDbCommand("SELECT * FROM Avion where Matricula='" & cmbmatricula.Text & "'", CM)
        Dim dm As OleDbDataReader
        CM.Close()
        CM.Open()
        If cmbmatricula.Text = "" Then

            Exit Sub
        Else
            dm = CMD.ExecuteReader
            If dm.Read Then
                txtmatricula.Text = dm(0)
                txtserial.Text = dm(1)
                txtfabricante.Text = dm(2)
                txtmodelo.Text = dm(3)
                txtsituacion.Text = dm(4)
                cmbcompania.Text = dm(5)
                txtpais.Text = dm(6)

            End If
        End If
    End Sub

    Private Sub cmbagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbagregar.Click
        If txtmatricula.Text = "" Or txtserial.Text = "" Or txtfabricante.Text = "" Or txtmodelo.Text = "" Or txtsituacion.Text = "" Or cmbcompania.Text = "" Or txtpais.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else
            Dim CMDF As New OleDb.OleDbCommand("SELECT Matricula FROM Avion where Matricula='" & txtmatricula.Text & "'", CM)
            Dim dm As OleDbDataReader
            CM.Close()
            CM.Open()
            dm = CMDF.ExecuteReader
            If dm.Read Then
                If txtmatricula.Text = dm(0) Then
                    MsgBox("El usuario ya fue creado.", MsgBoxStyle.Critical, "MENSAJE")
                    cmbmatricula.Text = ""
                    cmbmatricula.Text = ""
                    txtmatricula.Text = ""
                    txtserial.Text = ""
                    txtfabricante.Text = ""
                    txtmodelo.Text = ""
                    txtsituacion.Text = ""
                    cmbcompania.Text = ""
                    txtpais.Text = ""
                    Exit Sub
                End If
            End If

            Dim CMD As New OleDb.OleDbCommand("INSERT INTO Avion VALUES ('" & txtmatricula.Text & "'," & txtserial.Text & ",'" & txtfabricante.Text & "','" & txtmodelo.Text & "','" & txtsituacion.Text & "','" & cmbcompania.Text & "','" & txtpais.Text & "')", CM)
            CM.Close()
            CM.Open()
            CMD.ExecuteNonQuery()
            CM.Close()
            MsgBox("SU AVION HA SIDO AGREGADO CORRECTAMENTE", MsgBoxStyle.Information, "MENSAJE")

            cmbmatricula.Text = ""
            cmbmatricula.Text = ""
            txtmatricula.Text = ""
            txtserial.Text = ""
            txtfabricante.Text = ""
            txtmodelo.Text = ""
            txtsituacion.Text = ""
            cmbcompania.Text = ""
            txtpais.Text = ""
            CARGAR6()
            Frmprincipal.cargar11()

            Exit Sub
        End If
    End Sub
    Private Sub cmbmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmodificar.Click
        If txtmatricula.Text = "" Or txtserial.Text = "" Or txtfabricante.Text = "" Or txtmodelo.Text = "" Or txtsituacion.Text = "" Or cmbcompania.Text = "" Or txtpais.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else

            Dim cp As New OleDb.OleDbCommand("UPDATE Avion SET Serial=" & txtserial.Text & ",Fabricante = '" & txtfabricante.Text & "', Modelo = '" & txtmodelo.Text & "', Situacion = '" & txtsituacion.Text & "', Compañia = '" & cmbcompania.Text & "', Pais = '" & txtpais.Text & "'  Where Matricula = '" & cmbmatricula.Text & "'", CM)
            CM.Close()
            CM.Open()
            cp.ExecuteNonQuery()
            MsgBox("Usuario Modificado satisfactoriamente", MsgBoxStyle.Information, "MENSAJE")
            cmbmatricula.Text = ""
            cmbmatricula.Text = ""
            txtmatricula.Text = ""
            txtserial.Text = ""
            txtfabricante.Text = ""
            txtmodelo.Text = ""
            txtsituacion.Text = ""
            cmbcompania.Text = ""
            txtpais.Text = ""
           
            CARGAR6()
            Exit Sub
        End If
    End Sub

    Private Sub cmbeliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbeliminar.Click
        If txtmatricula.Text = "" Or txtserial.Text = "" Or txtfabricante.Text = "" Or txtmodelo.Text = "" Or txtsituacion.Text = "" Or cmbcompania.Text = "" Or txtpais.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else

            Dim cp As New OleDb.OleDbCommand("DELETE FROM Avion WHERE Matricula = '" & cmbmatricula.Text & "'", CM)
            CM.Close()
            CM.Open()
            cp.ExecuteNonQuery()
            CM.Close()
            MsgBox("Avion Eliminado satisfactoriamente", MsgBoxStyle.Information, "MENSAJE")
            cmbmatricula.Text = ""
            cmbmatricula.Text = ""
            txtmatricula.Text = ""
            txtserial.Text = ""
            txtfabricante.Text = ""
            txtmodelo.Text = ""
            txtsituacion.Text = ""
            cmbcompania.Text = ""
            txtpais.Text = ""
            cmbmodificar.Enabled = False
            cmbeliminar.Enabled = True
            cmbagregar.Enabled = False
            CARGAR6()
            Exit Sub
        End If
    End Sub

    Private Sub txtserial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtserial.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtsituacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsituacion.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtpais_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpais.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub


    Private Sub cmbagregar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbagregar.MouseHover
        cmbagregar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub cmbagregar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbagregar.MouseLeave
        cmbagregar.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub cmbeliminar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbeliminar.MouseHover
        cmbeliminar.Size = New Size(Width:=48, Height:=48)
    End Sub

    Private Sub cmbeliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbeliminar.MouseLeave
        cmbeliminar.Size = New Size(Width:=41, Height:=41)
    End Sub

    Private Sub cmbmodificar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbmodificar.MouseHover
        cmbmodificar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub cmbmodificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbmodificar.MouseLeave
        cmbmodificar.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub lblagregar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblagregar.MouseHover
        lblagregar.Size = New Size(Width:=175, Height:=45)
    End Sub

    Private Sub lblagregar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblagregar.MouseLeave
        lblagregar.Size = New Size(Width:=170, Height:=40)
    End Sub

    Private Sub lblmodificar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblmodificar.MouseHover
        lblmodificar.Size = New Size(Width:=175, Height:=45)
    End Sub

    Private Sub lblmodificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblmodificar.MouseLeave
        lblmodificar.Size = New Size(Width:=170, Height:=40)
    End Sub

    Private Sub lbleliminar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbleliminar.MouseHover
        lbleliminar.Size = New Size(Width:=175, Height:=45)
    End Sub

    Private Sub lbleliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbleliminar.MouseLeave
        lbleliminar.Size = New Size(Width:=170, Height:=40)
    End Sub

    Private Sub lblagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblagregar.Click
        lblagregar.BackColor = Color.DarkRed
        lblmodificar.BackColor = Color.DarkGray
        lbleliminar.BackColor = Color.DarkGray

        cmbagregar.Visible = True
        cmbmodificar.Visible = False
        cmbeliminar.Visible = False
        cmbmatricula.Visible = False
        txtmatricula.Visible = True
        cmbmatricula.Text = ""
        txtmatricula.Text = ""
        txtserial.Text = ""
        txtfabricante.Text = ""
        txtmodelo.Text = ""
        txtsituacion.Text = ""
        cmbcompania.Text = ""
        txtpais.Text = ""
    End Sub

    Private Sub lblmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmodificar.Click
        lblagregar.BackColor = Color.DarkGray
        lblmodificar.BackColor = Color.DarkRed
        lbleliminar.BackColor = Color.DarkGray

        cmbagregar.Visible = False
        cmbmodificar.Visible = True
        cmbeliminar.Visible = False
        cmbmatricula.Visible = True
        cmbmatricula.Text = ""
        cmbmatricula.Text = ""
        txtmatricula.Text = ""
        txtserial.Text = ""
        txtfabricante.Text = ""
        txtmodelo.Text = ""
        txtsituacion.Text = ""
        cmbcompania.Text = ""
        txtpais.Text = ""
        txtmatricula.Visible = False
    End Sub

    Private Sub lbleliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbleliminar.Click
        lblagregar.BackColor = Color.DarkGray
        lblmodificar.BackColor = Color.DarkGray
        lbleliminar.BackColor = Color.DarkRed

        cmbagregar.Visible = False
        cmbmodificar.Visible = False
        cmbeliminar.Visible = True
        cmbmatricula.Visible = True
        cmbmatricula.Text = ""
        cmbmatricula.Text = ""
        cmbmatricula.Text = ""
        txtmatricula.Text = ""
        txtserial.Text = ""
        txtfabricante.Text = ""
        txtmodelo.Text = ""
        txtsituacion.Text = ""
        cmbcompania.Text = ""
        txtpais.Text = ""
        txtmatricula.Visible = False
    End Sub
    Private Sub picboxretornar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxretornar.MouseHover
        picboxretornar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxretornar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxretornar.MouseLeave
        picboxretornar.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub picboxretornar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxretornar.Click
        Hide()
        Frmprincipal.Show()
    End Sub
End Class