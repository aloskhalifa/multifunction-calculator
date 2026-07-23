Public Class Multifunction

    Private Sub closebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebt.Click
        Me.Close()
    End Sub

    Private Sub minimizebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizebt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub scientificbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scientificbt.Click
        functions.FormOverlay(scientificform)
    End Sub

    Private Sub gpbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpbt.Click
        functions.FormOverlay(gpacalculator)
    End Sub

    Private Sub agebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agebt.Click
        functions.FormOverlay(agecalculator)
    End Sub

    Private Sub boylesbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boylesbt.Click
        functions.FormOverlay(boyleslawform)
    End Sub

    Private Sub loanbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loanbt.Click
        functions.FormOverlay(loancaculatorform)
    End Sub

    Private Sub converterbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles converterbt.Click
        functions.FormOverlay(Unit_Converter)
    End Sub
End Class
