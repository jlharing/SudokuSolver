Public Class SudokuSolver
    Public Property Puzzles As New List(Of SudokuPuzzle)
    Public Property CurrentPuzzle As SudokuPuzzle

    Public Sub New()

    End Sub
    Public Sub Solve()

    End Sub
    Public Sub AddPuzzle(Puzzle As SudokuPuzzle)
        Puzzles.Add(Puzzle)
    End Sub
    Public Sub Init()
        CurrentPuzzle = Puzzles(2)
        DisplayPuzzle()
    End Sub
#Region "Solving Routines"
#Region "Solver Simple Row"
    Public Sub SolveSimpleRow()

        Dim FoundOne As Boolean = True
        Dim Success As Boolean = False

        frmMain.rtbLog.Text = frmMain.rtbLog.Text & "Simple Row Part 1" & vbCrLf
        While FoundOne
            Dim Rows() As String = CurrentPuzzle.GetRows
            FoundOne = False
            For i As Integer = 1 To 9
                Success = SSRSolveRowAllButOne(i, Rows)
                If Success Then
                    FoundOne = True
                    Exit For
                End If
            Next
            DisplayPuzzle()
        End While
        frmMain.rtbLog.Text = frmMain.rtbLog.Text & "Simple Row Part 2" & vbCrLf
        FoundOne = True
        While FoundOne
            Dim Rows() As String = CurrentPuzzle.GetRows
            FoundOne = False
            For i As Integer = 1 To 9
                Success = SSRSolveRowOnlyOne(i, Rows)
                If Success Then
                    FoundOne = True
                    Exit For
                End If
            Next
            DisplayPuzzle()
        End While
    End Sub
    Private Function SSRSolveRowAllButOne(Row As Integer, Rows() As String) As Boolean
        '
        ' Try to find a column that has all but one of the missing numbers
        '
        Dim Blanks As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim Missing As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim BlankCount As Integer = 0
        Dim MissingCount As Integer = 0
        Dim FoundInColumnCount As Integer = 0

        ' Find and count the blanks
        For i As Integer = 1 To 9
            If Rows(Row).Substring(i - 1, 1) = 0 Then
                BlankCount += 1
                Blanks(BlankCount) = i
            End If
        Next
        If BlankCount = 0 Then
            Return False
        End If
        If BlankCount > 5 Then
            Return False
        End If

        ' Find the missing numbers
        Dim FoundIt As Boolean = False
        For i As Integer = 1 To 9
            FoundIt = False
            For j As Integer = 1 To 9
                If Rows(Row).Substring(j - 1, 1) = i Then
                    FoundIt = True
                End If
            Next
            If Not FoundIt Then
                MissingCount += 1
                Missing(MissingCount) = i
            End If
        Next

        ' Check columns with blank for all but 1 of the missing
        For i As Integer = 1 To 9
            If Rows(Row).Substring(i - 1, 1) = 0 Then
                ' Count how many of the missing are in this column
                Dim CheckingCol As String = ""
                FoundInColumnCount = 0
                For j As Integer = 1 To MissingCount
                    CheckingCol = CurrentPuzzle.GetCol(i)
                    For k As Integer = 1 To 9
                        If CheckingCol.Substring(k - 1, 1) = Missing(j) Then
                            FoundInColumnCount += 1
                        End If
                    Next
                Next
                ' Can solve this row/column with info that I have
                If FoundInColumnCount = MissingCount - 1 Then
                    ' Loop through the missing numbers
                    For j As Integer = 1 To MissingCount
                        CheckingCol = CurrentPuzzle.GetCol(i)
                        ' Go through the column blanking out the rows missing numbers found in this column
                        For k As Integer = 1 To 9
                            If CheckingCol.Substring(k - 1, 1) = Missing(j) Then
                                Missing(j) = 0
                            End If
                        Next
                    Next
                    ' Find them missing number that is left and it is the one that goes here
                    For j = 1 To 9
                        If Missing(j) <> 0 Then
                            CurrentPuzzle.SetCell(Row, i, Missing(j))
                            frmMain.rtbLog.Text = frmMain.rtbLog.Text & "Row " & Row & " can solve column " & i & " Value " & Missing(j) & vbCrLf
                            Return True
                        End If
                    Next
                End If
            End If
        Next

        Return False
    End Function
    Private Function SSRSolveRowOnlyOne(Row As Integer, Rows() As String) As Boolean
        '
        ' Try to find one of the missing columns that is the only one missing a number
        '
        Dim Blanks As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim Missing As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim BlankCount As Integer = 0
        Dim MissingCount As Integer = 0
        Dim FoundInColumnCount As Integer = 0

        ' Find and count the blanks
        For i As Integer = 1 To 9
            If Rows(Row).Substring(i - 1, 1) = 0 Then
                BlankCount += 1
                Blanks(BlankCount) = i
            End If
        Next
        If BlankCount = 0 Then
            Return False
        End If
        If BlankCount > 4 Then
            Return False
        End If

        ' Find the missing numbers
        Dim FoundIt As Boolean = False
        For i As Integer = 1 To 9
            FoundIt = False
            For j As Integer = 1 To 9
                If Rows(Row).Substring(j - 1, 1) = i Then
                    FoundIt = True
                End If
            Next
            If Not FoundIt Then
                MissingCount += 1
                Missing(MissingCount) = i
            End If
        Next

        ' Checking each missing number
        For i As Integer = 1 To MissingCount

        Next
        Return False
    End Function
#End Region
#End Region
#Region "Display Puzzle"
    Public Sub DisplayPuzzle()

        For i As Integer = 1 To 81
            DisplayCell(i, CurrentPuzzle.Puzzle, CurrentPuzzle.Solving)
        Next
    End Sub
    Private Sub DisplayCell(Cell As Integer, OPuzzle As String, SPuzzle As String)
        Dim CellColor As Color = Color.Black
        Dim CellText As String = ""

        CellText = SPuzzle.Substring(Cell - 1, 1)
        If CellText = "0" Then
            CellText = " "
        End If
        If SPuzzle.Substring(Cell - 1, 1) <> OPuzzle.Substring(Cell - 1, 1) Then
            CellColor = Color.Blue
        End If

        SCells(Cell).Text = CellText
        SCells(Cell).ForeColor = CellColor
    End Sub
#End Region
End Class
