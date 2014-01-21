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
        Me.ButtonUsuarios = New System.Windows.Forms.Button()
        Me.ButtonProfesores = New System.Windows.Forms.Button()
        Me.ButtonPagos = New System.Windows.Forms.Button()
        Me.ButtonDescuentos = New System.Windows.Forms.Button()
        Me.ButtonPeriodos = New System.Windows.Forms.Button()
        Me.ButtonEstudinates = New System.Windows.Forms.Button()
        Me.ButtonGrupos = New System.Windows.Forms.Button()
        Me.ButtonCursos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ButtonMatricula = New System.Windows.Forms.Button()
        Me.TabPageMatricula = New System.Windows.Forms.TabPage()
        Me.TabPageCursos = New System.Windows.Forms.TabPage()
        Me.TabPageEstudiante = New System.Windows.Forms.TabPage()
        Me.TabControlPrincipal.SuspendLayout()
        Me.TabPageMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlPrincipal
        '
        Me.TabControlPrincipal.Controls.Add(Me.TabPageMenu)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageMatricula)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageCursos)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageEstudiante)
        Me.TabControlPrincipal.ItemSize = New System.Drawing.Size(42, 20)
        Me.TabControlPrincipal.Location = New System.Drawing.Point(-2, 0)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.ShowToolTips = True
        Me.TabControlPrincipal.Size = New System.Drawing.Size(1158, 638)
        Me.TabControlPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControlPrincipal.TabIndex = 0
        '
        'TabPageMenu
        '
        Me.TabPageMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPageMenu.Controls.Add(Me.ButtonUsuarios)
        Me.TabPageMenu.Controls.Add(Me.ButtonProfesores)
        Me.TabPageMenu.Controls.Add(Me.ButtonPagos)
        Me.TabPageMenu.Controls.Add(Me.ButtonDescuentos)
        Me.TabPageMenu.Controls.Add(Me.ButtonPeriodos)
        Me.TabPageMenu.Controls.Add(Me.ButtonEstudinates)
        Me.TabPageMenu.Controls.Add(Me.ButtonGrupos)
        Me.TabPageMenu.Controls.Add(Me.ButtonCursos)
        Me.TabPageMenu.Controls.Add(Me.Button1)
        Me.TabPageMenu.Controls.Add(Me.TextBoxBuscar)
        Me.TabPageMenu.Controls.Add(Me.ButtonMatricula)
        Me.TabPageMenu.Location = New System.Drawing.Point(4, 24)
        Me.TabPageMenu.Name = "TabPageMenu"
        Me.TabPageMenu.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMenu.Size = New System.Drawing.Size(1150, 610)
        Me.TabPageMenu.TabIndex = 0
        Me.TabPageMenu.Text = "Menu"
        '
        'ButtonUsuarios
        '
        Me.ButtonUsuarios.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUsuarios.Location = New System.Drawing.Point(631, 413)
        Me.ButtonUsuarios.Name = "ButtonUsuarios"
        Me.ButtonUsuarios.Size = New System.Drawing.Size(169, 77)
        Me.ButtonUsuarios.TabIndex = 11
        Me.ButtonUsuarios.Text = "Usuarios"
        Me.ButtonUsuarios.UseVisualStyleBackColor = False
        '
        'ButtonProfesores
        '
        Me.ButtonProfesores.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProfesores.Location = New System.Drawing.Point(338, 413)
        Me.ButtonProfesores.Name = "ButtonProfesores"
        Me.ButtonProfesores.Size = New System.Drawing.Size(169, 77)
        Me.ButtonProfesores.TabIndex = 10
        Me.ButtonProfesores.Text = "Profesores"
        Me.ButtonProfesores.UseVisualStyleBackColor = False
        '
        'ButtonPagos
        '
        Me.ButtonPagos.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPagos.Location = New System.Drawing.Point(40, 413)
        Me.ButtonPagos.Name = "ButtonPagos"
        Me.ButtonPagos.Size = New System.Drawing.Size(169, 77)
        Me.ButtonPagos.TabIndex = 9
        Me.ButtonPagos.Text = "Pagos"
        Me.ButtonPagos.UseVisualStyleBackColor = False
        '
        'ButtonDescuentos
        '
        Me.ButtonDescuentos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDescuentos.Location = New System.Drawing.Point(631, 286)
        Me.ButtonDescuentos.Name = "ButtonDescuentos"
        Me.ButtonDescuentos.Size = New System.Drawing.Size(169, 77)
        Me.ButtonDescuentos.TabIndex = 8
        Me.ButtonDescuentos.Text = "Descuentos"
        Me.ButtonDescuentos.UseVisualStyleBackColor = False
        '
        'ButtonPeriodos
        '
        Me.ButtonPeriodos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPeriodos.Location = New System.Drawing.Point(338, 286)
        Me.ButtonPeriodos.Name = "ButtonPeriodos"
        Me.ButtonPeriodos.Size = New System.Drawing.Size(169, 77)
        Me.ButtonPeriodos.TabIndex = 7
        Me.ButtonPeriodos.Text = "Periodos"
        Me.ButtonPeriodos.UseVisualStyleBackColor = False
        '
        'ButtonEstudinates
        '
        Me.ButtonEstudinates.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonEstudinates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEstudinates.Location = New System.Drawing.Point(40, 286)
        Me.ButtonEstudinates.Name = "ButtonEstudinates"
        Me.ButtonEstudinates.Size = New System.Drawing.Size(169, 77)
        Me.ButtonEstudinates.TabIndex = 6
        Me.ButtonEstudinates.Text = "Estudiantes"
        Me.ButtonEstudinates.UseVisualStyleBackColor = False
        '
        'ButtonGrupos
        '
        Me.ButtonGrupos.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGrupos.Location = New System.Drawing.Point(631, 145)
        Me.ButtonGrupos.Name = "ButtonGrupos"
        Me.ButtonGrupos.Size = New System.Drawing.Size(169, 77)
        Me.ButtonGrupos.TabIndex = 5
        Me.ButtonGrupos.Text = "Grupos"
        Me.ButtonGrupos.UseVisualStyleBackColor = False
        '
        'ButtonCursos
        '
        Me.ButtonCursos.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCursos.Location = New System.Drawing.Point(338, 145)
        Me.ButtonCursos.Name = "ButtonCursos"
        Me.ButtonCursos.Size = New System.Drawing.Size(169, 77)
        Me.ButtonCursos.TabIndex = 4
        Me.ButtonCursos.Text = "Cursos"
        Me.ButtonCursos.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(641, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(413, 51)
        Me.TextBoxBuscar.Multiline = True
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(222, 25)
        Me.TextBoxBuscar.TabIndex = 2
        '
        'ButtonMatricula
        '
        Me.ButtonMatricula.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMatricula.Location = New System.Drawing.Point(40, 145)
        Me.ButtonMatricula.Name = "ButtonMatricula"
        Me.ButtonMatricula.Size = New System.Drawing.Size(169, 77)
        Me.ButtonMatricula.TabIndex = 0
        Me.ButtonMatricula.Text = "Matricula"
        Me.ButtonMatricula.UseVisualStyleBackColor = False
        '
        'TabPageMatricula
        '
        Me.TabPageMatricula.Location = New System.Drawing.Point(4, 24)
        Me.TabPageMatricula.Name = "TabPageMatricula"
        Me.TabPageMatricula.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMatricula.Size = New System.Drawing.Size(1150, 610)
        Me.TabPageMatricula.TabIndex = 1
        Me.TabPageMatricula.Text = "Matricula"
        Me.TabPageMatricula.UseVisualStyleBackColor = True
        '
        'TabPageCursos
        '
        Me.TabPageCursos.Location = New System.Drawing.Point(4, 24)
        Me.TabPageCursos.Name = "TabPageCursos"
        Me.TabPageCursos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCursos.Size = New System.Drawing.Size(1150, 610)
        Me.TabPageCursos.TabIndex = 2
        Me.TabPageCursos.Text = "Cursos"
        Me.TabPageCursos.UseVisualStyleBackColor = True
        '
        'TabPageEstudiante
        '
        Me.TabPageEstudiante.Location = New System.Drawing.Point(4, 24)
        Me.TabPageEstudiante.Name = "TabPageEstudiante"
        Me.TabPageEstudiante.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEstudiante.Size = New System.Drawing.Size(1150, 610)
        Me.TabPageEstudiante.TabIndex = 3
        Me.TabPageEstudiante.Text = "Estudiante"
        Me.TabPageEstudiante.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(872, 580)
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
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonUsuarios As System.Windows.Forms.Button
    Friend WithEvents ButtonProfesores As System.Windows.Forms.Button
    Friend WithEvents ButtonPagos As System.Windows.Forms.Button
    Friend WithEvents ButtonDescuentos As System.Windows.Forms.Button
    Friend WithEvents ButtonPeriodos As System.Windows.Forms.Button
    Friend WithEvents ButtonEstudinates As System.Windows.Forms.Button
    Friend WithEvents ButtonGrupos As System.Windows.Forms.Button
    Friend WithEvents ButtonCursos As System.Windows.Forms.Button
    Friend WithEvents TabPageCursos As System.Windows.Forms.TabPage
    Friend WithEvents TabPageEstudiante As System.Windows.Forms.TabPage

End Class
