Public Class loancaculatorform
    Dim duration As Integer
    Dim interest, loan, repayment, monthlyrepayment, totalrepayment, totalpayment, months, loandiff, rate As Double
    Private Sub calculatebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatebt.Click
        If String.IsNullOrWhiteSpace(loanbox.Text) Or
            String.IsNullOrWhiteSpace(durationbox.Text) Then
            MessageBox.Show("PLEASE FILL THE LOAN AND DURATION BOX!", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            loanbox.Focus()
            Return
        End If
        If Not Double.TryParse(loanbox.Text, loan) OrElse loan <= 0 Then
            MessageBox.Show("PLEASE INPUT A VALID LOAN AMOUNT.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            loanbox.Clear()
            loanbox.Focus()
            Return
        ElseIf Not Integer.TryParse(durationbox.Text, duration) OrElse duration < 1 Then
            MessageBox.Show("PLEASE INPUT A VALID NUMBER OF MONTHS.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            durationbox.Clear()
            durationbox.Focus()
            Return
        End If

        If loanbox.Text > 6000000 Then
            MessageBox.Show("LOAN AMOUNT HAS EXCEEDED 6 MILLION!", "WARNING.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            loanbox.Clear()
            loanbox.Focus()
            Return
        End If

        If durationbox.Text > 12 Then
            MessageBox.Show("LOAN DURATION HAS EXCEEDED 12 MONTHS!", "WARNING.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            durationbox.Clear()
            durationbox.Focus()
            Return
        End If
        rate = 0.015
        repayment = loan / duration

        ListBox.Items.Clear()
        ListBox.Items.Add("Months |  Principal    | Repayment     | Interest    | Monthly Repayment")
        ListBox.Items.Add("________________________________________________________________________")

        For months = 1 To duration
            interest = rate * loan
            monthlyrepayment = repayment + interest
            totalrepayment += monthlyrepayment
            loandiff += interest
            ListBox.Items.Add(months.ToString().PadRight(14) + "|" +
                                        loan.ToString("n2").PadRight(14) + "|" +
                                        repayment.ToString("n2").PadRight(14) + "|" +
                                        interest.ToString("n2").PadRight(14) + "|" +
                                        (monthlyrepayment).ToString("n2").PadRight(14))
            loan -= repayment
        Next
        interestbox.Text = loandiff.ToString("n2")
        principalbox.Text = totalrepayment.ToString("n2")
    End Sub

    Private Sub closebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebt.Click
        Me.Close()
    End Sub

    Private Sub resetbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetbt.Click
        ListBox.Items.Clear()
        loanbox.Text = ""
        durationbox.Text = ""
        principalbox.Text = "0"
        interestbox.Text = "0"
    End Sub

    Private Sub loanbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles loanbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("ONLY DIGITS ARE ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf e.KeyChar = "." AndAlso loanbox.Text.Length = 0 Then
            e.Handled = True
            MessageBox.Show("DECIMAL CAN'T BE THE FIRST CHARACTER!", "INVALID INPUT.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf e.KeyChar = "." AndAlso loanbox.Text.Contains(".") Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub durationbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles durationbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("ONLY DIGITS ARE ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
    End Sub
End Class