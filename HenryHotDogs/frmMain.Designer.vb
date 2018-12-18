<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerateBill = New System.Windows.Forms.Button()
        Me.OrderTabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.newTab = New System.Windows.Forms.TabPage()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout
        Me.OrderTabs.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnGenerateBill, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.OrderTabs, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtOutput, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(327, 319)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Henry's Hot Dogs, please review the menu items below, and choose a mea"& _ 
    "l, side, and drink"
        '
        'btnGenerateBill
        '
        Me.btnGenerateBill.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnGenerateBill.Location = New System.Drawing.Point(3, 136)
        Me.btnGenerateBill.Name = "btnGenerateBill"
        Me.btnGenerateBill.Size = New System.Drawing.Size(321, 87)
        Me.btnGenerateBill.TabIndex = 2
        Me.btnGenerateBill.Text = "Generate Bill"
        Me.btnGenerateBill.UseVisualStyleBackColor = true
        '
        'OrderTabs
        '
        Me.OrderTabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.OrderTabs.Controls.Add(Me.TabPage1)
        Me.OrderTabs.Controls.Add(Me.newTab)
        Me.OrderTabs.Location = New System.Drawing.Point(3, 43)
        Me.OrderTabs.Name = "OrderTabs"
        Me.OrderTabs.SelectedIndex = 0
        Me.OrderTabs.Size = New System.Drawing.Size(321, 87)
        Me.OrderTabs.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(313, 61)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Order #1"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'newTab
        '
        Me.newTab.Location = New System.Drawing.Point(4, 22)
        Me.newTab.Name = "newTab"
        Me.newTab.Padding = New System.Windows.Forms.Padding(3)
        Me.newTab.Size = New System.Drawing.Size(313, 61)
        Me.newTab.TabIndex = 1
        Me.newTab.Text = "+"
        Me.newTab.UseVisualStyleBackColor = true
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtOutput.Location = New System.Drawing.Point(3, 229)
        Me.txtOutput.Multiline = true
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(321, 87)
        Me.txtOutput.TabIndex = 4
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 321)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmMain"
        Me.Text = "Henry's Hot Dogs"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.OrderTabs.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerateBill As Button
    Friend WithEvents OrderTabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents newTab As TabPage
    Friend WithEvents txtOutput As TextBox
End Class
