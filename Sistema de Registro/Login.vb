Imports System.Data.SqlClient
Public Class Login

    Dim conexionSQL As SqlConnection
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSQL = New SqlConnection("server=MSI; database=h_san_jose; integrated security=true")
        Try
            conexionSQL.Open()
            'MessageBox.Show("Conexión exitosa a la base de datos", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexionSQL.Close()
        End Try
    End Sub

    Private Sub User_Click(sender As Object, e As EventArgs) Handles User.Click
        User.Text = ""

    End Sub

    Private Sub password_Click(sender As Object, e As EventArgs) Handles password.Click
        password.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(User.Text) Or String.IsNullOrWhiteSpace(password.Text) Then
            MessageBox.Show("Por favor, ingrese usuario y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If



        If User.Text = "admin" And password.Text = "admin123" Then
            Dim Menu_Principal As New Menu_Principal()
            Menu_Principal.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If String.IsNullOrWhiteSpace(User.Text) Or String.IsNullOrWhiteSpace(password.Text) Then
            MessageBox.Show("Por favor, ingrese usuario y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.PerformClick()
        End If
    End Sub


End Class
