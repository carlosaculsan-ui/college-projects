<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        rbMath = New RadioButton()
        rbHistory = New RadioButton()
        rbComputerScience = New RadioButton()
        btnStart = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(32, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(521, 62)
        Label1.TabIndex = 0
        Label1.Text = "                       SELECT A SUBJECT"
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ButtonShadow
        Label2.Font = New Font("Mongolian Baiti", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1, -2)
        Label2.Name = "Label2"
        Label2.Size = New Size(552, 53)
        Label2.TabIndex = 1
        Label2.Text = "                    QUIZ APPLICATION"
        ' 
        ' rbMath
        ' 
        rbMath.AutoSize = True
        rbMath.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbMath.Location = New Point(59, 173)
        rbMath.Name = "rbMath"
        rbMath.Size = New Size(61, 20)
        rbMath.TabIndex = 2
        rbMath.TabStop = True
        rbMath.Text = "Math"
        rbMath.UseVisualStyleBackColor = True
        ' 
        ' rbHistory
        ' 
        rbHistory.AutoSize = True
        rbHistory.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbHistory.Location = New Point(200, 173)
        rbHistory.Name = "rbHistory"
        rbHistory.Size = New Size(78, 20)
        rbHistory.TabIndex = 3
        rbHistory.TabStop = True
        rbHistory.Text = "History"
        rbHistory.UseVisualStyleBackColor = True
        ' 
        ' rbComputerScience
        ' 
        rbComputerScience.AutoSize = True
        rbComputerScience.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbComputerScience.Location = New Point(343, 173)
        rbComputerScience.Name = "rbComputerScience"
        rbComputerScience.Size = New Size(155, 20)
        rbComputerScience.TabIndex = 4
        rbComputerScience.TabStop = True
        rbComputerScience.Text = "Computer Science"
        rbComputerScience.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.ButtonShadow
        btnStart.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(227, 234)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(100, 59)
        btnStart.TabIndex = 5
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(554, 305)
        Controls.Add(btnStart)
        Controls.Add(rbComputerScience)
        Controls.Add(rbHistory)
        Controls.Add(rbMath)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rbMath As RadioButton
    Friend WithEvents rbHistory As RadioButton
    Friend WithEvents rbComputerScience As RadioButton
    Friend WithEvents btnStart As Button

End Class
