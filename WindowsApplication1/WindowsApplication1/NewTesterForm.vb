Public Class NewTesterForm

    Public totavote, totovote, totvote As Decimal

    Private Sub cancelbutton_Click(sender As Object, e As EventArgs) Handles cancelbutton.Click
        Me.Close()
    End Sub

    Private Sub okbutton_Click(sender As Object, e As EventArgs) Handles okbutton.Click
        Dim ainteger, ointeger As Integer

        Try

            ainteger = Integer.Parse(apptxtbox.Text)
            ointeger = Integer.Parse(ortxtbox.Text)

            If ainteger < 1 Or ointeger < 1 Or ainteger > 10 Or ointeger > 10 Then
                MessageBox.Show("Enter a value between 1 to 10", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            With apptxtbox
                .Focus()
                .Clear()
                With ortxtbox
                    .Clear()
                End With
            End With
        Catch ex As Exception
            MessageBox.Show("Numbers must be numeric", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        totavote += ainteger
        totovote += ointeger
        totvote += 1

    End Sub
End Class