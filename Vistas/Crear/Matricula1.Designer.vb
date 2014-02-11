<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Matricula))
        Me.CrearEstudiante = New System.Windows.Forms.Button()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.Siguiente = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Elegir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LEstudianteSeleccionado = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrearEstudiante
        '
        Me.CrearEstudiante.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.CrearEstudiante.FlatAppearance.BorderSize = 0
        Me.CrearEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CrearEstudiante.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrearEstudiante.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CrearEstudiante.Location = New System.Drawing.Point(71, 187)
        Me.CrearEstudiante.Margin = New System.Windows.Forms.Padding(0)
        Me.CrearEstudiante.Name = "CrearEstudiante"
        Me.CrearEstudiante.Size = New System.Drawing.Size(182, 77)
        Me.CrearEstudiante.TabIndex = 1
        Me.CrearEstudiante.Text = "Crear Estudiante"
        Me.CrearEstudiante.UseVisualStyleBackColor = False
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.AcceptsReturn = True
        Me.TextBoxBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBoxBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscar.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxBuscar.Location = New System.Drawing.Point(359, 207)
        Me.TextBoxBuscar.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBoxBuscar.MaximumSize = New System.Drawing.Size(350, 50)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxBuscar.Size = New System.Drawing.Size(350, 31)
        Me.TextBoxBuscar.TabIndex = 4
        '
        'Siguiente
        '
        Me.Siguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Siguiente.FlatAppearance.BorderSize = 0
        Me.Siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Siguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Siguiente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Siguiente.Location = New System.Drawing.Point(695, 417)
        Me.Siguiente.Margin = New System.Windows.Forms.Padding(0)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(157, 77)
        Me.Siguiente.TabIndex = 7
        Me.Siguiente.Text = "Siguiente"
        Me.Siguiente.UseVisualStyleBackColor = False
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.Gray
        Me.Cancelar.FlatAppearance.BorderSize = 0
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cancelar.Location = New System.Drawing.Point(528, 417)
        Me.Cancelar.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(157, 77)
        Me.Cancelar.TabIndex = 8
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'Elegir
        '
        Me.Elegir.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Elegir.FlatAppearance.BorderSize = 0
        Me.Elegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Elegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elegir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Elegir.Location = New System.Drawing.Point(715, 207)
        Me.Elegir.Margin = New System.Windows.Forms.Padding(0)
        Me.Elegir.Name = "Elegir"
        Me.Elegir.Size = New System.Drawing.Size(64, 31)
        Me.Elegir.TabIndex = 12
        Me.Elegir.Text = "Elegir"
        Me.Elegir.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(221, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(416, 31)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Seleccione o Cree un Estudiante:"
        '
        'LEstudianteSeleccionado
        '
        Me.LEstudianteSeleccionado.BackColor = System.Drawing.Color.Gainsboro
        Me.LEstudianteSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEstudianteSeleccionado.ForeColor = System.Drawing.Color.Gray
        Me.LEstudianteSeleccionado.Image = CType(resources.GetObject("LEstudianteSeleccionado.Image"), System.Drawing.Image)
        Me.LEstudianteSeleccionado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LEstudianteSeleccionado.Location = New System.Drawing.Point(71, 278)
        Me.LEstudianteSeleccionado.Name = "LEstudianteSeleccionado"
        Me.LEstudianteSeleccionado.Size = New System.Drawing.Size(708, 73)
        Me.LEstudianteSeleccionado.TabIndex = 11
        Me.LEstudianteSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 78)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(863, 503)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Elegir)
        Me.Controls.Add(Me.LEstudianteSeleccionado)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Siguiente)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.CrearEstudiante)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Matricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matricular Estudiante - Paso 1"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrearEstudiante As System.Windows.Forms.Button
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Siguiente As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LEstudianteSeleccionado As System.Windows.Forms.Label
    Friend WithEvents Elegir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
