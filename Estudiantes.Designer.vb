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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estudiantes))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 78)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
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
        Me.tfCedula.Location = New System.Drawing.Point(56, 144)
        Me.tfCedula.Mask = "000000000000000"
        Me.tfCedula.Name = "tfCedula"
        Me.tfCedula.Size = New System.Drawing.Size(100, 20)
        Me.tfCedula.TabIndex = 19
        '
        'tfNombre
        '
        Me.tfNombre.Location = New System.Drawing.Point(56, 197)
        Me.tfNombre.Name = "tfNombre"
        Me.tfNombre.Size = New System.Drawing.Size(136, 20)
        Me.tfNombre.TabIndex = 20
        '
        'tfApellido1
        '
        Me.tfApellido1.Location = New System.Drawing.Point(56, 251)
        Me.tfApellido1.Name = "tfApellido1"
        Me.tfApellido1.Size = New System.Drawing.Size(136, 20)
        Me.tfApellido1.TabIndex = 21
        '
        'tfApellido2
        '
        Me.tfApellido2.Location = New System.Drawing.Point(56, 307)
        Me.tfApellido2.Name = "tfApellido2"
        Me.tfApellido2.Size = New System.Drawing.Size(136, 20)
        Me.tfApellido2.TabIndex = 22
        '
        'tfTelefono
        '
        Me.tfTelefono.Location = New System.Drawing.Point(56, 359)
        Me.tfTelefono.Mask = "00000000"
        Me.tfTelefono.Name = "tfTelefono"
        Me.tfTelefono.Size = New System.Drawing.Size(100, 20)
        Me.tfTelefono.TabIndex = 23
        '
        'tfCorreo
        '
        Me.tfCorreo.Location = New System.Drawing.Point(56, 405)
        Me.tfCorreo.Name = "tfCorreo"
        Me.tfCorreo.Size = New System.Drawing.Size(136, 20)
        Me.tfCorreo.TabIndex = 24
        '
        'tfTelefonoResponsable
        '
        Me.tfTelefonoResponsable.Location = New System.Drawing.Point(286, 272)
        Me.tfTelefonoResponsable.Mask = "00000000"
        Me.tfTelefonoResponsable.Name = "tfTelefonoResponsable"
        Me.tfTelefonoResponsable.Size = New System.Drawing.Size(100, 20)
        Me.tfTelefonoResponsable.TabIndex = 25
        '
        'tfResponsable
        '
        Me.tfResponsable.Location = New System.Drawing.Point(286, 224)
        Me.tfResponsable.Name = "tfResponsable"
        Me.tfResponsable.Size = New System.Drawing.Size(136, 20)
        Me.tfResponsable.TabIndex = 26
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LNombre.Location = New System.Drawing.Point(53, 177)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 27
        Me.LNombre.Text = "Nombre"
        '
        'LCedula
        '
        Me.LCedula.AutoSize = True
        Me.LCedula.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LCedula.Location = New System.Drawing.Point(53, 122)
        Me.LCedula.Name = "LCedula"
        Me.LCedula.Size = New System.Drawing.Size(40, 13)
        Me.LCedula.TabIndex = 28
        Me.LCedula.Text = "Cédula"
        '
        'LApellido1
        '
        Me.LApellido1.AutoSize = True
        Me.LApellido1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LApellido1.Location = New System.Drawing.Point(53, 231)
        Me.LApellido1.Name = "LApellido1"
        Me.LApellido1.Size = New System.Drawing.Size(76, 13)
        Me.LApellido1.TabIndex = 29
        Me.LApellido1.Text = "Primer Apellido"
        '
        'LApellido2
        '
        Me.LApellido2.AutoSize = True
        Me.LApellido2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LApellido2.Location = New System.Drawing.Point(53, 286)
        Me.LApellido2.Name = "LApellido2"
        Me.LApellido2.Size = New System.Drawing.Size(90, 13)
        Me.LApellido2.TabIndex = 30
        Me.LApellido2.Text = "Segundo Apellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(53, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Telefono"
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LCorreo.Location = New System.Drawing.Point(58, 389)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(38, 13)
        Me.LCorreo.TabIndex = 32
        Me.LCorreo.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(283, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nombre De Responsable"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(283, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Telefono"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(449, 358)
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
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(616, 358)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 77)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Crear"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Estudiantes"
        Me.Text = "Estudiantes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
End Class
