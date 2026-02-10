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
        txtTask = New TextBox()
        Label2 = New Label()
        btnAdd = New Button()
        btnDelete = New Button()
        lstTasks = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(109, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 52)
        Label1.TabIndex = 0
        Label1.Text = "TO DO LIST FORM"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtTask
        ' 
        txtTask.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTask.Location = New Point(159, 107)
        txtTask.Name = "txtTask"
        txtTask.Size = New Size(212, 25)
        txtTask.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 21)
        Label2.TabIndex = 2
        Label2.Text = "Insert New Task"
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(473, 99)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(86, 38)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(250, 423)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(107, 39)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' lstTasks
        ' 
        lstTasks.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstTasks.FormattingEnabled = True
        lstTasks.ItemHeight = 17
        lstTasks.Location = New Point(47, 143)
        lstTasks.Name = "lstTasks"
        lstTasks.Size = New Size(512, 242)
        lstTasks.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._1
        ClientSize = New Size(608, 474)
        Controls.Add(lstTasks)
        Controls.Add(txtTask)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTask As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lstTasks As ListBox

End Class
