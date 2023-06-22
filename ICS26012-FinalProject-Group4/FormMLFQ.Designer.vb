<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMLFQ
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelMLFQ = New System.Windows.Forms.Label()
        Me.LabelInLevels = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.LabelL1 = New System.Windows.Forms.Label()
        Me.LabelL3 = New System.Windows.Forms.Label()
        Me.LabelL2 = New System.Windows.Forms.Label()
        Me.TextBoxInLevels = New System.Windows.Forms.TextBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.RichTextWaiting = New System.Windows.Forms.RichTextBox()
        Me.RichTextTurnAround = New System.Windows.Forms.RichTextBox()
        Me.LabelOutput = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ComboBoxL1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxL2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxL3 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LabelMLFQ
        '
        Me.LabelMLFQ.AutoSize = True
        Me.LabelMLFQ.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMLFQ.Location = New System.Drawing.Point(460, 38)
        Me.LabelMLFQ.Name = "LabelMLFQ"
        Me.LabelMLFQ.Size = New System.Drawing.Size(529, 36)
        Me.LabelMLFQ.TabIndex = 1
        Me.LabelMLFQ.Text = "Multi-level Feedback Queue (MLFQ)"
        '
        'LabelInLevels
        '
        Me.LabelInLevels.AutoSize = True
        Me.LabelInLevels.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInLevels.Location = New System.Drawing.Point(73, 140)
        Me.LabelInLevels.Name = "LabelInLevels"
        Me.LabelInLevels.Size = New System.Drawing.Size(260, 24)
        Me.LabelInLevels.TabIndex = 3
        Me.LabelInLevels.Text = "Input number of levels [1-3]:"
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Lato", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(77, 491)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(157, 49)
        Me.ButtonExit.TabIndex = 44
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(74, 215)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(281, 24)
        Me.Label.TabIndex = 45
        Me.Label.Text = "Input algorithms for each level:"
        '
        'LabelL1
        '
        Me.LabelL1.AutoSize = True
        Me.LabelL1.Font = New System.Drawing.Font("Lato", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelL1.Location = New System.Drawing.Point(73, 283)
        Me.LabelL1.Name = "LabelL1"
        Me.LabelL1.Size = New System.Drawing.Size(67, 21)
        Me.LabelL1.TabIndex = 49
        Me.LabelL1.Text = "Level 1:"
        '
        'LabelL3
        '
        Me.LabelL3.AutoSize = True
        Me.LabelL3.Font = New System.Drawing.Font("Lato", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelL3.Location = New System.Drawing.Point(74, 416)
        Me.LabelL3.Name = "LabelL3"
        Me.LabelL3.Size = New System.Drawing.Size(67, 21)
        Me.LabelL3.TabIndex = 51
        Me.LabelL3.Text = "Level 3:"
        '
        'LabelL2
        '
        Me.LabelL2.AutoSize = True
        Me.LabelL2.Font = New System.Drawing.Font("Lato", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelL2.Location = New System.Drawing.Point(74, 346)
        Me.LabelL2.Name = "LabelL2"
        Me.LabelL2.Size = New System.Drawing.Size(67, 21)
        Me.LabelL2.TabIndex = 50
        Me.LabelL2.Text = "Level 2:"
        '
        'TextBoxInLevels
        '
        Me.TextBoxInLevels.Location = New System.Drawing.Point(355, 144)
        Me.TextBoxInLevels.Name = "TextBoxInLevels"
        Me.TextBoxInLevels.Size = New System.Drawing.Size(246, 22)
        Me.TextBoxInLevels.TabIndex = 52
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Font = New System.Drawing.Font("Lato", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalculate.Location = New System.Drawing.Point(445, 491)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(156, 49)
        Me.ButtonCalculate.TabIndex = 53
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'RichTextWaiting
        '
        Me.RichTextWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextWaiting.Location = New System.Drawing.Point(647, 204)
        Me.RichTextWaiting.Name = "RichTextWaiting"
        Me.RichTextWaiting.ReadOnly = True
        Me.RichTextWaiting.Size = New System.Drawing.Size(323, 336)
        Me.RichTextWaiting.TabIndex = 55
        Me.RichTextWaiting.Text = ""
        '
        'RichTextTurnAround
        '
        Me.RichTextTurnAround.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextTurnAround.Location = New System.Drawing.Point(1003, 204)
        Me.RichTextTurnAround.Name = "RichTextTurnAround"
        Me.RichTextTurnAround.ReadOnly = True
        Me.RichTextTurnAround.Size = New System.Drawing.Size(323, 336)
        Me.RichTextTurnAround.TabIndex = 56
        Me.RichTextTurnAround.Text = ""
        '
        'LabelOutput
        '
        Me.LabelOutput.AutoSize = True
        Me.LabelOutput.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOutput.Location = New System.Drawing.Point(643, 140)
        Me.LabelOutput.Name = "LabelOutput"
        Me.LabelOutput.Size = New System.Drawing.Size(85, 24)
        Me.LabelOutput.TabIndex = 57
        Me.LabelOutput.Text = "Output:"
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Lato", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(262, 491)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(157, 49)
        Me.ButtonClear.TabIndex = 54
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ComboBoxL1
        '
        Me.ComboBoxL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxL1.FormattingEnabled = True
        Me.ComboBoxL1.Items.AddRange(New Object() {"Shortest Remaining Time First (SRTF)", "Round Robin (RR)", "Round Robin with Overhead (RRO)", "Preemptive Priority (P-Prio)", "Multi-level Feedback Queue (MLFQ)"})
        Me.ComboBoxL1.Location = New System.Drawing.Point(255, 276)
        Me.ComboBoxL1.Name = "ComboBoxL1"
        Me.ComboBoxL1.Size = New System.Drawing.Size(346, 28)
        Me.ComboBoxL1.TabIndex = 58
        '
        'ComboBoxL2
        '
        Me.ComboBoxL2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxL2.FormattingEnabled = True
        Me.ComboBoxL2.Items.AddRange(New Object() {"Shortest Remaining Time First (SRTF)", "Round Robin (RR)", "Round Robin with Overhead (RRO)", "Preemptive Priority (P-Prio)", "Multi-level Feedback Queue (MLFQ)"})
        Me.ComboBoxL2.Location = New System.Drawing.Point(255, 339)
        Me.ComboBoxL2.Name = "ComboBoxL2"
        Me.ComboBoxL2.Size = New System.Drawing.Size(346, 28)
        Me.ComboBoxL2.TabIndex = 59
        '
        'ComboBoxL3
        '
        Me.ComboBoxL3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxL3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxL3.FormattingEnabled = True
        Me.ComboBoxL3.Items.AddRange(New Object() {"First Come First Serve (FCFS)", "Shortest Job First (SJF)"})
        Me.ComboBoxL3.Location = New System.Drawing.Point(255, 409)
        Me.ComboBoxL3.Name = "ComboBoxL3"
        Me.ComboBoxL3.Size = New System.Drawing.Size(346, 28)
        Me.ComboBoxL3.TabIndex = 60
        '
        'FormMLFQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 593)
        Me.Controls.Add(Me.ComboBoxL3)
        Me.Controls.Add(Me.ComboBoxL2)
        Me.Controls.Add(Me.ComboBoxL1)
        Me.Controls.Add(Me.LabelOutput)
        Me.Controls.Add(Me.RichTextTurnAround)
        Me.Controls.Add(Me.RichTextWaiting)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.TextBoxInLevels)
        Me.Controls.Add(Me.LabelL3)
        Me.Controls.Add(Me.LabelL2)
        Me.Controls.Add(Me.LabelL1)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.LabelInLevels)
        Me.Controls.Add(Me.LabelMLFQ)
        Me.Name = "FormMLFQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MLFQ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelMLFQ As Label
    Friend WithEvents LabelInLevels As Label
    Friend WithEvents ButtonExit As Button
    Friend WithEvents Label As Label
    Friend WithEvents LabelL1 As Label
    Friend WithEvents LabelL3 As Label
    Friend WithEvents LabelL2 As Label
    Friend WithEvents TextBoxInLevels As TextBox
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents RichTextWaiting As RichTextBox
    Friend WithEvents RichTextTurnAround As RichTextBox
    Friend WithEvents LabelOutput As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ComboBoxL1 As ComboBox
    Friend WithEvents ComboBoxL2 As ComboBox
    Friend WithEvents ComboBoxL3 As ComboBox
End Class
