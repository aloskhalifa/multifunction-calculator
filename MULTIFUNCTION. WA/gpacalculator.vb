Public Class gpacalculator

    Private Sub close_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_bt.Click
        Me.Close()
    End Sub

    Private Sub gpacalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        firstsemesterpanel.Show()
        secondsemesterpanel.Hide()
    End Sub

    Private Sub firstsemesterbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firstsemesterbt.Click
        firstsemesterpanel.Show()
        secondsemesterpanel.Hide()
    End Sub

    Private Sub secondsemesterbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles secondsemesterbt.Click
        firstsemesterpanel.Hide()
        secondsemesterpanel.Show()
    End Sub

    Private Sub calculatebt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatebt1.Click

        Dim sdt101gp, mad102gp, sda103gp, wad104gp, nes105gp, gdt106gp, totalgp, firstsemestergpa, totalcu As Double

        If String.IsNullOrWhiteSpace(sdt101box.Text) Or
        String.IsNullOrWhiteSpace(mad102box.Text) Or
        String.IsNullOrWhiteSpace(sda103box.Text) Or
        String.IsNullOrWhiteSpace(wad104box.Text) Or
        String.IsNullOrWhiteSpace(nes105box.Text) Or
        String.IsNullOrWhiteSpace(gdt106box.Text) Then
            MessageBox.Show("PLEASE FILL ALL EMPTY SPACES.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            sdt101box.Focus()
            Return
        End If
        sdt101gp = scorefunction.calcultegpa(sdt101box.Text, 4)
        mad102gp = scorefunction.calcultegpa(mad102box.Text, 4)
        sda103gp = scorefunction.calcultegpa(sda103box.Text, 5)
        wad104gp = scorefunction.calcultegpa(wad104box.Text, 4)
        nes105gp = scorefunction.calcultegpa(nes105box.Text, 4)
        gdt106gp = scorefunction.calcultegpa(gdt106box.Text, 4)

        totalgp = sdt101gp + mad102gp + sda103gp + wad104gp + nes105gp + gdt106gp

        totalcu = 4 + 4 + 5 + 4 + 4 + 4

        firstsemestergpa = totalgp / totalcu

        gp1box.Text = totalgp.ToString("F2")

        gpa1box.Text = firstsemestergpa.ToString("F2")

        If (firstsemestergpa >= 3.5) And (firstsemestergpa <= 4.0) Then
            remark1box.Text = "Dinstiction"
        ElseIf (firstsemestergpa >= 3.0) And (firstsemestergpa <= 3.49) Then
            remark1box.Text = "Upper Credit"
        ElseIf (firstsemestergpa >= 2.5) And (firstsemestergpa <= 2.99) Then
            remark1box.Text = "Lower Credit"
        ElseIf (firstsemestergpa >= 2.0) And (firstsemestergpa <= 2.49) Then
            remark1box.Text = "Pass"
        ElseIf (firstsemestergpa >= 0) And (firstsemestergpa <= 1.99) Then
            remark1box.Text = "Fail"
        End If

    End Sub

    Private Sub clearbt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbt1.Click
        sdt101box.Text = ""
        mad102box.Text = ""
        sda103box.Text = ""
        wad104box.Text = ""
        nes105box.Text = ""
        gdt106box.Text = ""
        gpa1box.Text = ""
        gp1box.Text = ""
        remark1box.Text = ""
    End Sub

    Private Sub calculatebt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatebt2.Click
        Dim dbms201gp, uiux202gp, ai204gp, sqt205gp, aa206gp, devop207gp, secondsemestergpa, totalgp2, totalcu2 As Double

        If String.IsNullOrWhiteSpace(dbms201box.Text) Or
        String.IsNullOrWhiteSpace(uiux202box.Text) Or
        String.IsNullOrWhiteSpace(ai204box.Text) Or
        String.IsNullOrWhiteSpace(sqt205box.Text) Or
        String.IsNullOrWhiteSpace(aa206box.Text) Or
        String.IsNullOrWhiteSpace(devop207box.Text) Then
            MessageBox.Show("PLEASE FILL ALL EMPTY SPACES.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sdt101box.Focus()
            Return
        End If

        dbms201gp = scorefunction.calcultegpa(dbms201box.Text, 5)
        uiux202gp = scorefunction.calcultegpa(uiux202box.Text, 3)
        ai204gp = scorefunction.calcultegpa(ai204box.Text, 5)
        sqt205gp = scorefunction.calcultegpa(sqt205box.Text, 3)
        aa206gp = scorefunction.calcultegpa(aa206box.Text, 4)
        devop207gp = scorefunction.calcultegpa(devop207box.Text, 4)

        totalgp2 = dbms201gp + uiux202gp + ai204gp + sqt205gp + aa206gp + devop207gp

        totalcu2 = 5 + 3 + 5 + 3 + 4 + 4

        secondsemestergpa = totalgp2 / totalcu2

        gp2box.Text = totalgp2.ToString("F2")

        gpa2box.Text = secondsemestergpa.ToString("F2")

        If (secondsemestergpa >= 3.5) And (secondsemestergpa <= 4.0) Then
            remark2box.Text = "Dinstiction"
        ElseIf (secondsemestergpa >= 3.0) And (secondsemestergpa <= 3.49) Then
            remark2box.Text = "Upper Credit"
        ElseIf (secondsemestergpa >= 2.5) And (secondsemestergpa <= 2.99) Then
            remark2box.Text = "Lower Credit"
        ElseIf (secondsemestergpa >= 2.0) And (secondsemestergpa <= 2.49) Then
            remark2box.Text = "Pass"
        ElseIf (secondsemestergpa >= 0) And (secondsemestergpa <= 1.99) Then
            remark2box.Text = "Fail"
        End If

    End Sub

    Private Sub clearbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbt.Click
        dbms201box.Text = ""
        uiux202box.Text = ""
        ai204box.Text = ""
        sqt205box.Text = ""
        aa206box.Text = ""
        devop207box.Text = ""
        gpa2box.Text = ""
        gp2box.Text = ""
        remark2box.Text = ""
    End Sub

    
    Private Sub dbms201box_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles uiux202box.KeyPress, sqt205box.KeyPress, devop207box.KeyPress, dbms201box.KeyPress, ai204box.KeyPress, aa206box.KeyPress, wad104box.KeyPress, sdt101box.KeyPress, sda103box.KeyPress, nes105box.KeyPress, mad102box.KeyPress, gdt106box.KeyPress, sdt101box.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("ONLY DIGITS ARE ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, Guna.UI2.WinForms.Guna2TextBox).TextLength = 0) Then
            e.Handled = True
            MessageBox.Show("DECIMAL CAN'T BE THE FIRST CHARACTER!", "INVALID INPUT.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(".") > -1) Then
            e.Handled = True
        End If
        If e.KeyChar <> ControlChars.Back Then
            Dim text As String = (DirectCast(sender, Guna.UI2.WinForms.Guna2TextBox).Text & e.KeyChar).Trim()
            Dim value As Double
            If Not Double.TryParse(text, value) OrElse value < 0 OrElse value > 100 Then
                e.Handled = True
                MessageBox.Show("SCORE CAN NOT BE GREATER THAN 100!", "WARNING.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

End Class