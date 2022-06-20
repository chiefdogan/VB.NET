
Public Class Form1

    Private Property dLoan As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim dLoan, dRate, dPayment As Double

        Dim iYears As Integer


        'Convert the Loan amount to a double and store it in dLoan
        Try
            'Try to convert the value in txtLoan to a double
            dLoan = CDbl(txtLoan.Text.Trim)
        Catch
            'If a conversion error occurs, this code is executed
            MessageBox.Show("Loan Amount Invalid!", "Invalid Loan Amount", _
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Set the focus back on the txtLoan textbox
            txtLoan.Focus()
            'Exit the sub, so the user can correct their error and try again
            Exit Sub
        End Try

        'Convert the Interest Rate to a double and store it in dRate
        Try
            'Try to convert the value in txtRate to a double
            dRate = CDbl(txtRate.Text.Trim)
            'Convert dRate to a percent value (required by the Pmt function)
            If dRate > 1 Then dRate = dRate / 100
        Catch
            'If a conversion error occurs, this code is executed
            MessageBox.Show("Interest Rate Invalid!", "Invalid Interest Rate", _
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Set the focus back on the txtRate textbox
            txtRate.Focus()
            'Exit the sub, so the user can correct their error and try again
            Exit Sub
        End Try

        'Convert the Years of Loan to an Integer and store it in iYears
        Try
            'Try to convert the value in nudYears to a double

            iYears = CInt(nudYears.Text.Trim)

        Catch
            'If a conversion error occurs, this code is executed

            MessageBox.Show("Years of Loan Invalid!", "Invalid Years of Loan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'Set the focus back on the nudYears control

            nudYears.Focus()

            'Exit the sub, so the user can correct their error and try again

            Exit Sub

        End Try

        'Convert the Years of Loan to an Integer and store it in iYears

        Try

            'Use the Pmt function to calculate the Monthly Payment

            dPayment = Pmt(dRate / 12, iYears * 12, -1 * dLoan)

        Catch

            'If an error occurs, this code is executed

            MessageBox.Show("Payment cannot be calculated! Check entries!", "Payment Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'Set the focus back on the txtLoan control

            txtLoan.Focus()

            'Exit the sub, so the user can correct their error and try again

            Exit Sub

        End Try

        'Display the Monthly Payment in the txtPayment textbox

        txtTotal.Text = Format(dPayment, "Tshs.")

        'Display the Payment amount before the Amortization process starts

        txtPayment.Refresh()

        MsgBox(CDbl(dPayment))


        richtxt.Text = "Your Name is :" & txtfull.Text & vbNewLine & " Your Account type is :" & txtCombo.Text & vbNewLine & " Loan balance : " & txtLoan.Text & vbNewLine & " Interest Rate : " & txtRate.Text & " % " & vbNewLine

        ''Dimension the variables for Loan amount, Interest Rate,
        ''    and Monthly Payment variable in
        ''    the Declarations section.

        'Dim dLoan, dRate, dPayment As Double

        'Dim iYears As Integer

        ''The following code goes in the btnCalculate_Click event procedure

        ''Convert the Loan amount to a double and store it in dLoan

        'dLoan = CDbl(txtLoan.Text.Trim)

        ''Convert the Interest Rate to a double and store it in dRate
        'dRate = CDbl(txtRate.Text.Trim)

        ''Convert dRate to a percent value (required by the Pmt function)
        'If dRate > 1 Then dRate = dRate / 100
        ''Convert the Years of Loan to an Integer and store it in iYears
        'iYears = CInt(nudYears.Text.Trim)

        ''Use the Pmt function to calculate the Monthly Payment

        'dPayment = Pmt(dRate / 12, iYears * 12, -1 * dLoan)

        ''Display the Monthly Payment in the txtPayment textbox

        'txtTotal.Text = Format(dPayment, "Tshs#,##0.00")

        ''Display the Payment amount before the Amortization process starts
        'txtPayment.Refresh()
    End Sub

    Private Sub txtLoan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoan.TextChanged
        Try
            'Try to convert the value in txtLoan to a double
            dLoan = CDbl(txtLoan.Text.Trim)
        Catch
            'If a conversion error occurs, this code is executed
            MessageBox.Show("Loan Amount Invalid!", "Invalid Loan Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Set the focus back on the txtLoan textbox
            txtLoan.Focus()

            'Exit the sub, so the user can correct their error and try again
            Exit Sub
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtLoan.Clear()
        txtPayment.Clear()
        txtRate.Clear()
        txtTotal.Clear()
        txtCombo.Text = " "
        richtxt.Clear()
        txtfull.Clear()
        nudYears.ResetText()

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles richtxt.TextChanged, richtxt.ReadOnlyChanged


    End Sub

    Private Sub nudYears_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudYears.ValueChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("utajua haujui ")

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
