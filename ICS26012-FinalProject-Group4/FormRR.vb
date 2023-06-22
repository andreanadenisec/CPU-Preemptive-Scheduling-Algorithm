Public Class FormRR
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
        TextBoxTimeSlice.Clear()
        RichTextWaiting.Clear()
        RichTextTurnAround.Clear()
        TextBoxTimeSlice.Focus()
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