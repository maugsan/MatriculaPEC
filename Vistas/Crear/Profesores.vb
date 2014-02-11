Public Class Profesores
    Private ptableAdapter As New MatriculaPECDataSetTableAdapters.profesoresTableAdapter()
    Private mCanceling As Boolean = False
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        If Not IsNumeric(ptableAdapter.consultar_cod_profesor(Me.tfCedula.Text)) Then


            ptableAdapter.insertar_profesor(Me.tfCedula.Text, Me.tfNombre.Text, Me.tfApellido1.Text, Me.tfApellido2.Text, Me.tfTelefono.Text, Me.tfCorreo.Text)
            Me.Close()



        Else
            MsgBox("Este profesor ya existe")

        End If


    End Sub



    Private Function ValidEmailAddress(ByVal emailAddress As String, ByRef errorMessage As String) As Boolean

        If tfCorreo.Text.Length = 0 Then
            errorMessage = "El Correo es es requerido."
            Return False

        End If


        If emailAddress.IndexOf("@") > -1 Then
            If (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@")) Then
                errorMessage = ""
                Return True
            End If
        End If

        errorMessage = "El correo debe tener un formato valido." + ControlChars.Cr + _
          "Ejemplo: 'alguien@ejemplo.com' "
        Return False
    End Function



    Private Sub tfCorreo_Validating(ByVal sender As Object, _
    ByVal e As System.ComponentModel.CancelEventArgs) Handles tfCorreo.Validating



        If Not mCanceling Then
            Dim errorMsg As String
            errorMsg = ""
            If Not ValidEmailAddress(tfCorreo.Text, errorMsg) Then

                e.Cancel = True

                tfCorreo.Select(0, tfCorreo.Text.Length)


                Me.ErrorProvider1.SetError(tfCorreo, errorMsg)
                tfCorreo.BackColor = Color.LightPink

            End If
        End If

    End Sub


    Private Sub tfCedula_Validating(ByVal sender As Object, _
ByVal e As System.ComponentModel.CancelEventArgs) Handles tfCedula.Validating

        If Not mCanceling Then

            Dim x As Double

            If tfCedula.Text <> "" Then
                x = CDbl(tfCedula.Text.Trim())
            End If

            If tfCedula.Text.Length > 10 Then

                e.Cancel = True
                ErrorProvider1.SetError(tfCedula,
               "No cumple con el formato.")
                Principal.BorderColor(tfCedula, Color.Red)

            End If

            If IsNumeric(ptableAdapter.consultar_cod_profesor(x)) Then

                e.Cancel = True
                ErrorProvider1.SetError(tfCedula,
               "Ya existe un estudiante registrado con esa cédula.")
                Principal.BorderColor(tfCedula, Color.Red)


            End If



            If tfCedula.Text.Trim.Length = 0 Then
                e.Cancel = True
                ErrorProvider1.SetError(tfCedula,
               "Este campo  es requerido.")
                Principal.BorderColor(tfCedula, Color.Red)





            End If

            If Not IsNumeric(tfCedula.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfCedula,
               "Debe insertar valores numericos.")
                Principal.BorderColor(tfCedula, Color.Red)

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
                Principal.BorderColor(tfNombre, Color.Red)


            End If

            If IsNumeric(tfNombre.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfNombre,
               "Debe insertar valores numericos.")
                Principal.BorderColor(tfNombre, Color.Red)


            End If

        End If
    End Sub




    Private Sub tfApellido1_Validating(ByVal sender As Object, _
ByVal e As System.ComponentModel.CancelEventArgs) Handles tfApellido1.Validating



        If Not mCanceling Then

            If tfApellido1.Text = "" Then
                e.Cancel = True
                ErrorProvider1.SetError(tfApellido1,
               "Este campo  es requerido.")
                Principal.BorderColor(tfApellido1, Color.Red)


            End If

            If IsNumeric(tfApellido1.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfApellido1,
               "No debe insertar valores numericos.")
                Principal.BorderColor(tfApellido1, Color.Red)


            End If

        End If
    End Sub

    Private Sub tfApellido2_Validating(ByVal sender As Object, _
ByVal e As System.ComponentModel.CancelEventArgs) Handles tfApellido2.Validating
        If Not mCanceling Then

            If tfApellido2.Text = "" Then
                e.Cancel = True
                ErrorProvider1.SetError(tfApellido2,
               "Este campo  es requerido.")
                Principal.BorderColor(tfApellido2, Color.Red)


            End If

            If IsNumeric(tfApellido2.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfApellido2,
               "No debe insertar valores numericos.")
                Principal.BorderColor(tfApellido2, Color.Red)


            End If

        End If
    End Sub



    Private Sub tftelefono_Validating(ByVal sender As Object, _
ByVal e As System.ComponentModel.CancelEventArgs) Handles tfTelefono.Validating

        If Not mCanceling Then

            If tfTelefono.Text = "" Then
                e.Cancel = True
                ErrorProvider1.SetError(tfTelefono,
               "Este campo  es requerido.")
                Principal.BorderColor(tfTelefono, Color.Red)


            End If

            If Not IsNumeric(tfTelefono.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfTelefono,
               "Debe insertar valores numericos.")
                Principal.BorderColor(tfTelefono, Color.Red)


            End If

        End If
    End Sub





    'Validado


    Private Sub tfCedula_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfCedula.Validated

        ErrorProvider1.SetError(tfCedula, "")

        Me.Button2.Enabled = True
        Principal.BorderColor(tfCedula, Color.Green)

    End Sub



    Private Sub tfNombre_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfNombre.Validated

        ErrorProvider1.SetError(tfNombre, "")

        Principal.BorderColor(tfNombre, Color.Green)


    End Sub



    Private Sub tfApellido1_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfApellido1.Validated

        ErrorProvider1.SetError(tfApellido1, "")

        Principal.BorderColor(tfApellido1, Color.Green)


    End Sub



    Private Sub tfApellido2_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfApellido2.Validated

        ErrorProvider1.SetError(tfApellido2, "")

        Principal.BorderColor(tfApellido2, Color.Green)


    End Sub


    Private Sub tfTelefono_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfTelefono.Validated

        ErrorProvider1.SetError(tfTelefono, "")

        Principal.BorderColor(tfTelefono, Color.Green)


    End Sub



    Private Sub tfCorreo_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfCorreo.Validated
        ' If all conditions have been met, clear the error provider of errors.
        errorProvider1.SetError(tfCorreo, "")

        Principal.BorderColor(tfCorreo, Color.Green)


    End Sub


    ' Solo numeros en Textbox
    Private Sub tfCedula_KeyPress(ByVal sender As System.Object,
                                  ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tfCedula.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


    Private Sub tfTelefono_KeyPress(ByVal sender As System.Object,
                                    ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tfTelefono.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub





End Class