<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControlPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPageMenu = New System.Windows.Forms.TabPage()
        Me.ComboBoxOpciones = New System.Windows.Forms.ComboBox()
        Me.ButtonUsuarios = New System.Windows.Forms.Button()
        Me.ButtonDescuentos = New System.Windows.Forms.Button()
        Me.ButtonProfesores = New System.Windows.Forms.Button()
        Me.ButtonPeriodos = New System.Windows.Forms.Button()
        Me.ButtonPagos = New System.Windows.Forms.Button()
        Me.ButtonEstudintes = New System.Windows.Forms.Button()
        Me.ButtonGrupos = New System.Windows.Forms.Button()
        Me.ButtonCursos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ButtonMatricula = New System.Windows.Forms.Button()
        Me.TabPageMatricula = New System.Windows.Forms.TabPage()
        Me.TabPageCursos = New System.Windows.Forms.TabPage()
        Me.TabPageGrupos = New System.Windows.Forms.TabPage()
        Me.TabPageEstudiante = New System.Windows.Forms.TabPage()
        Me.TabPagePeriodos = New System.Windows.Forms.TabPage()
        Me.TabPageDescuentos = New System.Windows.Forms.TabPage()
        Me.TabPagePagos = New System.Windows.Forms.TabPage()
        Me.TabPageProfesores = New System.Windows.Forms.TabPage()
        Me.TabPageUsuarios = New System.Windows.Forms.TabPage()
        Me.TabControlPrincipal.SuspendLayout()
        Me.TabPageMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlPrincipal
        '
        Me.TabControlPrincipal.Controls.Add(Me.TabPageMenu)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageMatricula)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageCursos)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageGrupos)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageEstudiante)
        Me.TabControlPrincipal.Controls.Add(Me.TabPagePeriodos)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageDescuentos)
        Me.TabControlPrincipal.Controls.Add(Me.TabPagePagos)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageProfesores)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageUsuarios)
        Me.TabControlPrincipal.ItemSize = New System.Drawing.Size(42, 20)
        Me.TabControlPrincipal.Location = New System.Drawing.Point(-2, 0)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.ShowToolTips = True
        Me.TabControlPrincipal.Size = New System.Drawing.Size(1366, 768)
        Me.TabControlPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControlPrincipal.TabIndex = 0
        '
        'TabPageMenu
        '
        Me.TabPageMenu.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPageMenu.Controls.Add(Me.ComboBoxOpciones)
        Me.TabPageMenu.Controls.Add(Me.ButtonUsuarios)
        Me.TabPageMenu.Controls.Add(Me.ButtonDescuentos)
        Me.TabPageMenu.Controls.Add(Me.ButtonProfesores)
        Me.TabPageMenu.Controls.Add(Me.ButtonPeriodos)
        Me.TabPageMenu.Controls.Add(Me.ButtonPagos)
        Me.TabPageMenu.Controls.Add(Me.ButtonEstudintes)
        Me.TabPageMenu.Controls.Add(Me.ButtonGrupos)
        Me.TabPageMenu.Controls.Add(Me.ButtonCursos)
        Me.TabPageMenu.Controls.Add(Me.Button1)
        Me.TabPageMenu.Controls.Add(Me.TextBoxBuscar)
        Me.TabPageMenu.Controls.Add(Me.ButtonMatricula)
        Me.TabPageMenu.Location = New System.Drawing.Point(4, 24)
        Me.TabPageMenu.Name = "TabPageMenu"
        Me.TabPageMenu.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMenu.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageMenu.TabIndex = 0
        Me.TabPageMenu.Text = "Menu"
        '
        'ComboBoxOpciones
        '
        Me.ComboBoxOpciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxOpciones.IntegralHeight = False
        Me.ComboBoxOpciones.ItemHeight = 13
        Me.ComboBoxOpciones.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBoxOpciones.Location = New System.Drawing.Point(703, 44)
        Me.ComboBoxOpciones.Name = "ComboBoxOpciones"
        Me.ComboBoxOpciones.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxOpciones.TabIndex = 20
        '
        'ButtonUsuarios
        '
        Me.ButtonUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonUsuarios.Location = New System.Drawing.Point(909, 413)
        Me.ButtonUsuarios.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonUsuarios.Name = "ButtonUsuarios"
        Me.ButtonUsuarios.Size = New System.Drawing.Size(221, 77)
        Me.ButtonUsuarios.TabIndex = 19
        Me.ButtonUsuarios.Text = "Usuarios"
        Me.ButtonUsuarios.UseVisualStyleBackColor = False
        '
        'ButtonDescuentos
        '
        Me.ButtonDescuentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDescuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDescuentos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDescuentos.Location = New System.Drawing.Point(909, 293)
        Me.ButtonDescuentos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonDescuentos.Name = "ButtonDescuentos"
        Me.ButtonDescuentos.Size = New System.Drawing.Size(221, 77)
        Me.ButtonDescuentos.TabIndex = 18
        Me.ButtonDescuentos.Text = "Descuentos"
        Me.ButtonDescuentos.UseVisualStyleBackColor = False
        '
        'ButtonProfesores
        '
        Me.ButtonProfesores.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProfesores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProfesores.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonProfesores.Location = New System.Drawing.Point(603, 413)
        Me.ButtonProfesores.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonProfesores.Name = "ButtonProfesores"
        Me.ButtonProfesores.Size = New System.Drawing.Size(221, 77)
        Me.ButtonProfesores.TabIndex = 17
        Me.ButtonProfesores.Text = "Profesores"
        Me.ButtonProfesores.UseVisualStyleBackColor = False
        '
        'ButtonPeriodos
        '
        Me.ButtonPeriodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPeriodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPeriodos.Location = New System.Drawing.Point(603, 293)
        Me.ButtonPeriodos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPeriodos.Name = "ButtonPeriodos"
        Me.ButtonPeriodos.Size = New System.Drawing.Size(221, 77)
        Me.ButtonPeriodos.TabIndex = 16
        Me.ButtonPeriodos.Text = "Periodos"
        Me.ButtonPeriodos.UseVisualStyleBackColor = False
        '
        'ButtonPagos
        '
        Me.ButtonPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPagos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPagos.Location = New System.Drawing.Point(288, 413)
        Me.ButtonPagos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPagos.Name = "ButtonPagos"
        Me.ButtonPagos.Size = New System.Drawing.Size(221, 77)
        Me.ButtonPagos.TabIndex = 15
        Me.ButtonPagos.Text = "Pagos"
        Me.ButtonPagos.UseVisualStyleBackColor = False
        '
        'ButtonEstudintes
        '
        Me.ButtonEstudintes.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonEstudintes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEstudintes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEstudintes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonEstudintes.Location = New System.Drawing.Point(288, 293)
        Me.ButtonEstudintes.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonEstudintes.Name = "ButtonEstudintes"
        Me.ButtonEstudintes.Size = New System.Drawing.Size(221, 77)
        Me.ButtonEstudintes.TabIndex = 14
        Me.ButtonEstudintes.Text = "Estudiantes"
        Me.ButtonEstudintes.UseVisualStyleBackColor = False
        '
        'ButtonGrupos
        '
        Me.ButtonGrupos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGrupos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGrupos.Location = New System.Drawing.Point(909, 168)
        Me.ButtonGrupos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonGrupos.Name = "ButtonGrupos"
        Me.ButtonGrupos.Size = New System.Drawing.Size(221, 77)
        Me.ButtonGrupos.TabIndex = 13
        Me.ButtonGrupos.Text = "Grupos"
        Me.ButtonGrupos.UseVisualStyleBackColor = False
        '
        'ButtonCursos
        '
        Me.ButtonCursos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCursos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCursos.Location = New System.Drawing.Point(603, 168)
        Me.ButtonCursos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonCursos.Name = "ButtonCursos"
        Me.ButtonCursos.Size = New System.Drawing.Size(221, 77)
        Me.ButtonCursos.TabIndex = 12
        Me.ButtonCursos.Text = "Cursos"
        Me.ButtonCursos.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(830, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(476, 36)
        Me.TextBoxBuscar.Multiline = True
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxBuscar.Size = New System.Drawing.Size(222, 32)
        Me.TextBoxBuscar.TabIndex = 2
        '
        'ButtonMatricula
        '
        Me.ButtonMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMatricula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMatricula.Location = New System.Drawing.Point(288, 168)
        Me.ButtonMatricula.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonMatricula.Name = "ButtonMatricula"
        Me.ButtonMatricula.Size = New System.Drawing.Size(221, 77)
        Me.ButtonMatricula.TabIndex = 0
        Me.ButtonMatricula.Text = "Matricula"
        Me.ButtonMatricula.UseVisualStyleBackColor = False
        '
        'TabPageMatricula
        '
        Me.TabPageMatricula.Location = New System.Drawing.Point(4, 24)
        Me.TabPageMatricula.Name = "TabPageMatricula"
        Me.TabPageMatricula.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMatricula.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageMatricula.TabIndex = 1
        Me.TabPageMatricula.Text = "Matricula"
        Me.TabPageMatricula.UseVisualStyleBackColor = True
        '
        'TabPageCursos
        '
        Me.TabPageCursos.Location = New System.Drawing.Point(4, 24)
        Me.TabPageCursos.Name = "TabPageCursos"
        Me.TabPageCursos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCursos.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageCursos.TabIndex = 2
        Me.TabPageCursos.Text = "Cursos"
        Me.TabPageCursos.UseVisualStyleBackColor = True
        '
        'TabPageGrupos
        '
        Me.TabPageGrupos.Location = New System.Drawing.Point(4, 24)
        Me.TabPageGrupos.Name = "TabPageGrupos"
        Me.TabPageGrupos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGrupos.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageGrupos.TabIndex = 3
        Me.TabPageGrupos.Text = "Grupos"
        Me.TabPageGrupos.UseVisualStyleBackColor = True
        '
        'TabPageEstudiante
        '
        Me.TabPageEstudiante.Location = New System.Drawing.Point(4, 24)
        Me.TabPageEstudiante.Name = "TabPageEstudiante"
        Me.TabPageEstudiante.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEstudiante.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageEstudiante.TabIndex = 4
        Me.TabPageEstudiante.Text = "Estudiante"
        Me.TabPageEstudiante.UseVisualStyleBackColor = True
        '
        'TabPagePeriodos
        '
        Me.TabPagePeriodos.Location = New System.Drawing.Point(4, 24)
        Me.TabPagePeriodos.Name = "TabPagePeriodos"
        Me.TabPagePeriodos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePeriodos.Size = New System.Drawing.Size(1358, 740)
        Me.TabPagePeriodos.TabIndex = 5
        Me.TabPagePeriodos.Text = "Periodos"
        Me.TabPagePeriodos.UseVisualStyleBackColor = True
        '
        'TabPageDescuentos
        '
        Me.TabPageDescuentos.Location = New System.Drawing.Point(4, 24)
        Me.TabPageDescuentos.Name = "TabPageDescuentos"
        Me.TabPageDescuentos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDescuentos.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageDescuentos.TabIndex = 6
        Me.TabPageDescuentos.Text = "Descuentos"
        Me.TabPageDescuentos.UseVisualStyleBackColor = True
        '
        'TabPagePagos
        '
        Me.TabPagePagos.Location = New System.Drawing.Point(4, 24)
        Me.TabPagePagos.Name = "TabPagePagos"
        Me.TabPagePagos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePagos.Size = New System.Drawing.Size(1358, 740)
        Me.TabPagePagos.TabIndex = 7
        Me.TabPagePagos.Text = "Pagos"
        Me.TabPagePagos.UseVisualStyleBackColor = True
        '
        'TabPageProfesores
        '
        Me.TabPageProfesores.Location = New System.Drawing.Point(4, 24)
        Me.TabPageProfesores.Name = "TabPageProfesores"
        Me.TabPageProfesores.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageProfesores.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageProfesores.TabIndex = 8
        Me.TabPageProfesores.Text = "Profesores"
        Me.TabPageProfesores.UseVisualStyleBackColor = True
        '
        'TabPageUsuarios
        '
        Me.TabPageUsuarios.Location = New System.Drawing.Point(4, 24)
        Me.TabPageUsuarios.Name = "TabPageUsuarios"
        Me.TabPageUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUsuarios.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageUsuarios.TabIndex = 9
        Me.TabPageUsuarios.Text = "Usuarios"
        Me.TabPageUsuarios.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.TabControlPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Matricula Educación Continua"
        Me.TabControlPrincipal.ResumeLayout(False)
        Me.TabPageMenu.ResumeLayout(False)
        Me.TabPageMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlPrincipal As System.Windows.Forms.TabControl
    Friend WithEvents TabPageMenu As System.Windows.Forms.TabPage
    Friend WithEvents TabPageMatricula As System.Windows.Forms.TabPage
    Friend WithEvents ButtonMatricula As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPageCursos As System.Windows.Forms.TabPage
    Friend WithEvents TabPageGrupos As System.Windows.Forms.TabPage
    Friend WithEvents ButtonCursos As System.Windows.Forms.Button
    Friend WithEvents ButtonUsuarios As System.Windows.Forms.Button
    Friend WithEvents ButtonDescuentos As System.Windows.Forms.Button
    Friend WithEvents ButtonProfesores As System.Windows.Forms.Button
    Friend WithEvents ButtonPeriodos As System.Windows.Forms.Button
    Friend WithEvents ButtonPagos As System.Windows.Forms.Button
    Friend WithEvents ButtonEstudintes As System.Windows.Forms.Button
    Friend WithEvents ButtonGrupos As System.Windows.Forms.Button
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxOpciones As System.Windows.Forms.ComboBox
    Friend WithEvents TabPageEstudiante As System.Windows.Forms.TabPage
    Friend WithEvents TabPagePeriodos As System.Windows.Forms.TabPage
    Friend WithEvents TabPageDescuentos As System.Windows.Forms.TabPage
    Friend WithEvents TabPagePagos As System.Windows.Forms.TabPage
    Friend WithEvents TabPageProfesores As System.Windows.Forms.TabPage
    Friend WithEvents TabPageUsuarios As System.Windows.Forms.TabPage

End Class
