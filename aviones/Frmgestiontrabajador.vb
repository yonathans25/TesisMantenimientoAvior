Imports System.Data.OleDb

Public Class Frmgestiontrabajador
    Dim CM As New OleDb.OleDbConnection("Provider=SQLNCLI10;Server=YOHANA-HP\SQLEXPRESS;Database=Aviones;Trusted_Connection=yes;")

    Private Sub Frmgestiontrabajador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Sub CARGAR()
        Dim da As New OleDb.OleDbDataAdapter("Select * from Trabajadores", CM)
        Dim ds As New DataSet
        da.Fill(ds, "Trabajadores")
        cmblicencia.DataSource = ds.Tables("Trabajadores")
        cmblicencia.DisplayMember = "Licencia"
        cmblicencia.Text = ""

        Dim daa As New OleDb.OleDbDataAdapter("Select * from Datos", CM)
        Dim dss As New DataSet
        daa.Fill(dss, "Datos")
        cmbcargo.DataSource = dss.Tables("Datos")
        cmbcargo.DisplayMember = "Tipo"
        cmbcargo.Text = ""

        cmbagregar.Visible = True
        cmbmodificar.Visible = False
        cmbeliminar.Visible = False

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

    Private Sub txtlicencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtlicencia.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmblicencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmblicencia.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub txtcedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcedula.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    
    Private Sub lblagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblagregar.Click
        lblagregar.BackColor = Color.DarkRed
        lblmodificar.BackColor = Color.DarkGray
        lbleliminar.BackColor = Color.DarkGray

        cmbagregar.Visible = True
        cmbmodificar.Visible = False
        cmbeliminar.Visible = False
        cmblicencia.Visible = False
        Txtlicencia.Visible = True

        Txtlicencia.Text = ""
        txtcedula.Text = ""
        txtnombre.Text = ""
        cmbcargo.Text = ""
        txttelefono.Text = ""
        txtdepartamento.Text = ""
    End Sub

    Private Sub lblmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmodificar.Click
        lblagregar.BackColor = Color.DarkGray
        lblmodificar.BackColor = Color.DarkRed
        lbleliminar.BackColor = Color.DarkGray

        cmbagregar.Visible = False
        cmbmodificar.Visible = True
        cmbeliminar.Visible = False
        cmblicencia.Visible = True
        cmblicencia.Text = ""

        Txtlicencia.Text = ""
        txtcedula.Text = ""
        txtnombre.Text = ""
        cmbcargo.Text = ""
        txttelefono.Text = ""
        Txtlicencia.Visible = False
    End Sub

    Private Sub lbleliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbleliminar.Click
        lblagregar.BackColor = Color.DarkGray
        lblmodificar.BackColor = Color.DarkGray
        lbleliminar.BackColor = Color.DarkRed

        cmbagregar.Visible = False
        cmbmodificar.Visible = False
        cmbeliminar.Visible = True
        cmblicencia.Visible = True
        cmblicencia.Text = ""

        Txtlicencia.Text = ""
        txtcedula.Text = ""
        txtnombre.Text = ""
        cmbcargo.Text = ""
        txttelefono.Text = ""
        txtdepartamento.Text = ""

        Txtlicencia.Visible = False
    End Sub


    Private Sub cmblicencia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmblicencia.LostFocus
        Dim CMD As New OleDb.OleDbCommand("SELECT * FROM Trabajadores where Licencia='" & cmblicencia.Text & "'", CM)
        Dim dm As OleDbDataReader
        CM.Close()
        CM.Open()
        If cmblicencia.Text = "" Then

            Exit Sub
        Else
            dm = CMD.ExecuteReader
            If dm.Read Then
                Txtlicencia.Text = dm(0)
                txtnombre.Text = dm(1)
                txtcedula.Text = dm(2)
                cmbcargo.Text = dm(3)
                txttelefono.Text = dm(4)
                txtdepartamento.Text = dm(5)

            End If
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

    Private Sub cmbagregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbagregar.Click
        If txtcedula.Text = "" Or txtnombre.Text = "" Or Txtlicencia.Text = "" Or cmbcargo.Text = "" Or txttelefono.Text = "" Or txtdepartamento.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else

            Dim CMDF As New OleDb.OleDbCommand("SELECT Licencia FROM Trabajadores where Licencia='" & Txtlicencia.Text & "'", CM)
            Dim dm As OleDbDataReader
            CM.Close()
            CM.Open()
            dm = CMDF.ExecuteReader
            If dm.Read Then
                If Txtlicencia.Text = dm(0) Then
                    MsgBox("El usuario ya fue creado.", MsgBoxStyle.Critical, "MENSAJE")
                    Txtlicencia.Text = ""
                    txtcedula.Text = ""
                    txtnombre.Text = ""
                    cmbcargo.Text = ""
                    txttelefono.Text = ""
                    txtdepartamento.Text = ""
                    Exit Sub
                End If
            End If


            Dim CMD As New OleDb.OleDbCommand("INSERT INTO Trabajadores VALUES ('" & Txtlicencia.Text & "','" & txtnombre.Text & "'," & txtcedula.Text & ",'" & cmbcargo.Text & "','" & txttelefono.Text & "','" & txtdepartamento.Text & "')", CM)
            CM.Close()
            CM.Open()
            CMD.ExecuteNonQuery()
            CM.Close()
            MsgBox("SU TRABAJADOR HA SIDO AGREGADO CORRECTAMENTE", MsgBoxStyle.Information, "MENSAJE")

            Txtlicencia.Text = ""
            txtcedula.Text = ""
            txtnombre.Text = ""
            cmbcargo.Text = ""
            txttelefono.Text = ""
            txtdepartamento.Text = ""
            CARGAR()
            Exit Sub
        End If
    End Sub

    Private Sub cmbmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmodificar.Click
        If txtcedula.Text = "" Or txtnombre.Text = "" Or Txtlicencia.Text = "" Or txtdepartamento.Text = "" Or cmbcargo.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub

        Else
            
            Dim cp As New OleDb.OleDbCommand("UPDATE Trabajadores SET Nombre_apell='" & txtnombre.Text & "',Licencia = " & Txtlicencia.Text & ", Cargo = '" & cmbcargo.Text & "', Telefono = '" & txttelefono.Text & "', Departamento = '" & txtdepartamento.Text & "'  Where Licencia = '" & cmblicencia.Text & "'", CM)
            CM.Close()
            CM.Open()
            cp.ExecuteNonQuery()
            MsgBox("Trabajador Modificado satisfactoriamente", MsgBoxStyle.Information, "MENSAJE")

            cmblicencia.Text = ""
            Txtlicencia.Text = ""
            txtcedula.Text = ""
            txtnombre.Text = ""
            cmbcargo.Text = ""
            txttelefono.Text = ""
            txtdepartamento.Text = ""

            CARGAR()
            Exit Sub
        End If
    End Sub

    Private Sub cmbeliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbeliminar.Click

        If txtcedula.Text = "" Or txtnombre.Text = "" Or Txtlicencia.Text = "" Or txtdepartamento.Text = "" Or cmbcargo.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else

            Dim cp As New OleDb.OleDbCommand("DELETE FROM Trabajadores WHERE Licencia = '" & cmblicencia.Text & "'", CM)
            CM.Close()
            CM.Open()
            cp.ExecuteNonQuery()
            CM.Close()
            MsgBox("Trabajador Eliminado satisfactoriamente", MsgBoxStyle.Information, "MENSAJE")

            cmblicencia.Text = ""
            Txtlicencia.Text = ""
            txtcedula.Text = ""
            txtnombre.Text = ""
            cmbcargo.Text = ""
            txttelefono.Text = ""
            txtdepartamento.Text = ""

            cmbmodificar.Enabled = False
            cmbeliminar.Enabled = True
            cmbagregar.Enabled = False
            CARGAR()
            Exit Sub
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

End Class