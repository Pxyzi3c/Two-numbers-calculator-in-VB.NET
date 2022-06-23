Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtFirstNumber.Text = String.Empty Or txtSecondNumber.Text = String.Empty Then
            MsgBox("Complete the nescessary fields before calculating!", vbOKOnly + vbCritical, "Warning")
        Else
            lblSymbol.Text = "+"
            Dim result = CInt(txtFirstNumber.Text) + CInt(txtSecondNumber.Text)
            txtResult.Text = result.ToString()
        End If
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If txtFirstNumber.Text = String.Empty Or txtSecondNumber.Text = String.Empty Then
            MsgBox("Complete the nescessary fields before calculating!", vbOKOnly + vbCritical, "Warning")
        Else
            lblSymbol.Text = "-"
            Dim result = CInt(txtFirstNumber.Text) - CInt(txtSecondNumber.Text)
            txtResult.Text = result.ToString()
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If txtFirstNumber.Text = String.Empty Or txtSecondNumber.Text = String.Empty Then
            MsgBox("Complete the nescessary fields before calculating!", vbOKOnly + vbCritical, "Warning")
        Else
            lblSymbol.Text = "x"
            Dim result = CInt(txtFirstNumber.Text) * CInt(txtSecondNumber.Text)
            txtResult.Text = result.ToString()
        End If
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If txtFirstNumber.Text = String.Empty Or txtSecondNumber.Text = String.Empty Then
            MsgBox("Complete the nescessary fields before calculating!", vbOKOnly + vbCritical, "Warning")
        Else
            lblSymbol.Text = "/"
            Dim result = CInt(txtFirstNumber.Text) / CInt(txtSecondNumber.Text)
            txtResult.Text = result.ToString()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstNumber.Text = String.Empty
        txtSecondNumber.Text = String.Empty
        txtResult.Text = String.Empty
        lblSymbol.Text = "?"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response As VariantType
        response = MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion, "Exit")
        If response = vbYes Then
            End
        End If
    End Sub
End Class
