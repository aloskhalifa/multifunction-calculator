Module functions
    Function FormOverlay(ByVal newForm As Form)
        Dim overlay As New Form
        Try
            overlay.FormBorderStyle = FormBorderStyle.None
            overlay.Opacity = 0.7
            overlay.BackColor = Color.Black
            overlay.WindowState = FormWindowState.Maximized
            overlay.Show()
            newForm.Owner = overlay

            newForm.ShowDialog()
        Catch ex As Exception
        Finally
            overlay.Dispose()
        End Try
        Return newForm
    End Function
End Module