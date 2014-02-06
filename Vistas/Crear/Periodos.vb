Public Class Periodos


    Dim ptableAdapter As New MatriculaPECDataSetTableAdapters.periodosTableAdapter

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim nombre As String
        nombre = Me.ComboBox1.Text.Trim & " " & Me.ComboBox2.Text.Trim
        MsgBox(nombre)
        If Not IsNumeric(ptableAdapter.consultar_cod_periodo(nombre)) Then
            ptableAdapter.insertar_periodo(nombre)
        Else
            MsgBox("Este periodo ya existe.")

        End If
        Me.Close()
        Principal.PeriodosTableAdapter.Fill(Principal.MatriculaPECDataSet1.periodos)
    End Sub
End Class