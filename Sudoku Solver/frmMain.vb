Imports System.IO
Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim but As Button
        For i As Integer = 1 To 81
            but = New Button
            but.Size = New Size(24, 24)
            but.Text = "3"
            but.Font = New Font(but.Font, FontStyle.Bold)
            SCells.Add(i, but)
        Next
        Dim x = 840
        Dim y = 65
        Dim s = 1
        For i As Integer = 1 To 3
            For j As Integer = 1 To 3
                For k As Integer = 1 To 3
                    For l As Integer = 1 To 3
                        SCells(s).Location = New Point(x, y)
                        Me.Controls.Add(SCells(s))
                        x = x + 22
                        s = s + 1
                    Next
                    x = x + 5
                Next
                x = 840
                y = y + 22
            Next
            y = y + 5
        Next
    End Sub

    Private Sub OpenPuzzlesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPuzzlesToolStripMenuItem.Click
        Dim iFile As New StreamReader("f:\sudoku.csv")
        Dim Line As String = ""
        Dim Parts() As String

        ' Remove Header
        Line = iFile.ReadLine
        While Not iFile.EndOfStream
            Line = iFile.ReadLine
            Parts = Line.Split(",")
            APuzzle = New SudokuPuzzle(Parts(0), Parts(1))
            MySolver.AddPuzzle(APuzzle)
        End While
        MySolver.Init()
        rtbLog.Text = rtbLog.Text & "Loaded Puzzle file." & vbCrLf
    End Sub

    Private Sub butSolve_Click(sender As Object, e As EventArgs) Handles butSolve.Click
        Select Case cmbSolve.Text
            Case "Simple Line"
                MySolver.SolveSimpleRow()
        End Select
    End Sub
End Class
