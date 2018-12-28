Imports System.ComponentModel

Public Class MainFrm

    Private Sub TBSearch_TextChanged(sender As Object, e As EventArgs) Handles TBSearch.TextChanged
        LBHowMany.Text = TBSearch.TextLength & " 자"
    End Sub

    Private Sub MainFrm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub
End Class
