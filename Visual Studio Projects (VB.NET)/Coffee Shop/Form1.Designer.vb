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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        chkEspresso = New CheckBox()
        chkCappucino = New CheckBox()
        chkKopiko = New CheckBox()
        chkBlackCoffee = New CheckBox()
        chkAmericano = New CheckBox()
        chkMocha = New CheckBox()
        GroupBox2 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        txtTotalAmount = New TextBox()
        Label3 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        NumericUpDown1 = New NumericUpDown()
        Label2 = New Label()
        GroupBox3 = New GroupBox()
        Button3 = New Button()
        txtChange = New TextBox()
        txtPayment = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        PrintReceiptToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label1.Font = New Font("Malgun Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(138, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(476, 102)
        Label1.TabIndex = 0
        Label1.Text = "PARA KANINO KA BUMABANGON" & vbCrLf & "                 COFFEE SHOP"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        GroupBox1.Controls.Add(chkEspresso)
        GroupBox1.Controls.Add(chkCappucino)
        GroupBox1.Controls.Add(chkKopiko)
        GroupBox1.Controls.Add(chkBlackCoffee)
        GroupBox1.Controls.Add(chkAmericano)
        GroupBox1.Controls.Add(chkMocha)
        GroupBox1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(21, 150)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(276, 307)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Coffee Selection"
        ' 
        ' chkEspresso
        ' 
        chkEspresso.AutoSize = True
        chkEspresso.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkEspresso.ForeColor = Color.Black
        chkEspresso.Location = New Point(22, 232)
        chkEspresso.Name = "chkEspresso"
        chkEspresso.Size = New Size(156, 24)
        chkEspresso.TabIndex = 5
        chkEspresso.Text = "Espresso            100"
        chkEspresso.UseVisualStyleBackColor = True
        ' 
        ' chkCappucino
        ' 
        chkCappucino.AutoSize = True
        chkCappucino.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkCappucino.ForeColor = Color.Black
        chkCappucino.Location = New Point(22, 192)
        chkCappucino.Name = "chkCappucino"
        chkCappucino.Size = New Size(157, 24)
        chkCappucino.TabIndex = 4
        chkCappucino.Text = "Cappucino          70"
        chkCappucino.UseVisualStyleBackColor = True
        ' 
        ' chkKopiko
        ' 
        chkKopiko.AutoSize = True
        chkKopiko.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkKopiko.ForeColor = Color.Black
        chkKopiko.Location = New Point(22, 152)
        chkKopiko.Name = "chkKopiko"
        chkKopiko.Size = New Size(157, 24)
        chkKopiko.TabIndex = 3
        chkKopiko.Text = "Kopiko 3 in 1       10"
        chkKopiko.UseVisualStyleBackColor = True
        ' 
        ' chkBlackCoffee
        ' 
        chkBlackCoffee.AutoSize = True
        chkBlackCoffee.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkBlackCoffee.ForeColor = Color.Black
        chkBlackCoffee.Location = New Point(22, 115)
        chkBlackCoffee.Name = "chkBlackCoffee"
        chkBlackCoffee.Size = New Size(160, 24)
        chkBlackCoffee.TabIndex = 2
        chkBlackCoffee.Text = "Black Coffee        20"
        chkBlackCoffee.UseVisualStyleBackColor = True
        ' 
        ' chkAmericano
        ' 
        chkAmericano.AutoSize = True
        chkAmericano.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkAmericano.ForeColor = Color.Black
        chkAmericano.Location = New Point(22, 77)
        chkAmericano.Name = "chkAmericano"
        chkAmericano.Size = New Size(158, 24)
        chkAmericano.TabIndex = 1
        chkAmericano.Text = "Americano          50"
        chkAmericano.UseVisualStyleBackColor = True
        ' 
        ' chkMocha
        ' 
        chkMocha.AutoSize = True
        chkMocha.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkMocha.ForeColor = Color.Black
        chkMocha.Location = New Point(22, 39)
        chkMocha.Name = "chkMocha"
        chkMocha.Size = New Size(158, 24)
        chkMocha.TabIndex = 0
        chkMocha.Text = "Caffe Mocha       35"
        chkMocha.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Controls.Add(txtTotalAmount)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(NumericUpDown1)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(428, 157)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(304, 179)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Order Information"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(174, 73)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(68, 21)
        RadioButton2.TabIndex = 9
        RadioButton2.TabStop = True
        RadioButton2.Text = "Dine in"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(41, 73)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(74, 21)
        RadioButton1.TabIndex = 8
        RadioButton1.TabStop = True
        RadioButton1.Text = "Takeout"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Location = New Point(147, 145)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.Size = New Size(107, 25)
        txtTotalAmount.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 17)
        Label3.TabIndex = 6
        Label3.Text = "Total Amount:"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(174, 105)
        Button2.Name = "Button2"
        Button2.Size = New Size(80, 37)
        Button2.TabIndex = 5
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(48, 105)
        Button1.Name = "Button1"
        Button1.Size = New Size(80, 37)
        Button1.TabIndex = 4
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(134, 31)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 25)
        NumericUpDown1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 17)
        Label2.TabIndex = 0
        Label2.Text = "Quantity"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        GroupBox3.Controls.Add(Button3)
        GroupBox3.Controls.Add(txtChange)
        GroupBox3.Controls.Add(txtPayment)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(309, 342)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(422, 110)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Customer Payment"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(298, 40)
        Button3.Name = "Button3"
        Button3.Size = New Size(95, 53)
        Button3.TabIndex = 10
        Button3.Text = "Purchase"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' txtChange
        ' 
        txtChange.Location = New Point(147, 68)
        txtChange.Name = "txtChange"
        txtChange.Size = New Size(117, 25)
        txtChange.TabIndex = 9
        ' 
        ' txtPayment
        ' 
        txtPayment.Location = New Point(147, 37)
        txtPayment.Name = "txtPayment"
        txtPayment.Size = New Size(117, 25)
        txtPayment.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(49, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 17)
        Label5.TabIndex = 1
        Label5.Text = "Change:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(49, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 17)
        Label4.TabIndex = 0
        Label4.Text = "Payment:"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, AboutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(752, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PrintReceiptToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' PrintReceiptToolStripMenuItem
        ' 
        PrintReceiptToolStripMenuItem.Name = "PrintReceiptToolStripMenuItem"
        PrintReceiptToolStripMenuItem.Size = New Size(141, 22)
        PrintReceiptToolStripMenuItem.Text = "Print Receipt"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(141, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(52, 20)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(752, 464)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkEspresso As CheckBox
    Friend WithEvents chkCappucino As CheckBox
    Friend WithEvents chkKopiko As CheckBox
    Friend WithEvents chkBlackCoffee As CheckBox
    Friend WithEvents chkAmericano As CheckBox
    Friend WithEvents chkMocha As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtChange As TextBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintReceiptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton

End Class
