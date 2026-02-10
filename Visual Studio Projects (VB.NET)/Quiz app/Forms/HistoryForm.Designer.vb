<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        rtbQuestion = New RichTextBox()
        btnNext = New Button()
        rbOption4 = New RadioButton()
        rbOption3 = New RadioButton()
        rbOption2 = New RadioButton()
        rbOption1 = New RadioButton()
        SuspendLayout()
        ' 
        ' rtbQuestion
        ' 
        rtbQuestion.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rtbQuestion.Location = New Point(-5, -3)
        rtbQuestion.Name = "rtbQuestion"
        rtbQuestion.Size = New Size(570, 154)
        rtbQuestion.TabIndex = 1
        rtbQuestion.Text = ""
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ButtonShadow
        btnNext.Font = New Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNext.Location = New Point(45, 395)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(467, 49)
        btnNext.TabIndex = 10
        btnNext.Text = "       <<< NEXT >>>"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' rbOption4
        ' 
        rbOption4.AutoSize = True
        rbOption4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbOption4.Location = New Point(358, 272)
        rbOption4.Name = "rbOption4"
        rbOption4.Size = New Size(110, 21)
        rbOption4.TabIndex = 9
        rbOption4.TabStop = True
        rbOption4.Text = "RadioButton4"
        rbOption4.UseVisualStyleBackColor = True
        ' 
        ' rbOption3
        ' 
        rbOption3.AutoSize = True
        rbOption3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbOption3.Location = New Point(358, 209)
        rbOption3.Name = "rbOption3"
        rbOption3.Size = New Size(110, 21)
        rbOption3.TabIndex = 8
        rbOption3.TabStop = True
        rbOption3.Text = "RadioButton3"
        rbOption3.UseVisualStyleBackColor = True
        ' 
        ' rbOption2
        ' 
        rbOption2.AutoSize = True
        rbOption2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbOption2.Location = New Point(62, 272)
        rbOption2.Name = "rbOption2"
        rbOption2.Size = New Size(110, 21)
        rbOption2.TabIndex = 7
        rbOption2.TabStop = True
        rbOption2.Text = "RadioButton2"
        rbOption2.UseVisualStyleBackColor = True
        ' 
        ' rbOption1
        ' 
        rbOption1.AutoSize = True
        rbOption1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbOption1.Location = New Point(62, 209)
        rbOption1.Name = "rbOption1"
        rbOption1.Size = New Size(110, 21)
        rbOption1.TabIndex = 6
        rbOption1.TabStop = True
        rbOption1.Text = "RadioButton1"
        rbOption1.UseVisualStyleBackColor = True
        ' 
        ' HistoryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(566, 467)
        Controls.Add(btnNext)
        Controls.Add(rbOption4)
        Controls.Add(rbOption3)
        Controls.Add(rbOption2)
        Controls.Add(rbOption1)
        Controls.Add(rtbQuestion)
        Name = "HistoryForm"
        Text = "HistoryForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rtbQuestion As RichTextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents rbOption4 As RadioButton
    Friend WithEvents rbOption3 As RadioButton
    Friend WithEvents rbOption2 As RadioButton
    Friend WithEvents rbOption1 As RadioButton
End Class
