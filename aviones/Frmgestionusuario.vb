Imports System.Data.OleDb

Public Class Frmgestionusuario
    Dim CM As New OleDb.OleDbConnection("Provider=SQLNCLI10;Server=YOHANA-HP\SQLEXPRESS;Database=Aviones;Trusted_Connection=yes;")
    Private Sub Frmgestionusuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub
    Sub CARGAR()
        Dim da As New OleDb.OleDbDataAdapter("Select * from Usuarios", CM)
        Dim ds As New DataSet
        da.Fill(ds, "Usuarios")
        cmbusuario.DataSource = ds.Tables("Usuarios")
        cmbusuario.DisplayMember = "Usuario"
        cmbusuario.Text = ""

        Dim daa As New OleDb.OleDbDataAdapter("Select * from Datos", CM)
        Dim dss As New DataSet
        daa.Fill(dss, "Datos")
        cmbtipo.DataSource = dss.Tables("Datos")
        cmbtipo.DisplayMember = "Tipo"
        cmbtipo.Text = ""

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
    Private Sub txtlicencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlicencia.KeyPress
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
        cmbusuario.Visible = False
        Txtusuario.Visible = True
        cmbusuario.Text = ""
        Txtusuario.Text = ""
        txtcedula.Text = ""
        txtnombre.Text = ""
        txtcontrasena.Text = ""
        txtcontrasena1.Text = ""
        cmbtipo.Text = ""
        txtlicencia.Text = ""
    End Sub

    Private Sub lblmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmodificar.Click
        lblagregar.BackColor = Color.DarkGray
        lblmodificar.BackColor = Color.DarkRed
        lbleliminar.BackColor = Color.DarkGray

        cmbagregar.Visible = False
        cmbmodificar.Visible = True
        cmbeliminar.Visible = False
        cmbusuario.Visible = True
        cmbusuario.Text = ""
        Txtusuario.Text = ""
        txtcedula.Text = ""
        txtnombre.Text = ""
        txtcontrasena.Text = ""
        txtcontrasena1.Text = ""
        cmbtipo.Text = ""
        txtlicencia.Text = ""
        Txtusuario.Visible = False

    End Sub

    Private Sub lbleliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbleliminar.Click
        lblagregar.BackColor = Color.DarkGray
        lblmodificar.BackColor = Color.DarkGray
        lbleliminar.BackColor = Color.DarkRed

        cmbagregar.Visible = False
        cmbmodificar.Visible = False
        cmbeliminar.Visible = True
        cmbusuario.Visible = True
        cmbusuario.Text = ""
        Txtusuario.Text = ""
        txtcedula.Text = ""
        txtnombre.Text = ""
        txtcontrasena.Text = ""
        txtcontrasena1.Text = ""
        cmbtipo.Text = ""
        txtlicencia.Text = ""
        Txtusuario.Visible = False
    End Sub

    Private Sub cmbusuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbusuario.LostFocus
        Dim CMD As New OleDb.OleDbCommand("SELECT * FROM Usuarios where Usuario='" & cmbusuario.Text & "'", CM)
        Dim dm As OleDbDataReader
        CM.Close()
        CM.Open()
        If cmbusuario.Text = "" Then

            Exit Sub
        Else
            dm = CMD.ExecuteReader
            If dm.Read Then
                Txtusuario.Text = dm(0)
                txtnombre.Text = dm(1)
                txtcedula.Text = dm(2)
                txtcontrasena.Text = dm(3)
                txtcontrasena1.Text = dm(4)
                cmbtipo.Text = dm(5)
                txtlicencia.Text = dm(6)

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

    Private Sub cmbagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbagregar.Click
        If txtcedula.Text = "" Or txtnombre.Text = "" Or Txtusuario.Text = "" Or txtcontrasena.Text = "" Or txtcontrasena1.Text = "" Or cmbtipo.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else
            If txtcontrasena.Text <> txtcontrasena1.Text Then
                MsgBox("LOS DATOS INTRODUCIDOS EN LA CONTRASEÑA Y CONTRASEÑA1 SON DISTINTOS VERIFIQUE POR FAVOR", MsgBoxStyle.Critical, "MENSAJE")
                txtcontrasena.Text = ""
                txtcontrasena1.Text = ""
                Exit Sub
            End If


            Dim CMD As New OleDb.OleDbCommand("SELECT Usuario FROM Usuarios where Usuario='" & Txtusuario.Text & "'", CM)
            Dim dm As OleDbDataReader
            CM.Close()
            CM.Open()
            dm = CMD.ExecuteReader
            If dm.Read Then
                If Txtusuario.Text = dm(0) Then
                    MsgBox("El usuario ya fue creado.", MsgBoxStyle.Critical, "MENSAJE")
                    txtcontrasena.Text = ""
                    txtcontrasena1.Text = ""
                    Txtusuario.Text = ""
                    txtcedula.Text = ""
                    txtnombre.Text = ""
                    cmbtipo.Text = ""
                    txtlicencia.Text = ""
                    Exit Sub
                End If
            End If

            Dim CMDd As New OleDb.OleDbCommand("INSERT INTO Usuarios VALUES ('" & Txtusuario.Text & "','" & txtnombre.Text & "'," & txtcedula.Text & ",'" & txtcontrasena.Text & "','" & txtcontrasena1.Text & "','" & cmbtipo.Text & "'," & txtlicencia.Text & ")", CM)
            CM.Close()
            CM.Open()
            CMDd.ExecuteNonQuery()
            CM.Close()
            MsgBox("SU USUARIO HA SIDO AGREGADO CORRECTAMENTE", MsgBoxStyle.Information, "MENSAJE")

            Txtusuario.Text = ""
            txtcedula.Text = ""
            txtnombre.Text = ""
            txtcontrasena.Text = ""
            txtcontrasena1.Text = ""
            cmbtipo.Text = ""
            txtlicencia.Text = ""
            CARGAR()
            Exit Sub
            End If
    End Sub

    Private Sub cmbmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmodificar.Click
        If txtcedula.Text = "" Or txtnombre.Text = "" Or Txtusuario.Text = "" Or txtcontrasena.Text = "" Or txtcontrasena1.Text = "" Or cmbtipo.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else

            If txtcontrasena.Text <> txtcontrasena1.Text Then
                MsgBox("LOS DATOS INTRODUCIDOS EN LA CONTRASEÑA Y CONTRASEÑA1 SON DISTINTOS VERIFIQUE POR FAVOR", MsgBoxStyle.Critical, "MENSAJE")
                txtcontrasena.Text = ""
                txtcontrasena1.Text = ""
                Exit Sub
            End If
            Dim cp As New OleDb.OleDbCommand("UPDATE USUARIOS SET Nombre='" & txtnombre.Text & "',Cedula = " & txtcedula.Text & ", Contrasena = '" & txtcontrasena.Text & "', Contrasena1 = '" & txtcontrasena1.Text & "', Tipo_user = '" & cmbtipo.Text & "', Licencia = " & txtlicencia.Text & "  Where Usuario = '" & cmbusuario.Text & "'", CM)
            CM.Close()
            CM.Open()
            cp.ExecuteNonQuery()
            MsgBox("Usuario Modificado satisfactoriamente", MsgBoxStyle.Information, "MENSAJE")
            txtcedula.Text = ""
            txtnombre.Text = ""
            Txtusuario.Text = ""
            txtcontrasena.Text = ""
            txtcontrasena1.Text = ""
            cmbtipo.Text = ""
            txtlicencia.Text = ""
          
            CARGAR()
            Exit Sub
        End If
    End Sub

    Private Sub cmbeliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbeliminar.Click
        If txtcedula.Text = "" Or txtnombre.Text = "" Or Txtusuario.Text = "" Or txtcontrasena.Text = "" Or txtcontrasena1.Text = "" Or cmbtipo.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else

            Dim cp As New OleDb.OleDbCommand("DELETE FROM USUARIOS WHERE Usuario = '" & cmbusuario.Text & "'", CM)
            CM.Close()
            CM.Open()
            cp.ExecuteNonQuery()
            CM.Close()
            MsgBox("Usuario Eliminado satisfactoriamente", MsgBoxStyle.Information, "MENSAJE")
            txtcedula.Text = ""
            txtnombre.Text = ""
            Txtusuario.Text = ""
            txtcontrasena.Text = ""
            txtcontrasena1.Text = ""
            cmbtipo.Text = ""
            txtlicencia.Text = ""
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