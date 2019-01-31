Public Class Rest_HomePage

    Public Property Username As String
    Public Property Type As String

    Private Sub Rest_HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(Username)
        MessageBox.Show(Type)
    End Sub
End Class