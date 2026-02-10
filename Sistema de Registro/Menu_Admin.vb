Imports System.Data.SqlClient

Public Class Menu_Admin

    Private Sub Menu_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userName.Text = EnvioDatos.userName
        'rol.Text = EnvioDatos.rol
    End Sub

    Private Sub AbrirFromEnPanel(ByVal formhijo As Object)
        If Me.Panel2.Controls.Count > 0 Then
            Me.Panel2.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(fh)
        Me.Panel2.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        AbrirFromEnPanel(New Registro_Usuarios)
    End Sub
End Class