Imports System.Data.OleDb

Public Class Frmprincipal
    Dim CM As New OleDb.OleDbConnection("Provider=SQLNCLI10;Server=YOHANA-HP\SQLEXPRESS;Database=Aviones;Trusted_Connection=yes;")
    
    Private d_table As DataTable
    Private d_table2 As DataTable

    Public Sub cargar2()
        Dim CMD As New OleDb.OleDbCommand("SELECT count(Num_correccion) FROM  Report_mant where Num_correccion =0", CM)
        Dim dm As OleDbDataReader
        CM.Close()
        CM.Open()

        dm = CMD.ExecuteReader
        If dm.Read Then
            TextBox1.Text = dm(0)
        End If
    End Sub

    Public Sub cargar11()
        Dim da2 As New OleDb.OleDbDataAdapter("Select Avion.Matricula, Avion.Fabricante, Avion.Modelo from Avion where Avion.Situacion ='Operativo'", CM)
        Dim ds2 As New DataSet
        d_table2 = New DataTable
        da2.Fill(d_table2)
        DataGridView2.DataSource = d_table2
    End Sub


    Private Sub Frmprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Refresh()
        Dim fecha As String
        fecha = DateTimePicker1.Text
        label1.Text = fecha
        DateTimePicker1.Visible = False

        txtfecha.Value = Now
        Dim da1 As New OleDb.OleDbDataAdapter("Select Vuelos.Numero, Vuelos.Hora_salida, Vuelos.Estatus from Vuelos where Fecha_vuelo='" & txtfecha.Value.ToString("dd/MM/yyyy") & "'", CM)
        Dim ds1 As New DataSet
        d_table = New DataTable
        da1.Fill(d_table)
        DataGridView1.DataSource = d_table

        cargar11()
        cargar2()

        PictureBox1.Visible = True

       

    End Sub


    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (MsgBox("Esta seguro que desea cambiar de usuario???", vbInformation + vbYesNo, "MENSAJE") = vbYes) Then
            frminicio.Show()
            Hide()
        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (MsgBox("Esta seguro que desea Salir del sistema?", vbInformation + vbYesNo, "MENSAJE") = vbYes) Then
            MsgBox("Gracias por Utilizar el Sistema", vbInformation, "MENSAJE")

            Hide()
        End If
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label9.Visible = False
        Label13.Visible = True
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        Label13.Visible = False
        Label9.Visible = True
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frmconsultar.cmbmatricula.Text = ""
        Frmconsultar.txtnombre.Text = ""
        Frmconsultar.cmbfecha.Value = Now
        Frmconsultar.DataGridView1.DataSource = Nothing
        Frmconsultar.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frmnuevoreporte.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frmcorrecion.Show()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frmcertificado.Show()
    End Sub

    Private Sub picboxvuelos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxvuelos.Click
        Frmvuelos.cmbserial.Text = ""
        Frmvuelos.txtfecha.Value = Now
        Frmvuelos.DataGridView2.DataSource = Nothing
        Frmvuelos.Show()
    End Sub

    Private Sub opinspec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpInspec.Click
        PictureBox1.Visible = False

        Frmgestionmant.ShowDialog()

    End Sub

    Private Sub picboxaviones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxaviones.Click

        Frmveraviones.ShowDialog()

    End Sub

    Private Sub Optecnico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Optecnico.Click
        PictureBox1.Visible = False

        Frmgestionmant2.ShowDialog()

    End Sub

    Private Sub opsuperv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opsuperv.Click
        PictureBox1.Visible = False
        Frmgestionmant3.ShowDialog()

    End Sub

    Private Sub picboxusuarios_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxusuarios.Click
        Frmgestionusuario.txtcedula.Text = ""
        Frmgestionusuario.txtnombre.Text = ""
        Frmgestionusuario.Txtusuario.Text = ""
        Frmgestionusuario.txtlicencia.Text = ""
        Frmgestionusuario.txtcontrasena.Text = ""
        Frmgestionusuario.txtcontrasena1.Text = ""
        Frmgestionusuario.cmbtipo.Text = ""

        Frmgestionusuario.cmbagregar.Visible = True
        Frmgestionusuario.cmbmodificar.Visible = False
        Frmgestionusuario.cmbeliminar.Visible = False

        Frmgestionusuario.lblagregar.BackColor = Color.DarkRed
        Frmgestionusuario.lblmodificar.BackColor = Color.DarkGray
        Frmgestionusuario.lbleliminar.BackColor = Color.DarkGray

        Frmgestionusuario.cmbusuario.Visible = False
        Frmgestionusuario.Txtusuario.Visible = True

        Frmgestionusuario.ShowDialog()
    End Sub

    Private Sub picboxtrabajadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxtrabajadores.Click

        Frmgestiontrabajador.txtcedula.Text = ""
        Frmgestiontrabajador.txtnombre.Text = ""
        Frmgestiontrabajador.Txtlicencia.Text = ""
        Frmgestiontrabajador.txtdepartamento.Text = ""
        Frmgestiontrabajador.txttelefono.Text = ""
        Frmgestiontrabajador.cmbcargo.Text = ""

        Frmgestiontrabajador.cmbagregar.Visible = True
        Frmgestiontrabajador.cmbmodificar.Visible = False
        Frmgestiontrabajador.cmbeliminar.Visible = False

        Frmgestiontrabajador.lblagregar.BackColor = Color.DarkRed
        Frmgestiontrabajador.lblmodificar.BackColor = Color.DarkGray
        Frmgestiontrabajador.lbleliminar.BackColor = Color.DarkGray

        Frmgestiontrabajador.cmblicencia.Visible = False
        Frmgestiontrabajador.Txtlicencia.Visible = True

        Frmgestiontrabajador.ShowDialog()

    End Sub

    Private Sub picboxaviones2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxaviones2.Click
        
        Frmgestionaviones.cmbmatricula.Text = ""
        Frmgestionaviones.cmbmatricula.Text = ""
        Frmgestionaviones.txtmatricula.Text = ""
        Frmgestionaviones.txtserial.Text = ""
        Frmgestionaviones.txtfabricante.Text = ""
        Frmgestionaviones.txtmodelo.Text = ""
        Frmgestionaviones.txtsituacion.Text = ""
        Frmgestionaviones.cmbcompania.Text = ""
        Frmgestionaviones.txtpais.Text = ""

        Frmgestionaviones.cmbagregar.Visible = True
        Frmgestionaviones.cmbmodificar.Visible = False
        Frmgestionaviones.cmbeliminar.Visible = False

        Frmgestionaviones.lblagregar.BackColor = Color.DarkRed
        Frmgestionaviones.lblmodificar.BackColor = Color.DarkGray
        Frmgestionaviones.lbleliminar.BackColor = Color.DarkGray

        Frmgestionaviones.cmbmatricula.Visible = False
        Frmgestionaviones.txtmatricula.Visible = True

        Frmgestionaviones.ShowDialog()
    End Sub

    Private Sub picboxsesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxsesion.Click
        If (MsgBox("Esta seguro que desea cambiar de usuario???", vbInformation + vbYesNo, "MENSAJE") = vbYes) Then
            frminicio.Show()
            PictureBox1.Visible = True
            Hide()
        End If
    End Sub

    Private Sub picboxsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxsalir.Click
        If (MsgBox("Esta seguro que desea Salir del sistema?", vbInformation + vbYesNo, "MENSAJE") = vbYes) Then
            MsgBox("Gracias por Utilizar el Sistema", vbInformation, "MENSAJE")
            Hide()
        End If
    End Sub

    Private Sub picboxaviones_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxaviones.MouseHover
        picboxaviones.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picbocaviones_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxaviones.MouseLeave
        picboxaviones.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub picboxvuelos_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxvuelos.MouseHover
        picboxvuelos.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxvuelos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxvuelos.MouseLeave
        picboxvuelos.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub picboxusuarios_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxusuarios.MouseHover
        picboxusuarios.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxusuarios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxusuarios.MouseLeave
        picboxusuarios.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub picboxtrabajadores_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxtrabajadores.MouseHover
        picboxtrabajadores.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxtrabajadores_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxtrabajadores.MouseLeave
        picboxtrabajadores.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub picboxaviones2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxaviones2.MouseHover
        picboxaviones2.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxaviones2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxaviones2.MouseLeave
        picboxaviones2.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub Optecnico_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Optecnico.MouseHover
        Optecnico.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub Optecnico_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Optecnico.MouseLeave
        Optecnico.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub opsuperv_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles opsuperv.MouseHover
        opsuperv.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub opsuperv_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles opsuperv.MouseLeave
        opsuperv.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub picboxsesion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxsesion.MouseHover
        picboxsesion.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxsesion_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxsesion.MouseLeave
        picboxsesion.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub picboxsalir_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxsalir.MouseHover
        picboxsalir.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub picboxsalir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxsalir.MouseLeave
        picboxsalir.Size = New Size(Width:=53, Height:=53)
    End Sub

    Private Sub OpInspec_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpInspec.MouseHover
        OpInspec.Size = New Size(Width:=60, Height:=60)
    End Sub

    Private Sub OpInspec_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpInspec.MouseLeave
        OpInspec.Size = New Size(Width:=53, Height:=53)
    End Sub


    Private Sub UsuariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim da3 As New OleDb.OleDbDataAdapter("Select * from Usuarios", CM)
        Dim ds3 As New DataSet
        Dim reporte As New CrystalReport5
        reporte.SetDataSource(ds3)
        Frmreporteusuarios.CrystalReportViewer1.ReportSource = reporte
        Frmreporteusuarios.CrystalReportViewer1.Refresh()
        Frmreporteusuarios.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TrabajadoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrabajadoresToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim da4 As New OleDb.OleDbDataAdapter("Select * from Trabajadores", CM)
        Dim ds4 As New DataSet
        Dim reporte As New CrystalReport7
        reporte.SetDataSource(ds4)
        Frmreporteusuarios.CrystalReportViewer1.ReportSource = reporte
        Frmreporteusuarios.CrystalReportViewer1.Refresh()
        Frmreporteusuarios.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AvionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvionesToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim da5 As New OleDb.OleDbDataAdapter("Select * from Aviones", CM)
        Dim ds5 As New DataSet
        Dim reporte As New CrystalReport1
        reporte.SetDataSource(ds5)
        Frmreporteusuarios.CrystalReportViewer1.ReportSource = reporte
        Frmreporteusuarios.CrystalReportViewer1.Refresh()
        Frmreporteusuarios.Show()
        Me.Cursor = Cursors.Default
    End Sub





    Private Sub CertificadosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificadosToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim da7 As New OleDb.OleDbDataAdapter("Select * from Cert_mant", CM)
        Dim ds7 As New DataSet
        Dim reporte As New CrystalReport3
        reporte.SetDataSource(ds7)
        Frmreporteusuarios.CrystalReportViewer1.ReportSource = reporte
        Frmreporteusuarios.CrystalReportViewer1.Refresh()
        Frmreporteusuarios.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub CorrecionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrecionesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim da8 As New OleDb.OleDbDataAdapter("Select * from Correc_mant", CM)
        Dim ds8 As New DataSet
        Dim reporte As New CrystalReport2
        reporte.SetDataSource(ds8)
        Frmreporteusuarios.CrystalReportViewer1.ReportSource = reporte
        Frmreporteusuarios.CrystalReportViewer1.Refresh()
        Frmreporteusuarios.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub InspeccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InspeccionesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim da6 As New OleDb.OleDbDataAdapter("Select * from Report_mant", CM)
        Dim ds6 As New DataSet
        Dim reporte As New CrystalReport6
        reporte.SetDataSource(ds6)
        Frmreporteusuarios.CrystalReportViewer1.ReportSource = reporte
        Frmreporteusuarios.CrystalReportViewer1.Refresh()
        Frmreporteusuarios.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class