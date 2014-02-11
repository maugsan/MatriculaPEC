Public Class Formas


    Dim ftableAdapter As New MatriculaPECDataSetTableAdapters.formas_de_pagoTableAdapter

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim nombre As String
        nombre = Me.TextBox1.Text
        MsgBox(nombre)
        If nombre <> "" Then

            ftableAdapter.insertar_formadepago(nombre)
            Me.Close()

        End If


    End Sub
End Class