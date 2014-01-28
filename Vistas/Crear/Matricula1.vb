Public Class Matricula

   
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Siguiente.Click




        Me.Hide()

        Matricula2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Cancelar.Click

        MenuPrincipal.estudiante = "----"
        Me.Close()

    End Sub

    Private Sub ButtonMatricula_Click(sender As Object, e As EventArgs) Handles CrearEstudiante.Click


        MenuPrincipal.banderaEstudiante = 1
        Estudiantes.Show()
        Me.Close()


    End Sub

    Private Sub Matricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TextBoxBuscar.Text = ""


        agregarNombreALabel()


        Dim namesCollection As New AutoCompleteStringCollection()

        Dim etableAdapter As New MatriculaPECDataSetTableAdapters.alumnosTableAdapter()

        TextBoxBuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TextBoxBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource


        For Each alumno As MatriculaPECDataSet.alumnosRow In etableAdapter.GetData


            TextBoxBuscar.AutoCompleteCustomSource.Add(alumno.nombre.Trim & " " & alumno.apellido1.Trim & " " & alumno.apellido2.Trim & " COD " & alumno.cod_alumno)


        Next alumno


    End Sub

    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Elegir.Click


        '    Me.LEstudianteSeleccionado.Text 


        If Me.LEstudianteSeleccionado.Text = "" Then

            Me.Siguiente.Enabled = False
            Me.LEstudianteSeleccionado.Text = "----"


        End If


        If comprobarEstudiante(Me.TextBoxBuscar.Text) Then


            MatriculaPEC.MenuPrincipal.estudiante = Me.TextBoxBuscar.Text
            agregarNombreALabel()



        End If






    End Sub

    Public Sub agregarNombreALabel()


        Me.Siguiente.Enabled = False

        Me.LEstudianteSeleccionado.Text = MatriculaPEC.MenuPrincipal.estudiante
        Me.LEstudianteSeleccionado.Update()



        Me.TextBoxBuscar.Text = ""

        If Me.LEstudianteSeleccionado.Text <> "----" And Me.LEstudianteSeleccionado.Text <> "" Then

            Me.Siguiente.Enabled = True


        End If


    End Sub

    Public Function comprobarEstudiante(ByVal texto As String) As Boolean

        Dim retorno As Boolean

        retorno = False

        If texto <> "" Then

            Dim valor As String
            valor = ""
            Dim TestArray() As String = Split(texto)
            Dim LastNonEmpty As Integer = -1


            For i As Integer = 0 To TestArray.Length - 1
                If TestArray(i) <> "" Then
                    LastNonEmpty += 1
                    TestArray(LastNonEmpty) = TestArray(i)
                    valor = TestArray(LastNonEmpty)
                End If

            Next


            If IsNumeric(valor) Then


                Dim etableAdapter As New MatriculaPECDataSetTableAdapters.alumnosTableAdapter()

                If etableAdapter.comprobarEstudiante(valor) <> "" Then

                    retorno = True


                End If

            End If


        End If


        Return retorno

    End Function

End Class