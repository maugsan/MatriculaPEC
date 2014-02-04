Public Class Matricula3

    Dim listaCodigos As New List(Of Integer)
    Dim nombreCurso() As String

    Dim total As Double
    Dim subtotal As Double
    Dim costo As Double
    Dim factura As Double
    Dim descuento As Integer
    Dim ctableAdapter As New MatriculaPECDataSetTableAdapters.cursosTableAdapter
    Dim qtableAdapter As New MatriculaPECDataSetTableAdapters.QueriesTableAdapter
    Dim gtableAdapter As New MatriculaPECDataSetTableAdapters.gruposTableAdapter
    Dim mtableAdapter As New MatriculaPECDataSetTableAdapters.matriculasTableAdapter
    Dim dtableAdapter As New MatriculaPECDataSetTableAdapters.descuentosTableAdapter
    Dim etableAdapter As New MatriculaPECDataSetTableAdapters.alumnosTableAdapter
    Dim ftableAdapter As New MatriculaPECDataSetTableAdapters.formas_de_pagoTableAdapter
    Dim destableAdapter As New MatriculaPECDataSetTableAdapters.descuentosTableAdapter

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

        Dim codigoEstudiante As Integer
        Dim codigoDescuento As Integer
        Dim codigoFormaPago As Integer

        Dim valor As String
        valor = ""
        Dim TestArray() As String = Split(Principal.estudiante)
        Dim LastNonEmpty As Integer = -1


        For i As Integer = 0 To TestArray.Length - 1
            If TestArray(i) <> "" Then
                LastNonEmpty += 1
                TestArray(LastNonEmpty) = TestArray(i)
                valor = TestArray(LastNonEmpty)
            End If

        Next

        codigoEstudiante = etableAdapter.consultar_codigo_estudiante(valor)


        For Each codigoGrupo As String In listaCodigos


            qtableAdapter.insertar_matricula(codigoGrupo, codigoEstudiante)
            codigoFormaPago = ftableAdapter.consultarCodigoFormadePago(Matricula2.ComboBox3.Text)
            codigoDescuento = destableAdapter.consultarCodigoDescuento(Matricula2.ComboBox4.Text.TrimEnd)
            qtableAdapter.insertar_factura(codigoEstudiante, mtableAdapter.consultarCodigoMatricula(codigoGrupo, codigoEstudiante), 0, codigoDescuento, codigoFormaPago, total, subtotal, total)

        Next


        Me.Close()
    End Sub


    Public Sub procesar()

        Dim linea As New List(Of String)
        Dim codigoCurso As New Integer
        listaCodigos = New List(Of Integer)


        linea.Add("----------------------------------------------------------")
        linea.Add("SISTEMA DE MATRICULA")
        linea.Add("EDUCACIÓN CONTINÚA")
        linea.Add("UNIVERSIDAD DE COSTA RICA")
        linea.Add("RECINTO DE GUÁPILES")
        linea.Add("----------------------------------------------------------")
        linea.Add("ESTUDIANTE")
        linea.Add(Principal.estudiante)
        linea.Add("----------------------------------------------------------")
        linea.Add("CURSOS")
        For Each row As DataGridViewRow In Matricula2.DataGridViewMatricula2.Rows

            Dim nombreGrupo As String
            nombreGrupo = row.Cells.Item("Grupo").Value.ToString.TrimEnd

            nombreCurso = Split(nombreGrupo, " ")

            codigoCurso = ctableAdapter.buscarCodigoCurso(nombreCurso(1) & " " & nombreCurso(2))


            listaCodigos.Add(CInt(gtableAdapter.consultarCodigoGrupoPorNumeroYCurso(nombreCurso(0).Replace("G", ""), codigoCurso)))


            costo = ctableAdapter.consultarCosto(codigoCurso)
           
            descuento = dtableAdapter.consultarPorcentaje(row.Cells.Item("Descuento").Value.trim)
            subtotal += costo
            total += costo - costo * (descuento / 100)


            linea.Add(nombreGrupo & " - " & row.Cells.Item("Forma").Value.trim & " - ¢" & costo & " - " & descuento & "%")


        Next
        linea.Add("----------------------------------------------------------")
        linea.Add(Date.Now)
        linea.Add("----------------------------------------------------------")
        ListBox1.DataSource = linea

        Label3.Text = "¢" & subtotal
        Label2.Text = "¢" & total

       


    End Sub
End Class