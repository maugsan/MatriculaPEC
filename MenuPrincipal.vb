﻿Public Class MenuPrincipal




    Public codigoEstudiante As Integer
    Public estudiante As String
    Public banderaEstudiante As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.matriculas' Puede moverla o quitarla según sea necesario.
        Me.MatriculasTableAdapter.Fill(Me.MatriculaPECDataSet.matriculas)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me.MatriculaPECDataSet.profesores)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.MatriculaPECDataSet.pagos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.descuentos' Puede moverla o quitarla según sea necesario.
        Me.DescuentosTableAdapter.Fill(Me.MatriculaPECDataSet.descuentos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.periodos' Puede moverla o quitarla según sea necesario.
        Me.PeriodosTableAdapter.Fill(Me.MatriculaPECDataSet.periodos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.MatriculaPECDataSet.grupos)
        'TODO: esta línea de código carga datos en la tabla 'MatriculaPECDataSet.cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.MatriculaPECDataSet.cursos)

        Me.AlumnosTableAdapter.Fill(Me.MatriculaPECDataSet.alumnos)

        Me.estudiante = "----"
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

    Private Sub ButtonUsuarios_Click(sender As Object, e As EventArgs) Handles ButtonUsuarios.Click
        TabControlPrincipal.SelectTab(9)
    End Sub

    Private Sub ButtonFormas_Click(sender As Object, e As EventArgs) Handles ButtonFormas.Click
        TabControlPrincipal.SelectTab(10)
    End Sub


    Private Sub ButtonMedios_Click(sender As Object, e As EventArgs) Handles ButtonMedios.Click
        TabControlPrincipal.SelectTab(11)
    End Sub


    Private Sub ButtonListas_Click(sender As Object, e As EventArgs) Handles ButtonListas.Click
        TabControlPrincipal.SelectTab(12)
    End Sub


#End Region

#Region " BOTONES RETORNO "
    'boton atras

    Private Sub ButtonRegresar_Click(sender As Object, e As EventArgs) Handles ButtonRegresar.Click
        TabControlPrincipal.SelectTab(0)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click
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



#End Region

#Region " ABRIR VENTANAS "


    Private Sub ButtonMMatricula_Click(sender As Object, e As EventArgs) Handles ButtonMMatricula.Click
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

            etableAdapter.eliminar_alumno(cedula)

            Form1_Load(sender, e)


        End If
    End Sub

#End Region

End Class