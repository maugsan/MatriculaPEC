<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estudiantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tfCedula = New System.Windows.Forms.MaskedTextBox()
        Me.tfNombre = New System.Windows.Forms.TextBox()
        Me.tfApellido1 = New System.Windows.Forms.TextBox()
        Me.tfApellido2 = New System.Windows.Forms.TextBox()
        Me.tfTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.tfCorreo = New System.Windows.Forms.TextBox()
        Me.tfTelefonoResponsable = New System.Windows.Forms.MaskedTextBox()
        Me.tfResponsable = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LCedula = New System.Windows.Forms.Label()
        Me.LApellido1 = New System.Windows.Forms.Label()
        Me.LApellido2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(260, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 39)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Crear Estudiante"
        '
        'tfCedula
        '
        Me.tfCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfCedula.Location = New System.Drawing.Point(40, 133)
        Me.tfCedula.Name = "tfCedula"
        Me.tfCedula.Size = New System.Drawing.Size(198, 23)
        Me.tfCedula.TabIndex = 19
        '
        'tfNombre
        '
        Me.tfNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfNombre.Location = New System.Drawing.Point(40, 203)
        Me.tfNombre.Name = "tfNombre"
        Me.tfNombre.Size = New System.Drawing.Size(198, 23)
        Me.tfNombre.TabIndex = 20
        '
        'tfApellido1
        '
        Me.tfApellido1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfApellido1.Location = New System.Drawing.Point(40, 275)
        Me.tfApellido1.Name = "tfApellido1"
        Me.tfApellido1.Size = New System.Drawing.Size(198, 23)
        Me.tfApellido1.TabIndex = 21
        '
        'tfApellido2
        '
        Me.tfApellido2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfApellido2.Location = New System.Drawing.Point(40, 354)
        Me.tfApellido2.Name = "tfApellido2"
        Me.tfApellido2.Size = New System.Drawing.Size(198, 23)
        Me.tfApellido2.TabIndex = 22
        '
        'tfTelefono
        '
        Me.tfTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.tfTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfTelefono.Location = New System.Drawing.Point(302, 203)
        Me.tfTelefono.Name = "tfTelefono"
        Me.tfTelefono.Size = New System.Drawing.Size(198, 23)
        Me.tfTelefono.TabIndex = 23
        '
        'tfCorreo
        '
        Me.tfCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfCorreo.Location = New System.Drawing.Point(300, 133)
        Me.tfCorreo.Name = "tfCorreo"
        Me.tfCorreo.Size = New System.Drawing.Size(200, 23)
        Me.tfCorreo.TabIndex = 24
        '
        'tfTelefonoResponsable
        '
        Me.tfTelefonoResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfTelefonoResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfTelefonoResponsable.Location = New System.Drawing.Point(559, 205)
        Me.tfTelefonoResponsable.Name = "tfTelefonoResponsable"
        Me.tfTelefonoResponsable.Size = New System.Drawing.Size(203, 23)
        Me.tfTelefonoResponsable.TabIndex = 25
        '
        'tfResponsable
        '
        Me.tfResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfResponsable.Location = New System.Drawing.Point(559, 133)
        Me.tfResponsable.Name = "tfResponsable"
        Me.tfResponsable.Size = New System.Drawing.Size(203, 23)
        Me.tfResponsable.TabIndex = 26
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LNombre.Location = New System.Drawing.Point(35, 175)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(99, 25)
        Me.LNombre.TabIndex = 27
        Me.LNombre.Text = "Nombre  *"
        '
        'LCedula
        '
        Me.LCedula.AutoSize = True
        Me.LCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCedula.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LCedula.Location = New System.Drawing.Point(35, 105)
        Me.LCedula.Name = "LCedula"
        Me.LCedula.Size = New System.Drawing.Size(93, 25)
        Me.LCedula.TabIndex = 28
        Me.LCedula.Text = "Cédula  *"
        '
        'LApellido1
        '
        Me.LApellido1.AutoSize = True
        Me.LApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LApellido1.Location = New System.Drawing.Point(37, 247)
        Me.LApellido1.Name = "LApellido1"
        Me.LApellido1.Size = New System.Drawing.Size(161, 25)
        Me.LApellido1.TabIndex = 29
        Me.LApellido1.Text = "Primer Apellido  *"
        '
        'LApellido2
        '
        Me.LApellido2.AutoSize = True
        Me.LApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LApellido2.Location = New System.Drawing.Point(35, 326)
        Me.LApellido2.Name = "LApellido2"
        Me.LApellido2.Size = New System.Drawing.Size(185, 25)
        Me.LApellido2.TabIndex = 30
        Me.LApellido2.Text = "Segundo Apellido  *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(297, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 25)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Teléfono  *"
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LCorreo.Location = New System.Drawing.Point(297, 105)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(90, 25)
        Me.LCorreo.TabIndex = 32
        Me.LCorreo.Text = "Correo  *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(558, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nombre De Responsable"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(554, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Teléfono de Responsable"
        '
        'Button3
        '
        Me.Button3.AllowDrop = True
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(471, 376)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 77)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(638, 376)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 77)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Crear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Estudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 462)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LCorreo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LApellido2)
        Me.Controls.Add(Me.LApellido1)
        Me.Controls.Add(Me.LCedula)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.tfResponsable)
        Me.Controls.Add(Me.tfTelefonoResponsable)
        Me.Controls.Add(Me.tfCorreo)
        Me.Controls.Add(Me.tfTelefono)
        Me.Controls.Add(Me.tfApellido2)
        Me.Controls.Add(Me.tfApellido1)
        Me.Controls.Add(Me.tfNombre)
        Me.Controls.Add(Me.tfCedula)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(820, 500)
        Me.Name = "Estudiantes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Estudiante"
        Me.TopMost = True
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents tfCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tfNombre As System.Windows.Forms.TextBox
    Friend WithEvents tfApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents tfApellido2 As System.Windows.Forms.TextBox
    Public WithEvents tfTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tfCorreo As System.Windows.Forms.TextBox
    Public WithEvents tfTelefonoResponsable As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tfResponsable As System.Windows.Forms.TextBox
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents LCedula As System.Windows.Forms.Label
    Friend WithEvents LApellido1 As System.Windows.Forms.Label
    Friend WithEvents LApellido2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LCorreo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
