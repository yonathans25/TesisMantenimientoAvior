Imports System.Data.OleDb
Public Class frminicio
    Dim CM As New OleDb.OleDbConnection("Provider=SQLNCLI10;Server=YOHANA-HP\SQLEXPRESS;Database=Aviones;Trusted_Connection=yes;")
    Private Sub cmbsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsalir.Click
        MsgBox("Gracias por Utilizar Este Programa", vbInformation, "MENSAJE")
        End
    End Sub

    Private Sub cmbingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbingresar.Click
        Dim CMD As New OleDb.OleDbCommand("SELECT * FROM Usuarios where Usuario='" & txtusuario.Text & "'  And  Contrasena = '" & txtcontrasena.Text & "'", CM)
        Dim dm As OleDbDataReader
        CM.Close()
        CM.Open()
        dm = CMD.ExecuteReader
        If dm.Read Then

            If dm(5) = "SUPERVISOR" Then
          
                Frmprincipal.lbltipousuario.Text = "Supervisor"
                Frmprincipal.opsuperv.Visible = True
                Frmprincipal.OpInspec.Visible = False
                Frmprincipal.Optecnico.Visible = False

                Frmprincipal.Label13.Visible = True
                Frmprincipal.Label6.Visible = True
                Frmprincipal.Label7.Visible = True
                Frmprincipal.Label9.Visible = True
                Frmprincipal.picboxusuarios.Visible = True
                Frmprincipal.picboxtrabajadores.Visible = True
                Frmprincipal.picboxaviones2.Visible = True

                Frmprincipal.Label21.Visible = False
                Frmprincipal.Label20.Visible = False
                Frmprincipal.Label31.Visible = False
                Frmprincipal.PictureBox4.Visible = False

                Hide()
            End If
            If dm(5) = "TECNICO" Then
           
                Frmprincipal.lbltipousuario.Text = "Tecnico"

                Frmprincipal.opsuperv.Visible = False
                Frmprincipal.OpInspec.Visible = False
                Frmprincipal.Optecnico.Visible = True

                Frmprincipal.Label13.Visible = False
                Frmprincipal.Label6.Visible = False
                Frmprincipal.Label7.Visible = False
                Frmprincipal.Label9.Visible = False
                Frmprincipal.picboxusuarios.Visible = False
                Frmprincipal.picboxtrabajadores.Visible = False
                Frmprincipal.picboxaviones2.Visible = False

                Frmprincipal.Label21.Visible = True
                Frmprincipal.Label20.Visible = True
                Frmprincipal.Label31.Visible = True
                Frmprincipal.PictureBox4.Visible = True

                Frmprincipal.TrabajadoresToolStripMenuItem1.Visible = False
                Frmprincipal.UsuariosToolStripMenuItem1.Visible = False

                
                Hide()
            End If
            If dm(5) = "INSPECTOR" Then
          
                Frmprincipal.lbltipousuario.Text = "Inspector"

                Frmprincipal.opsuperv.Visible = False
                Frmprincipal.OpInspec.Visible = True
                Frmprincipal.Optecnico.Visible = False

                Frmprincipal.Label13.Visible = False
                Frmprincipal.Label6.Visible = False
                Frmprincipal.Label7.Visible = False
                Frmprincipal.Label9.Visible = False
                Frmprincipal.picboxusuarios.Visible = False
                Frmprincipal.picboxtrabajadores.Visible = False
                Frmprincipal.picboxaviones2.Visible = False

                Frmprincipal.Label21.Visible = True
                Frmprincipal.Label20.Visible = True
                Frmprincipal.Label31.Visible = True
                Frmprincipal.PictureBox4.Visible = True
                Frmprincipal.TrabajadoresToolStripMenuItem1.Visible = False
                Frmprincipal.UsuariosToolStripMenuItem1.Visible = False

                Hide()
            End If

            Frmprincipal.lbl_usu.Text = "Bienvenido:" & vbCr & dm(1)
 
            Frmprincipal.Show()
            txtcontrasena.Text = ""
            txtusuario.Text = ""

        Else
            MsgBox("Usuario desconocido verifique, Por favor", MsgBoxStyle.Critical, "MENSAJE")
            txtusuario.Text = ""
            txtcontrasena.Text = ""
            Exit Sub
        End If

    End Sub

    Private Sub frminicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
