<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profesores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profesores))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LApellido2 = New System.Windows.Forms.Label()
        Me.LApellido1 = New System.Windows.Forms.Label()
        Me.LCedula = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.tfCorreo = New System.Windows.Forms.TextBox()
        Me.tfTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.tfApellido2 = New System.Windows.Forms.TextBox()
        Me.tfApellido1 = New System.Windows.Forms.TextBox()
        Me.tfNombre = New System.Windows.Forms.TextBox()
        Me.tfCedula = New System.Windows.Forms.MaskedTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Button3
        '
        Me.Button3.AllowDrop = true
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(487, 348)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 77)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = false
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(173,Byte),Integer), CType(CType(215,Byte),Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(654, 348)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 77)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Crear"
        Me.Button2.UseVisualStyleBackColor = false
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = true
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LCorreo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LCorreo.Location = New System.Drawing.Point(313, 77)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(90, 25)
        Me.LCorreo.TabIndex = 50
        Me.LCorreo.Text = "Correo  *"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(313, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 25)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Teléfono  *"
        '
        'LApellido2
        '
        Me.LApellido2.AutoSize = true
        Me.LApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LApellido2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LApellido2.Location = New System.Drawing.Point(51, 298)
        Me.LApellido2.Name = "LApellido2"
        Me.LApellido2.Size = New System.Drawing.Size(185, 25)
        Me.LApellido2.TabIndex = 48
        Me.LApellido2.Text = "Segundo Apellido  *"
        '
        'LApellido1
        '
        Me.LApellido1.AutoSize = true
        Me.LApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LApellido1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LApellido1.Location = New System.Drawing.Point(53, 219)
        Me.LApellido1.Name = "LApellido1"
        Me.LApellido1.Size = New System.Drawing.Size(161, 25)
        Me.LApellido1.TabIndex = 47
        Me.LApellido1.Text = "Primer Apellido  *"
        '
        'LCedula
        '
        Me.LCedula.AutoSize = true
        Me.LCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LCedula.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LCedula.Location = New System.Drawing.Point(51, 77)
        Me.LCedula.Name = "LCedula"
        Me.LCedula.Size = New System.Drawing.Size(93, 25)
        Me.LCedula.TabIndex = 46
        Me.LCedula.Text = "Cédula  *"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = true
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LNombre.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LNombre.Location = New System.Drawing.Point(51, 147)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(99, 25)
        Me.LNombre.TabIndex = 45
        Me.LNombre.Text = "Nombre  *"
        '
        'tfCorreo
        '
        Me.tfCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tfCorreo.Location = New System.Drawing.Point(316, 105)
        Me.tfCorreo.Name = "tfCorreo"
        Me.tfCorreo.Size = New System.Drawing.Size(200, 23)
        Me.tfCorreo.TabIndex = 42
        '
        'tfTelefono
        '
        Me.tfTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.tfTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tfTelefono.Location = New System.Drawing.Point(318, 175)
        Me.tfTelefono.Name = "tfTelefono"
        Me.tfTelefono.Size = New System.Drawing.Size(198, 23)
        Me.tfTelefono.TabIndex = 41
        '
        'tfApellido2
        '
        Me.tfApellido2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tfApellido2.Location = New System.Drawing.Point(56, 326)
        Me.tfApellido2.Name = "tfApellido2"
        Me.tfApellido2.Size = New System.Drawing.Size(198, 23)
        Me.tfApellido2.TabIndex = 40
        '
        'tfApellido1
        '
        Me.tfApellido1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tfApellido1.Location = New System.Drawing.Point(56, 247)
        Me.tfApellido1.Name = "tfApellido1"
        Me.tfApellido1.Size = New System.Drawing.Size(198, 23)
        Me.tfApellido1.TabIndex = 39
        '
        'tfNombre
        '
        Me.tfNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tfNombre.Location = New System.Drawing.Point(56, 175)
        Me.tfNombre.Name = "tfNombre"
        Me.tfNombre.Size = New System.Drawing.Size(198, 23)
        Me.tfNombre.TabIndex = 38
        '
        'tfCedula
        '
        Me.tfCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tfCedula.Location = New System.Drawing.Point(56, 105)
        Me.tfCedula.Name = "tfCedula"
        Me.tfCedula.Size = New System.Drawing.Size(198, 23)
        Me.tfCedula.TabIndex = 37
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Profesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(863, 503)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LCorreo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LApellido2)
        Me.Controls.Add(Me.LApellido1)
        Me.Controls.Add(Me.LCedula)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.tfCorreo)
        Me.Controls.Add(Me.tfTelefono)
        Me.Controls.Add(Me.tfApellido2)
        Me.Controls.Add(Me.tfApellido1)
        Me.Controls.Add(Me.tfNombre)
        Me.Controls.Add(Me.tfCedula)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Profesores"
        Me.Text = "Profesores PEC"
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LCorreo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LApellido2 As System.Windows.Forms.Label
    Friend WithEvents LApellido1 As System.Windows.Forms.Label
    Friend WithEvents LCedula As System.Windows.Forms.Label
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents tfCorreo As System.Windows.Forms.TextBox
    Public WithEvents tfTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tfApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents tfApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents tfNombre As System.Windows.Forms.TextBox
    Public WithEvents tfCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
