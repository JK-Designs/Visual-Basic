Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim totalCash As Double

        If Double.TryParse(txtTotalCash.Text, totalCash) Then
            lblTotalYears.Text = totalCash / 40
        Else
            MessageBox.Show("Error: Input should be a number value.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
