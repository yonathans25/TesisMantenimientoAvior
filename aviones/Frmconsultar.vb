Imports System.Data.OleDb

Public Class Frmconsultar
    Dim CM As New OleDb.OleDbConnection("Provider=SQLNCLI10;Server=YOHANA-HP\SQLEXPRESS;Database=Aviones;Trusted_Connection=yes;")
    Private Sub txtborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmbmatricula.Text = ""
        txtnombre.Text = ""
        cmbfecha.Value = Now
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Frmconsultar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblmantenimiento.Visible = False
        lblnumero.Visible = False
        txtnunmant1.Visible = False
        cmbeliminar.Visible = False
        cmbmodificar.Visible = False

        Dim da As New OleDb.OleDbDataAdapter("Select * from Avion", CM)
        Dim ds As New DataSet
        da.Fill(ds, "Avion")
        cmbmatricula.DataSource = ds.Tables("Avion")
        cmbmatricula.DisplayMember = "Matricula"
        cmbmatricula.Text = ""
        txtnombre.Text = ""

    End Sub

    Private Sub txtnunmant1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnunmant1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private d_table2 As DataTable

    Private d_table As DataTable
  

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        e.KeyChar = Chr(0)
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
                txtnombre.Text = dm(2)
            End If
        End If
    End Sub


    Private Sub cmbmatricula_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmatricula.SelectedIndexChanged
        Dim CMD As New OleDb.OleDbCommand("SELECT * FROM Avion where Matricula='" & cmbmatricula.Text & "'", CM)
        Dim dm As OleDbDataReader
        CM.Close()
        CM.Open()
        If cmbmatricula.Text = "" Then

            Exit Sub
        Else
            dm = CMD.ExecuteReader
            If dm.Read Then
                txtnombre.Text = dm(2)
            End If
        End If
    End Sub



    Private Sub lblmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmodificar.Click

        lblconsultar.BackColor = Color.Gray
        lblmodificar.BackColor = Color.DarkRed
        cmbfecha.Visible = False
        lblmatricula.Visible = False
        cmbmatricula.Visible = False
        lblfabricante.Visible = False
        txtnombre.Visible = False
        cmbconsultar.Visible = False
        DataGridView1.Visible = False

        Label2.Visible = False

        lblmantenimiento.Visible = True
        lblnumero.Visible = True
        txtnunmant1.Visible = True
        cmbeliminar.Visible = True
        cmbmodificar.Visible = True

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

    Private Sub lblconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblconsultar.Click
        lblconsultar.BackColor = Color.DarkRed
        lblmodificar.BackColor = Color.DarkGray
        cmbfecha.Visible = True
        lblmatricula.Visible = True
        cmbmatricula.Visible = True
        lblfabricante.Visible = True
        txtnombre.Visible = True
        cmbconsultar.Visible = True
        DataGridView1.Visible = True


        lblmantenimiento.Visible = False
        lblnumero.Visible = False
        txtnunmant1.Visible = False
        cmbeliminar.Visible = False
        cmbmodificar.Visible = False

    End Sub

    Private Sub lblconsultar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblconsultar.MouseHover
        lblconsultar.Size = New Size(Width:=175, Height:=45)
    End Sub

    Private Sub lblconsultar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblconsultar.MouseLeave
        lblconsultar.Size = New Size(Width:=170, Height:=40)
    End Sub

    Private Sub lblmodificar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblmodificar.MouseHover
        lblmodificar.Size = New Size(Width:=185, Height:=45)
    End Sub

    Private Sub lblmodificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblmodificar.MouseLeave
        lblmodificar.Size = New Size(Width:=180, Height:=40)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbeliminar1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtnunmant1.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else
            Dim CMD As New OleDb.OleDbCommand("SELECT * FROM Report_mant where Num_report=" & txtnunmant1.Text & "", CM)
            Dim dm As OleDbDataReader
            CM.Close()
            CM.Open()
            dm = CMD.ExecuteReader
            If dm.Read Then

                txtnunmant1.Text = ""

                Frmmodificarreporte.txtnumreporte.Text = dm(0)
                Frmmodificarreporte.txtfecha.Text = dm(1)
                Frmmodificarreporte.Maskedmatricula.Text = dm(2)
                Frmmodificarreporte.txtvuelo.Text = dm(3)
                Frmmodificarreporte.cmbestacion.Text = dm(4)
                Frmmodificarreporte.Txtcodigoata.Text = dm(5)
                Frmmodificarreporte.txtdescripcion.Text = dm(7)
                Frmmodificarreporte.txtvalorfase.Text = dm(8)
                Frmmodificarreporte.txtlicencia.Text = dm(9)

                Frmmodificarreporte.ShowDialog()
                Exit Sub
            Else
                MsgBox("No se encuentra el mantenimiento", MsgBoxStyle.Information, "MENSAJE")
                txtnunmant1.Text = ""
                Exit Sub
            End If
        End If
    End Sub

    Private Sub picboxagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbconsultar.Click
        If cmbmatricula.Text <> "" Then
            Dim da As New OleDb.OleDbDataAdapter("Select * from Report_mant where Matri_avion='" & cmbmatricula.Text & "'and fecha='" & cmbfecha.Value.ToString("dd/MM/yyyy") & "'", CM)
            Dim ds As New DataSet
            d_table = New DataTable
            da.Fill(d_table)
            DataGridView1.DataSource = d_table

        Else
            Dim da As New OleDb.OleDbDataAdapter("Select * from Report_mant where fecha='" & cmbfecha.Value.ToString("dd/MM/yyyy") & "'", CM)
            Dim ds As New DataSet
            d_table = New DataTable
            da.Fill(d_table)
            DataGridView1.DataSource = d_table
        End If
    End Sub


    Private Sub cmbconsultar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbconsultar.MouseHover
        cmbconsultar.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub cmbconsultar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbconsultar.MouseLeave
        cmbconsultar.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub cmbeliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbeliminar.Click
        If txtnunmant1.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else
            Dim CMD As New OleDb.OleDbCommand("SELECT * FROM Report_mant where Num_report=" & txtnunmant1.Text & "", CM)
            Dim dm As OleDbDataReader
            CM.Close()
            CM.Open()
            dm = CMD.ExecuteReader
            If dm.Read Then
                Dim cp As New OleDb.OleDbCommand("DELETE FROM Report_mant WHERE Num_report = " & txtnunmant1.Text & "", CM)
                CM.Close()
                CM.Open()
                cp.ExecuteNonQuery()
                MsgBox("Mantenimiento Eliminado satisfactoriamente", MsgBoxStyle.Information, "MENSAJE")
                
                txtnunmant1.Text = ""
                
                Exit Sub
            Else
                MsgBox("No se encuentra el mantenimiento", MsgBoxStyle.Information, "MENSAJE")
                txtnunmant1.Text = ""
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmbmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmodificar.Click
        If txtnunmant1.Text = "" Then
            MsgBox("DEBE AGREGAR DATOS", MsgBoxStyle.Critical, "MENSAJE")
            Exit Sub
        Else
            Dim CMD As New OleDb.OleDbCommand("SELECT * FROM Report_mant where Num_report=" & txtnunmant1.Text & "", CM)
            Dim dm As OleDbDataReader
            CM.Close()
            CM.Open()
            dm = CMD.ExecuteReader
            If dm.Read Then

                txtnunmant1.Text = ""

                Dim da As New OleDb.OleDbDataAdapter("Select * from Inspecciones_cond", CM)
                Dim ds As New DataSet
                da.Fill(ds, "Inspecciones_cond")
                Frmmodificarreporte.cmbinspeccion.DataSource = ds.Tables("Inspecciones_cond")
                Frmmodificarreporte.cmbinspeccion.DisplayMember = "Inspecciones"
                Frmmodificarreporte.cmbinspeccion.Text = dm(12)

                Dim daa As New OleDb.OleDbDataAdapter("Select * from Estaciones", CM)
                Dim dss As New DataSet
                daa.Fill(dss, "Estaciones")
                Frmmodificarreporte.cmbestacion.DataSource = dss.Tables("Estaciones")
                Frmmodificarreporte.cmbestacion.DisplayMember = "Estacion"
                Frmmodificarreporte.cmbestacion.Text = dm(4)

                Frmmodificarreporte.txtnumreporte.Text = dm(0)
                Frmmodificarreporte.txtfecha.Text = dm(1)
                Frmmodificarreporte.Maskedmatricula.Text = dm(2)
                Frmmodificarreporte.txtvuelo.Text = dm(3)

                Frmmodificarreporte.Txtcodigoata.Text = dm(5)
                Frmmodificarreporte.txtdescripcion.Text = dm(7)
                Frmmodificarreporte.txtvalorfase.Text = dm(8)
                Frmmodificarreporte.txtlicencia.Text = dm(9)

                If dm(8) = "PRE FLY" Then
                    Frmmodificarreporte.CheckBox1.Checked = True
                End If
                If dm(8) = "TAXI" Then
                    Frmmodificarreporte.CheckBox2.Checked = True
                End If
                If dm(8) = "T.OFF" Then
                    Frmmodificarreporte.CheckBox3.Checked = True
                End If
                If dm(8) = "CLB" Then
                    Frmmodificarreporte.CheckBox4.Checked = True
                End If
                If dm(8) = "CRS" Then
                    Frmmodificarreporte.CheckBox5.Checked = True
                End If
                If dm(8) = "APP" Then
                    Frmmodificarreporte.CheckBox5.Checked = True
                End If
                If dm(8) = "LGD" Then
                    Frmmodificarreporte.CheckBox7.Checked = True
                End If
                If dm(8) = "GRD" Then
                    Frmmodificarreporte.CheckBox8.Checked = True
                End If

                Frmmodificarreporte.ShowDialog()
                Exit Sub
            Else
                MsgBox("No se encuentra el mantenimiento", MsgBoxStyle.Information, "MENSAJE")
                txtnunmant1.Text = ""
                Exit Sub

            End If
        End If
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