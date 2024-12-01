Imports System.Data.SqlClient

Module Conexao

    Public con As New SqlConnection("server=localhost; userid=root; password=; database=salao; port=;")

    Sub Abrir()
        If con.State = 0 Then
            con.Open()
        End If
    End Sub

    Sub Fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub

End Module
