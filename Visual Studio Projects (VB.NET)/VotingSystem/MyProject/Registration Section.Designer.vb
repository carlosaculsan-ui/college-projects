<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration_Section
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration_Section))
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        ListView1 = New ListView()
        Button1 = New Button()
        Button2 = New Button()
        Label4 = New Label()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 28)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 28)
        Label2.TabIndex = 1
        Label2.Text = "Surname"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(166, 59)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(143, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(165, 105)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(143, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 28)
        Label3.TabIndex = 4
        Label3.Text = "MIddle Initial"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(166, 155)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(142, 23)
        TextBox3.TabIndex = 5
        ' 
        ' ListView1
        ' 
        ListView1.GridLines = True
        ListView1.Location = New Point(330, 53)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(327, 272)
        ListView1.TabIndex = 6
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(185, 209)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 45)
        Button1.TabIndex = 7
        Button1.Text = "SAVE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(397, 342)
        Button2.Name = "Button2"
        Button2.Size = New Size(188, 40)
        Button2.TabIndex = 8
        Button2.Text = "PROCEED TO VOTING"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(44, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 13)
        Label4.TabIndex = 9
        Label4.Text = "Optional"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(185, 269)
        Button3.Name = "Button3"
        Button3.Size = New Size(103, 45)
        Button3.TabIndex = 10
        Button3.Text = "REMOVE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Registration_Section
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(660, 461)
        Controls.Add(Button3)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListView1)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Registration_Section"
        Text = "Registration_Section"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
End Class
