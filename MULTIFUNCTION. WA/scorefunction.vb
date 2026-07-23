Module scorefunction
    Function calcultegpa(ByVal score As Double, ByVal cu As Integer)
        Dim gpa As Double
        If (score >= 80) And (score <= 100) Then
            gpa = cu * 4.0
        ElseIf (score >= 70) And (score <= 79.9) Then
            gpa = cu * 3.5
        ElseIf (score >= 60) And (score <= 69.9) Then
            gpa = cu * 3.0
        ElseIf (score >= 50) And (score <= 59.9) Then
            gpa = cu * 2.5
        ElseIf (score >= 40) And (score <= 49.9) Then
            gpa = cu * 2.0
        ElseIf (score >= 0) And (score <= 39.9) Then
            gpa = cu * 0
        End If
        Return gpa
    End Function
End Module 