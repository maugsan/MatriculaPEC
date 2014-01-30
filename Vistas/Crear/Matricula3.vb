Public Class Matricula3


    Dim linea As New List(Of String)
    Dim nombreCurso() As String
    Dim total As Double
    Dim subtotal As Double
    Dim costo As Double
    Dim factura As Double
    Dim descuento As Integer
    Dim ctableAdapter As New MatriculaPECDataSetTableAdapters.cursosTableAdapter
    Dim dtableAdapter As New MatriculaPECDataSetTableAdapters.descuentosTableAdapter
    Private Sub Matricula3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.total = 0
        Me.subtotal = 0

        Me.Hide()
        Matricula2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click





        Me.Close()
    End Sub


    Public Sub procesar()

        linea.Add("----------------------------------------------------------")
        linea.Add("SISTEMA DE MATRICULA")
        linea.Add("EDUCACIÓN CONTINÚA")
        linea.Add("UNIVERSIDAD DE COSTA RICA")
        linea.Add("RECINTO DE GUÁPILES")
        linea.Add("----------------------------------------------------------")
        linea.Add("ESTUDIANTE")
        linea.Add(MenuPrincipal.estudiante)
        linea.Add("----------------------------------------------------------")
        linea.Add("CURSOS")
        For Each row As DataGridViewRow In Matricula2.DataGridViewMatricula2.Rows

            Dim nombreGrupo As String
            nombreGrupo = row.Cells.Item("Grupo").Value.ToString.TrimEnd

            nombreCurso = Split(nombreGrupo, " ")

            costo = ctableAdapter.consultarCosto(ctableAdapter.burcarCodigoCurso(nombreCurso(3) & " " & nombreCurso(4)))
           
            descuento = dtableAdapter.consultarPorcentaje(row.Cells.Item("Descuento").Value.trim)
            subtotal += costo
            total += costo - costo * (3 / 100)


            linea.Add(nombreGrupo & " - " & row.Cells.Item("Forma").Value.trim & " - ¢" & costo & " - " & descuento & "%")




        Next
        linea.Add("----------------------------------------------------------")
        linea.Add(DateTime.Now)
        linea.Add("----------------------------------------------------------")
        ListBox1.DataSource = linea

        Label3.Text = "¢" & subtotal
        Label2.Text = "¢" & total

       


    End Sub
End Class