Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPageMenu.Click

    End Sub

    Private Sub ButtonMatricula_Click(sender As Object, e As EventArgs) Handles ButtonMatricula.Click
         TabControlPrincipal.SelectTab(1)
    End Sub





    Private Sub ButtonPeriodos_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub ButtonEstudintes_Click(sender As Object, e As EventArgs) Handles ButtonEstudintes.Click
        TabControlPrincipal.SelectTab(4)
    End Sub

    Private Sub ButtonCursos_Click(sender As Object, e As EventArgs) Handles ButtonCursos.Click
        TabControlPrincipal.SelectTab(2)
    End Sub

    Private Sub ButtonGrupos_Click(sender As Object, e As EventArgs) Handles ButtonGrupos.Click
        TabControlPrincipal.SelectTab(3)
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

    Private Sub ButtonRegresar_Click(sender As Object, e As EventArgs) Handles ButtonRegresar.Click
        TabControlPrincipal.SelectTab(0)
    End Sub

    Private Sub TabPageMatricula_Click(sender As Object, e As EventArgs) Handles TabPageMatricula.Click

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

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
End Class
