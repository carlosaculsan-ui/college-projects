Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1

    Const cCaffeMocha_PRICE = 35
    Const cAmericano_PRICE = 50
    Const cBlackCoffee_PRICE = 20
    Const cKopiko_PRICE = 10
    Const cCappucino_PRICE = 70
    Const cEspresso_PRICE = 100
    Public itemName As String
    Public cPrice As Double
    Public quantity As Double
    Public itemAmount As Double
    Public totalAmount As Double = 0
    Public iPayment As Double
    Public change As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If chkMocha.Checked = True Then
            itemName = "Caffe Mocha"
            cPrice = cCaffeMocha_PRICE
        ElseIf chkAmericano.Checked = True Then
            itemName = "Americano"
            cPrice = cAmericano_PRICE
        ElseIf chkBlackCoffee.Checked = True Then
            itemName = "Black Coffee"
            cPrice = cBlackCoffee_PRICE
        ElseIf chkKopiko.Checked = True Then
            itemName = "Kopiko 3in1"
            cPrice = cKopiko_PRICE
        ElseIf chkCappucino.Checked = True Then
            itemName = "Cappucino"
            cPrice = cCappucino_PRICE
        ElseIf chkEspresso.Checked = True Then
            itemName = "Espresso"
            cPrice = cEspresso_PRICE
        Else
            MsgBox("Please Select an Item", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Oops")
            Exit Sub
        End If

        quantity = CInt(NumericUpDown1.Value)
        itemAmount = cPrice * quantity
        If NumericUpDown1.Value = 0 Then
            MessageBox.Show("Please select the number of items.", "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim previousTotal As Double
        If Double.TryParse(txtTotalAmount.Text, previousTotal) Then
            totalAmount = previousTotal
        End If

        If chkMocha.Checked Then
            totalAmount += cCaffeMocha_PRICE * NumericUpDown1.Value
        End If

        If chkAmericano.Checked Then
            totalAmount += cAmericano_PRICE * NumericUpDown1.Value
        End If

        If chkBlackCoffee.Checked Then
            totalAmount += cBlackCoffee_PRICE * NumericUpDown1.Value
        End If

        If chkKopiko.Checked Then
            totalAmount += cKopiko_PRICE * NumericUpDown1.Value
        End If

        If chkCappucino.Checked Then
            totalAmount += cCappucino_PRICE * NumericUpDown1.Value
        End If

        If chkEspresso.Checked Then
            totalAmount += cEspresso_PRICE * NumericUpDown1.Value
        End If
        txtTotalAmount.Text = totalAmount.ToString("0.00")
        If totalAmount = 0 Then
            MessageBox.Show("Please select at least one item.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If Not RadioButton1.Checked AndAlso Not RadioButton2.Checked Then
            MessageBox.Show("Please select either Takeout or Dine-in.", "No Option Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NumericUpDown1.Value = 0
        txtTotalAmount.Text = ""
        txtPayment.Text = ""
        txtChange.Text = ""
        chkAmericano.Checked = False
        chkBlackCoffee.Checked = False
        chkCappucino.Checked = False
        chkEspresso.Checked = False
        chkKopiko.Checked = False
        chkMocha.Checked = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtPayment.Text <> "" Then


            If Not Double.TryParse(txtPayment.Text, iPayment) Then
                MessageBox.Show("Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If iPayment < CDbl(txtTotalAmount.Text) Then
                MessageBox.Show("Insufficient payment amount. Please enter a higher amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            change = iPayment - CDbl(txtTotalAmount.Text)
            txtChange.Text = change.ToString("0.00")
        Else
            MessageBox.Show("Please enter the payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenReceiptForm(sender As Object, e As EventArgs) Handles PrintReceiptToolStripMenuItem.Click
        Dim items As New List(Of String)
        Dim quantities As New List(Of Integer)
        Dim prices As New List(Of Double)

        If chkMocha.Checked Then
            items.Add("Caffe Mocha")
            quantities.Add(NumericUpDown1.Value)
            prices.Add(cCaffeMocha_PRICE)
        End If
        If chkAmericano.Checked Then
            items.Add("Americano")
            quantities.Add(NumericUpDown1.Value)
            prices.Add(cAmericano_PRICE)
        End If
        If chkBlackCoffee.Checked Then
            items.Add("Black Coffee")
            quantities.Add(NumericUpDown1.Value)
            prices.Add(cBlackCoffee_PRICE)
        End If
        If chkKopiko.Checked Then
            items.Add("Kopiko 3in1")
            quantities.Add(NumericUpDown1.Value)
            prices.Add(cKopiko_PRICE)
        End If
        If chkCappucino.Checked Then
            items.Add("Cappucino")
            quantities.Add(NumericUpDown1.Value)
            prices.Add(cCappucino_PRICE)
        End If
        If chkEspresso.Checked Then
            items.Add("Espresso")
            quantities.Add(NumericUpDown1.Value)
            prices.Add(cEspresso_PRICE)
        End If
        Dim totalAmount As Double = CalculateTotalAmount(items, quantities, prices)
        Dim takeoutOrDineIn As String = If(RadioButton1.Checked, "Takeout", "Dine-in")
        Dim receiptForm As New Receipt
        receiptForm.PopulateReceipt(items, quantities, prices, totalAmount, takeoutOrDineIn)
        receiptForm.Show()

    End Sub

    Private Function CalculateTotalAmount(items As List(Of String), quantities As List(Of Integer), prices As List(Of Double)) As Double
        Dim totalAmount As Double = 0



        Return totalAmount
    End Function
End Class
