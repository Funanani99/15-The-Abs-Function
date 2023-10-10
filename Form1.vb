Imports System.Reflection.Metadata.BlobBuilder

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim number, abs As Double

        ' number = Val(TextBox2.Text)
        ' abs = Math.Abs(number)
        'TextBox1.Text = abs

        TextBox1.Text = Math.Abs(Val(TextBox2.Text))
    End Sub
End Class
