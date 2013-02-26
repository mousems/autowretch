Public Class talk

    Private Sub talk_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        WebBrowser1.Navigate("http://autowretch.com/talktoenginer.html")
    End Sub

    Private Sub talk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://autowretch.com/talktoenginer.html")
    End Sub
End Class