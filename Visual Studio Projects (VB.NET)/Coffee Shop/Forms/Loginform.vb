Public Class Loginform


    Private Const LOCKOUT_DURATION As Integer = 10
    Private lockoutStartTime As DateTime
    Private failedAttempts As Integer = 0
    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stUsername As String = TextBox1.Text
        Dim stPassword As String = TextBox2.Text

        If String.IsNullOrEmpty(stUsername) AndAlso String.IsNullOrEmpty(stPassword) Then
            MsgBox("Username and password cannot be empty", MessageBoxButtons.OK)
            Return
        End If

        If String.IsNullOrEmpty(stUsername) Then
            MsgBox("User account cannot be empty", MessageBoxButtons.OK)
            Return
        End If

        If String.IsNullOrEmpty(stPassword) Then
            MsgBox("Password cannot be empty", MessageBoxButtons.OK)
            Return
        End If

        If stUsername.Length < 4 Then
            MsgBox("Username cannot be less than 4 characters", MessageBoxButtons.OK)
            Return
        End If

        If stUsername = "admin" AndAlso stPassword = "password" Then
            MessageBox.Show("LOGIN SUCCESSFUL", "Press OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Show()
            Me.Hide()
        Else
            failedAttempts += 1
            MsgBox("Incorrect Username or Password", MsgBoxStyle.OkOnly, "Invalid")

            If failedAttempts >= 3 Then
                MsgBox("You are locked out for 10 seconds due to multiple failed login attempts.", MsgBoxStyle.Information, "Locked Out")
                Button1.Enabled = False
                LockoutTimer.Interval = 10000
                LockoutTimer.Start()
            End If


        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub
    Private Sub LockLoginForm()

        Button1.Enabled = False
        lockoutStartTime = DateTime.Now
        LockoutTimer.Start()
    End Sub

    Private Sub LockoutTimer_Tick(sender As Object, e As EventArgs) Handles LockoutTimer.Tick
        LockoutTimer.Stop()
        Button1.Enabled = True
        failedAttempts = 0
    End Sub



End Class