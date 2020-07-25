<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataSet1 = New WindowsApplication1.DataSet1
        Me.Faturamento_instrucaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Faturamento_instrucaoTableAdapter = New WindowsApplication1.DataSet1TableAdapters.faturamento_instrucaoTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.DataSet1TableAdapters.TableAdapterManager
        Me.Faturamento_instrucaoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.Faturamento_instrucaoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.InstrucaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstrucaoTableAdapter = New WindowsApplication1.DataSet1TableAdapters.instrucaoTableAdapter
        Me.Faturamento_instrucaoDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Faturamento_instrucaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Faturamento_instrucaoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Faturamento_instrucaoBindingNavigator.SuspendLayout()
        CType(Me.InstrucaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Faturamento_instrucaoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Faturamento_instrucaoBindingSource
        '
        Me.Faturamento_instrucaoBindingSource.DataMember = "faturamento_instrucao"
        Me.Faturamento_instrucaoBindingSource.DataSource = Me.DataSet1
        '
        'Faturamento_instrucaoTableAdapter
        '
        Me.Faturamento_instrucaoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.faturamento_instrucaoTableAdapter = Me.Faturamento_instrucaoTableAdapter
        Me.TableAdapterManager.instrucaoTableAdapter = Me.InstrucaoTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Faturamento_instrucaoBindingNavigator
        '
        Me.Faturamento_instrucaoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Faturamento_instrucaoBindingNavigator.BindingSource = Me.Faturamento_instrucaoBindingSource
        Me.Faturamento_instrucaoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Faturamento_instrucaoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Faturamento_instrucaoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Faturamento_instrucaoBindingNavigatorSaveItem})
        Me.Faturamento_instrucaoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Faturamento_instrucaoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Faturamento_instrucaoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Faturamento_instrucaoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Faturamento_instrucaoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Faturamento_instrucaoBindingNavigator.Name = "Faturamento_instrucaoBindingNavigator"
        Me.Faturamento_instrucaoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Faturamento_instrucaoBindingNavigator.Size = New System.Drawing.Size(759, 25)
        Me.Faturamento_instrucaoBindingNavigator.TabIndex = 0
        Me.Faturamento_instrucaoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Faturamento_instrucaoBindingNavigatorSaveItem
        '
        Me.Faturamento_instrucaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Faturamento_instrucaoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Faturamento_instrucaoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Faturamento_instrucaoBindingNavigatorSaveItem.Name = "Faturamento_instrucaoBindingNavigatorSaveItem"
        Me.Faturamento_instrucaoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Faturamento_instrucaoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InstrucaoBindingSource
        '
        Me.InstrucaoBindingSource.DataMember = "instrucao"
        Me.InstrucaoBindingSource.DataSource = Me.DataSet1
        '
        'InstrucaoTableAdapter
        '
        Me.InstrucaoTableAdapter.ClearBeforeFill = True
        '
        'Faturamento_instrucaoDataGridView
        '
        Me.Faturamento_instrucaoDataGridView.AutoGenerateColumns = False
        Me.Faturamento_instrucaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Faturamento_instrucaoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Faturamento_instrucaoDataGridView.DataSource = Me.Faturamento_instrucaoBindingSource
        Me.Faturamento_instrucaoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Faturamento_instrucaoDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Faturamento_instrucaoDataGridView.Name = "Faturamento_instrucaoDataGridView"
        Me.Faturamento_instrucaoDataGridView.Size = New System.Drawing.Size(759, 457)
        Me.Faturamento_instrucaoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cd_faturamento"
        Me.DataGridViewTextBoxColumn1.HeaderText = "cd_faturamento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cd_instrucao"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cd_instrucao"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nr_instrucao"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nr_instrucao"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 482)
        Me.Controls.Add(Me.Faturamento_instrucaoDataGridView)
        Me.Controls.Add(Me.Faturamento_instrucaoBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Faturamento_instrucaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Faturamento_instrucaoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Faturamento_instrucaoBindingNavigator.ResumeLayout(False)
        Me.Faturamento_instrucaoBindingNavigator.PerformLayout()
        CType(Me.InstrucaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Faturamento_instrucaoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents Faturamento_instrucaoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Faturamento_instrucaoTableAdapter As WindowsApplication1.DataSet1TableAdapters.faturamento_instrucaoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Faturamento_instrucaoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Faturamento_instrucaoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents InstrucaoTableAdapter As WindowsApplication1.DataSet1TableAdapters.instrucaoTableAdapter
    Friend WithEvents InstrucaoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Faturamento_instrucaoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
