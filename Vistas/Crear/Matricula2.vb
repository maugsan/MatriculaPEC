Public Class Matricula2

    Dim mtableAdapter As New MatriculaPECDataSetTableAdapters.matriculasTableAdapter
    Dim atableAdapter As New MatriculaPECDataSetTableAdapters.alumnosTableAdapter
    Dim ctableAdapter As New MatriculaPECDataSetTableAdapters.cursosTableAdapter
    Dim gtableAdapter As New MatriculaPECDataSetTableAdapters.gruposTableAdapter


    Private mCanceling As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.borrarDatagridGrupos()
        Me.Hide()
        Matricula.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

        Matricula3.procesar()
        Matricula3.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

        DataGridViewMatricula2.Rows.Clear()
        DataGridViewMatricula2.Refresh()

    End Sub

    Private Sub Matricula2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.descuentos' Puede moverla o quitarla según sea necesario.
        Me.DescuentosTableAdapter.Fill(Me.MatriculaPECDataSet.descuentos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.formas_de_pago' Puede moverla o quitarla según sea necesario.
        Me.Formas_de_pagoTableAdapter.Fill(Me.MatriculaPECDataSet.formas_de_pago)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.periodos' Puede moverla o quitarla según sea necesario.
        Me.PeriodosTableAdapter.Fill(Me.MatriculaPECDataSet.periodos)


        If DataGridViewMatricula2.Rows.Count = 0 Then

            Button2.Enabled = False
        End If


    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim nombreGrupo As String

        Dim nombreCurso() As String

        Dim row1 As String() = New String() {Me.ComboBox2.Text, ComboBox3.Text, ComboBox4.Text}
        Dim encontrado As Boolean


        If Me.ComboBox2.Text <> "" Then


            encontrado = False


            nombreGrupo = Me.ComboBox2.Text.TrimEnd
            nombreCurso = Split(nombreGrupo, " ")

            If (DataGridViewMatricula2.RowCount = 0) Then

                If estaMatriculado(nombreCurso) = False Then

                    DataGridViewMatricula2.Rows.Add(row1)
                    Button2.Enabled = True


                End If

            Else

                For Each row As DataGridViewRow In DataGridViewMatricula2.Rows


                    If estaMatriculado(nombreCurso) = True Then

                        encontrado = True


                    End If

                Next


                For Each row As DataGridViewRow In DataGridViewMatricula2.Rows


                    If row.Cells.Item("Grupo").Value.ToString.TrimEnd = nombreGrupo Then

                        encontrado = True

                        MsgBox("El grupo seleccionado existe.")


                    End If

                Next

                If encontrado = False Then

                    DataGridViewMatricula2.Rows.Add(row1)
                    Button2.Enabled = True

                End If

            End If

        End If
    End Sub


    Private Function obtenerCodigoEstudiante() As String

        Dim valor As String
        valor = ""
        Dim TestArray() As String = Split(Principal.estudiante)
        Dim LastNonEmpty As Integer = -1


        For i As Integer = 0 To TestArray.Length - 1
            If TestArray(i) <> "" Then
                LastNonEmpty += 1
                TestArray(LastNonEmpty) = TestArray(i)
                valor = TestArray(LastNonEmpty)
            End If

        Next
        Return valor
    End Function



    Private Sub ComboBox2_Validating(ByVal sender As Object, _
ByVal e As System.ComponentModel.CancelEventArgs)

        If Not mCanceling Then

            If ComboBox2.Text = "" Then
                e.Cancel = True
                ErrorProvider1.SetError(ComboBox2,
               "Este campo  es requerido.")
                ComboBox2.BackColor = Color.LightPink


            End If



        End If
    End Sub

    Private Sub ComboBox3_Validating(ByVal sender As Object, _
ByVal e As System.ComponentModel.CancelEventArgs)

        If Not mCanceling Then

            If ComboBox3.Text = "" Then
                e.Cancel = True
                ErrorProvider1.SetError(ComboBox3,
               "Este campo  es requerido.")
                ComboBox3.BackColor = Color.LightPink


            End If

        End If
    End Sub


    Private Sub ComboBox4_Validating(ByVal sender As Object, _
ByVal e As System.ComponentModel.CancelEventArgs)

        If Not mCanceling Then

            If ComboBox4.Text = "" Then
                e.Cancel = True
                ErrorProvider1.SetError(ComboBox4,
               "Este campo  es requerido.")
                ComboBox4.BackColor = Color.LightPink


            End If

        End If
    End Sub



#Region " ELIMINAR DATAGRIDS "

    'Eliminar 



    Private Sub DataGridViewMatricula2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewMatricula2.CellClick

        If e.ColumnIndex = 3 Then

            If e.RowIndex <> -1 Then
                DataGridViewMatricula2.Rows.RemoveAt(e.RowIndex)

            End If


        End If


        If DataGridViewMatricula2.Rows.Count = 0 Then

            Button2.Enabled = False

        End If
    End Sub

#End Region


    Private Function estaMatriculado(nombreCurso() As String) As Boolean

        Dim matriculado As Boolean
        Dim codMatricula As Integer
        Dim codCurso As Integer
        Dim codGrupo As Integer
        Dim codEstudiante As Integer


        matriculado = True

        codCurso = ctableAdapter.consultar_cod_curso(nombreCurso(1) & " " & nombreCurso(2))

        codEstudiante = atableAdapter.consultar_cod_estudiante(obtenerCodigoEstudiante)

        MsgBox(gtableAdapter.consultarGrupo(nombreCurso(0).Replace("G", ""), codCurso))

        codGrupo = gtableAdapter.consultarGrupo(nombreCurso(0).Replace("G", ""), codCurso)

        codMatricula = mtableAdapter.consultar_cod_matricula(codGrupo, codEstudiante)


        If codMatricula = 0 Or codMatricula = Nothing Then

            matriculado = False

        Else
            MsgBox("Ya esta matriculado en este grupo.")

        End If


        Return matriculado
    End Function


    Public Function borrarDatagridGrupos() As Integer

        Me.DataGridViewMatricula2.Rows.Clear()

        Return 0

    End Function




    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged



        If gtableAdapter.GetDataByGrupoPorPeriodo(ComboBox1.Text).Rows.Count <> 0 Then


            ComboBox2.Enabled = True
            ComboBox2.DataSource = gtableAdapter.GetDataByGrupoPorPeriodo(ComboBox1.Text)
            ComboBox2.DisplayMember = "Curso"



        Else

            ComboBox2.Enabled = False
            ComboBox2.DataSource = Nothing
        End If


    End Sub
End Class