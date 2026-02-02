Imports BCrypt.Net
Module SeguridadPassword
    Public Function HashPassword(password As String) As String
        ' Genera un hash seguro para la contraseña utilizando BCrypt
        Return BCrypt.Net.BCrypt.HashPassword(password, workFactor:=12)
    End Function

    Public Function VerifyPassword(password As String, hashedPassword As String) As Boolean
        ' Verifica si la contraseña proporcionada coincide con el hash almacenado
        Return BCrypt.Net.BCrypt.Verify(password, hashedPassword)
    End Function
End Module
