Public Class SudokuPuzzle
    Public Property Puzzle As String = ""
    Public Property Solution As String = ""
    Public Property Solving As String = ""
    Public Sub New(Puzzle As String, Solution As String)
        Me.Puzzle = Puzzle
        Me.Solution = Solution
        Me.Solving = Puzzle
    End Sub
    Public Sub SetCell(Row As Integer, Col As Integer, Value As Integer)
        Dim Cell As Integer = ((Row - 1) * 9) + Col
        Solving = Solving.Substring(0, Cell - 1) & Value.ToString & Solving.Substring(Cell)
    End Sub
    Public Function GetRow(Row As Integer) As String
        Return GetRow(Row, True)
    End Function
    Public Function GetRow(Row As Integer, Solving As Boolean) As String
        If Solving Then
            Return Me.Solving.Substring((Row - 1) * 9, 9)
        Else
            Return Me.Puzzle.Substring((Row - 1) * 9, 9)
        End If
    End Function
    Public Function GetRows() As String()
        Return GetRows(True)
    End Function
    Public Function GetRows(Solving As Boolean) As String()
        Dim Rows(9) As String

        For i As Integer = 1 To 9
            Rows(i) = GetRow(i, Me.Solving)
        Next

        Return Rows
    End Function
    Public Function GetCol(Col As Integer) As String
        Return GetCol(Col, True)
    End Function
    Public Function GetCol(Col As Integer, Solving As Boolean) As String
        Dim sCol As String = ""

        If Me.Solving Then
            For i As Integer = Col - 1 To 71 + Col Step 9
                sCol = sCol & Me.Solving.Substring(i, 1)
            Next
        Else
            For i As Integer = Col - 1 To 71 + Col Step 9
                sCol = sCol & Me.Puzzle.Substring(i, 1)
            Next
        End If

        Return sCol
    End Function
    Public Function GetSection(Section As Integer) As String
        Dim sSect As String = ""
        Dim j As Integer = 0

        Select Case Section
            Case 1
                j = 0
            Case 2
                j = 3
            Case 3
                j = 6
        End Select
        For i As Integer = 1 To 3
            sSect = sSect & Me.Puzzle.Substring(j, 3)
            j = j + 9
        Next
        Return sSect
    End Function
End Class
