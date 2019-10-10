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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lblAverageRunTime = New System.Windows.Forms.Label()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.runColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resultColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pBarRunsDone = New System.Windows.Forms.ProgressBar()
        Me.nupRuns = New System.Windows.Forms.NumericUpDown()
        Me.btnStartPerformanceTest = New System.Windows.Forms.Button()
        Me.chkSuspenLayout = New System.Windows.Forms.CheckBox()
        Me.chkDestroyPanelHandle = New System.Windows.Forms.CheckBox()
        Me.panel1.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupRuns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.Controls.Add(Me.lblAverageRunTime)
        Me.panel1.Controls.Add(Me.dgvResults)
        Me.panel1.Location = New System.Drawing.Point(226, 315)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(524, 550)
        Me.panel1.TabIndex = 11
        '
        'lblAverageRunTime
        '
        Me.lblAverageRunTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverageRunTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAverageRunTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageRunTime.Location = New System.Drawing.Point(0, 518)
        Me.lblAverageRunTime.Name = "lblAverageRunTime"
        Me.lblAverageRunTime.Size = New System.Drawing.Size(524, 32)
        Me.lblAverageRunTime.TabIndex = 6
        Me.lblAverageRunTime.Text = "Average run time:"
        '
        'dgvResults
        '
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.runColumn, Me.resultColumn})
        Me.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResults.Location = New System.Drawing.Point(0, 0)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.RowHeadersWidth = 62
        Me.dgvResults.RowTemplate.Height = 28
        Me.dgvResults.Size = New System.Drawing.Size(524, 550)
        Me.dgvResults.TabIndex = 5
        '
        'runColumn
        '
        Me.runColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        Me.runColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.runColumn.FillWeight = 20.0!
        Me.runColumn.HeaderText = "Run"
        Me.runColumn.MinimumWidth = 8
        Me.runColumn.Name = "runColumn"
        '
        'resultColumn
        '
        Me.resultColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3)
        Me.resultColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.resultColumn.FillWeight = 80.0!
        Me.resultColumn.HeaderText = "Result (ms)"
        Me.resultColumn.MinimumWidth = 8
        Me.resultColumn.Name = "resultColumn"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(414, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(51, 20)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Runs:"
        '
        'pBarRunsDone
        '
        Me.pBarRunsDone.Location = New System.Drawing.Point(278, 149)
        Me.pBarRunsDone.Name = "pBarRunsDone"
        Me.pBarRunsDone.Size = New System.Drawing.Size(472, 31)
        Me.pBarRunsDone.TabIndex = 9
        '
        'nupRuns
        '
        Me.nupRuns.Location = New System.Drawing.Point(484, 15)
        Me.nupRuns.Name = "nupRuns"
        Me.nupRuns.Size = New System.Drawing.Size(115, 26)
        Me.nupRuns.TabIndex = 8
        Me.nupRuns.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnStartPerformanceTest
        '
        Me.btnStartPerformanceTest.Location = New System.Drawing.Point(412, 219)
        Me.btnStartPerformanceTest.Name = "btnStartPerformanceTest"
        Me.btnStartPerformanceTest.Size = New System.Drawing.Size(215, 64)
        Me.btnStartPerformanceTest.TabIndex = 7
        Me.btnStartPerformanceTest.Text = "Start Performance Test"
        Me.btnStartPerformanceTest.UseVisualStyleBackColor = True
        '
        'chkSuspenLayout
        '
        Me.chkSuspenLayout.AutoSize = True
        Me.chkSuspenLayout.Checked = True
        Me.chkSuspenLayout.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSuspenLayout.Location = New System.Drawing.Point(418, 91)
        Me.chkSuspenLayout.Name = "chkSuspenLayout"
        Me.chkSuspenLayout.Size = New System.Drawing.Size(161, 24)
        Me.chkSuspenLayout.TabIndex = 13
        Me.chkSuspenLayout.Text = "Suspend Drawing"
        Me.chkSuspenLayout.UseVisualStyleBackColor = True
        '
        'chkDestroyPanelHandle
        '
        Me.chkDestroyPanelHandle.AutoSize = True
        Me.chkDestroyPanelHandle.Checked = True
        Me.chkDestroyPanelHandle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDestroyPanelHandle.Location = New System.Drawing.Point(418, 60)
        Me.chkDestroyPanelHandle.Name = "chkDestroyPanelHandle"
        Me.chkDestroyPanelHandle.Size = New System.Drawing.Size(189, 24)
        Me.chkDestroyPanelHandle.TabIndex = 12
        Me.chkDestroyPanelHandle.Text = "Destroy Panel Handle"
        Me.chkDestroyPanelHandle.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 877)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pBarRunsDone)
        Me.Controls.Add(Me.nupRuns)
        Me.Controls.Add(Me.btnStartPerformanceTest)
        Me.Controls.Add(Me.chkSuspenLayout)
        Me.Controls.Add(Me.chkDestroyPanelHandle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupRuns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents lblAverageRunTime As Label
    Private WithEvents dgvResults As DataGridView
    Private WithEvents runColumn As DataGridViewTextBoxColumn
    Private WithEvents resultColumn As DataGridViewTextBoxColumn
    Private WithEvents label1 As Label
    Private WithEvents pBarRunsDone As ProgressBar
    Private WithEvents nupRuns As NumericUpDown
    Private WithEvents btnStartPerformanceTest As Button
    Private WithEvents chkSuspenLayout As CheckBox
    Private WithEvents chkDestroyPanelHandle As CheckBox
End Class
