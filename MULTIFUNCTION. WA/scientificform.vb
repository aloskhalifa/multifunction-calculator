Public Class scientificform
    Private firstnum As Double = 0
    Private secondnum As Double = 0
    Private answer As Double = 9
    Dim opera As String = ""

    Private Sub closebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebt.Click
        Me.Close()
    End Sub

    Private Sub Numeric_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt9.Click, bt8.Click, bt7.Click, bt6.Click, bt5.Click, bt4.Click, bt3.Click, bt2.Click, bt1.Click, bt0.Click
        Dim b As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        If inputdisplaybox.Text = "0" Then
            inputdisplaybox.Text = b.Text
        Else
            inputdisplaybox.Text &= b.Text
        End If
    End Sub

    Private Sub PerformCalculation()
        If inputdisplaybox.Text <> "" AndAlso Double.TryParse(inputdisplaybox.Text, secondnum) Then
            Select Case opera
                Case "+"
                    answer += secondnum
                Case "-"
                    answer -= secondnum
                Case "X"
                    answer *= secondnum
                Case "/"
                    If secondnum <> 0 Then
                        answer /= secondnum
                    Else
                        MessageBox.Show("Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ClearDisplay()
                        Return
                    End If
                Case "Mod"
                    answer = answer Mod secondnum
                Case Else
                    MessageBox.Show("Invalid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ClearDisplay()
                    Return
            End Select

            inputdisplaybox.Text = answer.ToString()
        Else
            MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDisplay()
        End If
    End Sub

    Private Sub Arithmetic_operators(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtractionbt.Click, multiplicationbt.Click, divisionbt.Click, additionbt.Click, modbt.Click
        Dim ops As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        If inputdisplaybox.Text <> "" AndAlso Double.TryParse(inputdisplaybox.Text, firstnum) Then
            If opera <> "" Then
                PerformCalculation()
            Else
                answer = firstnum
            End If
        Else
            MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDisplay()
            Return
        End If
        historybox.Text = answer.ToString() & " " & ops.Text
        inputdisplaybox.Text = "0"
        opera = ops.Text
    End Sub

    Private Sub equalbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equalbt.Click
        PerformCalculation()
        historybox.Text = ""
        opera = ""
    End Sub

    Private Sub backspacebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backspacebt.Click
        If inputdisplaybox.Text.Length > 0 Then
            inputdisplaybox.Text = inputdisplaybox.Text.Remove(inputdisplaybox.Text.Length - 1)
            If inputdisplaybox.Text = "" Then inputdisplaybox.Text = "0"
        End If
    End Sub

    Private Sub cbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbt.Click
        ClearDisplay()
    End Sub

    Private Sub cebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cebt.Click
        inputdisplaybox.Text = ""
    End Sub

    Private Sub decimalbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decimalbt.Click
        If Not inputdisplaybox.Text.Contains(".") Then
            inputdisplaybox.Text &= "."
        End If
    End Sub

    Private Sub percentbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percentbt.Click
        Try
            inputdisplaybox.Text = (Double.Parse(inputdisplaybox.Text) / 100).ToString()
        Catch ex As Exception
            MessageBox.Show("Invalid input for operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDisplay()
        End Try
    End Sub

    Private Sub negatebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles negatebt.Click
        If Double.TryParse(inputdisplaybox.Text, firstnum) Then
            inputdisplaybox.Text = (-1 * Double.Parse(inputdisplaybox.Text)).ToString()
        Else
            MessageBox.Show("Invalid number for negation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub intXbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intXbt.Click
        Dim input As Double = Double.Parse(inputdisplaybox.Text)
        historybox.Text = "ln(" & inputdisplaybox.Text & ")"
        inputdisplaybox.Text = Math.Log(input).ToString()
    End Sub

    Private Sub factorialbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles factorialbt.Click
        Try
            Dim factorial As Integer
            Dim input As Integer = Integer.Parse(inputdisplaybox.Text)
            factorial = 1
            For i = 1 To input
                factorial *= i
            Next
            inputdisplaybox.Text = factorial
            historybox.Text = input & "!".ToString
        Catch ex As Exception
            MessageBox.Show("Invalid input for operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDisplay()
            Return
        End Try
    End Sub

    Private Sub pibt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pibt.Click
        inputdisplaybox.Text = Math.PI.ToString("F15")
    End Sub

    Private Sub sqrtbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sqrtbt.Click
        Dim value As Double
        If Double.TryParse(inputdisplaybox.Text, value) AndAlso value >= 0 Then
            inputdisplaybox.Text = Math.Sqrt(value).ToString("F15")
            historybox.Text = "sqrt(" & value & ")".ToString
        Else
            MessageBox.Show("Invalid input. Please enter a non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDisplay()
        End If
    End Sub

    Private Sub ApplySingleOperation(ByVal operationName As String, ByVal operation As Func(Of Double, Double))
        Try
            Dim input As Double = Double.Parse(inputdisplaybox.Text)
            historybox.Text = operationName & "(" & inputdisplaybox.Text & ")"
            inputdisplaybox.Text = operation(input).ToString()
        Catch ex As Exception
            MessageBox.Show("Invalid input for operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDisplay()
        End Try
    End Sub

    Private Sub oneoverXbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oneoverXbt.Click
        ApplySingleOperation("1/x", Function(x) 1 / x)
    End Sub

    Private Sub xcubebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xcubebt.Click
        ApplySingleOperation("x³", Function(x) x * x * x)
    End Sub

    Private Sub xsquarebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xsquarebt.Click
        ApplySingleOperation("x²", Function(x) x * x)
    End Sub

    Private Sub tanbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tanbt.Click
        ApplySingleOperation("tan", Function(x) Math.Tan(x))
    End Sub

    Private Sub cosbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cosbt.Click
        ApplySingleOperation("cos", Function(x) Math.Cos(x))
    End Sub

    Private Sub sinbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinbt.Click
        ApplySingleOperation("sin", Function(x) Math.Sin(x))
    End Sub

    Private Sub logbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logbt.Click
        ApplySingleOperation("log", Function(x) Math.Log10(x))
    End Sub

    Private Sub expbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles expbt.Click
        ApplySingleOperation("Exp", Function(x) Math.Exp(x))
    End Sub

    Private Sub tanHbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tanHbt.Click
        ApplySingleOperation("atan", Function(x) Math.Atan(x))
    End Sub

    Private Sub cosHbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cosHbt.Click
        ApplySingleOperation("cosh", Function(x) Math.Cosh(x))
    End Sub

    Private Sub sinHbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinHbt.Click
        ApplySingleOperation("asin", Function(x) Math.Asin(x))
    End Sub

    Private Sub ApplyConversion(ByVal conversionName As String, ByVal conversion As Func(Of Integer, String))
        Try
            Dim input As Integer = Integer.Parse(inputdisplaybox.Text)
            historybox.Text = conversionName & "(" & inputdisplaybox.Text & ")"
            inputdisplaybox.Text = conversion(input)
        Catch ex As Exception
            MessageBox.Show("Invalid input for conversion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDisplay()
        End Try
    End Sub

    Private Sub octbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles octbt.Click
        ApplyConversion("Oct", Function(x) Convert.ToString(x, 8))
    End Sub

    Private Sub hexbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hexbt.Click
        ApplyConversion("Hex", Function(x) Convert.ToString(x, 16))
    End Sub

    Private Sub binarybt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles binarybt.Click
        ApplyConversion("Bin", Function(x) Convert.ToString(x, 2))
    End Sub

    Private Sub ClearDisplay()
        inputdisplaybox.Text = "0"
        historybox.Text = ""
        firstnum = 0
        secondnum = 0
        answer = 0
        opera = ""
    End Sub

End Class