Public Class Grupos

    Private Sub Grupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me.MatriculaPECDataSet.profesores)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.periodos' Puede moverla o quitarla según sea necesario.
        Me.PeriodosTableAdapter.Fill(Me.MatriculaPECDataSet.periodos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.MatriculaPECDataSet.cursos)

    End Sub

    Private Sub ButtonMatricula_Click(sender As Object, e As EventArgs) Handles ButtonMatricula.Click


        Dim etableAdapter As New MatriculaPECDataSetTableAdapters.gruposTableAdapter

        Dim ctableAdapter As New MatriculaPECDataSetTableAdapters.cursosTableAdapter

        Dim periodotableAdapter As New MatriculaPECDataSetTableAdapters.periodosTableAdapter

        Dim ptableAdapter As New MatriculaPECDataSetTableAdapters.profesoresTableAdapter


        ' Toma los valores de los combobox de crear grupo y buscar los codigo para insertar
        ' grupo desde el precedimiento almacenado
        etableAdapter.insertar_grupo(ctableAdapter.burcarCodigoCurso(ComboBox1.Text),
                                     ComboBox2.Text,
                                     periodotableAdapter.buscarCodigoPeriodo(ComboBox3.Text),
                                     ptableAdapter.buscarCodigoProfesor(ComboBox4.Text))


        MatriculaPEC.MenuPrincipal.GruposTableAdapter.Fill(MatriculaPEC.MenuPrincipal.MatriculaPECDataSet.grupos)


        Me.Close()



    End Sub
End Class