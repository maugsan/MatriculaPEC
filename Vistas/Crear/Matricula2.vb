Public Class Matricula2


    Private mCanceling As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Matricula.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MsgBox(MatriculaPEC.MenuPrincipal.codigoEstudiante)
        Matricula3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

        DataGridViewMatricula2.Rows.Clear()
        DataGridViewMatricula2.Refresh()

    End Sub

    Private Sub Matricula2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If DataGridViewMatricula2.Rows.Count = 0 Then

            Button2.Enabled = False

        End If

        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.MatriculaPECDataSet.grupos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.descuentos' Puede moverla o quitarla según sea necesario.
        Me.DescuentosTableAdapter.Fill(Me.MatriculaPECDataSet.descuentos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.formas_de_pago' Puede moverla o quitarla según sea necesario.
        Me.Formas_de_pagoTableAdapter.Fill(Me.MatriculaPECDataSet.formas_de_pago)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.MatriculaPECDataSet.cursos)

    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        MsgBox(DataGridViewMatricula2.RowCount)



        If (DataGridViewMatricula2.RowCount = 0) Then



            Dim row1 As String() = New String() {Me.ComboBox2.Text, ComboBox3.Text, ComboBox4.Text}
            DataGridViewMatricula2.Rows.Add(row1)




        Else


            For Each row As DataGridViewRow In DataGridViewMatricula2.Rows



                Dim rowindex As String
                If row.Cells.Item("Grupo").Value = "" Then
                    rowindex = row.Index.ToString()


                    MsgBox("2")



                ElseIf row.Cells.Item("GRUPO").Value = ComboBox2.Text Then
                    rowindex = row.Index.ToString()


                    MsgBox("3")

                Else



                    Dim row1 As String() = New String() {ComboBox2.Text, ComboBox3.Text, ComboBox4.Text}
                    DataGridViewMatricula2.Rows.Add(row1)
                    MsgBox("Diferente")


                End If
            Next

        End If






        ' DataGridViewMatricula2.NewRowIndex

        Button2.Enabled = True

    End Sub


    Private Sub ComboBox2_Validating(ByVal sender As Object, _
ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox2.Validating

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
ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox3.Validating

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
ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox4.Validating

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



End Class