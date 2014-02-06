Public Class Grupos


    Dim gtableAdapter As New MatriculaPECDataSetTableAdapters.gruposTableAdapter

    Dim ctableAdapter As New MatriculaPECDataSetTableAdapters.cursosTableAdapter

    Dim periodotableAdapter As New MatriculaPECDataSetTableAdapters.periodosTableAdapter

    Dim ptableAdapter As New MatriculaPECDataSetTableAdapters.profesoresTableAdapter


    Private Sub Grupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet1.profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me.MatriculaPECDataSet1.profesores)

        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.profesores' Puede moverla o quitarla según sea necesario.
        '  Me.ProfesoresTableAdapter.Fill(Me.MatriculaPECDataSet.profesores)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.periodos' Puede moverla o quitarla según sea necesario.
        Me.PeriodosTableAdapter.Fill(Me.MatriculaPECDataSet.periodos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.MatriculaPECDataSet.usuarios)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.MatriculaPECDataSet.grupos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.MatriculaPECDataSet.cursos)


        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me.MatriculaPECDataSet.profesores)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.periodos' Puede moverla o quitarla según sea necesario.
        Me.PeriodosTableAdapter.Fill(Me.MatriculaPECDataSet.periodos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.MatriculaPECDataSet.cursos)


        Me.ComboBox1.SelectedItem = 1


    End Sub

    Private Sub ButtonMatricula_Click(sender As Object, e As EventArgs) Handles ButtonMatricula.Click




        'Verificar si existe Grupo antes de insertar


        If IsNothing(gtableAdapter.consultarGrupo(ctableAdapter.consultar_cod_curso(ComboBox2.Text.Trim), ComboBox1.Text.Trim)) Then

            MsgBox(ptableAdapter.consultar_ced_profesor(Me.ComboBox4.Text))

            gtableAdapter.insertar_grupo(ctableAdapter.consultar_cod_curso(ComboBox2.Text.Trim),
            ComboBox1.Text.Trim,
            periodotableAdapter.consultar_cod_periodo(ComboBox3.Text.Trim), ptableAdapter.consultar_ced_profesor(Me.ComboBox4.Text.Trim))
            Principal.GruposTableAdapter.Fill(Principal.MatriculaPECDataSet1.grupos)
            Me.Close()

        Else
            MsgBox("Este Grupo ya existe.")
        End If



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()

    End Sub
End Class