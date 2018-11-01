Public Class helpScreen
    'Back button when clicked redirects user back to media player page
    Private Sub picBoxBackHelp_Click(sender As Object, e As EventArgs) Handles picBoxBackHelp.Click
        Me.Hide()
        mainProgram.Show()
    End Sub
End Class