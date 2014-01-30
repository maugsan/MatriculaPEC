Public Class Grupos


    Dim etableAdapter As New MatriculaPECDataSetTableAdapters.gruposTableAdapter

    Dim ctableAdapter As New MatriculaPECDataSetTableAdapters.cursosTableAdapter

    Dim periodotableAdapter As New MatriculaPECDataSetTableAdapters.periodosTableAdapter

    Dim ptableAdapter As New MatriculaPECDataSetTableAdapters.profesoresTableAdapter

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


        If Not IsNumeric(etableAdapter.comprobarGrupo(ctableAdapter.burcarCodigoCurso(ComboBox2.Text.Trim), ComboBox1.Text.Trim)) Then



            ' Toma los valores de los combobox de crear grupo y buscar los codigo para insertar
            ' grupo desde el precedimiento almacenado


            etableAdapter.insertar_grupo(ctableAdapter.burcarCodigoCurso(ComboBox2.Text.Trim), ComboBox1.Text.Trim, periodotableAdapter.buscarCodigoPeriodo(ComboBox3.Text.Trim), ptableAdapter.buscarCodigoProfesor(ComboBox4.Text.Trim))

            MatriculaPEC.MenuPrincipal.GruposTableAdapter.Fill(MatriculaPEC.MenuPrincipal.MatriculaPECDataSet.grupos)

            MenuPrincipal.DataTableGruposNombresTableAdapter.Fill(MenuPrincipal.MatriculaPECDataSet.DataTableGruposNombres)


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