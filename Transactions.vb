Public Class Transactions
    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayRecords("select BookID,AmountPaid,Date,Method from transaction", DGTransactions)
        displayRecords("select *from AdditionalCharge", DGAdditionalCharge)
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles txtTransSearch.OnTextChange
        If (Tabb.SelectedTab.Text.Equals("Booking Transactions")) Then
            displayRecords("select *from transaction where ID like '%" & txtTransSearch.text & "%' or BookID like '%" & txtTransSearch.text & "%' or AmountPaid like '%" & txtTransSearch.text & "%' or Date like '%" & txtTransSearch.text & "%' or Method like '%" & txtTransSearch.text & "%'", DGTransactions)
        Else
            displayRecords("select *from AdditionalCharge where BookID like '%" & txtTransSearch.text & "%' or Type like '%" & txtTransSearch.text & "%' or Date like '%" & txtTransSearch.text & "%'", DGAdditionalCharge)
        End If
    End Sub
End Class