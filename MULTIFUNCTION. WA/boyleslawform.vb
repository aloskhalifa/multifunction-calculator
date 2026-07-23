Public Class boyleslawform
    Dim p1, v1, p2, v2, a As Double

    Private Sub p1button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1button.Click
        p1box.Enabled = False
        v1box.Enabled = True
        v1box.Focus()
        p2box.Enabled = True
        v2box.Enabled = True
        p1box.Text = "?"
        v1box.Text = ""
        p2box.Text = ""
        v2box.Text = ""
        calculatebt.Enabled = True
    End Sub

    Private Sub v1button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v1button.Click
        p1box.Enabled = True
        p1box.Focus()
        v1box.Enabled = False
        p2box.Enabled = True
        v2box.Enabled = True
        p1box.Text = ""
        v1box.Text = "?"
        p2box.Text = ""
        v2box.Text = ""
        calculatebt.Enabled = True
    End Sub

    Private Sub p2button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2button.Click
        p1box.Enabled = True
        p1box.Focus()
        v1box.Enabled = True
        p2box.Enabled = False
        v2box.Enabled = True
        p1box.Text = ""
        v1box.Text = ""
        p2box.Text = "?"
        v2box.Text = ""
        calculatebt.Enabled = True
    End Sub

    Private Sub v2button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v2button.Click
        p1box.Enabled = True
        p1box.Focus()
        v1box.Enabled = True
        p2box.Enabled = True
        v2box.Enabled = False
        p1box.Text = ""
        v1box.Text = ""
        p2box.Text = ""
        v2box.Text = "?"
        calculatebt.Enabled = True
    End Sub

    Private Sub close_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_bt.Click
        Me.Close()
    End Sub

    Private Sub calculatebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatebt.Click
        If p1box.Enabled = False And v1box.Enabled = True And p2box.Enabled = True And v2box.Enabled = True Then
            If String.IsNullOrWhiteSpace(v1box.Text) Or
            String.IsNullOrWhiteSpace(p2box.Text) Or
            String.IsNullOrWhiteSpace(v2box.Text) Then
                MessageBox.Show("PLEASE FILL ALL EMPTY SPACES.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                v1box.Focus()
                Return
            End If
            v1 = v1box.Text
            p2 = p2box.Text
            v2 = v2box.Text
            a = p2 * v2
            p1 = a / v1
            If v1box.Text = 0 Then
                MessageBox.Show("CAN'T DIVIDE BY ZERO.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                v1box.Focus()
                Return
            Else
                resultbox.Text = Math.Round(p1, 3).ToString("n") & " mmHg"
            End If
        ElseIf p1box.Enabled = True And v1box.Enabled = False And p2box.Enabled = True And v2box.Enabled = True Then
            If String.IsNullOrWhiteSpace(p1box.Text) Or
            String.IsNullOrWhiteSpace(p2box.Text) Or
            String.IsNullOrWhiteSpace(v2box.Text) Then
                MessageBox.Show("PLEASE FILL ALL EMPTY SPACES.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p1box.Focus()
                Return
            End If
            p1 = p1box.Text
            p2 = p2box.Text
            v2 = v2box.Text
            a = p2 * v2
            v1 = a / p1
            If p1box.Text = 0 Then
                MessageBox.Show("CAN'T DIVIDE BY ZERO.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p1box.Focus()
                Return
            Else
                resultbox.Text = Math.Round(v1, 3).ToString("n") & " Litres"
            End If
        ElseIf p1box.Enabled = True And v1box.Enabled = True And p2box.Enabled = False And v2box.Enabled = True Then
            If String.IsNullOrWhiteSpace(p1box.Text) Or
            String.IsNullOrWhiteSpace(v1box.Text) Or
            String.IsNullOrWhiteSpace(v2box.Text) Then
                MessageBox.Show("PLEASE FILL ALL EMPTY SPACES.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p1box.Focus()
                Return
            End If
            p1 = p1box.Text
            v1 = v1box.Text
            v2 = v2box.Text
            a = p1 * v1
            p2 = a / v2
            If v2box.Text = 0 Then
                MessageBox.Show("CAN'T DIVIDE BY ZERO.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                v2box.Focus()
                Return
            Else
                resultbox.Text = Math.Round(p2, 3).ToString("n") & " mmHg"
            End If
        Else
            If String.IsNullOrWhiteSpace(p1box.Text) Or
            String.IsNullOrWhiteSpace(v1box.Text) Or
            String.IsNullOrWhiteSpace(p2box.Text) Then
                MessageBox.Show("PLEASE FILL ALL EMPTY SPACES.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p1box.Focus()
                Return
            End If
            p1 = p1box.Text
            v1 = v1box.Text
            p2 = p2box.Text
            a = p1 * v1
            v2 = a / p2
            If p2box.Text = 0 Then
                MessageBox.Show("CAN'T DIVIDE BY ZERO.", "INPUT ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p2box.Focus()
                Return
            Else
                resultbox.Text = Math.Round(v2, 3).ToString("n") & " Litres"
            End If
        End If
    End Sub

    Private Sub clearbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbt.Click
        If p1box.Enabled = False Then
            v1box.Text = ""
            p2box.Text = ""
            v2box.Text = ""
        ElseIf v1box.Enabled = False Then
            p1box.Text = ""
            p2box.Text = ""
            v2box.Text = ""
        ElseIf p2box.Enabled = False Then
            p1box.Text = ""
            v1box.Text = ""
            v2box.Text = ""
        Else
            p1box.Text = ""
            v1box.Text = ""
            p2box.Text = ""
        End If
    End Sub

    Private Sub p1box_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles p1box.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("ONLY DIGITS ARE ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf e.KeyChar = "." AndAlso p1box.Text.Length = 0 Then
            e.Handled = True
            MessageBox.Show("DECIMAL CAN'T BE THE FIRST CHARACTER!", "INVALID INPUT.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            p1box.Focus()
            Return
        ElseIf e.KeyChar = "." AndAlso p1box.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub v1box_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles v1box.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("ONLY DIGITS ARE ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf e.KeyChar = "." AndAlso v1box.Text.Length = 0 Then
            e.Handled = True
            MessageBox.Show("DECIMAL CAN'T BE THE FIRST CHARACTER!", "INVALID INPUT.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            v1box.Focus()
            Return
        ElseIf e.KeyChar = "." AndAlso v1box.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub p2box_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles p2box.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("ONLY DIGITS ARE ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf e.KeyChar = "." AndAlso p2box.Text.Length = 0 Then
            e.Handled = True
            MessageBox.Show("DECIMAL CAN'T BE THE FIRST CHARACTER!", "INVALID INPUT.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            p2box.Focus()
            Return
        ElseIf e.KeyChar = "." AndAlso p2box.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub v2box_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles v2box.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("ONLY DIGITS ARE ALLOWED!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf e.KeyChar = "." AndAlso v2box.Text.Length = 0 Then
            e.Handled = True
            MessageBox.Show("DECIMAL CAN'T BE THE FIRST CHARACTER!", "INVALID INPUT.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            v2box.Focus()
            Return
        ElseIf e.KeyChar = "." AndAlso v2box.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
End Class