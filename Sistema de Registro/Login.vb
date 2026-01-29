Public Class Login
    Private Sub User_Click(sender As Object, e As EventArgs) Handles User.Click
        User.Text = ""
    End Sub

    Private Sub password_Click(sender As Object, e As EventArgs) Handles password.Click
        password.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If User.Text = "admin" And password.Text = "admin123" Then
            Dim Menu_Principal As New Menu_Principal()
            Menu_Principal.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.PerformClick()
        End If
    End Sub
End Class
