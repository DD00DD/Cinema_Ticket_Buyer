Public Class Form1
    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        userName = txtName.Text
        userName = StrConv(userName, vbProperCase)
        Dim letter As Char

        If userName.Contains("(", ".") Then

            MessageBox.Show("Please type in a valid name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

        End If
    End Sub
End Class
