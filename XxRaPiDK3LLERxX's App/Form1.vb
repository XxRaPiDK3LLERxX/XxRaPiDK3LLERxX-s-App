Public Class Screen_Resolution
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        If RadioButton1.Checked = True Then
            Main_Menu.Show()
            Close()
            Dispose()
            GC.SuppressFinalize(Me)
        Else
            MsgBox("Other screen resolutions are not ready yet! 720p is only screen resolution that is ready.")
        End If
    End Sub
End Class
