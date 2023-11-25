Public Class Dashboard
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to Log out?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1, "Close Application") = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class