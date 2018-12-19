Public Class FrmMain
    
    Dim ReadOnly _orderForms As List(Of FrmOrder) = New List(Of FrmOrder)()

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddTab()
        OrderTabs.SelectedTab = OrderTabs.TabPages.Item(0)
    End Sub
    Private Sub OrderTabs_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles OrderTabs.Selecting
        If OrderTabs.SelectedTab.TabIndex <> 1 Then
            Return
        End If
        AddTab()
        e.Cancel = True
    End Sub

    Private Sub AddTab()
        Dim index As Int32 = OrderTabs.TabPages.Count
        Dim tabPage As TabPage = New TabPage()
        tabPage.Controls.Add(AddForm(new FrmOrder()))
        tabPage.Text = $"Order #" & index
        OrderTabs.TabPages.Insert(index - 1, tabPage)
    End Sub
    
    Private Function AddForm(frm as frmOrder) As Form
        frm.TopLevel = false
        frm.Visible = true
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        _orderForms.Add(frm)
        return frm
    End Function

    Private Sub btnGenerateBill_Click(sender As Object, e As EventArgs) Handles btnGenerateBill.Click
        For Each frm As FrmOrder In _orderForms
            'Do stuff with these controls
            'frm.ComboBox1
            'frm.ComboBox2
            'frm.ComboBox3
        Next
    End Sub
End Class
