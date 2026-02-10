Public Class Menu_Principal
    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userName.Text = EnvioDatos.userName
        rol.Text = EnvioDatos.rol
    End Sub
    Private Sub exite_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub


    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Close()
    End Sub
End Class