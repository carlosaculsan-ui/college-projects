<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loginform
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loginform))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        LockoutTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Lime
        Label1.Font = New Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(422, 99)
        Label1.TabIndex = 0
        Label1.Text = "PARA KANINO KA BUMABABANGON" & vbCrLf & "                   COFFEE SHOP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Lime
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(89, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 21)
        Label2.TabIndex = 1
        Label2.Text = "Username" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Lime
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(89, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 21)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(207, 177)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(114, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(207, 248)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 23)
        TextBox2.TabIndex = 4
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        CheckBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(340, 250)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(60, 21)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(143, 309)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 52)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LockoutTimer
        ' 
        ' 
        ' Loginform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(430, 405)
        Controls.Add(Button1)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Loginform"
        Text = "Loginform"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LockoutTimer As Timer
End Class
