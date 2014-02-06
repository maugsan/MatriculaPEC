<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matricula2
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewMatricula2 = New System.Windows.Forms.DataGridView()
        Me.Grupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Forma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MatriculaPECDataSet = New MatriculaPEC.MatriculaPECDataSet()
        Me.DataTableGruposNombresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PeriodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeriodosTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.periodosTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GrupoPorPeriodoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.GrupoPorPeriodoTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.GrupoPorPeriodoTableAdapter()
        Me.FormasdepagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Formas_de_pagoTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.formas_de_pagoTableAdapter()
        Me.DescuentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescuentosTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.descuentosTableAdapter()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridViewMatricula2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculaPECDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableGruposNombresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoPorPeriodoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormasdepagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(521, 417)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 77)
        Me.Button3.TabIndex = 10
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
        Me.Button2.Location = New System.Drawing.Point(688, 417)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 77)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Siguiente"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(355, 417)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 77)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridViewMatricula2
        '
        Me.DataGridViewMatricula2.AllowUserToAddRows = False
        Me.DataGridViewMatricula2.AllowUserToDeleteRows = False
        Me.DataGridViewMatricula2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewMatricula2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewMatricula2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMatricula2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewMatricula2.ColumnHeadersHeight = 40
        Me.DataGridViewMatricula2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewMatricula2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Grupo, Me.Forma, Me.Descuento, Me.Eliminar})
        Me.DataGridViewMatricula2.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewMatricula2.Location = New System.Drawing.Point(355, 145)
        Me.DataGridViewMatricula2.Name = "DataGridViewMatricula2"
        Me.DataGridViewMatricula2.ReadOnly = True
        Me.DataGridViewMatricula2.RowTemplate.Height = 40
        Me.DataGridViewMatricula2.Size = New System.Drawing.Size(488, 242)
        Me.DataGridViewMatricula2.TabIndex = 12
        '
        'Grupo
        '
        Me.Grupo.HeaderText = "Grupo"
        Me.Grupo.Name = "Grupo"
        Me.Grupo.ReadOnly = True
        '
        'Forma
        '
        Me.Forma.HeaderText = "Forma"
        Me.Forma.Name = "Forma"
        Me.Forma.ReadOnly = True
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.MatriculaPEC.My.Resources.Resources.Close
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'MatriculaPECDataSet
        '
        Me.MatriculaPECDataSet.DataSetName = "MatriculaPECDataSet"
        Me.MatriculaPECDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(34, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Seleccionar Grupo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(35, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Seleccionar  Forma"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(33, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Seleccionar Descuento"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(227, 417)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 34)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Agregar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MatriculaPEC.My.Resources.Resources.MATRICULA_PEC
        Me.PictureBox1.Location = New System.Drawing.Point(31, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 81)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(322, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(521, 31)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Agregue los Grupos que desea Matricular:"
        '
        'PeriodosBindingSource
        '
        Me.PeriodosBindingSource.DataMember = "periodos"
        Me.PeriodosBindingSource.DataSource = Me.MatriculaPECDataSet
        '
        'PeriodosTableAdapter
        '
        Me.PeriodosTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(40, 219)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(281, 33)
        Me.ComboBox2.TabIndex = 27
        '
        'GrupoPorPeriodoBindingSource
        '
        Me.GrupoPorPeriodoBindingSource.DataMember = "GrupoPorPeriodo"
        Me.GrupoPorPeriodoBindingSource.DataSource = Me.MatriculaPECDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.FormasdepagoBindingSource
        Me.ComboBox3.DisplayMember = "nombre"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(40, 293)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(281, 33)
        Me.ComboBox3.TabIndex = 28
        Me.ComboBox3.ValueMember = "cod_formapago"
        '
        'GrupoPorPeriodoTableAdapter
        '
        Me.GrupoPorPeriodoTableAdapter.ClearBeforeFill = True
        '
        'FormasdepagoBindingSource
        '
        Me.FormasdepagoBindingSource.DataMember = "formas_de_pago"
        Me.FormasdepagoBindingSource.DataSource = Me.MatriculaPECDataSet
        '
        'Formas_de_pagoTableAdapter
        '
        Me.Formas_de_pagoTableAdapter.ClearBeforeFill = True
        '
        'DescuentosBindingSource
        '
        Me.DescuentosBindingSource.DataMember = "descuentos"
        Me.DescuentosBindingSource.DataSource = Me.MatriculaPECDataSet
        '
        'DescuentosTableAdapter
        '
        Me.DescuentosTableAdapter.ClearBeforeFill = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.DescuentosBindingSource
        Me.ComboBox4.DisplayMember = "nombre"
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(38, 363)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(283, 33)
        Me.ComboBox4.TabIndex = 29
        Me.ComboBox4.ValueMember = "cod_descuento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(35, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Seleccionar Periodo:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PeriodosBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(40, 150)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(281, 33)
        Me.ComboBox1.TabIndex = 26
        Me.ComboBox1.ValueMember = "cod_periodo"
        '
        'Matricula2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 514)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewMatricula2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.MaximizeBox = False
        Me.Name = "Matricula2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matricular Estudiante - Paso 2"
        CType(Me.DataGridViewMatricula2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculaPECDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableGruposNombresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoPorPeriodoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormasdepagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewMatricula2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MatriculaPECDataSet As MatriculaPEC.MatriculaPECDataSet
    Friend WithEvents CursosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DataTableGruposNombresBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents DataTableGruposNombresTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.DataTableGruposNombresTableAdapter
    Friend WithEvents Grupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Forma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PeriodosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodosTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.periodosTableAdapter
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents GrupoPorPeriodoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GrupoPorPeriodoTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.GrupoPorPeriodoTableAdapter
    Friend WithEvents FormasdepagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Formas_de_pagoTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.formas_de_pagoTableAdapter
    Friend WithEvents DescuentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescuentosTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.descuentosTableAdapter
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
