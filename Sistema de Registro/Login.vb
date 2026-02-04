Imports System.Data.SqlClient

Public Class Login

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

                Dim consulta As String = "SELECT rol, password FROM Usuario WHERE userName = @userName"

                Using comando As New SqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@userName", usuario) 'Envia el parametro de usuario

                    Using reader As SqlDataReader = comando.ExecuteReader()
                        If reader.Read() Then
                            Dim hashedPassword As String = reader("password").ToString().Trim()
                            ' Verificamos si la contraseña ingresada coincide con el hash almacenado
                            If SeguridadPassword.VerifyPassword(contrasena, hashedPassword) Then
                                'Contraseña verificada correctamente, obtener el rol
                                Dim rol As String = reader("rol").ToString().Trim()
                                'MessageBox.Show("Inicio de sesión exitoso. Rol: " & rol, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                'Envia los datos al módulo EnvioDatos
                                EnvioDatos.rol = rol
                                EnvioDatos.userName = usuario
                                'Abre el formulario correspondiente según el rol
                                Select Case rol.ToLower()
                                    Case "admin", "administrador"
                                        Dim Menu_Admin As New Menu_Admin()
                                        Menu_Admin.Show()
                                    Case "user", "usuario"
                                        Dim Menu_Principal As New Menu_Principal()
                                        Menu_Principal.Show()
                                    Case Else
                                        MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Return
                                End Select
                                Me.Close()
                                'Me.Hide() 'Oculta el formulario de login
                            Else
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class