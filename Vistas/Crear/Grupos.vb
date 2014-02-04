Public Class Grupos


    Dim gtableAdapter As New MatriculaPECDataSetTableAdapters.gruposTableAdapter

    Dim ctableAdapter As New MatriculaPECDataSetTableAdapters.cursosTableAdapter

    Dim periodotableAdapter As New MatriculaPECDataSetTableAdapters.periodosTableAdapter

    Dim ptableAdapter As New MatriculaPECDataSetTableAdapters.profesoresTableAdapter

    Dim qtableAdapter As New MatriculaPECDataSetTableAdapters.QueriesTableAdapter



    Private Sub Grupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me.MatriculaPECDataSet.profesores)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.periodos' Puede moverla o quitarla según sea necesario.
        Me.PeriodosTableAdapter.Fill(Me.MatriculaPECDataSet.periodos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.MatriculaPECDataSet.cursos)




    End Sub

    Private Sub ButtonMatricula_Click(sender As Object, e As EventArgs) Handles ButtonMatricula.Click




        'Verificar si existe Grupo antes de insertar


        If Not IsNumeric(gtableAdapter.comprobarGrupo(ctableAdapter.buscarCodigoCurso(ComboBox2.Text.Trim), ComboBox1.Text.Trim)) Then



            ' Toma los valores de los combobox de crear grupo y buscar los codigo para insertar
            ' grupo desde el precedimiento almacenado


            qtableAdapter.insertar_grupo(ctableAdapter.buscarCodigoCurso(ComboBox2.Text.Trim), ComboBox1.Text.Trim, periodotableAdapter.consultarCodigoPeriodo(ComboBox3.Text.Trim), 1)

            MatriculaPEC.Principal.GruposTableAdapter.Fill(MatriculaPEC.Principal.MatriculaPECDataSet.grupos)

            '  MenuPrincipal.DataTableGruposNombresTableAdapter.Fill(MenuPrincipal.MatriculaPECDataSet.DataTableGruposNombres)


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