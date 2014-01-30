Public Class Matricula2


    Private mCanceling As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Matricula.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

        Matricula3.Show()
        Matricula3.procesar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

        DataGridViewMatricula2.Rows.Clear()
        DataGridViewMatricula2.Refresh()

    End Sub

    Private Sub Matricula2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.DataTableGruposNombres' Puede moverla o quitarla según sea necesario.
        Me.DataTableGruposNombresTableAdapter.Fill(Me.MatriculaPECDataSet.DataTableGruposNombres)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.MatriculaPECDataSet.grupos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.matriculas' Puede moverla o quitarla según sea necesario.
        Me.MatriculasTableAdapter.Fill(Me.MatriculaPECDataSet.matriculas)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.alumnos_en_grupos' Puede moverla o quitarla según sea necesario.
        Me.Alumnos_en_gruposTableAdapter.Fill(Me.MatriculaPECDataSet.alumnos_en_grupos)

        Dim gtableAdapter As New MatriculaPECDataSetTableAdapters.gruposTableAdapter()

        'ComboBox2.DataBindings = gtableAdapter.seleccionarGruposCombo()
        'ComboBox2.DisplayMember = "x"
        'ComboBox2.ValueMember = "cod_grupo"

        'Dim Customers = gtableAdapter.seleccionarGruposCombo().Trim

        ' For Each Customer In Customers.Split

        'MsgBox(Customer)

        ' Next

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


        Dim encontrado As Boolean
        encontrado = False


        Dim row1 As String() = New String() {Me.ComboBox2.Text, ComboBox3.Text, ComboBox4.Text}

        If (DataGridViewMatricula2.RowCount = 0) Then


            DataGridViewMatricula2.Rows.Add(row1)


        Else
     
            For Each row As DataGridViewRow In DataGridViewMatricula2.Rows


                If Me.ComboBox2.Text.Trim = row.Cells.Item("Grupo").Value.trim Then

                    encontrado = True

                    MsgBox("El grupo seleccionado existe.")

                End If


            Next

            If encontrado = False Then
                DataGridViewMatricula2.Rows.Add(row1)
            End If

        End If

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



    Private Sub FillByGrupoToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.GruposTableAdapter.FillByGrupo(Me.MatriculaPECDataSet.grupos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByGrupoToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.GruposTableAdapter.FillByGrupo(Me.MatriculaPECDataSet.grupos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByGrupoToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.GruposTableAdapter.FillByGrupo(Me.MatriculaPECDataSet.grupos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByGrupoToolStripButton1_Click_1(sender As Object, e As EventArgs)
        Try
            Me.GruposTableAdapter.FillByGrupo(Me.MatriculaPECDataSet.grupos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

 
End Class