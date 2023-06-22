Public Class FormMLFQ
    Private Sub FormMLFQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideText()
        TextBoxInLevels.Focus()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxInLevels.KeyPress
        'Enter only numbers 
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 AndAlso Asc(ch) <> 46 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxInLevels_TextChanged(sender As Object, e As EventArgs) Handles TextBoxInLevels.TextChanged
        Dim num As Integer
        num = Val(TextBoxInLevels.Text)

        If TextBoxInLevels.Text = "" Then
            hideText()
        ElseIf num = 1 Then
            l1()
        ElseIf num = 2 Then
            l1()
            l2()
        ElseIf num = 3 Then
            l1()
            l2()
            l3()
        Else
            hideText()
            MsgBox("Invalid Input! Enter only numbers from 1-3!")
        End If


    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim num As Integer = FormMain.numProcess
        Dim ArrivalTime() As Double = FormMain.ArrayArrival
        Dim BurstTime() As Double = FormMain.ArrayBurst

        RichTextWaiting.Text = RichTextWaiting.Text & "Waiting Time: " & vbCrLf
        RichTextWaiting.Text = RichTextWaiting.Text & "Average Waiting Time: " & vbCrLf

        RichTextTurnAround.Text = RichTextTurnAround.Text & "Turnaround Time: " & vbCrLf
        RichTextTurnAround.Text = RichTextTurnAround.Text & "Average Turnaround Time: " & vbCrLf
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxInLevels.Clear()
        ComboBoxL1.SelectedIndex = -1
        ComboBoxL2.SelectedIndex = -1
        ComboBoxL3.SelectedIndex = -1
        TextBoxInLevels.Focus()
    End Sub

    Private Sub hideText()
        LabelL1.Visible = False
        LabelL2.Visible = False
        LabelL3.Visible = False
        ComboBoxL1.Visible = False
        ComboBoxL2.Visible = False
        ComboBoxL3.Visible = False
    End Sub

    Private Sub l1()
        LabelL1.Visible = True
        ComboBoxL1.Visible = True
    End Sub

    Private Sub l2()
        LabelL2.Visible = True
        ComboBoxL2.Visible = True
    End Sub

    Private Sub l3()
        LabelL3.Visible = True
        ComboBoxL3.Visible = True
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Dim confirmExit As DialogResult
        confirmExit = MessageBox.Show("Input Again?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (confirmExit = DialogResult.Yes) Then
            Me.Close()
            FormMain.clearText()
            FormMain.Show()
        Else
            Me.Close()
        End If
    End Sub
End Class