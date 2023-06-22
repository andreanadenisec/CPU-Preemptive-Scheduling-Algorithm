Public Class FormPPrio
    Private Sub FormPPrio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num As Integer = FormMain.numProcess
        hideText()
        TextBoxPrio1.Focus()

        If num = 2 Then
            pr2()
        ElseIf num = 3 Then
            pr2()
            pr3()
        ElseIf num = 4 Then
            pr2()
            pr3()
            pr4()
        ElseIf num = 5 Then
            pr2()
            pr3()
            pr4()
            pr5()
        ElseIf num = 6 Then
            pr2()
            pr3()
            pr4()
            pr5()
            pr6()
        ElseIf num = 7 Then
            pr2()
            pr3()
            pr4()
            pr5()
            pr6()
            pr7()
        ElseIf num = 8 Then
            pr2()
            pr3()
            pr4()
            pr5()
            pr6()
            pr7()
            pr8()
        ElseIf num = 9 Then
            pr2()
            pr3()
            pr4()
            pr5()
            pr6()
            pr7()
            pr8()
            pr9()
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
        clearText()
        TextBoxPrio1.Focus()
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

    Private Sub clearText()
        TextBoxPrio1.Clear()
        TextBoxPrio2.Clear()
        TextBoxPrio3.Clear()
        TextBoxPrio4.Clear()
        TextBoxPrio5.Clear()
        TextBoxPrio6.Clear()
        TextBoxPrio7.Clear()
        TextBoxPrio8.Clear()
        TextBoxPrio9.Clear()
        RichTextWaiting.Clear()
        RichTextTurnAround.Clear()
        TextBoxPrio1.Focus()
    End Sub

    Private Sub pr2()
        LabelPrio1.Visible = True
        TextBoxPrio1.Visible = True
        LabelPrio2.Visible = True
        TextBoxPrio2.Visible = True
    End Sub

    Private Sub pr3()
        LabelPrio3.Visible = True
        TextBoxPrio3.Visible = True
    End Sub

    Private Sub pr4()
        LabelPrio4.Visible = True
        TextBoxPrio4.Visible = True
    End Sub

    Private Sub pr5()
        LabelPrio5.Visible = True
        TextBoxPrio5.Visible = True
    End Sub

    Private Sub pr6()
        LabelPrio6.Visible = True
        TextBoxPrio6.Visible = True
    End Sub

    Private Sub pr7()
        LabelPrio7.Visible = True
        TextBoxPrio7.Visible = True
    End Sub

    Private Sub pr8()
        LabelPrio8.Visible = True
        TextBoxPrio8.Visible = True
    End Sub

    Private Sub pr9()
        LabelPrio9.Visible = True
        TextBoxPrio9.Visible = True
    End Sub

    Private Sub hideText()
        LabelPrio1.Visible = False
        TextBoxPrio1.Visible = False
        LabelPrio2.Visible = False
        TextBoxPrio2.Visible = False
        LabelPrio3.Visible = False
        TextBoxPrio3.Visible = False
        LabelPrio4.Visible = False
        TextBoxPrio4.Visible = False
        LabelPrio5.Visible = False
        TextBoxPrio5.Visible = False
        LabelPrio6.Visible = False
        TextBoxPrio6.Visible = False
        LabelPrio7.Visible = False
        TextBoxPrio7.Visible = False
        LabelPrio8.Visible = False
        TextBoxPrio8.Visible = False
        LabelPrio9.Visible = False
        TextBoxPrio9.Visible = False
    End Sub
End Class