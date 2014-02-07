Public Class Principal
    'variables globales para realizar Matricula

    Public codigoEstudiante As Integer
    Public estudiante As String
    Public banderaEstudiante As Integer

    'variables globales para filtrar DatagridMatricula

    Private periodoMatricula As String
    Private grupoMatricula As String
    Private estudianteMatricula As String
    Private estadoMatricula As String

    Dim mtableAdapter As New MatriculaPECDataSetTableAdapters.matriculasTableAdapter
    Dim atableAdapter As New MatriculaPECDataSetTableAdapters.alumnosTableAdapter
    Dim gtableAdapter As New MatriculaPECDataSetTableAdapters.gruposTableAdapter


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet1.descuentos' Puede moverla o quitarla según sea necesario.
        Me.DescuentosTableAdapter.Fill(Me.MatriculaPECDataSet1.descuentos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet1.grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.MatriculaPECDataSet1.grupos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet1.alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.MatriculaPECDataSet1.alumnos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet2.profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me.MatriculaPECDataSet2.profesores)

        Me.CursosTableAdapter.Fill(Me.MatriculaPECDataSet1.cursos)

        Me.Formas_de_pagoTableAdapter.Fill(Me.MatriculaPECDataSet1.formas_de_pago)

        Me.PeriodosTableAdapter.Fill(Me.MatriculaPECDataSet1.periodos)

        DataGridView1.DataSource = mtableAdapter.GetData

        Me.estudiante = "----"


        Dim utableAdapter As New MatriculaPECDataSetTableAdapters.usuariosTableAdapter

        ' utableAdapter.Insert("Admin", "Admin", "Admin", "Admin", 1)

    End Sub

    'TABS DEL MENU PRINCIPAL


#Region " TABS "

    Private Sub ButtonMatricula_Click(sender As Object, e As EventArgs) Handles ButtonMatricula.Click
        TabControlPrincipal.SelectTab(1)
    End Sub


    Private Sub ButtonCursos_Click(sender As Object, e As EventArgs) Handles ButtonCursos.Click
        TabControlPrincipal.SelectTab(2)
    End Sub

    Private Sub ButtonGrupos_Click(sender As Object, e As EventArgs) Handles ButtonGrupos.Click
        TabControlPrincipal.SelectTab(3)
    End Sub

    Private Sub ButtonEstudintes_Click(sender As Object, e As EventArgs) Handles ButtonEstudintes.Click
        TabControlPrincipal.SelectTab(4)
    End Sub


    Private Sub ButtonPeriodos_Click_1(sender As Object, e As EventArgs) Handles ButtonPeriodos.Click
        TabControlPrincipal.SelectTab(5)
    End Sub

    Private Sub ButtonDescuentos_Click(sender As Object, e As EventArgs) Handles ButtonDescuentos.Click
        TabControlPrincipal.SelectTab(6)
    End Sub

    Private Sub ButtonPagos_Click(sender As Object, e As EventArgs) Handles ButtonPagos.Click
        TabControlPrincipal.SelectTab(7)
    End Sub

    Private Sub ButtonProfesores_Click(sender As Object, e As EventArgs) Handles ButtonProfesores.Click
        TabControlPrincipal.SelectTab(8)
    End Sub

    Private Sub ButtonUsuarios_Click(sender As Object, e As EventArgs)
        TabControlPrincipal.SelectTab(9)
    End Sub

    Private Sub ButtonFormas_Click(sender As Object, e As EventArgs) Handles ButtonFormas.Click
        TabControlPrincipal.SelectTab(10)
    End Sub


    Private Sub ButtonMedios_Click(sender As Object, e As EventArgs) Handles ButtonMedios.Click
        TabControlPrincipal.SelectTab(11)
    End Sub





    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TabControlPrincipal.SelectTab(12)


    End Sub


    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Matricula.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControlPrincipal.SelectTab(15)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TabControlPrincipal.SelectTab(14)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TabControlPrincipal.SelectTab(13)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControlPrincipal.SelectTab(9)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TabControlPrincipal.SelectTab(16)
    End Sub



#End Region

#Region " BOTONES RETORNO "
    'boton atras

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        TabControlPrincipal.SelectTab(0)
    End Sub


    Private Sub ButtonRegresar_Click(sender As Object, e As EventArgs) Handles ButtonRegresar.Click
        TabControlPrincipal.SelectTab(0)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles ButtonEAtras.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub ButtonPAtras_Click(sender As Object, e As EventArgs) Handles ButtonPAtras.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub ButtonDAtras_Click(sender As Object, e As EventArgs) Handles ButtonDAtras.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub ButtonPaAtras_Click(sender As Object, e As EventArgs) Handles ButtonPaAtras.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub ButtonPrAtras_Click(sender As Object, e As EventArgs) Handles ButtonPrAtras.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub ButtonGAtras_Click(sender As Object, e As EventArgs) Handles ButtonGAtras.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        TabControlPrincipal.SelectTab(0)
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TabControlPrincipal.SelectTab(0)
    End Sub


#End Region

#Region " ABRIR VENTANAS "


    Private Sub ButtonMMatricula_Click(sender As Object, e As EventArgs)
        Dim ventana As New Matricula
        ventana.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ButtonCCursos_Click(sender As Object, e As EventArgs) Handles ButtonCCursos.Click
        Dim ventana As New Cursos
        ventana.Show()
    End Sub

    Private Sub ButtonGGrupos_Click(sender As Object, e As EventArgs) Handles ButtonGGrupos.Click

        Dim ventana As New Grupos
        ventana.Show()
    End Sub

    Private Sub ButtonEEstudiantes_Click(sender As Object, e As EventArgs) Handles ButtonEEstudiantes.Click
        Dim ventana As New Estudiantes
        ventana.Show()
    End Sub



    Private Sub ButtonPPeriodos_Click(sender As Object, e As EventArgs) Handles ButtonPPeriodos.Click
        Dim ventana As New Periodos
        ventana.Show()
    End Sub

    Private Sub ButtonDDescuentos_Click(sender As Object, e As EventArgs) Handles ButtonDDescuentos.Click
        Dim ventana As New Descuentos
        ventana.Show()
    End Sub

    Private Sub ButtonPPagos_Click(sender As Object, e As EventArgs) Handles ButtonPPagos.Click
        Dim ventana As New Pagos
        ventana.Show()
    End Sub

    Private Sub ButtonPProfesores_Click(sender As Object, e As EventArgs) Handles ButtonPProfesores.Click
        Dim ventana As New Profesores

        ventana.Show()
    End Sub

#End Region

#Region " ELIMINAR DATAGRIDS "

    'Eliminar 



    Private Sub DataGridView4_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellClick


        Dim etableAdapter As New MatriculaPECDataSetTableAdapters.alumnosTableAdapter()



        If e.ColumnIndex = 5 Then

            Dim cedula As Int32

            cedula = Convert.ToInt32((DataGridView4.Item(0, e.RowIndex).Value.ToString()))

            atableAdapter.eliminar_alumno(cedula)

            Form1_Load(sender, e)


        End If
    End Sub



    Private Sub DataGridView3_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick




        Dim gtableAdapter As New MatriculaPECDataSetTableAdapters.gruposTableAdapter()


        If e.ColumnIndex = 4 Then



            If e.RowIndex <> -1 Then


                'gtableAdapter.BorrarGrupo(DataGridView3.Item(0, e.RowIndex).Value.ToString().TrimEnd())

            End If

            Form1_Load(sender, e)


        End If



    End Sub


#End Region

    Private Sub TabPageMenu_Click(sender As Object, e As EventArgs) Handles TabPageMenu.Click

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        TabControlPrincipal.SelectTab(9)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub TabPageGrupos_Click(sender As Object, e As EventArgs) Handles TabPageGrupos.Click




    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        periodoMatricula = ComboBox1.Text

        If periodoMatricula <> "" Then
            DataGridView1.DataSource = mtableAdapter.GetDataByMatriculaPorPeriodo(periodoMatricula)

            If gtableAdapter.GetDataByGrupoPorPeriodo(periodoMatricula).Rows.Count <> 0 Then


                ComboBox14.Enabled = True
                ComboBox14.DataSource = gtableAdapter.GetDataByGrupoPorPeriodo(periodoMatricula)
                ComboBox14.DisplayMember = "Curso"


            Else

                ComboBox14.Enabled = False
                ComboBox14.DataSource = Nothing
            End If

        End If



    End Sub



    Private Sub rellenarDataGridMatricula()




    End Sub

    Private Sub TabPageMatricula_Click(sender As Object, e As EventArgs) Handles TabPageMatricula.Click

    End Sub



    Private Sub ComboBox14_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox14.SelectedIndexChanged


        DataGridView1.DataSource = mtableAdapter.GetDataByMatriculaPorPeriodo(periodoMatricula)


    End Sub

    Private Sub TabPagePeriodos_Click(sender As Object, e As EventArgs) Handles TabPagePeriodos.Click

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        Formas.Show()


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub TabPageFormas_Click(sender As Object, e As EventArgs) Handles TabPageFormas.Click

    End Sub



    Public Sub BorderColor(ByRef _Control As Control, ByVal _Color As Color)

        ' Variables para metodos graficos

        Dim g As Graphics = Me.CreateGraphics

        Dim pen As New Pen(_Color, 2.0)



        ' Cambia el borde

        g.DrawRectangle(pen, New Rectangle(_Control.Location, _Control.Size))



        ' Libera los recursos

        pen.Dispose()

        g = Nothing

    End Sub

 


  
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Matricula.Show()

    End Sub


End Class