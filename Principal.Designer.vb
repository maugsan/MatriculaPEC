<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControlPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPageMenu = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonMedios = New System.Windows.Forms.Button()
        Me.ButtonFormas = New System.Windows.Forms.Button()
        Me.ComboBoxOpciones = New System.Windows.Forms.ComboBox()
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
        Me.ComboBox15 = New System.Windows.Forms.ComboBox()
        Me.ComboBox14 = New System.Windows.Forms.ComboBox()
        Me.ComboBox13 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
     
        Me.MatriculaPECDataSet = New MatriculaPEC.MatriculaPECDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonMMatricula = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MatriculasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ButtonRegresar = New System.Windows.Forms.Button()
        Me.TabPageCursos = New System.Windows.Forms.TabPage()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonCCursos = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabPageGrupos = New System.Windows.Forms.TabPage()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonGGrupos = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarGrupos = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataTableGruposNombresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonGAtras = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TabPageEstudiante = New System.Windows.Forms.TabPage()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonEEstudiantes = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarEstudiantes = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonEAtras = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TabPagePeriodos = New System.Windows.Forms.TabPage()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonPPeriodos = New System.Windows.Forms.Button()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarPeriodo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonPAtras = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TabPageDescuentos = New System.Windows.Forms.TabPage()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonDDescuentos = New System.Windows.Forms.Button()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarDescuento = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DescuentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ButtonDAtras = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TabPagePagos = New System.Windows.Forms.TabPage()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonPPagos = New System.Windows.Forms.Button()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodmediopagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarPago = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ButtonPaAtras = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TabPageProfesores = New System.Windows.Forms.TabPage()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ButtonPProfesores = New System.Windows.Forms.Button()
        Me.DataGridView8 = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarProfesor = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProfesoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ButtonPrAtras = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TabPageUsuarios = New System.Windows.Forms.TabPage()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.TabPageMedios = New System.Windows.Forms.TabPage()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.TabPageFormas = New System.Windows.Forms.TabPage()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.PictureBox24 = New System.Windows.Forms.PictureBox()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.TabPageListas = New System.Windows.Forms.TabPage()
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.MatriculasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FKmatriculacodg1DE57479BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatriculaPECDataSet1 = New MatriculaPEC.MatriculaPECDataSet()
        Me.AlumnosTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.alumnosTableAdapter()
        Me.CursosTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.cursosTableAdapter()
        Me.GruposTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.gruposTableAdapter()
        Me.PeriodosTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.periodosTableAdapter()
        Me.DescuentosTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.descuentosTableAdapter()
        Me.PagosTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.pagosTableAdapter()
        Me.ProfesoresTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.profesoresTableAdapter()
        Me.MatriculasTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.matriculasTableAdapter()

        Me.MatriculasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodmatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodgrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEstudianteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabControlPrincipal.SuspendLayout()
        Me.TabPageMenu.SuspendLayout()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMatricula.SuspendLayout()
        CType(Me.MatriculaPECDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCursos.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageGrupos.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableGruposNombresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageEstudiante.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePeriodos.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDescuentos.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePagos.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageProfesores.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageUsuarios.SuspendLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMedios.SuspendLayout()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageFormas.SuspendLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageListas.SuspendLayout()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKmatriculacodg1DE57479BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculaPECDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControlPrincipal.Controls.Add(Me.TabPageMedios)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageFormas)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageListas)
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
        Me.TabPageMenu.AutoScroll = True
        Me.TabPageMenu.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPageMenu.Controls.Add(Me.Button4)
        Me.TabPageMenu.Controls.Add(Me.Button15)
        Me.TabPageMenu.Controls.Add(Me.Button3)
        Me.TabPageMenu.Controls.Add(Me.PictureBox21)
        Me.TabPageMenu.Controls.Add(Me.Button2)
        Me.TabPageMenu.Controls.Add(Me.PictureBox2)
        Me.TabPageMenu.Controls.Add(Me.ButtonMedios)
        Me.TabPageMenu.Controls.Add(Me.ButtonFormas)
        Me.TabPageMenu.Controls.Add(Me.ComboBoxOpciones)
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
        Me.TabPageMenu.Padding = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.TabPageMenu.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageMenu.TabIndex = 0
        Me.TabPageMenu.Text = "Menu"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Image = Global.MatriculaPEC.My.Resources.Resources.User_Profile1
        Me.Button4.Location = New System.Drawing.Point(869, 410)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 150)
        Me.Button4.TabIndex = 31
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button15.Image = Global.MatriculaPEC.My.Resources.Resources.Help1
        Me.Button15.Location = New System.Drawing.Point(1031, 458)
        Me.Button15.Margin = New System.Windows.Forms.Padding(0)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(150, 102)
        Me.Button15.TabIndex = 30
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Image = Global.MatriculaPEC.My.Resources.Resources.Settings_021
        Me.Button3.Location = New System.Drawing.Point(1031, 186)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 150)
        Me.Button3.TabIndex = 23
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox21
        '
        Me.PictureBox21.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox21.Location = New System.Drawing.Point(1071, 39)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox21.TabIndex = 28
        Me.PictureBox21.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(1031, 349)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 96)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Listas"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox2.Location = New System.Drawing.Point(83, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'ButtonMedios
        '
        Me.ButtonMedios.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonMedios.FlatAppearance.BorderSize = 0
        Me.ButtonMedios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMedios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMedios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMedios.Location = New System.Drawing.Point(405, 410)
        Me.ButtonMedios.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonMedios.Name = "ButtonMedios"
        Me.ButtonMedios.Size = New System.Drawing.Size(150, 150)
        Me.ButtonMedios.TabIndex = 22
        Me.ButtonMedios.Text = "Medios"
        Me.ButtonMedios.UseVisualStyleBackColor = False
        '
        'ButtonFormas
        '
        Me.ButtonFormas.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonFormas.FlatAppearance.BorderSize = 0
        Me.ButtonFormas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFormas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFormas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonFormas.Location = New System.Drawing.Point(244, 410)
        Me.ButtonFormas.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonFormas.Name = "ButtonFormas"
        Me.ButtonFormas.Size = New System.Drawing.Size(150, 150)
        Me.ButtonFormas.TabIndex = 21
        Me.ButtonFormas.Text = "Formas"
        Me.ButtonFormas.UseVisualStyleBackColor = False
        '
        'ComboBoxOpciones
        '
        Me.ComboBoxOpciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxOpciones.IntegralHeight = False
        Me.ComboBoxOpciones.ItemHeight = 24
        Me.ComboBoxOpciones.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBoxOpciones.Location = New System.Drawing.Point(666, 71)
        Me.ComboBoxOpciones.Name = "ComboBoxOpciones"
        Me.ComboBoxOpciones.Size = New System.Drawing.Size(152, 32)
        Me.ComboBoxOpciones.TabIndex = 20
        '
        'ButtonDescuentos
        '
        Me.ButtonDescuentos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonDescuentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonDescuentos.FlatAppearance.BorderSize = 0
        Me.ButtonDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDescuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDescuentos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDescuentos.Location = New System.Drawing.Point(636, 299)
        Me.ButtonDescuentos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonDescuentos.Name = "ButtonDescuentos"
        Me.ButtonDescuentos.Size = New System.Drawing.Size(221, 100)
        Me.ButtonDescuentos.TabIndex = 18
        Me.ButtonDescuentos.Text = "Descuentos"
        Me.ButtonDescuentos.UseVisualStyleBackColor = False
        '
        'ButtonProfesores
        '
        Me.ButtonProfesores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonProfesores.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonProfesores.FlatAppearance.BorderSize = 0
        Me.ButtonProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProfesores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProfesores.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonProfesores.Location = New System.Drawing.Point(566, 410)
        Me.ButtonProfesores.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonProfesores.Name = "ButtonProfesores"
        Me.ButtonProfesores.Size = New System.Drawing.Size(291, 150)
        Me.ButtonProfesores.TabIndex = 17
        Me.ButtonProfesores.Text = "Profesores"
        Me.ButtonProfesores.UseVisualStyleBackColor = False
        '
        'ButtonPeriodos
        '
        Me.ButtonPeriodos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonPeriodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonPeriodos.FlatAppearance.BorderSize = 0
        Me.ButtonPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPeriodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPeriodos.Location = New System.Drawing.Point(405, 299)
        Me.ButtonPeriodos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPeriodos.Name = "ButtonPeriodos"
        Me.ButtonPeriodos.Size = New System.Drawing.Size(220, 100)
        Me.ButtonPeriodos.TabIndex = 16
        Me.ButtonPeriodos.Text = "Periodos"
        Me.ButtonPeriodos.UseVisualStyleBackColor = False
        '
        'ButtonPagos
        '
        Me.ButtonPagos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonPagos.FlatAppearance.BorderSize = 0
        Me.ButtonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPagos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPagos.Location = New System.Drawing.Point(83, 410)
        Me.ButtonPagos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPagos.Name = "ButtonPagos"
        Me.ButtonPagos.Size = New System.Drawing.Size(150, 150)
        Me.ButtonPagos.TabIndex = 15
        Me.ButtonPagos.Text = "Pagos"
        Me.ButtonPagos.UseVisualStyleBackColor = False
        '
        'ButtonEstudintes
        '
        Me.ButtonEstudintes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonEstudintes.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonEstudintes.FlatAppearance.BorderSize = 0
        Me.ButtonEstudintes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEstudintes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEstudintes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonEstudintes.Location = New System.Drawing.Point(869, 186)
        Me.ButtonEstudintes.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonEstudintes.Name = "ButtonEstudintes"
        Me.ButtonEstudintes.Size = New System.Drawing.Size(150, 213)
        Me.ButtonEstudintes.TabIndex = 14
        Me.ButtonEstudintes.Text = "Estudiantes"
        Me.ButtonEstudintes.UseVisualStyleBackColor = False
        '
        'ButtonGrupos
        '
        Me.ButtonGrupos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonGrupos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonGrupos.FlatAppearance.BorderSize = 0
        Me.ButtonGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGrupos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGrupos.Location = New System.Drawing.Point(636, 186)
        Me.ButtonGrupos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonGrupos.Name = "ButtonGrupos"
        Me.ButtonGrupos.Size = New System.Drawing.Size(221, 100)
        Me.ButtonGrupos.TabIndex = 13
        Me.ButtonGrupos.Text = "Grupos"
        Me.ButtonGrupos.UseVisualStyleBackColor = False
        '
        'ButtonCursos
        '
        Me.ButtonCursos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonCursos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonCursos.FlatAppearance.BorderSize = 0
        Me.ButtonCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCursos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCursos.Location = New System.Drawing.Point(405, 186)
        Me.ButtonCursos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonCursos.Name = "ButtonCursos"
        Me.ButtonCursos.Size = New System.Drawing.Size(220, 100)
        Me.ButtonCursos.TabIndex = 12
        Me.ButtonCursos.Text = "Cursos"
        Me.ButtonCursos.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button1.Location = New System.Drawing.Point(824, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscar.Location = New System.Drawing.Point(437, 72)
        Me.TextBoxBuscar.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxBuscar.Size = New System.Drawing.Size(227, 31)
        Me.TextBoxBuscar.TabIndex = 2
        '
        'ButtonMatricula
        '
        Me.ButtonMatricula.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonMatricula.BackColor = System.Drawing.Color.PowderBlue
        Me.ButtonMatricula.FlatAppearance.BorderSize = 0
        Me.ButtonMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMatricula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMatricula.Location = New System.Drawing.Point(83, 186)
        Me.ButtonMatricula.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonMatricula.Name = "ButtonMatricula"
        Me.ButtonMatricula.Size = New System.Drawing.Size(311, 213)
        Me.ButtonMatricula.TabIndex = 0
        Me.ButtonMatricula.Text = "Matriculas"
        Me.ButtonMatricula.UseVisualStyleBackColor = False
        '
        'TabPageMatricula
        '
        Me.TabPageMatricula.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPageMatricula.Controls.Add(Me.ComboBox15)
        Me.TabPageMatricula.Controls.Add(Me.ComboBox14)
        Me.TabPageMatricula.Controls.Add(Me.ComboBox13)
        Me.TabPageMatricula.Controls.Add(Me.ComboBox1)
        Me.TabPageMatricula.Controls.Add(Me.PictureBox1)
        Me.TabPageMatricula.Controls.Add(Me.PictureBox3)
        Me.TabPageMatricula.Controls.Add(Me.TextBox1)
        Me.TabPageMatricula.Controls.Add(Me.Label2)
        Me.TabPageMatricula.Controls.Add(Me.ButtonMMatricula)
        Me.TabPageMatricula.Controls.Add(Me.DataGridView1)
        Me.TabPageMatricula.Controls.Add(Me.Label1)
        Me.TabPageMatricula.Controls.Add(Me.Button5)
        Me.TabPageMatricula.Controls.Add(Me.ButtonRegresar)
        Me.TabPageMatricula.Location = New System.Drawing.Point(4, 24)
        Me.TabPageMatricula.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPageMatricula.Name = "TabPageMatricula"
        Me.TabPageMatricula.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMatricula.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageMatricula.TabIndex = 1
        Me.TabPageMatricula.Text = "Matricula"
        '
        'ComboBox15
        '
        Me.ComboBox15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox15.IntegralHeight = False
        Me.ComboBox15.ItemHeight = 24
        Me.ComboBox15.Location = New System.Drawing.Point(502, 337)
        Me.ComboBox15.Name = "ComboBox15"
        Me.ComboBox15.Size = New System.Drawing.Size(262, 32)
        Me.ComboBox15.TabIndex = 37
        '
        'ComboBox14
        '
        Me.ComboBox14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox14.IntegralHeight = False
        Me.ComboBox14.ItemHeight = 24
        Me.ComboBox14.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox14.Location = New System.Drawing.Point(91, 337)
        Me.ComboBox14.Name = "ComboBox14"
        Me.ComboBox14.Size = New System.Drawing.Size(262, 32)
        Me.ComboBox14.TabIndex = 36
        '
        'ComboBox13
        '
        Me.ComboBox13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox13.IntegralHeight = False
        Me.ComboBox13.ItemHeight = 24
        Me.ComboBox13.Location = New System.Drawing.Point(502, 290)
        Me.ComboBox13.Name = "ComboBox13"
        Me.ComboBox13.Size = New System.Drawing.Size(262, 32)
        Me.ComboBox13.TabIndex = 35
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.No
        '        Me.ComboBox1.DataSource = Me.PeriodosBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.DropDownHeight = 200
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.ItemHeight = 24
        Me.ComboBox1.Location = New System.Drawing.Point(91, 290)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(262, 32)
        Me.ComboBox1.TabIndex = 34
        Me.ComboBox1.ValueMember = "cod_periodo"
        '
        'PeriodosBindingSource
        '
        '        Me.PeriodosBindingSource.DataMember = "periodos"
        '        Me.PeriodosBindingSource.DataSource = Me.MatriculaPECDataSetBindingSource
        '
        'MatriculaPECDataSetBindingSource
        '
        '        Me.MatriculaPECDataSetBindingSource.DataSource = Me.MatriculaPECDataSet
        '        Me.MatriculaPECDataSetBindingSource.Position = 0
        '
        'MatriculaPECDataSet
        '
        Me.MatriculaPECDataSet.DataSetName = "MatriculaPECDataSet"
        Me.MatriculaPECDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox1.Location = New System.Drawing.Point(1044, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox3.Location = New System.Drawing.Point(91, 47)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(462, 78)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(374, 31)
        Me.TextBox1.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(178, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Menu/"
        '
        'ButtonMMatricula
        '
        Me.ButtonMMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonMMatricula.FlatAppearance.BorderSize = 0
        Me.ButtonMMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMMatricula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMMatricula.Location = New System.Drawing.Point(933, 290)
        Me.ButtonMMatricula.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonMMatricula.Name = "ButtonMMatricula"
        Me.ButtonMMatricula.Size = New System.Drawing.Size(221, 77)
        Me.ButtonMMatricula.TabIndex = 2
        Me.ButtonMMatricula.Text = "Matricular"
        Me.ButtonMMatricula.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodmatriculaDataGridViewTextBoxColumn, Me.CodgrupoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn5, Me.FechaDataGridViewTextBoxColumn1, Me.NumeroDataGridViewTextBoxColumn, Me.NombreEstudianteDataGridViewTextBoxColumn, Me.Apellido1DataGridViewTextBoxColumn2, Me.Apellido2DataGridViewTextBoxColumn2, Me.Column1})
        Me.DataGridView1.DataSource = Me.MatriculasBindingSource2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.Location = New System.Drawing.Point(91, 398)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(1063, 274)
        Me.DataGridView1.TabIndex = 1
        '
        'MatriculasBindingSource1
        '
        Me.MatriculasBindingSource1.DataMember = "matriculas"
        Me.MatriculasBindingSource1.DataSource = Me.MatriculaPECDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(285, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matricula"
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button5.Location = New System.Drawing.Point(849, 75)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(46, 34)
        Me.Button5.TabIndex = 31
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ButtonRegresar
        '
        Me.ButtonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonRegresar.Image = Global.MatriculaPEC.My.Resources.Resources.Previous
        Me.ButtonRegresar.Location = New System.Drawing.Point(91, 157)
        Me.ButtonRegresar.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonRegresar.Name = "ButtonRegresar"
        Me.ButtonRegresar.Size = New System.Drawing.Size(84, 83)
        Me.ButtonRegresar.TabIndex = 3
        Me.ButtonRegresar.UseVisualStyleBackColor = True
        '
        'TabPageCursos
        '
        Me.TabPageCursos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPageCursos.Controls.Add(Me.Button18)
        Me.TabPageCursos.Controls.Add(Me.PictureBox4)
        Me.TabPageCursos.Controls.Add(Me.PictureBox5)
        Me.TabPageCursos.Controls.Add(Me.ComboBox2)
        Me.TabPageCursos.Controls.Add(Me.TextBox2)
        Me.TabPageCursos.Controls.Add(Me.Label3)
        Me.TabPageCursos.Controls.Add(Me.ButtonCCursos)
        Me.TabPageCursos.Controls.Add(Me.DataGridView2)
        Me.TabPageCursos.Controls.Add(Me.Label4)
        Me.TabPageCursos.Controls.Add(Me.Button6)
        Me.TabPageCursos.Location = New System.Drawing.Point(4, 24)
        Me.TabPageCursos.Name = "TabPageCursos"
        Me.TabPageCursos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCursos.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageCursos.TabIndex = 2
        Me.TabPageCursos.Text = "Cursos"
        '
        'Button18
        '
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button18.Image = Global.MatriculaPEC.My.Resources.Resources.Previous
        Me.Button18.Location = New System.Drawing.Point(178, 184)
        Me.Button18.Margin = New System.Windows.Forms.Padding(0)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(84, 83)
        Me.Button18.TabIndex = 34
        Me.Button18.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox4.Location = New System.Drawing.Point(1069, 43)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox5.Location = New System.Drawing.Point(81, 43)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.IntegralHeight = False
        Me.ComboBox2.ItemHeight = 24
        Me.ComboBox2.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox2.Location = New System.Drawing.Point(681, 74)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(152, 32)
        Me.ComboBox2.TabIndex = 32
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(452, 75)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(227, 31)
        Me.TextBox2.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Location = New System.Drawing.Point(281, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 39)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Menu/"
        '
        'ButtonCCursos
        '
        Me.ButtonCCursos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonCCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCCursos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCCursos.Location = New System.Drawing.Point(994, 199)
        Me.ButtonCCursos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonCCursos.Name = "ButtonCCursos"
        Me.ButtonCCursos.Size = New System.Drawing.Size(221, 77)
        Me.ButtonCCursos.TabIndex = 7
        Me.ButtonCCursos.Text = "Cursos"
        Me.ButtonCCursos.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeight = 40
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn1, Me.DuracionDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.Eliminar})
        Me.DataGridView2.DataSource = Me.CursosBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(204, 293)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 40
        Me.DataGridView2.Size = New System.Drawing.Size(1011, 274)
        Me.DataGridView2.TabIndex = 6
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DuracionDataGridViewTextBoxColumn
        '
        Me.DuracionDataGridViewTextBoxColumn.DataPropertyName = "duracion"
        Me.DuracionDataGridViewTextBoxColumn.HeaderText = "duracion"
        Me.DuracionDataGridViewTextBoxColumn.Name = "DuracionDataGridViewTextBoxColumn"
        Me.DuracionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.MatriculaPEC.My.Resources.Resources.Close
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "cursos"
        '
        'Label4
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(398, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 39)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cursos"
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button6.Location = New System.Drawing.Point(839, 71)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(46, 34)
        Me.Button6.TabIndex = 31
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TabPageGrupos
        '
        Me.TabPageGrupos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPageGrupos.Controls.Add(Me.PictureBox6)
        Me.TabPageGrupos.Controls.Add(Me.PictureBox7)
        Me.TabPageGrupos.Controls.Add(Me.ComboBox3)
        Me.TabPageGrupos.Controls.Add(Me.TextBox3)
        Me.TabPageGrupos.Controls.Add(Me.Label5)
        Me.TabPageGrupos.Controls.Add(Me.ButtonGGrupos)
        Me.TabPageGrupos.Controls.Add(Me.DataGridView3)
        Me.TabPageGrupos.Controls.Add(Me.Label6)
        Me.TabPageGrupos.Controls.Add(Me.ButtonGAtras)
        Me.TabPageGrupos.Controls.Add(Me.Button7)
        Me.TabPageGrupos.Location = New System.Drawing.Point(4, 24)
        Me.TabPageGrupos.Name = "TabPageGrupos"
        Me.TabPageGrupos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGrupos.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageGrupos.TabIndex = 3
        Me.TabPageGrupos.Text = "Grupos"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox6.Location = New System.Drawing.Point(1072, 42)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox6.TabIndex = 33
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox7.Location = New System.Drawing.Point(84, 42)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox7.TabIndex = 29
        Me.PictureBox7.TabStop = False
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.IntegralHeight = False
        Me.ComboBox3.ItemHeight = 24
        Me.ComboBox3.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox3.Location = New System.Drawing.Point(684, 73)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(152, 32)
        Me.ComboBox3.TabIndex = 32
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(455, 74)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(227, 31)
        Me.TextBox3.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Location = New System.Drawing.Point(281, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 39)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Menu/"
        '
        'ButtonGGrupos
        '
        Me.ButtonGGrupos.AllowDrop = True
        Me.ButtonGGrupos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonGGrupos.FlatAppearance.BorderSize = 0
        Me.ButtonGGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGGrupos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGGrupos.Location = New System.Drawing.Point(994, 199)
        Me.ButtonGGrupos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonGGrupos.Name = "ButtonGGrupos"
        Me.ButtonGGrupos.Size = New System.Drawing.Size(221, 77)
        Me.ButtonGGrupos.TabIndex = 12
        Me.ButtonGGrupos.Text = "Crear Grupo"
        Me.ButtonGGrupos.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowDrop = True
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.EliminarGrupos})
        Me.DataGridView3.DataSource = Me.DataTableGruposNombresBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(203, 293)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowTemplate.Height = 40
        Me.DataGridView3.Size = New System.Drawing.Size(1012, 274)
        Me.DataGridView3.TabIndex = 11
        '
        'Código
        '
        Me.Código.DataPropertyName = "Código"
        Me.Código.HeaderText = "Código"
        Me.Código.Name = "Código"
        Me.Código.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Curso"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Curso"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Profesor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Profesor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Periodo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Periodo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'EliminarGrupos
        '
        Me.EliminarGrupos.HeaderText = "Eliminar"
        Me.EliminarGrupos.Image = Global.MatriculaPEC.My.Resources.Resources.Close
        Me.EliminarGrupos.Name = "EliminarGrupos"
        Me.EliminarGrupos.ReadOnly = True
        '
        'DataTableGruposNombresBindingSource
        '
        Me.DataTableGruposNombresBindingSource.DataMember = "DataTableGruposNombres"
        Me.DataTableGruposNombresBindingSource.DataSource = Me.MatriculaPECDataSet
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(398, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 39)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Grupos"
        '
        'ButtonGAtras
        '
        Me.ButtonGAtras.AllowDrop = True
        Me.ButtonGAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGAtras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonGAtras.Image = Global.MatriculaPEC.My.Resources.Resources.Previous
        Me.ButtonGAtras.Location = New System.Drawing.Point(160, 174)
        Me.ButtonGAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonGAtras.Name = "ButtonGAtras"
        Me.ButtonGAtras.Size = New System.Drawing.Size(145, 83)
        Me.ButtonGAtras.TabIndex = 13
        Me.ButtonGAtras.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button7.Location = New System.Drawing.Point(842, 70)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(46, 34)
        Me.Button7.TabIndex = 31
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TabPageEstudiante
        '
        Me.TabPageEstudiante.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPageEstudiante.Controls.Add(Me.PictureBox8)
        Me.TabPageEstudiante.Controls.Add(Me.PictureBox9)
        Me.TabPageEstudiante.Controls.Add(Me.ComboBox4)
        Me.TabPageEstudiante.Controls.Add(Me.TextBox4)
        Me.TabPageEstudiante.Controls.Add(Me.Label7)
        Me.TabPageEstudiante.Controls.Add(Me.ButtonEEstudiantes)
        Me.TabPageEstudiante.Controls.Add(Me.DataGridView4)
        Me.TabPageEstudiante.Controls.Add(Me.Label8)
        Me.TabPageEstudiante.Controls.Add(Me.ButtonEAtras)
        Me.TabPageEstudiante.Controls.Add(Me.Button8)
        Me.TabPageEstudiante.Location = New System.Drawing.Point(4, 24)
        Me.TabPageEstudiante.Name = "TabPageEstudiante"
        Me.TabPageEstudiante.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEstudiante.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageEstudiante.TabIndex = 4
        Me.TabPageEstudiante.Text = "Estudiante"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox8.Location = New System.Drawing.Point(1074, 38)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox8.TabIndex = 33
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox9.Location = New System.Drawing.Point(86, 38)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox9.TabIndex = 29
        Me.PictureBox9.TabStop = False
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.IntegralHeight = False
        Me.ComboBox4.ItemHeight = 24
        Me.ComboBox4.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox4.Location = New System.Drawing.Point(686, 69)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(152, 32)
        Me.ComboBox4.TabIndex = 32
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(457, 70)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox4.Size = New System.Drawing.Size(227, 31)
        Me.TextBox4.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Location = New System.Drawing.Point(281, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 39)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Menu/"
        '
        'ButtonEEstudiantes
        '
        Me.ButtonEEstudiantes.AllowDrop = True
        Me.ButtonEEstudiantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonEEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEEstudiantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEEstudiantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonEEstudiantes.Location = New System.Drawing.Point(994, 199)
        Me.ButtonEEstudiantes.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonEEstudiantes.Name = "ButtonEEstudiantes"
        Me.ButtonEEstudiantes.Size = New System.Drawing.Size(221, 77)
        Me.ButtonEEstudiantes.TabIndex = 17
        Me.ButtonEEstudiantes.Text = "Crear Estudiantes"
        Me.ButtonEEstudiantes.UseVisualStyleBackColor = False
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AllowUserToResizeColumns = False
        Me.DataGridView4.AllowUserToResizeRows = False
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CedulaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.Apellido1DataGridViewTextBoxColumn, Me.Apellido2DataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EliminarEstudiantes})
        Me.DataGridView4.DataSource = Me.AlumnosBindingSource
        Me.DataGridView4.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView4.Location = New System.Drawing.Point(422, 294)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowTemplate.Height = 40
        Me.DataGridView4.Size = New System.Drawing.Size(793, 274)
        Me.DataGridView4.TabIndex = 16
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Apellido1DataGridViewTextBoxColumn
        '
        Me.Apellido1DataGridViewTextBoxColumn.DataPropertyName = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.HeaderText = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.Name = "Apellido1DataGridViewTextBoxColumn"
        Me.Apellido1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Apellido2DataGridViewTextBoxColumn
        '
        Me.Apellido2DataGridViewTextBoxColumn.DataPropertyName = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.HeaderText = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.Name = "Apellido2DataGridViewTextBoxColumn"
        Me.Apellido2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EliminarEstudiantes
        '
        Me.EliminarEstudiantes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EliminarEstudiantes.DataPropertyName = "cod_alumno"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.EliminarEstudiantes.DefaultCellStyle = DataGridViewCellStyle5
        Me.EliminarEstudiantes.HeaderText = "Eliminar"
        Me.EliminarEstudiantes.Name = "EliminarEstudiantes"
        Me.EliminarEstudiantes.ReadOnly = True
        Me.EliminarEstudiantes.Text = "Eliminar"
        Me.EliminarEstudiantes.UseColumnTextForButtonValue = True
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "alumnos"
        Me.AlumnosBindingSource.DataSource = Me.MatriculaPECDataSet
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(398, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 39)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Estudiantes"
        '
        'ButtonEAtras
        '
        Me.ButtonEAtras.AllowDrop = True
        Me.ButtonEAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEAtras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonEAtras.Image = Global.MatriculaPEC.My.Resources.Resources.Previous
        Me.ButtonEAtras.Location = New System.Drawing.Point(143, 174)
        Me.ButtonEAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonEAtras.Name = "ButtonEAtras"
        Me.ButtonEAtras.Size = New System.Drawing.Size(145, 83)
        Me.ButtonEAtras.TabIndex = 18
        Me.ButtonEAtras.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button8.Location = New System.Drawing.Point(844, 66)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(46, 34)
        Me.Button8.TabIndex = 31
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TabPagePeriodos
        '
        Me.TabPagePeriodos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPagePeriodos.Controls.Add(Me.PictureBox10)
        Me.TabPagePeriodos.Controls.Add(Me.PictureBox11)
        Me.TabPagePeriodos.Controls.Add(Me.ComboBox5)
        Me.TabPagePeriodos.Controls.Add(Me.TextBox5)
        Me.TabPagePeriodos.Controls.Add(Me.Label9)
        Me.TabPagePeriodos.Controls.Add(Me.ButtonPPeriodos)
        Me.TabPagePeriodos.Controls.Add(Me.DataGridView5)
        Me.TabPagePeriodos.Controls.Add(Me.Label10)
        Me.TabPagePeriodos.Controls.Add(Me.ButtonPAtras)
        Me.TabPagePeriodos.Controls.Add(Me.Button9)
        Me.TabPagePeriodos.Location = New System.Drawing.Point(4, 24)
        Me.TabPagePeriodos.Name = "TabPagePeriodos"
        Me.TabPagePeriodos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePeriodos.Size = New System.Drawing.Size(1358, 740)
        Me.TabPagePeriodos.TabIndex = 5
        Me.TabPagePeriodos.Text = "Periodos"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox10.Location = New System.Drawing.Point(1067, 43)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox10.TabIndex = 33
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox11.Location = New System.Drawing.Point(79, 43)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox11.TabIndex = 29
        Me.PictureBox11.TabStop = False
        '
        'ComboBox5
        '
        Me.ComboBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.IntegralHeight = False
        Me.ComboBox5.ItemHeight = 24
        Me.ComboBox5.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox5.Location = New System.Drawing.Point(679, 74)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(152, 32)
        Me.ComboBox5.TabIndex = 32
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(450, 75)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox5.Size = New System.Drawing.Size(227, 31)
        Me.TextBox5.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.Location = New System.Drawing.Point(281, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 39)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Menu/"
        '
        'ButtonPPeriodos
        '
        Me.ButtonPPeriodos.AllowDrop = True
        Me.ButtonPPeriodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonPPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPPeriodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPPeriodos.Location = New System.Drawing.Point(994, 199)
        Me.ButtonPPeriodos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPPeriodos.Name = "ButtonPPeriodos"
        Me.ButtonPPeriodos.Size = New System.Drawing.Size(221, 77)
        Me.ButtonPPeriodos.TabIndex = 22
        Me.ButtonPPeriodos.Text = "Periodos"
        Me.ButtonPPeriodos.UseVisualStyleBackColor = False
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowDrop = True
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn2, Me.EliminarPeriodo})
        '        Me.DataGridView5.DataSource = Me.PeriodosBindingSource
        Me.DataGridView5.Location = New System.Drawing.Point(422, 293)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.Size = New System.Drawing.Size(793, 274)
        Me.DataGridView5.TabIndex = 21
        '
        'NombreDataGridViewTextBoxColumn2
        '
        Me.NombreDataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn2.Name = "NombreDataGridViewTextBoxColumn2"
        Me.NombreDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'EliminarPeriodo
        '
        Me.EliminarPeriodo.HeaderText = "Eliminar"
        Me.EliminarPeriodo.Name = "EliminarPeriodo"
        Me.EliminarPeriodo.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.AllowDrop = True
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Location = New System.Drawing.Point(398, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 39)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Periodos"
        '
        'ButtonPAtras
        '
        Me.ButtonPAtras.AllowDrop = True
        Me.ButtonPAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPAtras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonPAtras.Image = Global.MatriculaPEC.My.Resources.Resources.Previous
        Me.ButtonPAtras.Location = New System.Drawing.Point(143, 174)
        Me.ButtonPAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPAtras.Name = "ButtonPAtras"
        Me.ButtonPAtras.Size = New System.Drawing.Size(145, 83)
        Me.ButtonPAtras.TabIndex = 23
        Me.ButtonPAtras.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button9.Location = New System.Drawing.Point(837, 71)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(46, 34)
        Me.Button9.TabIndex = 31
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TabPageDescuentos
        '
        Me.TabPageDescuentos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPageDescuentos.Controls.Add(Me.PictureBox12)
        Me.TabPageDescuentos.Controls.Add(Me.PictureBox13)
        Me.TabPageDescuentos.Controls.Add(Me.ComboBox6)
        Me.TabPageDescuentos.Controls.Add(Me.TextBox6)
        Me.TabPageDescuentos.Controls.Add(Me.Label11)
        Me.TabPageDescuentos.Controls.Add(Me.ButtonDDescuentos)
        Me.TabPageDescuentos.Controls.Add(Me.DataGridView6)
        Me.TabPageDescuentos.Controls.Add(Me.Label12)
        Me.TabPageDescuentos.Controls.Add(Me.ButtonDAtras)
        Me.TabPageDescuentos.Controls.Add(Me.Button10)
        Me.TabPageDescuentos.Location = New System.Drawing.Point(4, 24)
        Me.TabPageDescuentos.Name = "TabPageDescuentos"
        Me.TabPageDescuentos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDescuentos.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageDescuentos.TabIndex = 6
        Me.TabPageDescuentos.Text = "Descuentos"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox12.Location = New System.Drawing.Point(1071, 41)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox12.TabIndex = 34
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox13.Location = New System.Drawing.Point(83, 41)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox13.TabIndex = 30
        Me.PictureBox13.TabStop = False
        '
        'ComboBox6
        '
        Me.ComboBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.IntegralHeight = False
        Me.ComboBox6.ItemHeight = 24
        Me.ComboBox6.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox6.Location = New System.Drawing.Point(683, 72)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(152, 32)
        Me.ComboBox6.TabIndex = 33
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(454, 73)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox6.Size = New System.Drawing.Size(227, 31)
        Me.TextBox6.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label11.Location = New System.Drawing.Point(281, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 39)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Menu/"
        '
        'ButtonDDescuentos
        '
        Me.ButtonDDescuentos.AllowDrop = True
        Me.ButtonDDescuentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonDDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDDescuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDDescuentos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDDescuentos.Location = New System.Drawing.Point(994, 199)
        Me.ButtonDDescuentos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonDDescuentos.Name = "ButtonDDescuentos"
        Me.ButtonDDescuentos.Size = New System.Drawing.Size(221, 77)
        Me.ButtonDDescuentos.TabIndex = 27
        Me.ButtonDDescuentos.Text = "Descuentos"
        Me.ButtonDDescuentos.UseVisualStyleBackColor = False
        '
        'DataGridView6
        '
        Me.DataGridView6.AllowDrop = True
        Me.DataGridView6.AllowUserToAddRows = False
        Me.DataGridView6.AllowUserToDeleteRows = False
        Me.DataGridView6.AutoGenerateColumns = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn3, Me.PorcentajeDataGridViewTextBoxColumn, Me.EliminarDescuento})
        Me.DataGridView6.DataSource = Me.DescuentosBindingSource
        Me.DataGridView6.Location = New System.Drawing.Point(422, 293)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.ReadOnly = True
        Me.DataGridView6.Size = New System.Drawing.Size(793, 274)
        Me.DataGridView6.TabIndex = 26
        '
        'NombreDataGridViewTextBoxColumn3
        '
        Me.NombreDataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn3.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn3.Name = "NombreDataGridViewTextBoxColumn3"
        Me.NombreDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'PorcentajeDataGridViewTextBoxColumn
        '
        Me.PorcentajeDataGridViewTextBoxColumn.DataPropertyName = "porcentaje"
        Me.PorcentajeDataGridViewTextBoxColumn.HeaderText = "porcentaje"
        Me.PorcentajeDataGridViewTextBoxColumn.Name = "PorcentajeDataGridViewTextBoxColumn"
        Me.PorcentajeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EliminarDescuento
        '
        Me.EliminarDescuento.HeaderText = "Eliminar"
        Me.EliminarDescuento.Name = "EliminarDescuento"
        Me.EliminarDescuento.ReadOnly = True
        '
        'DescuentosBindingSource
        '
        Me.DescuentosBindingSource.DataMember = "descuentos"
        '        Me.DescuentosBindingSource.DataSource = Me.MatriculaPECDataSetBindingSource
        '
        'Label12
        '
        Me.Label12.AllowDrop = True
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label12.Location = New System.Drawing.Point(398, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(197, 39)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Descuentos"
        '
        'ButtonDAtras
        '
        Me.ButtonDAtras.AllowDrop = True
        Me.ButtonDAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDAtras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonDAtras.Image = Global.MatriculaPEC.My.Resources.Resources.Previous
        Me.ButtonDAtras.Location = New System.Drawing.Point(143, 174)
        Me.ButtonDAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonDAtras.Name = "ButtonDAtras"
        Me.ButtonDAtras.Size = New System.Drawing.Size(145, 83)
        Me.ButtonDAtras.TabIndex = 28
        Me.ButtonDAtras.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button10.Location = New System.Drawing.Point(841, 69)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(46, 34)
        Me.Button10.TabIndex = 32
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TabPagePagos
        '
        Me.TabPagePagos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPagePagos.Controls.Add(Me.PictureBox14)
        Me.TabPagePagos.Controls.Add(Me.PictureBox15)
        Me.TabPagePagos.Controls.Add(Me.ComboBox7)
        Me.TabPagePagos.Controls.Add(Me.TextBox7)
        Me.TabPagePagos.Controls.Add(Me.Label13)
        Me.TabPagePagos.Controls.Add(Me.ButtonPPagos)
        Me.TabPagePagos.Controls.Add(Me.DataGridView7)
        Me.TabPagePagos.Controls.Add(Me.Label14)
        Me.TabPagePagos.Controls.Add(Me.ButtonPaAtras)
        Me.TabPagePagos.Controls.Add(Me.Button11)
        Me.TabPagePagos.Location = New System.Drawing.Point(4, 24)
        Me.TabPagePagos.Name = "TabPagePagos"
        Me.TabPagePagos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePagos.Size = New System.Drawing.Size(1358, 740)
        Me.TabPagePagos.TabIndex = 7
        Me.TabPagePagos.Text = "Pagos"
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox14.Location = New System.Drawing.Point(1075, 39)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox14.TabIndex = 39
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox15.Location = New System.Drawing.Point(87, 39)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox15.TabIndex = 35
        Me.PictureBox15.TabStop = False
        '
        'ComboBox7
        '
        Me.ComboBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.IntegralHeight = False
        Me.ComboBox7.ItemHeight = 24
        Me.ComboBox7.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox7.Location = New System.Drawing.Point(687, 70)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(152, 32)
        Me.ComboBox7.TabIndex = 38
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(458, 71)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox7.Size = New System.Drawing.Size(227, 31)
        Me.TextBox7.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AllowDrop = True
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label13.Location = New System.Drawing.Point(281, 199)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 39)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Menu/"
        '
        'ButtonPPagos
        '
        Me.ButtonPPagos.AllowDrop = True
        Me.ButtonPPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonPPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPPagos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPPagos.Location = New System.Drawing.Point(994, 199)
        Me.ButtonPPagos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPPagos.Name = "ButtonPPagos"
        Me.ButtonPPagos.Size = New System.Drawing.Size(221, 77)
        Me.ButtonPPagos.TabIndex = 32
        Me.ButtonPPagos.Text = "Pagos"
        Me.ButtonPPagos.UseVisualStyleBackColor = False
        '
        'DataGridView7
        '
        Me.DataGridView7.AllowDrop = True
        Me.DataGridView7.AllowUserToAddRows = False
        Me.DataGridView7.AllowUserToDeleteRows = False
        Me.DataGridView7.AutoGenerateColumns = False
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.CodmediopagoDataGridViewTextBoxColumn, Me.EliminarPago})
        Me.DataGridView7.DataSource = Me.PagosBindingSource
        Me.DataGridView7.Location = New System.Drawing.Point(422, 293)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.ReadOnly = True
        Me.DataGridView7.Size = New System.Drawing.Size(793, 274)
        Me.DataGridView7.TabIndex = 31
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodmediopagoDataGridViewTextBoxColumn
        '
        Me.CodmediopagoDataGridViewTextBoxColumn.DataPropertyName = "cod_mediopago"
        Me.CodmediopagoDataGridViewTextBoxColumn.HeaderText = "cod_mediopago"
        Me.CodmediopagoDataGridViewTextBoxColumn.Name = "CodmediopagoDataGridViewTextBoxColumn"
        Me.CodmediopagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EliminarPago
        '
        Me.EliminarPago.HeaderText = "Eliminar"
        Me.EliminarPago.Name = "EliminarPago"
        Me.EliminarPago.ReadOnly = True
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "pagos"
        '        Me.PagosBindingSource.DataSource = Me.MatriculaPECDataSetBindingSource
        '
        'Label14
        '
        Me.Label14.AllowDrop = True
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label14.Location = New System.Drawing.Point(398, 199)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 39)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Pagos"
        '
        'ButtonPaAtras
        '
        Me.ButtonPaAtras.AllowDrop = True
        Me.ButtonPaAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPaAtras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonPaAtras.Image = Global.MatriculaPEC.My.Resources.Resources.Previous
        Me.ButtonPaAtras.Location = New System.Drawing.Point(143, 174)
        Me.ButtonPaAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPaAtras.Name = "ButtonPaAtras"
        Me.ButtonPaAtras.Size = New System.Drawing.Size(145, 83)
        Me.ButtonPaAtras.TabIndex = 33
        Me.ButtonPaAtras.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button11.Location = New System.Drawing.Point(845, 67)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(46, 34)
        Me.Button11.TabIndex = 37
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TabPageProfesores
        '
        Me.TabPageProfesores.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPageProfesores.Controls.Add(Me.PictureBox16)
        Me.TabPageProfesores.Controls.Add(Me.PictureBox17)
        Me.TabPageProfesores.Controls.Add(Me.ComboBox8)
        Me.TabPageProfesores.Controls.Add(Me.TextBox8)
        Me.TabPageProfesores.Controls.Add(Me.Label15)
        Me.TabPageProfesores.Controls.Add(Me.ButtonPProfesores)
        Me.TabPageProfesores.Controls.Add(Me.DataGridView8)
        Me.TabPageProfesores.Controls.Add(Me.Label16)
        Me.TabPageProfesores.Controls.Add(Me.ButtonPrAtras)
        Me.TabPageProfesores.Controls.Add(Me.Button12)
        Me.TabPageProfesores.Location = New System.Drawing.Point(4, 24)
        Me.TabPageProfesores.Name = "TabPageProfesores"
        Me.TabPageProfesores.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageProfesores.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageProfesores.TabIndex = 8
        Me.TabPageProfesores.Text = "Profesores"
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox16.Location = New System.Drawing.Point(1071, 42)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox16.TabIndex = 44
        Me.PictureBox16.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox17.Location = New System.Drawing.Point(83, 42)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox17.TabIndex = 40
        Me.PictureBox17.TabStop = False
        '
        'ComboBox8
        '
        Me.ComboBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox8.IntegralHeight = False
        Me.ComboBox8.ItemHeight = 24
        Me.ComboBox8.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox8.Location = New System.Drawing.Point(683, 73)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(152, 32)
        Me.ComboBox8.TabIndex = 43
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(454, 74)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox8.Size = New System.Drawing.Size(227, 31)
        Me.TextBox8.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label15.Location = New System.Drawing.Point(281, 199)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 39)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Menu/"
        '
        'ButtonPProfesores
        '
        Me.ButtonPProfesores.AllowDrop = True
        Me.ButtonPProfesores.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonPProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPProfesores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPProfesores.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPProfesores.Location = New System.Drawing.Point(994, 199)
        Me.ButtonPProfesores.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPProfesores.Name = "ButtonPProfesores"
        Me.ButtonPProfesores.Size = New System.Drawing.Size(221, 77)
        Me.ButtonPProfesores.TabIndex = 37
        Me.ButtonPProfesores.Text = "Profesores"
        Me.ButtonPProfesores.UseVisualStyleBackColor = False
        '
        'DataGridView8
        '
        Me.DataGridView8.AllowDrop = True
        Me.DataGridView8.AllowUserToAddRows = False
        Me.DataGridView8.AllowUserToDeleteRows = False
        Me.DataGridView8.AutoGenerateColumns = False
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView8.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn4, Me.Apellido1DataGridViewTextBoxColumn1, Me.Apellido2DataGridViewTextBoxColumn1, Me.TelefonoDataGridViewTextBoxColumn1, Me.CorreoDataGridViewTextBoxColumn, Me.EliminarProfesor})
        Me.DataGridView8.DataSource = Me.ProfesoresBindingSource
        Me.DataGridView8.Location = New System.Drawing.Point(422, 293)
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.ReadOnly = True
        Me.DataGridView8.Size = New System.Drawing.Size(793, 274)
        Me.DataGridView8.TabIndex = 36
        '
        'NombreDataGridViewTextBoxColumn4
        '
        Me.NombreDataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn4.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn4.Name = "NombreDataGridViewTextBoxColumn4"
        Me.NombreDataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Apellido1DataGridViewTextBoxColumn1
        '
        Me.Apellido1DataGridViewTextBoxColumn1.DataPropertyName = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn1.HeaderText = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn1.Name = "Apellido1DataGridViewTextBoxColumn1"
        Me.Apellido1DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Apellido2DataGridViewTextBoxColumn1
        '
        Me.Apellido2DataGridViewTextBoxColumn1.DataPropertyName = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn1.HeaderText = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn1.Name = "Apellido2DataGridViewTextBoxColumn1"
        Me.Apellido2DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn1
        '
        Me.TelefonoDataGridViewTextBoxColumn1.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn1.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn1.Name = "TelefonoDataGridViewTextBoxColumn1"
        Me.TelefonoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EliminarProfesor
        '
        Me.EliminarProfesor.HeaderText = "Eliminar"
        Me.EliminarProfesor.Name = "EliminarProfesor"
        Me.EliminarProfesor.ReadOnly = True
        '
        'ProfesoresBindingSource
        '
        Me.ProfesoresBindingSource.DataMember = "profesores"
        '        Me.ProfesoresBindingSource.DataSource = Me.MatriculaPECDataSetBindingSource
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label16.Location = New System.Drawing.Point(398, 199)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 39)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Profesores"
        '
        'ButtonPrAtras
        '
        Me.ButtonPrAtras.AllowDrop = True
        Me.ButtonPrAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrAtras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonPrAtras.Image = Global.MatriculaPEC.My.Resources.Resources.Previous
        Me.ButtonPrAtras.Location = New System.Drawing.Point(143, 174)
        Me.ButtonPrAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPrAtras.Name = "ButtonPrAtras"
        Me.ButtonPrAtras.Size = New System.Drawing.Size(145, 83)
        Me.ButtonPrAtras.TabIndex = 38
        Me.ButtonPrAtras.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button12.Location = New System.Drawing.Point(841, 70)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(46, 34)
        Me.Button12.TabIndex = 42
        Me.Button12.UseVisualStyleBackColor = True
        '
        'TabPageUsuarios
        '
        Me.TabPageUsuarios.Controls.Add(Me.PictureBox18)
        Me.TabPageUsuarios.Controls.Add(Me.PictureBox19)
        Me.TabPageUsuarios.Controls.Add(Me.ComboBox9)
        Me.TabPageUsuarios.Controls.Add(Me.TextBox9)
        Me.TabPageUsuarios.Controls.Add(Me.Button13)
        Me.TabPageUsuarios.Location = New System.Drawing.Point(4, 24)
        Me.TabPageUsuarios.Name = "TabPageUsuarios"
        Me.TabPageUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUsuarios.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageUsuarios.TabIndex = 9
        Me.TabPageUsuarios.Text = "Usuarios"
        Me.TabPageUsuarios.UseVisualStyleBackColor = True
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox18.Location = New System.Drawing.Point(1087, 44)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox18.TabIndex = 33
        Me.PictureBox18.TabStop = False
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox19.Location = New System.Drawing.Point(99, 44)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox19.TabIndex = 29
        Me.PictureBox19.TabStop = False
        '
        'ComboBox9
        '
        Me.ComboBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox9.IntegralHeight = False
        Me.ComboBox9.ItemHeight = 24
        Me.ComboBox9.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox9.Location = New System.Drawing.Point(699, 75)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(152, 32)
        Me.ComboBox9.TabIndex = 32
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(470, 76)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox9.Size = New System.Drawing.Size(227, 31)
        Me.TextBox9.TabIndex = 30
        '
        'Button13
        '
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button13.Location = New System.Drawing.Point(857, 72)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(46, 34)
        Me.Button13.TabIndex = 31
        Me.Button13.UseVisualStyleBackColor = True
        '
        'TabPageMedios
        '
        Me.TabPageMedios.Controls.Add(Me.PictureBox20)
        Me.TabPageMedios.Controls.Add(Me.PictureBox22)
        Me.TabPageMedios.Controls.Add(Me.ComboBox10)
        Me.TabPageMedios.Controls.Add(Me.TextBox10)
        Me.TabPageMedios.Controls.Add(Me.Button14)
        Me.TabPageMedios.Location = New System.Drawing.Point(4, 24)
        Me.TabPageMedios.Name = "TabPageMedios"
        Me.TabPageMedios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMedios.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageMedios.TabIndex = 10
        Me.TabPageMedios.Text = "Medios"
        Me.TabPageMedios.UseVisualStyleBackColor = True
        '
        'PictureBox20
        '
        Me.PictureBox20.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox20.Location = New System.Drawing.Point(1072, 44)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox20.TabIndex = 33
        Me.PictureBox20.TabStop = False
        '
        'PictureBox22
        '
        Me.PictureBox22.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox22.Location = New System.Drawing.Point(84, 44)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox22.TabIndex = 29
        Me.PictureBox22.TabStop = False
        '
        'ComboBox10
        '
        Me.ComboBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox10.IntegralHeight = False
        Me.ComboBox10.ItemHeight = 24
        Me.ComboBox10.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox10.Location = New System.Drawing.Point(684, 75)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(152, 32)
        Me.ComboBox10.TabIndex = 32
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(455, 76)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox10.Size = New System.Drawing.Size(227, 31)
        Me.TextBox10.TabIndex = 30
        '
        'Button14
        '
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button14.Location = New System.Drawing.Point(842, 72)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(46, 34)
        Me.Button14.TabIndex = 31
        Me.Button14.UseVisualStyleBackColor = True
        '
        'TabPageFormas
        '
        Me.TabPageFormas.Controls.Add(Me.PictureBox23)
        Me.TabPageFormas.Controls.Add(Me.PictureBox24)
        Me.TabPageFormas.Controls.Add(Me.ComboBox11)
        Me.TabPageFormas.Controls.Add(Me.TextBox11)
        Me.TabPageFormas.Controls.Add(Me.Button16)
        Me.TabPageFormas.Location = New System.Drawing.Point(4, 24)
        Me.TabPageFormas.Name = "TabPageFormas"
        Me.TabPageFormas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFormas.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageFormas.TabIndex = 11
        Me.TabPageFormas.Text = "Formas"
        Me.TabPageFormas.UseVisualStyleBackColor = True
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox23.Location = New System.Drawing.Point(1078, 45)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox23.TabIndex = 33
        Me.PictureBox23.TabStop = False
        '
        'PictureBox24
        '
        Me.PictureBox24.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox24.Location = New System.Drawing.Point(90, 45)
        Me.PictureBox24.Name = "PictureBox24"
        Me.PictureBox24.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox24.TabIndex = 29
        Me.PictureBox24.TabStop = False
        '
        'ComboBox11
        '
        Me.ComboBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox11.IntegralHeight = False
        Me.ComboBox11.ItemHeight = 24
        Me.ComboBox11.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox11.Location = New System.Drawing.Point(690, 76)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(152, 32)
        Me.ComboBox11.TabIndex = 32
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(461, 77)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox11.Size = New System.Drawing.Size(227, 31)
        Me.TextBox11.TabIndex = 30
        '
        'Button16
        '
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button16.Location = New System.Drawing.Point(848, 73)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(46, 34)
        Me.Button16.TabIndex = 31
        Me.Button16.UseVisualStyleBackColor = True
        '
        'TabPageListas
        '
        Me.TabPageListas.Controls.Add(Me.PictureBox25)
        Me.TabPageListas.Controls.Add(Me.PictureBox26)
        Me.TabPageListas.Controls.Add(Me.ComboBox12)
        Me.TabPageListas.Controls.Add(Me.TextBox12)
        Me.TabPageListas.Controls.Add(Me.Button17)
        Me.TabPageListas.Location = New System.Drawing.Point(4, 24)
        Me.TabPageListas.Name = "TabPageListas"
        Me.TabPageListas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageListas.Size = New System.Drawing.Size(1358, 740)
        Me.TabPageListas.TabIndex = 12
        Me.TabPageListas.Text = "Listas"
        Me.TabPageListas.UseVisualStyleBackColor = True
        '
        'PictureBox25
        '
        Me.PictureBox25.Image = Global.MatriculaPEC.My.Resources.Resources.ec
        Me.PictureBox25.Location = New System.Drawing.Point(1074, 50)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(110, 82)
        Me.PictureBox25.TabIndex = 33
        Me.PictureBox25.TabStop = False
        '
        'PictureBox26
        '
        Me.PictureBox26.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox26.Location = New System.Drawing.Point(86, 50)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(192, 82)
        Me.PictureBox26.TabIndex = 29
        Me.PictureBox26.TabStop = False
        '
        'ComboBox12
        '
        Me.ComboBox12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox12.IntegralHeight = False
        Me.ComboBox12.ItemHeight = 24
        Me.ComboBox12.Items.AddRange(New Object() {"Cursos", "Descuentos", "Estudiantes", "Grupos", "Matricula", "Pagos", "Periodos", "Profesores", "Usuarios"})
        Me.ComboBox12.Location = New System.Drawing.Point(686, 81)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(152, 32)
        Me.ComboBox12.TabIndex = 32
        '
        'TextBox12
        '
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(457, 82)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox12.Size = New System.Drawing.Size(227, 31)
        Me.TextBox12.TabIndex = 30
        '
        'Button17
        '
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Image = Global.MatriculaPEC.My.Resources.Resources.Search_Find
        Me.Button17.Location = New System.Drawing.Point(844, 78)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(46, 34)
        Me.Button17.TabIndex = 31
        Me.Button17.UseVisualStyleBackColor = True
        '
        'MatriculasBindingSource
        '
        Me.MatriculasBindingSource.DataMember = "matriculas"
        '        Me.MatriculasBindingSource.DataSource = Me.MatriculaPECDataSetBindingSource
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "grupos"
        '        Me.GruposBindingSource.DataSource = Me.MatriculaPECDataSetBindingSource
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.MatriculaPEC.My.Resources.Resources.Close
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'MatriculaPECDataSet1
        '
        Me.MatriculaPECDataSet1.DataSetName = "MatriculaPECDataSet"
        Me.MatriculaPECDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'PeriodosTableAdapter
        '
        Me.PeriodosTableAdapter.ClearBeforeFill = True
        '
        'DescuentosTableAdapter
        '
        Me.DescuentosTableAdapter.ClearBeforeFill = True
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'ProfesoresTableAdapter
        '
        Me.ProfesoresTableAdapter.ClearBeforeFill = True
        '
        'MatriculasTableAdapter
        '
        Me.MatriculasTableAdapter.ClearBeforeFill = True
        '
        'DataTableGruposNombresTableAdapter
        '
        '  Me.DataTableGruposNombresTableAdapter.ClearBeforeFill = True
        '
        'MatriculasBindingSource2
        '
        Me.MatriculasBindingSource2.DataMember = "matriculas"
        Me.MatriculasBindingSource2.DataSource = Me.MatriculaPECDataSet
        '
        'CodmatriculaDataGridViewTextBoxColumn
        '
        Me.CodmatriculaDataGridViewTextBoxColumn.DataPropertyName = "cod_matricula"
        Me.CodmatriculaDataGridViewTextBoxColumn.HeaderText = "cod_matricula"
        Me.CodmatriculaDataGridViewTextBoxColumn.Name = "CodmatriculaDataGridViewTextBoxColumn"
        Me.CodmatriculaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodgrupoDataGridViewTextBoxColumn
        '
        Me.CodgrupoDataGridViewTextBoxColumn.DataPropertyName = "cod_grupo"
        Me.CodgrupoDataGridViewTextBoxColumn.HeaderText = "cod_grupo"
        Me.CodgrupoDataGridViewTextBoxColumn.Name = "CodgrupoDataGridViewTextBoxColumn"
        Me.CodgrupoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn5
        '
        Me.NombreDataGridViewTextBoxColumn5.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn5.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn5.Name = "NombreDataGridViewTextBoxColumn5"
        Me.NombreDataGridViewTextBoxColumn5.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreEstudianteDataGridViewTextBoxColumn
        '
        Me.NombreEstudianteDataGridViewTextBoxColumn.DataPropertyName = "nombreEstudiante"
        Me.NombreEstudianteDataGridViewTextBoxColumn.HeaderText = "nombreEstudiante"
        Me.NombreEstudianteDataGridViewTextBoxColumn.Name = "NombreEstudianteDataGridViewTextBoxColumn"
        Me.NombreEstudianteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Apellido1DataGridViewTextBoxColumn2
        '
        Me.Apellido1DataGridViewTextBoxColumn2.DataPropertyName = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn2.HeaderText = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn2.Name = "Apellido1DataGridViewTextBoxColumn2"
        Me.Apellido1DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Apellido2DataGridViewTextBoxColumn2
        '
        Me.Apellido2DataGridViewTextBoxColumn2.DataPropertyName = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn2.HeaderText = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn2.Name = "Apellido2DataGridViewTextBoxColumn2"
        Me.Apellido2DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "cod_matricula"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1284, 729)
        Me.Controls.Add(Me.TabControlPrincipal)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matricula Educación Continua"
        Me.TabControlPrincipal.ResumeLayout(False)
        Me.TabPageMenu.ResumeLayout(False)
        Me.TabPageMenu.PerformLayout()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMatricula.ResumeLayout(False)
        Me.TabPageMatricula.PerformLayout()
        '        CType(Me.PeriodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '        CType(Me.MatriculaPECDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculaPECDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCursos.ResumeLayout(False)
        Me.TabPageCursos.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageGrupos.ResumeLayout(False)
        Me.TabPageGrupos.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageEstudiante.ResumeLayout(False)
        Me.TabPageEstudiante.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePeriodos.ResumeLayout(False)
        Me.TabPagePeriodos.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDescuentos.ResumeLayout(False)
        Me.TabPageDescuentos.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePagos.ResumeLayout(False)
        Me.TabPagePagos.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageProfesores.ResumeLayout(False)
        Me.TabPageProfesores.PerformLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageUsuarios.ResumeLayout(False)
        Me.TabPageUsuarios.PerformLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMedios.ResumeLayout(False)
        Me.TabPageMedios.PerformLayout()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageFormas.ResumeLayout(False)
        Me.TabPageFormas.PerformLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageListas.ResumeLayout(False)
        Me.TabPageListas.PerformLayout()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKmatriculacodg1DE57479BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculaPECDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ButtonMMatricula As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonRegresar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonCCursos As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonGAtras As System.Windows.Forms.Button
    Friend WithEvents ButtonGGrupos As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonEAtras As System.Windows.Forms.Button
    Friend WithEvents ButtonEEstudiantes As System.Windows.Forms.Button
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ButtonPAtras As System.Windows.Forms.Button
    Friend WithEvents ButtonPPeriodos As System.Windows.Forms.Button
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ButtonDAtras As System.Windows.Forms.Button
    Friend WithEvents ButtonDDescuentos As System.Windows.Forms.Button
    Friend WithEvents DataGridView6 As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ButtonPaAtras As System.Windows.Forms.Button
    Friend WithEvents ButtonPPagos As System.Windows.Forms.Button
    Friend WithEvents DataGridView7 As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ButtonPrAtras As System.Windows.Forms.Button
    Friend WithEvents ButtonPProfesores As System.Windows.Forms.Button
    Friend WithEvents DataGridView8 As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ButtonMedios As System.Windows.Forms.Button
    Friend WithEvents ButtonFormas As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MatriculaPECDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MatriculaPECDataSet As MatriculaPEC.MatriculaPECDataSet
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.alumnosTableAdapter
    Friend WithEvents CedulaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EliminarEstudiantes As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TabPageMedios As System.Windows.Forms.TabPage
    Friend WithEvents TabPageFormas As System.Windows.Forms.TabPage
    Friend WithEvents TabPageListas As System.Windows.Forms.TabPage
    Friend WithEvents CursosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CursosTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.cursosTableAdapter
    Friend WithEvents GruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.gruposTableAdapter
    Friend WithEvents PeriodosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodosTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.periodosTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EliminarPeriodo As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DescuentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescuentosTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.descuentosTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EliminarDescuento As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PagosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.pagosTableAdapter
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodmediopagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EliminarPago As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ProfesoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.profesoresTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido1DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido2DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EliminarProfesor As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents MatriculasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MatriculasTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.matriculasTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox21 As System.Windows.Forms.PictureBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox19 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox22 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox23 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox24 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox11 As System.Windows.Forms.ComboBox
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox25 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox26 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox12 As System.Windows.Forms.ComboBox
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DuracionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CodalumnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKmatriculacodg1DE57479BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MatriculaPECDataSet1 As MatriculaPEC.MatriculaPECDataSet


    Friend WithEvents CursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfesorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CódigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataTableGruposNombresBindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents DataTableGruposNombresTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.DataTableGruposNombresTableAdapter
    Friend WithEvents Código As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EliminarGrupos As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ComboBox14 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox13 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox15 As System.Windows.Forms.ComboBox
    Friend WithEvents MatriculasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MatriculasBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CodmatriculaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodgrupoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreEstudianteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido1DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido2DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn











End Class
