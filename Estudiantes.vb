Public Class Estudiantes

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)



    End Sub




    Dim cache As String = ""


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Me.tfTelefonoResponsable.Text = "" Then
            MsgBox("Required Field")

        End If

        Dim etableAdapter As New MatriculaPECDataSetTableAdapters.alumnosTableAdapter()

        etableAdapter.insertar_alumno(Me.tfCedula.Text, tfNombre.Text, tfApellido1.Text, tfApellido2.Text, tfResponsable.Text, tfTelefonoResponsable.Text, tfTelefono.Text, tfCorreo.Text)





        Form1.AlumnosBindingSource.ResetBindings(False)

        Form1.AlumnosTableAdapter.Fill(Form1.MatriculaPECDataSet.alumnos)

        Form1.DataGridView4.Update()
        Form1.DataGridView4.RefreshEdit()



        Me.Close()

    End Sub


End Class