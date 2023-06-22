<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSRTF
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
        Me.LabelSRTF = New System.Windows.Forms.Label()
        Me.LabelOutput = New System.Windows.Forms.Label()
        Me.RichTextTurnAround = New System.Windows.Forms.RichTextBox()
        Me.RichTextWaiting = New System.Windows.Forms.RichTextBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelSRTF
        '
        Me.LabelSRTF.AutoSize = True
        Me.LabelSRTF.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSRTF.Location = New System.Drawing.Point(103, 36)
        Me.LabelSRTF.Name = "LabelSRTF"
        Me.LabelSRTF.Size = New System.Drawing.Size(542, 36)
        Me.LabelSRTF.TabIndex = 2
        Me.LabelSRTF.Text = "Shortest Remaining Time First (SRTF)"
        '
        'LabelOutput
        '
        Me.LabelOutput.AutoSize = True
        Me.LabelOutput.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOutput.Location = New System.Drawing.Point(33, 122)
        Me.LabelOutput.Name = "LabelOutput"
        Me.LabelOutput.Size = New System.Drawing.Size(85, 24)
        Me.LabelOutput.TabIndex = 60
        Me.LabelOutput.Text = "Output:"
        '
        'RichTextTurnAround
        '
        Me.RichTextTurnAround.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextTurnAround.Location = New System.Drawing.Point(390, 179)
        Me.RichTextTurnAround.Name = "RichTextTurnAround"
        Me.RichTextTurnAround.ReadOnly = True
        Me.RichTextTurnAround.Size = New System.Drawing.Size(323, 296)
        Me.RichTextTurnAround.TabIndex = 59
        Me.RichTextTurnAround.Text = ""
        '
        'RichTextWaiting
        '
        Me.RichTextWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextWaiting.Location = New System.Drawing.Point(37, 179)
        Me.RichTextWaiting.Name = "RichTextWaiting"
        Me.RichTextWaiting.ReadOnly = True
        Me.RichTextWaiting.Size = New System.Drawing.Size(323, 296)
        Me.RichTextWaiting.TabIndex = 58
        Me.RichTextWaiting.Text = ""
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Lato", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(37, 507)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(157, 49)
        Me.ButtonExit.TabIndex = 61
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'FormSRTF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 580)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.LabelOutput)
        Me.Controls.Add(Me.RichTextTurnAround)
        Me.Controls.Add(Me.RichTextWaiting)
        Me.Controls.Add(Me.LabelSRTF)
        Me.Name = "FormSRTF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SRTF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSRTF As Label
    Friend WithEvents LabelOutput As Label
    Friend WithEvents RichTextTurnAround As RichTextBox
    Friend WithEvents RichTextWaiting As RichTextBox
    Friend WithEvents ButtonExit As Button
End Class
