Imports System.Data.SqlClient
Public Class Login
    'Conexion a la base de datos SQL Server
    Dim conexionSQL As SqlConnection

    Private Sub User_Click(sender As Object, e As EventArgs) Handles User.Click
        User.Text = ""

    End Sub
    Private Sub password_Click(sender As Object, e As EventArgs) Handles password.Click
        password.Text = ""
    End Sub
    Private Sub User_LostFocus(sender As Object, e As EventArgs) Handles User.LostFocus
        If String.IsNullOrWhiteSpace(User.Text) Then User.Text = "Usuario"
    End Sub

    Private Sub password_LostFocus(sender As Object, e As EventArgs) Handles password.LostFocus
        If String.IsNullOrWhiteSpace(password.Text) Then password.Text = "Contraseña"
    End Sub


    'Evento del botón de inicio de sesión
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(User.Text) Or String.IsNullOrWhiteSpace(password.Text) Then
            MessageBox.Show("Por favor, ingrese usuario y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim usuario As String = User.Text.Trim() '.Trim() elimina espacios en blanco al inicio y al final
        Dim contrasena As String = password.Text.Trim()
        Dim conexionString As String = "server=MSI; database=h_san_jose; integrated security=true" 'Cadena de conexión a la base de datos

        Using conexion As New SqlConnection(conexionString)
            Try
                conexion.Open()
                Dim consulta As String = "SELECT COUNT(*) FROM Usuario Where userName = @userName and password = @password"
                Using comando As New SqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@userName", usuario) 'Envia el parametro de usuario
                    comando.Parameters.AddWithValue("@password", contrasena) 'Envia el parametro de contraseña
                    Dim resultado As Integer = Convert.ToInt32(comando.ExecuteScalar()) 'Ejecuta la consulta y obtiene el resultado

                    If resultado > 0 Then
                        Dim Menu_Principal As New Menu_Principal()
                        Menu_Principal.Show() 'Muestra el formulario del menú principal
                        Me.Hide() 'Oculta el formulario de inicio de sesión
                    Else
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using


    End Sub
End Class
