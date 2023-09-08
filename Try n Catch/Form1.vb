Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

        Try
            Dim Numb As Double
            Numb = CDbl(txtNumber.Text)
            MsgBox("All Done !" & vbNewLine & txtNumber.Text & " is a valid number ")

        Catch ex As Exception
            MsgBox("Error:  " & txtNumber.Text & vbNewLine & " Is not a  valid number")

        End Try



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
