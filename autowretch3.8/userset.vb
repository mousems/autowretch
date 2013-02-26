Public Class userset
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If func_autologin_id.Text = "" Or func_autologin_pass.Text = "" Then
            MsgBox("資料沒填齊")
            Exit Sub
        End If
        Button1.Enabled = False
        If WebBrowser1.Url.OriginalString Like "https://login.yahoo.com/config/login*" Then
            If WebBrowser1.Document.GetElementById("username") <> Nothing Then
                WebBrowser1.Document.GetElementById("username").SetAttribute("value", func_autologin_id.Text) '輸入帳號
            End If

            If WebBrowser1.Document.GetElementById("passwd") <> Nothing Then '檢查密碼欄位
                WebBrowser1.Document.GetElementById("passwd").SetAttribute("value", func_autologin_pass.Text) '輸入密碼
            End If

            WebBrowser1.Document.All.GetElementsByName(".save").Item(0).InvokeMember("click") '按下登入
            relogin.Enabled = True

        Else
            WebBrowser1.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
            MsgBox("系統尚未準備完成,請再試一次")
            Button1.Enabled = True
        End If
    End Sub

    Private Sub userset_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub userset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
    End Sub
    'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway", "4")
    Private Sub logintest_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logintest.Tick
        If WebBrowser1.Url.OriginalString Like "https://login.yahoo.com/config/login*" Then
            WebBrowser1.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")

            MsgBox("帳密錯誤,無法存檔")
            func_autologin_id.Enabled = True
            func_autologin_pass.Enabled = True
            Button1.Enabled = True
        Else
            Dim pass As String = ""
            For i = 1 To Len(func_autologin_pass.Text)
                pass = Chr(Asc(Mid(func_autologin_pass.Text, i, 1)) + 5) & pass
            Next

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway", "4")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway_username", func_autologin_id.Text)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway_password", pass)
            MsgBox("帳密已經儲存完畢,請重新啟動程式!")

            WebBrowser1.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
            func_autologin_id.Enabled = True
            func_autologin_pass.Enabled = True
            Button1.Enabled = True
            End
        End If
        logintest.Enabled = False
    End Sub

    Private Sub relogin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles relogin.Tick
        Try
            Button1.Enabled = False
            If WebBrowser1.Url.OriginalString Like "https://login.yahoo.com/config/login*" Then
                If WebBrowser1.Document.GetElementById("passwd") <> Nothing Then '檢查密碼欄位
                    WebBrowser1.Document.GetElementById("passwd").SetAttribute("value", func_autologin_pass.Text) '輸入密碼
                End If

                WebBrowser1.Document.All.GetElementsByName(".save").Item(0).InvokeMember("click") '按下登入
            Else
                logintest.Enabled = True
                relogin.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class