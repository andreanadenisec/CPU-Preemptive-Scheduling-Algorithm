<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelRR = New System.Windows.Forms.Label()
        Me.TextBoxTimeSlice = New System.Windows.Forms.TextBox()
        Me.LabelTimeSlice = New System.Windows.Forms.Label()
        Me.LabelOutput = New System.Windows.Forms.Label()
        Me.RichTextTurnAround = New System.Windows.Forms.RichTextBox()
        Me.RichTextWaiting = New System.Windows.Forms.RichTextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelRR
        '
        Me.LabelRR.AutoSize = True
        Me.LabelRR.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRR.Location = New System.Drawing.Point(530, 38)
        Me.LabelRR.Name = "LabelRR"
        Me.LabelRR.Size = New System.Drawing.Size(263, 36)
        Me.LabelRR.TabIndex = 3
        Me.LabelRR.Text = "Round Robin (RR)"
        '
        'TextBoxTimeSlice
        '
        Me.TextBoxTimeSlice.Location = New System.Drawing.Point(324, 305)
        Me.TextBoxTimeSlice.Name = "TextBoxTimeSlice"
        Me.TextBoxTimeSlice.Size = New System.Drawing.Size(225, 22)
        Me.TextBoxTimeSlice.TabIndex = 54
        '
        'LabelTimeSlice
        '
        Me.LabelTimeSlice.AutoSize = True
        Me.LabelTimeSlice.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTimeSlice.Location = New System.Drawing.Point(84, 305)
        Me.LabelTimeSlice.Name = "LabelTimeSlice"
        Me.LabelTimeSlice.Size = New System.Drawing.Size(156, 24)
        Me.LabelTimeSlice.TabIndex = 53
        Me.LabelTimeSlice.Text = "Input Time Slice:"
        '
        'LabelOutput
        '
        Me.LabelOutput.AutoSize = True
        Me.LabelOutput.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOutput.Location = New System.Drawing.Point(634, 140)
        Me.LabelOutput.Name = "LabelOutput"
        Me.LabelOutput.Size = New System.Drawing.Size(85, 24)
        Me.LabelOutput.TabIndex = 58
        Me.LabelOutput.Text = "Output:"
        '
        'RichTextTurnAround
        '
        Me.RichTextTurnAround.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextTurnAround.Location = New System.Drawing.Point(1003, 204)
        Me.RichTextTurnAround.Name = "RichTextTurnAround"
        Me.RichTextTurnAround.ReadOnly = True
        Me.RichTextTurnAround.Size = New System.Drawing.Size(323, 336)
        Me.RichTextTurnAround.TabIndex = 60
        Me.RichTextTurnAround.Text = ""
        '
        'RichTextWaiting
        '
        Me.RichTextWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextWaiting.Location = New System.Drawing.Point(647, 204)
        Me.RichTextWaiting.Name = "RichTextWaiting"
        Me.RichTextWaiting.ReadOnly = True
        Me.RichTextWaiting.Size = New System.Drawing.Size(323, 336)
        Me.RichTextWaiting.TabIndex = 59
        Me.RichTextWaiting.Text = ""
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Lato", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(246, 491)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(157, 49)
        Me.ButtonClear.TabIndex = 63
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Font = New System.Drawing.Font("Lato", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalculate.Location = New System.Drawing.Point(418, 491)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(156, 49)
        Me.ButtonCalculate.TabIndex = 62
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Lato", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(77, 491)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(157, 49)
        Me.ButtonExit.TabIndex = 61
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'FormRR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 593)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.RichTextTurnAround)
        Me.Controls.Add(Me.RichTextWaiting)
        Me.Controls.Add(Me.LabelOutput)
        Me.Controls.Add(Me.TextBoxTimeSlice)
        Me.Controls.Add(Me.LabelTimeSlice)
        Me.Controls.Add(Me.LabelRR)
        Me.Name = "FormRR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelRR As Label
    Friend WithEvents TextBoxTimeSlice As TextBox
    Friend WithEvents LabelTimeSlice As Label
    Friend WithEvents LabelOutput As Label
    Friend WithEvents RichTextTurnAround As RichTextBox
    Friend WithEvents RichTextWaiting As RichTextBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonExit As Button
End Class
