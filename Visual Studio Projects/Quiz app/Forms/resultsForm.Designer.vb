<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resultsForm
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
        lblScore = New Label()
        lblMessage = New Label()
        SuspendLayout()
        ' 
        ' lblScore
        ' 
        lblScore.Font = New Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(102, 78)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(222, 78)
        lblScore.TabIndex = 0
        ' 
        ' lblMessage
        ' 
        lblMessage.Font = New Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMessage.Location = New Point(102, 229)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(222, 78)
        lblMessage.TabIndex = 1
        ' 
        ' resultsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(452, 434)
        Controls.Add(lblMessage)
        Controls.Add(lblScore)
        Name = "resultsForm"
        Text = "resultsForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblScore As Label
    Friend WithEvents lblMessage As Label
End Class
