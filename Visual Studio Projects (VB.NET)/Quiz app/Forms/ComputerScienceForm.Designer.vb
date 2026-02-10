<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComputerScienceForm
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
        btnNext = New Button()
        rbOption4 = New RadioButton()
        rbOption3 = New RadioButton()
        rbOption2 = New RadioButton()
        rbOption1 = New RadioButton()
        rtbQuestion = New RichTextBox()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ButtonShadow
        btnNext.Font = New Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNext.Location = New Point(48, 400)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(467, 49)
        btnNext.TabIndex = 16
        btnNext.Text = "       <<< NEXT >>>"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' rbOption4
        ' 
        rbOption4.AutoSize = True
        rbOption4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbOption4.Location = New Point(361, 277)
        rbOption4.Name = "rbOption4"
        rbOption4.Size = New Size(110, 21)
        rbOption4.TabIndex = 15
        rbOption4.TabStop = True
        rbOption4.Text = "RadioButton4"
        rbOption4.UseVisualStyleBackColor = True
        ' 
        ' rbOption3
        ' 
        rbOption3.AutoSize = True
        rbOption3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbOption3.Location = New Point(361, 214)
        rbOption3.Name = "rbOption3"
        rbOption3.Size = New Size(110, 21)
        rbOption3.TabIndex = 14
        rbOption3.TabStop = True
        rbOption3.Text = "RadioButton3"
        rbOption3.UseVisualStyleBackColor = True
        ' 
        ' rbOption2
        ' 
        rbOption2.AutoSize = True
        rbOption2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbOption2.Location = New Point(65, 277)
        rbOption2.Name = "rbOption2"
        rbOption2.Size = New Size(110, 21)
        rbOption2.TabIndex = 13
        rbOption2.TabStop = True
        rbOption2.Text = "RadioButton2"
        rbOption2.UseVisualStyleBackColor = True
        ' 
        ' rbOption1
        ' 
        rbOption1.AutoSize = True
        rbOption1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbOption1.Location = New Point(65, 214)
        rbOption1.Name = "rbOption1"
        rbOption1.Size = New Size(110, 21)
        rbOption1.TabIndex = 12
        rbOption1.TabStop = True
        rbOption1.Text = "RadioButton1"
        rbOption1.UseVisualStyleBackColor = True
        ' 
        ' rtbQuestion
        ' 
        rtbQuestion.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rtbQuestion.Location = New Point(-2, 2)
        rtbQuestion.Name = "rtbQuestion"
        rtbQuestion.Size = New Size(570, 154)
        rtbQuestion.TabIndex = 11
        rtbQuestion.Text = ""
        ' 
        ' ComputerScienceForm
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
        Name = "ComputerScienceForm"
        Text = "ComputerScienceForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents rbOption4 As RadioButton
    Friend WithEvents rbOption3 As RadioButton
    Friend WithEvents rbOption2 As RadioButton
    Friend WithEvents rbOption1 As RadioButton
    Friend WithEvents rtbQuestion As RichTextBox
End Class
