Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        ' Read the input from the user
        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        ' All input must be numbers
        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) _
                And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If

        ' Convert to double
        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        txtResult.Text = FindIntersection(A, B, C, D)

       
    End Sub
    Function FindIntersection(A As Double,
                              B As Double,
                              C As Double,
                              D As Double) As String
        'Guarantee there is no intersection
        Dim result As String
        If B < C Or D < A Then
            result = txtResult.Text
            txtResult.Text = "They do not intersect"

        Else
            Dim begPoint As Double
            begPoint = Math.Max(A, C)

            Dim endPoint As Double
            endPoint = Math.Min(B, D)

            txtResult.Text = "There is an intersection from " & begPoint & " to " & endPoint
        End If

        'Solve where the intersection is, Why won't this code work, with all the different cases being listed

        'Dim intersection As String
        'If A < C And D < B Then
        'intersection = txtResult.Text
        'txtResult.Text = "There is an intersection from" & C & " to" & D

        Return txtResult.Text

    End Function
End Class
