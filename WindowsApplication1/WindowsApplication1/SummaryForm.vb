Public Class SummaryForm

    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        Dim avgavote, avgovote As Integer

        If NewTesterForm.totavote > NewTesterForm.totovote Then
            wintxtbox.Text = "The winner is Apple Ade!"
        Else
            wintxtbox.Text = "The winner is Prune Punch!"
        End If

        totvotetxtbox.Text = "Total Votes : " & NewTesterForm.totvote.ToString()

        avgavote = NewTesterForm.totavote / NewTesterForm.totvote
        avgovote = NewTesterForm.totovote / NewTesterForm.totvote

        avgatxtbox.Text = avgavote.ToString()
        avgotxtbox.Text = avgovote.ToString()

    End Sub
    Private Sub okbutton_Click(sender As Object, e As EventArgs) Handles okbutton.Click
        Me.Close()
    End Sub
End Class