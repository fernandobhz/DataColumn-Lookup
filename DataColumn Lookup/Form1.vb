Public Class Form1

    Private Sub Faturamento_instrucaoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Faturamento_instrucaoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Faturamento_instrucaoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.instrucao' table. You can move, or remove it, as needed.
        Me.InstrucaoTableAdapter.Fill(Me.DataSet1.instrucao)
        'TODO: This line of code loads data into the 'DataSet1.faturamento_instrucao' table. You can move, or remove it, as needed.
        Me.Faturamento_instrucaoTableAdapter.Fill(Me.DataSet1.faturamento_instrucao)

    End Sub
End Class