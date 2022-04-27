Public Class Form1
    Dim intI As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If intI < 3 Then
            If intI = 1 Then
                TextBox5.Text = "そうめん"
            Else
                TextBox5.Text = "水"
                TextBox4.Text = "そうめん"
            End If
        Else
            Select Case (intI - 3) Mod 3
                Case 0
                    TextBox4.Text = "水"
                    TextBox3.Text = "そうめん"
                    TextBox1.Text = "水"
                Case 1
                    TextBox5.Text = "そうめん"
                    TextBox3.Text = "水"
                    TextBox2.Text = "そうめん"
                Case 2
                    TextBox5.Text = "水"
                    TextBox4.Text = "そうめん"
                    TextBox2.Text = "水"
                    TextBox1.Text = "そうめん"
            End Select
        End If
        intI += 1
    End Sub
End Class
