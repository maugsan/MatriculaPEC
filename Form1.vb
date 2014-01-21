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
End Class
