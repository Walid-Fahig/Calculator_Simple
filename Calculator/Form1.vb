'إعداد وليد الشيبانى فحيج
' رقم القيد 152124

Imports System.Math

Public Class Calculator
    Dim Number1, Number2 As Double
    Dim operation As Char

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles ZeroButton.Click
        secrenTextBox.Text &= "0"
    End Sub

    Private Sub OneButton_Click(sender As Object, e As EventArgs) Handles OneButton.Click
        secrenTextBox.Text &= "1"
    End Sub

    Private Sub TwoButton_Click(sender As Object, e As EventArgs) Handles TwoButton.Click
        secrenTextBox.Text &= "2"
    End Sub

    Private Sub ThreeButton_Click(sender As Object, e As EventArgs) Handles ThreeButton.Click
        secrenTextBox.Text &= "3"
    End Sub

    Private Sub FourButton_Click(sender As Object, e As EventArgs) Handles FourButton.Click
        secrenTextBox.Text &= "4"
    End Sub

    Private Sub FiveButton_Click(sender As Object, e As EventArgs) Handles FiveButton.Click
        secrenTextBox.Text &= "5"
    End Sub

    Private Sub SixButton_Click(sender As Object, e As EventArgs) Handles SixButton.Click
        secrenTextBox.Text &= "6"
    End Sub

    Private Sub SevenButton_Click(sender As Object, e As EventArgs) Handles SevenButton.Click
        secrenTextBox.Text &= "7"
    End Sub

    Private Sub EightButton_Click(sender As Object, e As EventArgs) Handles EightButton.Click
        secrenTextBox.Text &= "8"
    End Sub

    Private Sub NineButton_Click(sender As Object, e As EventArgs) Handles NineButton.Click
        secrenTextBox.Text &= "9"
    End Sub

    Private Sub DivButton_Click(sender As Object, e As EventArgs) Handles DivButton.Click
        operation = "/"
        Number1 = secrenTextBox.Text
        secrenTextBox.Text = ""
    End Sub

    Private Sub MirButton_Click(sender As Object, e As EventArgs) Handles MirButton.Click
        operation = "*"
        Number1 = secrenTextBox.Text
        secrenTextBox.Text = ""
    End Sub

    Private Sub SubButton_Click(sender As Object, e As EventArgs) Handles SubButton.Click
        operation = "-"
        Number1 = secrenTextBox.Text
        secrenTextBox.Text = ""
    End Sub

    Private Sub SumButton_Click(sender As Object, e As EventArgs) Handles SumButton.Click
        operation = "+"
        Number1 = secrenTextBox.Text
        secrenTextBox.Text = ""
    End Sub

    Private Sub ResultButton_Click(sender As Object, e As EventArgs) Handles ResultButton.Click
        Number2 = secrenTextBox.Text
        If operation = "/" Then
            If Number2 = 0 Then
                secrenTextBox.Text = "Math Error"
            Else
                secrenTextBox.Text = Number1 / Number2
            End If

        ElseIf operation = "*"
            secrenTextBox.Text = Number1 * Number2
        ElseIf operation = "-"
            secrenTextBox.Text = Number1 - Number2
        ElseIf operation = "+"
            secrenTextBox.Text = Number1 + Number2
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        secrenTextBox.Text = ""
        Number1 = 0
        Number2 = 0
    End Sub

    Private Sub SinButton_Click(sender As Object, e As EventArgs) Handles SinButton.Click
        Number1 = Val(secrenTextBox.Text)
        secrenTextBox.Text = Sin(Number1)
    End Sub

    Private Sub cosButton_Click(sender As Object, e As EventArgs) Handles cosButton.Click
        Number1 = secrenTextBox.Text
        secrenTextBox.Text = Cos(Number1)
    End Sub

    Private Sub TanButton_Click(sender As Object, e As EventArgs) Handles TanButton.Click
        Number1 = Val(secrenTextBox.Text)
        secrenTextBox.Text = Tan(Number1)

    End Sub

    Private Sub wallButton_Click(sender As Object, e As EventArgs) Handles wallButton.Click
        Number1 = Val(secrenTextBox.Text)
        secrenTextBox.Text = Sqrt(Number1)

    End Sub

    Private Sub LogButton_Click(sender As Object, e As EventArgs) Handles LogButton.Click
        Number1 = Val(secrenTextBox.Text)
        If Number1 = 0 Then
            secrenTextBox.Text = "Invalid input"
        Else
            secrenTextBox.Text = Log10(Number1)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PIButton.Click
        secrenTextBox.Text = PI
    End Sub


    Private Sub pointButton_Click(sender As Object, e As EventArgs) Handles pointButton.Click
        secrenTextBox.Text &= "."
    End Sub
End Class
