Public Class FormSRTF
    Private Sub FormSRTF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialize Variables
        Dim num As Integer = FormMain.numProcess
        Dim ArrivalTime() As Double = FormMain.ArrayArrival
        Dim BurstTime() As Double = FormMain.ArrayBurst
        Dim BurstTimeCopy(10) As Double
        Dim WaitingTime(10) As Double
        Dim TurnaroundTime(10) As Double
        Dim CompletionTime(10) As Double
        Dim i, j As Integer
        Dim smallest, count, time, sumWaiting, sumTurnaround, endd As Double
        ReDim Preserve ArrivalTime(10)
        ReDim Preserve BurstTime(10)
        count = 0
        sumWaiting = 0
        sumTurnaround = 0

        'Make a copy of burst time to store remaining burst times
        For i = 0 To num - 1
            BurstTimeCopy(i) = BurstTime(i)
        Next

        BurstTime(9) = 9999
        time = 0

        'Compute for waiting time and turnaround time
        While count <> num
            smallest = 9

            For i = 0 To num - 1
                If ArrivalTime(i) <= time AndAlso BurstTime(i) < BurstTime(smallest) AndAlso BurstTime(i) > 0 Then
                    smallest = i
                End If
            Next

            BurstTime(smallest) -= 1

            If BurstTime(smallest) = 0 Then
                count += 1
                endd = time + 1
                CompletionTime(smallest) = endd
                WaitingTime(smallest) = endd - ArrivalTime(smallest) - BurstTimeCopy(smallest)
                TurnaroundTime(smallest) = endd - ArrivalTime(smallest)
            End If

            time += 1
        End While


        'Print Waiting Time and Average Waiting Time
        RichTextWaiting.Text = RichTextWaiting.Text & "Waiting Time" & vbCrLf & vbCrLf

        For i = 0 To num - 1
            RichTextWaiting.Text = RichTextWaiting.Text & "P" & i + 1 & ": " & WaitingTime(i) & vbCrLf
            sumWaiting = sumWaiting + WaitingTime(i)
        Next

        RichTextWaiting.Text = RichTextWaiting.Text & vbCrLf & "Average Waiting Time: " & Math.Round(sumWaiting / num, 2)


        'Print Turnaround Time and Average Turnaround Time
        RichTextTurnAround.Text = RichTextTurnAround.Text & "Turnaround Time" & vbCrLf & vbCrLf

        For i = 0 To num - 1
            RichTextTurnAround.Text = RichTextTurnAround.Text & "P" & i + 1 & ": " & TurnaroundTime(i) & vbCrLf
            sumTurnaround = sumTurnaround + TurnaroundTime(i)
        Next

        RichTextTurnAround.Text = RichTextTurnAround.Text & vbCrLf & "Average Turnaround Time: " & Math.Round(sumTurnaround / num, 2)



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