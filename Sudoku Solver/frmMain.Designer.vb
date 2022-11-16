<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenPuzzlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.cmbSolve = New System.Windows.Forms.ComboBox()
        Me.cmbSource = New System.Windows.Forms.ComboBox()
        Me.butSolve = New System.Windows.Forms.Button()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1270, 24)
        Me.msMain.TabIndex = 0
        Me.msMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenPuzzlesToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenPuzzlesToolStripMenuItem
        '
        Me.OpenPuzzlesToolStripMenuItem.Name = "OpenPuzzlesToolStripMenuItem"
        Me.OpenPuzzlesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenPuzzlesToolStripMenuItem.Text = "Open Puzzles"
        '
        'ssMain
        '
        Me.ssMain.Location = New System.Drawing.Point(0, 526)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(1270, 22)
        Me.ssMain.TabIndex = 1
        Me.ssMain.Text = "StatusStrip1"
        '
        'rtbLog
        '
        Me.rtbLog.Location = New System.Drawing.Point(348, 27)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.Size = New System.Drawing.Size(257, 481)
        Me.rtbLog.TabIndex = 2
        Me.rtbLog.Text = ""
        '
        'cmbSolve
        '
        Me.cmbSolve.FormattingEnabled = True
        Me.cmbSolve.Items.AddRange(New Object() {"Simple Line", "Simple Column", "Simple Square"})
        Me.cmbSolve.Location = New System.Drawing.Point(12, 52)
        Me.cmbSolve.Name = "cmbSolve"
        Me.cmbSolve.Size = New System.Drawing.Size(214, 21)
        Me.cmbSolve.TabIndex = 3
        Me.cmbSolve.Text = "Simple Line"
        '
        'cmbSource
        '
        Me.cmbSource.FormattingEnabled = True
        Me.cmbSource.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbSource.Location = New System.Drawing.Point(12, 102)
        Me.cmbSource.Name = "cmbSource"
        Me.cmbSource.Size = New System.Drawing.Size(121, 21)
        Me.cmbSource.TabIndex = 4
        Me.cmbSource.Text = "1"
        '
        'butSolve
        '
        Me.butSolve.Location = New System.Drawing.Point(12, 151)
        Me.butSolve.Name = "butSolve"
        Me.butSolve.Size = New System.Drawing.Size(75, 23)
        Me.butSolve.TabIndex = 5
        Me.butSolve.Text = "Solve"
        Me.butSolve.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 548)
        Me.Controls.Add(Me.butSolve)
        Me.Controls.Add(Me.cmbSource)
        Me.Controls.Add(Me.cmbSolve)
        Me.Controls.Add(Me.rtbLog)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.msMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sudoku Solver - Main"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenPuzzlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents rtbLog As RichTextBox
    Friend WithEvents cmbSolve As ComboBox
    Friend WithEvents cmbSource As ComboBox
    Friend WithEvents butSolve As Button
End Class
