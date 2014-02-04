Public Class Estudiantes


    Private cache As String = ""
    Private etableAdapter As New MatriculaPECDataSetTableAdapters.alumnosTableAdapter()
    Private qtableAdapter As New MatriculaPECDataSetTableAdapters.QueriesTableAdapter()
    Private mCanceling As Boolean = False
    Private Sub Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Button2.Enabled = False
        Me.CancelButton = Button3
        Me.CausesValidation = False
        Button3.CausesValidation = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        mCanceling = True
        Me.Close()
        If Principal.banderaEstudiante = 1 Then
            Matricula.Show()
            Principal.banderaEstudiante = 0
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

  
        If tfCedula.Text.Trim().Length = 0 Or tfNombre.Text.Trim().Length = 0 Or tfApellido1.Text.Trim().Length = 0 Or tfApellido2.Text.Trim().Length = 0 Or tfTelefono.Text.Trim().Length = 0 Or tfCorreo.Text.Trim().Length = 0 Then


            ToolTip1.Show("Debe completar los valores requeridos. (*)", Me.Button2)
            ToolTip1.ToolTipTitle = "IMPORTANTE"
            ToolTip1.UseAnimation = True



        Else



            tfResponsable.Text = "-"
            tfTelefonoResponsable.Text = "0"



            qtableAdapter.insertar_alumno(tfCedula.Text.Trim, tfNombre.Text.Trim, tfApellido1.Text.Trim,
                                             tfApellido2.Text.Trim, tfResponsable.Text.Trim, tfTelefonoResponsable.Text.Trim,
                                             tfTelefono.Text.Trim, tfCorreo.Text.Trim)




            MatriculaPEC.Principal.AlumnosTableAdapter.Fill(MatriculaPEC.Principal.MatriculaPECDataSet.alumnos)

            MatriculaPEC.Principal.estudiante = tfNombre.Text.Trim & " " & tfApellido1.Text.Trim & " " & tfApellido2.Text.Trim & " - " & Me.tfCedula.Text

            If (Principal.banderaEstudiante = 1) Then

                Matricula.Show()

            End If

            Principal.banderaEstudiante = 0


            Me.Close()


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
                x =  CDbl(tfCedula.Text.Trim())
            End If

            If tfCedula.Text.Length > 10 Then

                e.Cancel = True
                ErrorProvider1.SetError(tfCedula,
               "No cumple con el formato.")
                tfCedula.BackColor = Color.LightPink

            End If

            If IsNumeric(etableAdapter.consultar_codigo_estudiante(x)) Then

                e.Cancel = True
                ErrorProvider1.SetError(tfCedula,
               "Ya existe un estudiante registrado con esa cédula.")
                tfCedula.BackColor = Color.LightPink


            End If



            If tfCedula.Text.Trim.Length = 0 Then
                e.Cancel = True
                ErrorProvider1.SetError(tfCedula,
               "Este campo  es requerido.")
                tfCedula.BackColor = Color.LightPink





            End If

            If Not IsNumeric(tfCedula.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfCedula,
               "Debe insertar valores numericos.")
                tfCedula.BackColor = Color.LightPink

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
                tfNombre.BackColor = Color.LightPink


            End If

            If IsNumeric(tfNombre.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfNombre,
               "Debe insertar valores numericos.")
                tfNombre.BackColor = Color.LightPink


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
                tfApellido1.BackColor = Color.LightPink


            End If

            If IsNumeric(tfApellido1.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfApellido1,
               "No debe insertar valores numericos.")
                tfApellido1.BackColor = Color.LightPink


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
                tfApellido2.BackColor = Color.LightPink


            End If

            If IsNumeric(tfApellido2.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfApellido2,
               "No debe insertar valores numericos.")
                tfApellido2.BackColor = Color.LightPink


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
                tfTelefono.BackColor = Color.LightPink


            End If

            If Not IsNumeric(tfTelefono.Text.Trim) Then
                e.Cancel = True
                ErrorProvider1.SetError(tfTelefono,
               "Debe insertar valores numericos.")
                tfTelefono.BackColor = Color.LightPink


            End If

        End If
    End Sub





    'Validado


    Private Sub tfCedula_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfCedula.Validated

        ErrorProvider1.SetError(tfCedula, "")

        Me.Button2.Enabled = True
        tfCedula.BackColor = Color.LightSkyBlue

    End Sub



    Private Sub tfNombre_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfNombre.Validated

        ErrorProvider1.SetError(tfNombre, "")

        tfNombre.BackColor = Color.LightSkyBlue

    End Sub



    Private Sub tfApellido1_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfApellido1.Validated

        ErrorProvider1.SetError(tfApellido1, "")

        tfApellido1.BackColor = Color.LightSkyBlue

    End Sub



    Private Sub tfApellido2_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfApellido2.Validated

        ErrorProvider1.SetError(tfApellido2, "")

        tfApellido2.BackColor = Color.LightSkyBlue

    End Sub


    Private Sub tfTelefono_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfTelefono.Validated

        ErrorProvider1.SetError(tfTelefono, "")

        tfTelefono.BackColor = Color.LightSkyBlue

    End Sub



    Private Sub tfCorreo_Validated(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles tfCorreo.Validated
        ' If all conditions have been met, clear the error provider of errors.
        errorProvider1.SetError(tfCorreo, "")

        tfCorreo.BackColor = Color.LightSkyBlue

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


    Private Sub tfTelefonoResponsable_KeyPress(ByVal sender As System.Object,
                                               ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tfTelefonoResponsable.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub





End Class