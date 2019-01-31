Public Class Office_HomePage

    Public Property Username As String

    Private Sub Office_HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(Username)
    End Sub
End Class