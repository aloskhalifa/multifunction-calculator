Public Class unit_converter
    Private Sub unit_converter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        combobox.Items.Clear()
        combobox.Items.Add("Choose One")
        combobox.Items.Add("Celsius to Fahrenheit")
        combobox.Items.Add("Fahrenheit to Celsius")
        combobox.Items.Add("Miles to Kilometres")
        combobox.Items.Add("Kilometres to Miles")
        combobox.Items.Add("Centimeters to Meters")
        combobox.SelectedIndex = 0
    End Sub

    Private _autoConvert As Boolean = False

    Private Sub PerformConversion()
        Dim convert As Double
        If Not Double.TryParse(inputbox.Text, convert) Then
            resultbox.Text = ""
            Return
        End If
        If combobox.Text = "Choose One" Then
            MessageBox.Show("Select a Conversion Type!", "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Select Case combobox.Text
            Case "Celsius to Fahrenheit"
                convert = (9 / 5) * convert + 32
                resultbox.Text = convert.ToString("F2") & " Fahrenheit"
            Case "Fahrenheit to Celsius"
                convert = (convert - 32) * 5 / 9
                resultbox.Text = convert.ToString("F2") & " Celsius"
            Case "Miles to Kilometres"
                convert *= 1.60934
                resultbox.Text = convert.ToString("F2") & " Kilometres"
            Case "Kilometres to Miles"
                convert /= 1.60934
                resultbox.Text = convert.ToString("F2") & " Miles"
            Case "Centimeters to Meters"
                convert /= 100
                resultbox.Text = convert.ToString("F2") & " Meters"
            Case Else
                resultbox.Text = "Invalid Conversion Type"
        End Select
    End Sub

    Private Sub calculatebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatebt.Click
        _autoConvert = True
        PerformConversion()
    End Sub

    Private Sub clearbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbt.Click
        _autoConvert = False
        combobox.SelectedIndex = 0
        inputbox.Text = String.Empty
        resultbox.Text = String.Empty
    End Sub

    Private Sub inputbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputbox.TextChanged
        If _autoConvert Then
            PerformConversion()
        End If
    End Sub

    Private Sub combobox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combobox.SelectedIndexChanged
        If _autoConvert Then
            PerformConversion()
        End If
    End Sub

    Private Sub inputbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inputbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("ONLY DIGITS ARE ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf e.KeyChar = "." AndAlso inputbox.Text.Length = 0 Then
            e.Handled = True
            MessageBox.Show("DECIMAL CAN'T BE THE FIRST CHARACTER!", "INVALID INPUT.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            inputbox.Focus()
            Return
        ElseIf e.KeyChar = "." AndAlso inputbox.Text.Contains(".") Then
            e.Handled = True
        End If
        If e.KeyChar <> ControlChars.Back Then
            Dim text As String = inputbox.Text & e.KeyChar
            Dim value As Double
            If Not Double.TryParse(text, value) OrElse value <= 0 OrElse value > 10000 Then
                e.Handled = True
                Return
            End If
        End If
    End Sub

    Private Sub closebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebt.Click
        Me.Close()
    End Sub
End Class