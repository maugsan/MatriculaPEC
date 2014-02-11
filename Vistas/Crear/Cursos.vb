Public Class Cursos

    Private mCanceling As Boolean = False
    Private ctableAdapter As New MatriculaPECDataSetTableAdapters.cursosTableAdapter()
    Private Sub Cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ctableAdapter.Insert(Me.tfNombre.Text, Me.tfDuracion.Text, Me.tfDescripcion.Text, Me.tfCosto.Text)

        Me.Close()


    End Sub








    ' VALIDACION ---------------------------------------------------------------


    Private Sub tfDuracion_Validating(ByVal sender As Object, _
ByVal e As System.ComponentModel.CancelEventArgs) Handles tfDuracion.Validating

        If Not mCanceling Then

            Dim x As Double

            If tfDuracion.Text <> "" Then
                x = CDbl(tfDuracion.Text.Trim())
            End If

            If tfDuracion.Text.Length > 10 Then

                e.Cancel = True
                ErrorProvider1.SetError(tfDuracion,
               "No cumple con el formato.")
                Principal.BorderColor(tfDuracion, Color.Red)


            End If





            If tfDuracion.Text.Trim.Length = 0 Then
                e.Cancel = True
                ErrorProvider1.SetError(tfDuracion,
               "Este campo  es requerido.")
                Principal.BorderColor(tfDuracion, Color.Red)



            End If

            If Not IsNumeric(tfDuracion.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfDuracion,
               "Debe insertar valores numericos.")
                Principal.BorderColor(tfDuracion, Color.Red)

            End If

        End If

    End Sub




    Private Sub tfCosto_Validating(ByVal sender As Object, _
ByVal e As System.ComponentModel.CancelEventArgs) Handles tfCosto.Validating

        If Not mCanceling Then

            Dim x As Double

            If tfCosto.Text <> "" Then
                x = CDbl(tfCosto.Text.Trim())
            End If

            If tfCosto.Text.Length > 10 Then

                e.Cancel = True
                ErrorProvider1.SetError(tfCosto,
               "No cumple con el formato.")
                Principal.BorderColor(tfDuracion, Color.Red)

            End If



            If tfCosto.Text.Trim.Length = 0 Then
                e.Cancel = True
                ErrorProvider1.SetError(tfCosto,
               "Este campo  es requerido.")
                Principal.BorderColor(tfDuracion, Color.Red)



            End If

            If Not IsNumeric(tfCosto.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfCosto,
               "Debe insertar valores numericos.")
                Principal.BorderColor(tfDuracion, Color.Red)

            End If

        End If

    End Sub



    Private Sub tfNombre_Validating(ByVal sender As Object, _
    ByVal e As System.ComponentModel.CancelEventArgs) Handles tfNombre.Validating


        If Not mCanceling Then

            If tfNombre.Text = "" Then
                e.Cancel = True
                ErrorProvider1.SetError(tfNombre,
               "Este campo  es requerido.")
                Principal.BorderColor(tfDuracion, Color.Red)


            End If

            If IsNumeric(tfNombre.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfNombre,
               "Debe insertar valores numericos.")
                Principal.BorderColor(tfDuracion, Color.Red)


            End If

        End If
    End Sub



    Private Sub tfDescripcion_Validating(ByVal sender As Object, _
    ByVal e As System.ComponentModel.CancelEventArgs) Handles tfDescripcion.Validating


        If Not mCanceling Then

            If tfDescripcion.Text = "" Then
                e.Cancel = True
                ErrorProvider1.SetError(tfDescripcion,
               "Este campo  es requerido.")
                Principal.BorderColor(tfDuracion, Color.Red)


            End If

            If IsNumeric(tfNombre.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfNombre,
               "Debe insertar valores numericos.")
                Principal.BorderColor(tfDuracion, Color.Red)


            End If

        End If
    End Sub




    'Validado


    Private Sub tfDuracion_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfDuracion.Validated

        ErrorProvider1.SetError(tfDuracion, "")

        Me.Button2.Enabled = True
        Principal.BorderColor(tfDuracion, Color.Green)

    End Sub



    Private Sub tfCosto_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfCosto.Validated

        ErrorProvider1.SetError(tfCosto, "")

        Principal.BorderColor(tfDuracion, Color.Green)

    End Sub



    Private Sub tfDescripcion_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfDescripcion.Validated

        ErrorProvider1.SetError(tfDescripcion, "")

        Principal.BorderColor(tfDuracion, Color.Green)

    End Sub



    Private Sub tfNombre_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfNombre.Validated

        ErrorProvider1.SetError(tfNombre, "")
        Principal.BorderColor(tfDuracion, Color.Green)

    End Sub




    ' Solo numeros en Textbox
    Private Sub tfCosto_KeyPress(ByVal sender As System.Object,
                                  ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tfCosto.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


    Private Sub tfDuracion_KeyPress(ByVal sender As System.Object,
                                    ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tfDuracion.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub




End Class