Imports System.Data.SqlClient

Public Class Menu_Admin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(user.Text) Or String.IsNullOrWhiteSpace(password.Text) Then
            MessageBox.Show("Por favor ingrese el usuario y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nuevoUsuario As String = user.Text.Trim()
        Dim contrasena As String = password.Text.Trim()
        Dim rol As String = "user"

        ' Hasheamos la contraseña ANTES de guardarla
        Dim hashContrasena As String = SeguridadPassword.HashPassword(contrasena)

        Dim conexionString As String = "server=MSI; database=h_san_jose; integrated security=true"

        Dim sqlInsert As String =
            "INSERT INTO Usuario (userName, password, rol) 
             VALUES (@userName, @password, @rol)"

        Using conexion As New SqlConnection(conexionString)
            Try
                conexion.Open()

                Using comando As New SqlCommand(sqlInsert, conexion)
                    comando.Parameters.AddWithValue("@userName", nuevoUsuario)
                    comando.Parameters.AddWithValue("@password", hashContrasena)   ' ← guardamos el HASH, NO la contraseña en texto plano
                    comando.Parameters.AddWithValue("@rol", rol)

                    Dim filasAfectadas As Integer = comando.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Limpieza de campos (mejora UX)
                        user.Clear()
                        password.Clear()
                        user.Focus()
                    Else
                        MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

            Catch ex As SqlException
                If ex.Number = 2627 Or ex.Number = 2601 Then   ' Violación de clave única / duplicado
                    MessageBox.Show("El usuario '" & nuevoUsuario & "' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Error al registrar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error inesperado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class