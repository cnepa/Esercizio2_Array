Public Class Form1
    Dim nomi(4) As String
    Dim i As Integer
    Private Sub btncarica_Click(sender As Object, e As EventArgs) Handles btncarica.Click
        For i = 0 To 4
            nomi(i) = InputBox("Dammi valore di posizione: " & i)
        Next
    End Sub

    Private Sub btnmostra_Click(sender As Object, e As EventArgs) Handles btnmostra.Click
        lstris.Items.Clear()
        For i = 0 To 4
            lstris.Items.Add(nomi(i))
        Next
    End Sub
End Class
