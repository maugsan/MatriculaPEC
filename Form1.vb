Public Class Menu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim p As Patito = New Patito("HOLA PATITO")
        p.nombreP = "HOLA"




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.matriculas' Puede moverla o quitarla según sea necesario.
        Me.MatriculasTableAdapter.Fill(Me.MatriculaPECDataSet.matriculas)
        'TODO: esta línea de código carga datos en la tabla 'Tablas.matriculas' Puede moverla o quitarla según sea necesario.


    End Sub


    Private Sub SqlConnection1_InfoMessage(sender As Object, e As SqlClient.SqlInfoMessageEventArgs) Handles Conn.InfoMessage

    End Sub

    Private Sub MatriculasBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MatriculasBindingSource.CurrentChanged

    End Sub
End Class
