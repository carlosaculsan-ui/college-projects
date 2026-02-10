Public Class Receipt
    Public Sub PopulateReceipt(items As List(Of String), quantities As List(Of Integer), prices As List(Of Double), totalAmount As Double, takeoutOrDineIn As String)

        DataGridView1.Rows.Clear()


        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Item", "Item")
        DataGridView1.Columns.Add("Quantity", "Quantity")
        DataGridView1.Columns.Add("Price", "Price")


        Dim total As Double = 0
        For i As Integer = 0 To items.Count - 1
            Dim subtotal As Double = quantities(i) * prices(i)
            Dim row As String() = {items(i), quantities(i).ToString(), prices(i).ToString("0.00") & " (" & subtotal.ToString("0.00") & ")"}
            DataGridView1.Rows.Add(row)
            total += subtotal
        Next


        Dim totalRow As String() = {"Total Amount:", "", total.ToString("0.00")}
        DataGridView1.Rows.Add(totalRow)


        Dim paymentRow As String() = {"Payment:", "", Form1.iPayment.ToString("0.00")}
        DataGridView1.Rows.Add(paymentRow)


        Dim changeRow As String() = {"Change:", "", Form1.change.ToString("0.00")}
        DataGridView1.Rows.Add(changeRow)


        Dim takeoutOrDineInRow As String() = {"STATUS:", "", takeoutOrDineIn}
        DataGridView1.Rows.Add(takeoutOrDineInRow)
    End Sub
End Class 