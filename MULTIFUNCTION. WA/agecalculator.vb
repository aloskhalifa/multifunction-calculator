Public Class agecalculator
    Dim currentday, currentmonth, currentyear, birthday, birthmonth, birthyear, daysinmonth, daydiff, monthdiff, yeardiff As Integer

    Private Sub closebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebt.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timedisplay.Text = Date.Now
    End Sub

    Private Sub calculatebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatebt.Click
        If String.IsNullOrWhiteSpace(birthyear_txt.Text) Or
            String.IsNullOrWhiteSpace(birthmonth_txt.Text) Or
            String.IsNullOrWhiteSpace(birthday_txt.Text) Then
            MessageBox.Show("PLEASE FILL ALL EMPTY SPACES.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            birthyear_txt.Focus()
            Return
        End If

        currentyear = Date.Now.Year
        currentmonth = Date.Now.Month
        currentday = Date.Now.Day
        birthyear = birthyear_txt.Text
        birthmonth = birthmonth_txt.Text
        birthday = birthday_txt.Text

        If (birthyear > currentyear) Or (birthyear < 1000) Then

            MessageBox.Show("INVALID YEAR INPUT! TRY AGAIN.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            birthyear_txt.Clear()
            birthyear_txt.Focus()
            Return

        ElseIf (birthmonth > 12) OrElse (birthmonth < 1) Then

            MessageBox.Show("INVALID MONTH INPUT! TRY AGAIN.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            birthmonth_txt.Clear()
            birthmonth_txt.Focus()
            Return
        End If

        daysinmonth = DateTime.DaysInMonth(birthyear, birthmonth)

        If (birthday > daysinmonth) Or (birthday < 1) Then

            MessageBox.Show("INVALID DAY OF MONTH INPUT! TRY AGAIN.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            birthday_txt.Clear()
            birthday_txt.Focus()
            Return

        End If

        If birthyear <= currentyear And birthmonth <= currentmonth And birthday <= currentday Then

            yeardiff_txt.Text = currentyear - birthyear
            monthdiff_txt.Text = currentmonth - birthmonth
            daydiff_txt.Text = currentday - birthday

        ElseIf birthyear < currentyear And birthmonth < currentmonth And birthday > currentday Then

            yeardiff_txt.Text = currentyear - birthyear
            monthdiff_txt.Text = (currentmonth - birthmonth) - 1
            daydiff_txt.Text = (currentday - birthday) + daysinmonth

        ElseIf birthyear < currentyear And birthmonth = currentmonth And birthday > currentday Then

            yeardiff_txt.Text = (currentyear - birthyear) - 1
            monthdiff_txt.Text = ((currentmonth - birthmonth) + 12) - 1
            daydiff_txt.Text = (currentday - birthday) + daysinmonth

        ElseIf birthyear < currentyear And birthmonth > currentmonth And birthday < currentday Then

            yeardiff_txt.Text = (currentyear - birthyear) - 1
            monthdiff_txt.Text = ((currentmonth - birthmonth) + 12)
            daydiff_txt.Text = currentday - birthday
        ElseIf birthyear < currentyear And birthmonth > currentmonth And birthday = currentday Then

            yeardiff_txt.Text = (currentyear - birthyear) - 1
            monthdiff_txt.Text = ((currentmonth - birthmonth) + 12)
            daydiff_txt.Text = currentday - birthday
        ElseIf birthyear < currentyear And birthmonth > currentmonth And birthday > currentday Then

            yeardiff_txt.Text = (currentyear - birthyear) - 1
            monthdiff_txt.Text = ((currentmonth - birthmonth) + 12) - 1
            daydiff_txt.Text = (currentday - birthday) + daysinmonth

        ElseIf birthyear = currentyear And birthmonth < currentmonth And birthday > currentday Then

            yeardiff_txt.Text = currentyear - birthyear
            monthdiff_txt.Text = (currentmonth - birthmonth) - 1
            daydiff_txt.Text = (currentday - birthday) + daysinmonth

        ElseIf birthyear = currentyear And birthmonth = currentmonth And birthday > currentday Then

            MessageBox.Show("YOUR BIRTHDAY CANNOT BE GREATER THAN CURRENT DATE.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        ElseIf birthyear = currentyear And birthmonth > currentmonth And birthday < currentday Then

            MessageBox.Show("YOUR BIRTHDAY CANNOT BE GREATER THAN CURRENT DATE.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        ElseIf birthyear = currentyear And birthmonth > currentmonth And birthday >= currentday Then

            MessageBox.Show("YOUR BIRTHDAY CANNOT BE GREATER THAN CURRENT DATE.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
    End Sub

    Private Sub clearbt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbt.Click
        birthday_txt.Text = ""
        birthmonth_txt.Text = ""
        birthyear_txt.Text = ""
        daydiff_txt.Text = ""
        monthdiff_txt.Text = ""
        yeardiff_txt.Text = ""
    End Sub

    Private Sub birthyear_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles birthyear_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("ONLY DIGITS ARE ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If e.KeyChar <> ControlChars.Back Then
            Dim text As String = birthyear_txt.Text & e.KeyChar
            If text.Length > 4 Then
                e.Handled = True
                MessageBox.Show("MAXIMUM 4 DIGITS ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub birthmonth_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles birthmonth_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("ONLY DIGITS ARE ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If e.KeyChar <> ControlChars.Back Then
            Dim text As String = birthmonth_txt.Text & e.KeyChar
            If text.Length > 2 Then
                e.Handled = True
                MessageBox.Show("MAXIMUM 2 DIGITS ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub birthday_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles birthday_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("ONLY DIGITS ARE ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If e.KeyChar <> ControlChars.Back Then
            Dim text As String = birthday_txt.Text & e.KeyChar
            If text.Length > 2 Then
                e.Handled = True
                MessageBox.Show("MAXIMUM 2 DIGITS ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class