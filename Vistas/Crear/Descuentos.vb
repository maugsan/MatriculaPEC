Public Class Descuentos


    Dim dtableAdapter As New MatriculaPECDataSetTableAdapters.descuentosTableAdapter


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Me.TextBox1.Text <> "" And Me.TextBox2.Text Then

            dtableAdapter.Insert(Me.TextBox1.Text, Me.TextBox2.Text)
            Me.Close()
            Principal.DescuentosTableAdapter.Fill(Principal.MatriculaPECDataSet1.descuentos)
        End If


    End Sub

    Private Sub Descuentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As System.Object,
                                           ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub



End Class