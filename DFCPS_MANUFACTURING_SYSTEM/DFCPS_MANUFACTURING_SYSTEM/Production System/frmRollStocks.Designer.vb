<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRollStocks
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(599, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(63, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(581, 20)
        Me.txtSearch.TabIndex = 7
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column6, Me.Column3, Me.Column4, Me.Column5, Me.Column1})
        Me.dgv.Location = New System.Drawing.Point(7, 38)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(693, 394)
        Me.dgv.TabIndex = 6
        '
        'Column2
        '
        Me.Column2.HeaderText = "ROLL NO."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "LOOM NO."
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "MESH"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "WIDTH (CM)"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "DENIER"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
        '
        'Column1
        '
        Me.Column1.HeaderText = "LENGTH (M)"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'frmRollStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(707, 444)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgv)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRollStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Loom Roll Inventory"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
