<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cursos))
        Me.LApellido2 = New System.Windows.Forms.Label()
        Me.LApellido1 = New System.Windows.Forms.Label()
        Me.LCedula = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.tfCosto = New System.Windows.Forms.TextBox()
        Me.tfDuracion = New System.Windows.Forms.TextBox()
        Me.tfDescripcion = New System.Windows.Forms.TextBox()
        Me.tfNombre = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MatriculaPECDataSet1 = New MatriculaPEC.MatriculaPECDataSet()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.MatriculaPECDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LApellido2
        '
        Me.LApellido2.AutoSize = True
        Me.LApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LApellido2.Location = New System.Drawing.Point(171, 285)
        Me.LApellido2.Name = "LApellido2"
        Me.LApellido2.Size = New System.Drawing.Size(77, 25)
        Me.LApellido2.TabIndex = 38
        Me.LApellido2.Text = "Costo *"
        '
        'LApellido1
        '
        Me.LApellido1.AutoSize = True
        Me.LApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LApellido1.Location = New System.Drawing.Point(171, 215)
        Me.LApellido1.Name = "LApellido1"
        Me.LApellido1.Size = New System.Drawing.Size(103, 25)
        Me.LApellido1.TabIndex = 37
        Me.LApellido1.Text = "Duración *"
        '
        'LCedula
        '
        Me.LCedula.AutoSize = True
        Me.LCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCedula.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LCedula.Location = New System.Drawing.Point(169, 143)
        Me.LCedula.Name = "LCedula"
        Me.LCedula.Size = New System.Drawing.Size(99, 25)
        Me.LCedula.TabIndex = 36
        Me.LCedula.Text = "Nombre  *"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LNombre.Location = New System.Drawing.Point(404, 143)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(127, 25)
        Me.LNombre.TabIndex = 35
        Me.LNombre.Text = "Descripción *"
        '
        'tfCosto
        '
        Me.tfCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfCosto.Location = New System.Drawing.Point(174, 313)
        Me.tfCosto.Name = "tfCosto"
        Me.tfCosto.Size = New System.Drawing.Size(198, 23)
        Me.tfCosto.TabIndex = 34
        '
        'tfDuracion
        '
        Me.tfDuracion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfDuracion.Location = New System.Drawing.Point(174, 243)
        Me.tfDuracion.Name = "tfDuracion"
        Me.tfDuracion.Size = New System.Drawing.Size(74, 23)
        Me.tfDuracion.TabIndex = 33
        '
        'tfDescripcion
        '
        Me.tfDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfDescripcion.Location = New System.Drawing.Point(409, 171)
        Me.tfDescripcion.Multiline = True
        Me.tfDescripcion.Name = "tfDescripcion"
        Me.tfDescripcion.Size = New System.Drawing.Size(356, 165)
        Me.tfDescripcion.TabIndex = 32
        '
        'tfNombre
        '
        Me.tfNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tfNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfNombre.Location = New System.Drawing.Point(174, 171)
        Me.tfNombre.Name = "tfNombre"
        Me.tfNombre.Size = New System.Drawing.Size(198, 23)
        Me.tfNombre.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(331, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 39)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Crear Curso"
        '
        'Button3
        '
        Me.Button3.AllowDrop = True
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(516, 401)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 77)
        Me.Button3.TabIndex = 41
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
        Me.Button2.Location = New System.Drawing.Point(683, 401)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 77)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Crear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MatriculaPECDataSet1
        '
        Me.MatriculaPECDataSet1.DataSetName = "MatriculaPECDataSet"
        Me.MatriculaPECDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Cursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 503)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LApellido2)
        Me.Controls.Add(Me.LApellido1)
        Me.Controls.Add(Me.LCedula)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.tfCosto)
        Me.Controls.Add(Me.tfDuracion)
        Me.Controls.Add(Me.tfDescripcion)
        Me.Controls.Add(Me.tfNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cursos"
        Me.Text = "Cursos PEC"
        Me.TopMost = True
        CType(Me.MatriculaPECDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LApellido2 As System.Windows.Forms.Label
    Friend WithEvents LApellido1 As System.Windows.Forms.Label
    Friend WithEvents LCedula As System.Windows.Forms.Label
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents tfCosto As System.Windows.Forms.TextBox
    Friend WithEvents tfDuracion As System.Windows.Forms.TextBox
    Friend WithEvents tfDescripcion As System.Windows.Forms.TextBox
    Public WithEvents tfNombre As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MatriculaPECDataSet1 As MatriculaPEC.MatriculaPECDataSet
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
