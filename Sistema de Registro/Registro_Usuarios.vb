Imports System.Data.SqlClient

Public Class Registro_Usuarios
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If String.IsNullOrWhiteSpace(user.Text) Or String.IsNullOrWhiteSpace(password.Text) Then
            MessageBox.Show("Por favor ingrese el usuario y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nuevoUsuario As String = user.Text.Trim()
        Dim contrasena As String = password.Text.Trim()
        If ComboBoxRoles.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor seleccione un rol para el usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim rol As String = ComboBoxRoles.SelectedItem.ToString()
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

    Private Sub Registro_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Opciones de roles predefinidas
        ComboBoxRoles.Items.Add("<Seleccione>")
        ComboBoxRoles.Items.Add("admin")
        ComboBoxRoles.Items.Add("user")
        ComboBoxRoles.Items.Add("Veterinario")
        ComboBoxRoles.SelectedIndex = 0 ' Selecciona el primer rol por defecto
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        user.Clear()
        password.Clear()
        ComboBoxRoles.SelectedIndex = 0
    End Sub
End Class