<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Conn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.db1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.MatriculasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatriculaPECDataSet = New MatriculaPEC.MatriculaPECDataSet()
        Me.MatriculasTableAdapter = New MatriculaPEC.MatriculaPECDataSetTableAdapters.matriculasTableAdapter()
        Me.mta1 = New MatriculaPEC.MatriculaPECDataSetTableAdapters.matriculasTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.MatriculasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculaPECDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 71)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Matriculas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "dbo.nseleccionarMatriculas"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.Conn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.[Variant], 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing)})
        '
        'Conn
        '
        Me.Conn.ConnectionString = "Data Source=MAU-PC;Initial Catalog=MatriculaPEC;Integrated Security=True"
        Me.Conn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "dbo.ninsertarMatriculas"
        Me.SqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlInsertCommand1.Connection = Me.Conn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.[Variant], 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@cod_grupo", System.Data.SqlDbType.Int, 0, "cod_grupo"), New System.Data.SqlClient.SqlParameter("@cod_alumno", System.Data.SqlDbType.Int, 0, "cod_alumno"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.[Date], 0, "fecha")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "dbo.nactualizarMatriculas"
        Me.SqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlUpdateCommand1.Connection = Me.Conn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.[Variant], 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@cod_grupo", System.Data.SqlDbType.Int, 0, "cod_grupo"), New System.Data.SqlClient.SqlParameter("@cod_alumno", System.Data.SqlDbType.Int, 0, "cod_alumno"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.[Date], 0, "fecha"), New System.Data.SqlClient.SqlParameter("@Original_cod_matricula", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_matricula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cod_grupo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_grupo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cod_alumno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_alumno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@cod_matricula", System.Data.SqlDbType.Int, 4, "cod_matricula")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "dbo.nborrarMatriculas"
        Me.SqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlDeleteCommand1.Connection = Me.Conn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.[Variant], 0, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cod_matricula", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_matricula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cod_grupo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_grupo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cod_alumno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_alumno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing)})
        '
        'db1
        '
        Me.db1.DeleteCommand = Me.SqlDeleteCommand1
        Me.db1.InsertCommand = Me.SqlInsertCommand1
        Me.db1.SelectCommand = Me.SqlSelectCommand1
        Me.db1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "nseleccionarMatriculas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_matricula", "cod_matricula"), New System.Data.Common.DataColumnMapping("cod_grupo", "cod_grupo"), New System.Data.Common.DataColumnMapping("cod_alumno", "cod_alumno"), New System.Data.Common.DataColumnMapping("fecha", "fecha")})})
        Me.db1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'MatriculasBindingSource
        '
        Me.MatriculasBindingSource.DataMember = "matriculas"
        Me.MatriculasBindingSource.DataSource = Me.MatriculaPECDataSet
        '
        'MatriculaPECDataSet
        '
        Me.MatriculaPECDataSet.DataSetName = "MatriculaPECDataSet"
        Me.MatriculaPECDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MatriculasTableAdapter
        '
        Me.MatriculasTableAdapter.ClearBeforeFill = True
        '
        'mta1
        '
        Me.mta1.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(239, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 71)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Estudiantes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 443)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Menu"
        Me.Text = "Matricula "
        CType(Me.MatriculasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculaPECDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents db1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Conn As System.Data.SqlClient.SqlConnection
    Friend WithEvents MatriculaPECDataSet As MatriculaPEC.MatriculaPECDataSet
    Friend WithEvents MatriculasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MatriculasTableAdapter As MatriculaPEC.MatriculaPECDataSetTableAdapters.matriculasTableAdapter
    Friend WithEvents mta1 As MatriculaPEC.MatriculaPECDataSetTableAdapters.matriculasTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
