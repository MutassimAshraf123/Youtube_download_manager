Public Class wifi_error
    Private Sub wifi_error_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Panel4.Click, Label2.Click
        Me.Close()
    End Sub

    Private Sub timer4_Tick(sender As Object, e As EventArgs) Handles timer4.Tick
        If Me.InvokeRequired Then

            timer4.Stop()
        End If

        If Me.Opacity < 1 Then

            Me.Opacity += 0.1


        Else

            timer4.Stop()
        End If
    End Sub

    Private Sub a_h_Tick(sender As Object, e As EventArgs) Handles a_h.Tick
        Me.Opacity -= 0.1

        If Me.Opacity < 0.9 Then

            a_h.Stop()

        End If
    End Sub

    Private Sub GunaLinePanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles GunaLinePanel1.MouseDown
        a_h.Start()
    End Sub

    Private Sub GunaLinePanel1_MouseUp(sender As Object, e As MouseEventArgs) Handles GunaLinePanel1.MouseUp
        timer4.Start()
    End Sub
End Class