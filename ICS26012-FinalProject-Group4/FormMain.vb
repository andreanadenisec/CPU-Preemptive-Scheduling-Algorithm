Public Class FormMain

    'To pass the String to other forms
    Public Shared numProcess As Integer

    'To pass the Array to other forms
    Public Shared ArrayArrival As Double()
    Public Shared ArrayBurst As Double()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideText()
        clearText()
    End Sub

    Private Sub TextBoxNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNum.KeyPress
        'Enter only numbers 
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 AndAlso Asc(ch) <> 46 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxNum_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNum.TextChanged

        numProcess = Val(TextBoxNum.Text)

        If TextBoxNum.Text = "" Then
            hideText()
        ElseIf numProcess = 2 Then
            p2()
        ElseIf numProcess = 3 Then
            p2()
            p3()
        ElseIf numProcess = 4 Then
            p2()
            p3()
            p4()
        ElseIf numProcess = 5 Then
            p2()
            p3()
            p4()
            p5()
        ElseIf numProcess = 6 Then
            p2()
            p3()
            p4()
            p5()
            p6()
        ElseIf numProcess = 7 Then
            p2()
            p3()
            p4()
            p5()
            p6()
            p7()
        ElseIf numProcess = 8 Then
            p2()
            p3()
            p4()
            p5()
            p6()
            p7()
            p8()
        ElseIf numProcess = 9 Then
            p2()
            p3()
            p4()
            p5()
            p6()
            p7()
            p8()
            p9()
        Else
            hideText()
        MsgBox("Invalid Input! Enter only numbers from 2-9!")
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click

        'Initialize variables
        Dim txtA1, txtA2, txtA3, txtA4, txtA5, txtA6, txtA7, txtA8, txtA9 As Double
        Dim txtB1, txtB2, txtB3, txtB4, txtB5, txtB6, txtB7, txtB8, txtB9 As Double

        txtA1 = 0
        txtA2 = 0
        txtA3 = 0
        txtA4 = 0
        txtA5 = 0
        txtA6 = 0
        txtA7 = 0
        txtA8 = 0
        txtA9 = 0

        txtB1 = 0
        txtB2 = 0
        txtB3 = 0
        txtB4 = 0
        txtB5 = 0
        txtB6 = 0
        txtB7 = 0
        txtB8 = 0
        txtB9 = 0

        'Save value from textbox to variable
        txtA1 = Val(TextBoxAT1.Text)
        txtA2 = Val(TextBoxAT2.Text)
        txtA3 = Val(TextBoxAT3.Text)
        txtA4 = Val(TextBoxAT4.Text)
        txtA5 = Val(TextBoxAT5.Text)
        txtA6 = Val(TextBoxAT6.Text)
        txtA7 = Val(TextBoxAT7.Text)
        txtA8 = Val(TextBoxAT8.Text)
        txtA9 = Val(TextBoxAT9.Text)

        txtB1 = Val(TextBoxBT1.Text)
        txtB2 = Val(TextBoxBT2.Text)
        txtB3 = Val(TextBoxBT3.Text)
        txtB4 = Val(TextBoxBT4.Text)
        txtB5 = Val(TextBoxBT5.Text)
        txtB6 = Val(TextBoxBT6.Text)
        txtB7 = Val(TextBoxBT7.Text)
        txtB8 = Val(TextBoxBT8.Text)
        txtB9 = Val(TextBoxBT9.Text)

        'Store values in array
        ReDim ArrayArrival(9)
        ArrayArrival(0) = txtA1
        ArrayArrival(1) = txtA2
        ArrayArrival(2) = txtA3
        ArrayArrival(3) = txtA4
        ArrayArrival(4) = txtA5
        ArrayArrival(5) = txtA6
        ArrayArrival(6) = txtA7
        ArrayArrival(7) = txtA8
        ArrayArrival(8) = txtA9

        ReDim ArrayBurst(9)
        ArrayBurst(0) = txtB1
        ArrayBurst(1) = txtB2
        ArrayBurst(2) = txtB3
        ArrayBurst(3) = txtB4
        ArrayBurst(4) = txtB5
        ArrayBurst(5) = txtB6
        ArrayBurst(6) = txtB7
        ArrayBurst(7) = txtB8
        ArrayBurst(8) = txtB9

        'Redirect to other forms
        If ComboBoxAlgo.SelectedIndex = 0 Then 'SRTF
            FormSRTF.Show()
            Me.Hide()
        ElseIf ComboBoxAlgo.SelectedIndex = 1 Then 'RR
            FormRR.Show()
            Me.Hide()
        ElseIf ComboBoxAlgo.SelectedIndex = 2 Then 'P-Prio
            FormPPrio.Show()
            Me.Hide()
        ElseIf ComboBoxAlgo.SelectedIndex = 3 Then 'MLFQ
            FormMLFQ.Show()
            Me.Hide()
        Else
            MsgBox("Select an algorithm")
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clearText()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Public Sub hideText()
        TextBoxNum.Clear()

        LabelAT1.Visible = False
        LabelAT2.Visible = False
        LabelAT3.Visible = False
        LabelAT4.Visible = False
        LabelAT5.Visible = False
        LabelAT6.Visible = False
        LabelAT7.Visible = False
        LabelAT8.Visible = False
        LabelAT9.Visible = False

        TextBoxAT1.Visible = False
        TextBoxAT2.Visible = False
        TextBoxAT3.Visible = False
        TextBoxAT4.Visible = False
        TextBoxAT5.Visible = False
        TextBoxAT6.Visible = False
        TextBoxAT7.Visible = False
        TextBoxAT8.Visible = False
        TextBoxAT9.Visible = False

        LabelBT1.Visible = False
        LabelBT2.Visible = False
        LabelBT3.Visible = False
        LabelBT4.Visible = False
        LabelBT5.Visible = False
        LabelBT6.Visible = False
        LabelBT7.Visible = False
        LabelBT8.Visible = False
        LabelBT9.Visible = False

        TextBoxBT1.Visible = False
        TextBoxBT2.Visible = False
        TextBoxBT3.Visible = False
        TextBoxBT4.Visible = False
        TextBoxBT5.Visible = False
        TextBoxBT6.Visible = False
        TextBoxBT7.Visible = False
        TextBoxBT8.Visible = False
        TextBoxBT9.Visible = False
    End Sub

    Public Sub clearText()
        TextBoxNum.Clear()
        TextBoxNum.Focus()

        ComboBoxAlgo.SelectedIndex = -1

        TextBoxAT1.Clear()
        TextBoxAT2.Clear()
        TextBoxAT3.Clear()
        TextBoxAT4.Clear()
        TextBoxAT5.Clear()
        TextBoxAT6.Clear()
        TextBoxAT7.Clear()
        TextBoxAT8.Clear()
        TextBoxAT9.Clear()

        TextBoxBT1.Clear()
        TextBoxBT2.Clear()
        TextBoxBT3.Clear()
        TextBoxBT4.Clear()
        TextBoxBT5.Clear()
        TextBoxBT6.Clear()
        TextBoxBT7.Clear()
        TextBoxBT8.Clear()
        TextBoxBT9.Clear()
    End Sub

    Private Sub p2()
        LabelAT1.Visible = True
        TextBoxAT1.Visible = True
        LabelBT1.Visible = True
        TextBoxBT1.Visible = True
        LabelAT2.Visible = True
        TextBoxAT2.Visible = True
        LabelBT2.Visible = True
        TextBoxBT2.Visible = True
    End Sub

    Private Sub p3()
        LabelAT3.Visible = True
        TextBoxAT3.Visible = True
        LabelBT3.Visible = True
        TextBoxBT3.Visible = True
    End Sub

    Private Sub p4()
        LabelAT4.Visible = True
        TextBoxAT4.Visible = True
        LabelBT4.Visible = True
        TextBoxBT4.Visible = True
    End Sub

    Private Sub p5()
        LabelAT5.Visible = True
        TextBoxAT5.Visible = True
        LabelBT5.Visible = True
        TextBoxBT5.Visible = True
    End Sub

    Private Sub p6()
        LabelAT6.Visible = True
        TextBoxAT6.Visible = True
        LabelBT6.Visible = True
        TextBoxBT6.Visible = True
    End Sub

    Private Sub p7()
        LabelAT7.Visible = True
        TextBoxAT7.Visible = True
        LabelBT7.Visible = True
        TextBoxBT7.Visible = True
    End Sub

    Private Sub p8()
        LabelAT8.Visible = True
        TextBoxAT8.Visible = True
        LabelBT8.Visible = True
        TextBoxBT8.Visible = True
    End Sub

    Private Sub p9()
        LabelAT9.Visible = True
        TextBoxAT9.Visible = True
        LabelBT9.Visible = True
        TextBoxBT9.Visible = True
    End Sub

End Class
