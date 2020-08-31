Public Class frmMain
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDoughnuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        txtDoughnuts.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblTotalItems.Text = Val(txtDoughnuts.Text) + Val(txtMuffins.Text)
        lblTotalSales.Text = Val(lblTotalItems.Text) * 0.5
        lblTotalSales.Text = Format(lblTotalSales.Text, "currency")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnCalc.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False
        btnPrint.Visible = False
        PrintForm1.Print()
        btnCalc.Visible = True
        btnClear.Visible = True
        btnExit.Visible = True
        btnPrint.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
