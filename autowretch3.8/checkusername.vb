Public Class checkusername

    Public Sub loginenter()
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("有欄位未輸入")
        Else
            If Mid(welcome.WebBrowser2.Url.ToString, 1, 19) <> "https://login.yahoo" Then
                welcome.WebBrowser2.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
                MsgBox("系統尚未就緒,請再試一次")
            Else
                Try
                    If welcome.WebBrowser2.Document.GetElementById("username") <> Nothing Then
                        welcome.WebBrowser2.Document.GetElementById("username").SetAttribute("value", TextBox1.Text) '輸入帳號
                    End If

                    If welcome.WebBrowser2.Document.GetElementById("passwd") <> Nothing Then '檢查密碼欄位
                        welcome.WebBrowser2.Document.GetElementById("passwd").SetAttribute("value", TextBox2.Text) '輸入密碼
                    End If
                    welcome.WebBrowser2.Document.All.GetElementsByName(".save").Item(0).InvokeMember("click") '按下登入
                    welcome.Label_title2.Text = "正在為您登入您的雅虎帳號以便確認驗證"
                    Application.DoEvents()
                Catch ex As Exception
                    MsgBox("系統尚未就緒,可能是你的網路過慢不適合本驗證")
                    Exit Sub
                End Try
                Me.Hide()
                welcome.Show()
                welcome.Label_title1.Text = "無名驗證中,請稍後幾秒!"

                Timer1.Enabled = True
                'relogin.Enabled = True
            End If
        End If
    End Sub


    Private Sub checkusername_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub checkusername_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        welcome.WebBrowser2.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
        If welcome.autousercheck = True Then
            Timer2.Enabled = True
            Dim pass As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway_password", Nothing)
            Dim pass2 As String = ""
            For i = 1 To Len(pass)
                pass2 = Chr(Asc(Mid(pass, i, 1)) - 5) & pass2
            Next

            welcome.TextBox1str = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway_username", Nothing)
            TextBox1.Enabled = False
            TextBox2.Text = pass2
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Try

            welcome.Button1.Enabled = False
            welcome.Button2.Enabled = False
            welcome.Button3.Enabled = False
            welcome.Button4.Enabled = False


            welcome.TextBox1str = welcome.WebBrowser2.DocumentText.ToString
            If InStr(welcome.TextBox1str, "或密碼無效。") <> 0 Or welcome.WebBrowser2.Url.ToString = "https://login.yahoo.com/config/login?" Then
                welcome.WebBrowser2.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
                MsgBox("雅虎密碼錯誤")
                welcome.countdown2.Enabled = False
                welcome.autologin.Enabled = False
                Me.Show()
                Exit Sub
            End If



            Dim a As String
            If welcome.WebBrowser2.Url.ToString = "http://www.wretch.cc/blog/mousems1" Then
                welcome.WebBrowser2.Stop()
                welcome.TextBox1str = welcome.WebBrowser2.DocumentText.ToString

                If InStr(welcome.TextBox1str, "<a style=""margin:0 5px"">Hi, ") = 0 Then
                    Timer1.Enabled = False
                    MsgBox("驗證失敗 請重新啟動程式")
                    End

                ElseIf InStr(welcome.TextBox1str, "或密碼無效。") <> 0 Then
                    welcome.WebBrowser2.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
                    MsgBox("雅虎密碼錯誤")
                    welcome.countdown2.Enabled = False
                    welcome.autologin.Enabled = False
                    Me.Show()
                    welcome.Hide()
                Else

                    'Dim txt3() As String = Split(welcome.TextBox1str, "<span class=""bar-block theme"">Hi, ") 新版無名
                    Dim txt3() As String = Split(welcome.TextBox1str, "<a style=""margin:0 5px"">Hi, ")
                    Dim txt4() As String = Split(txt3(1), "<") '無名帳號

                    welcome.Label_title2.Text = "您的無名帳號是:" & LCase(txt4(0)) & "(認證用)"

                    Application.DoEvents()
                    form1.Tag = LCase(txt4(0))
                    a = form1.Tag
                    Dim checkans As String = wretchuser_check(LCase(txt4(0)))
                    Select Case Mid(checkans, 1, 2)
                        Case "20"
                            welcome.dueto = checkans
                            welcome.Tag = "vip2"
                            welcome.wretchusername = LCase(txt4(0))
                            welcome.Label_title1.Text = "3秒後進入主畫面"
                            welcome.Label_title2.Text = "您是VIP，擁有全部的功能! 到期日:" & welcome.dueto
                            welcome.Label_title2.ForeColor = Color.Blue
                            welcome.countdown2.Enabled = True
                        Case "21"
                            welcome.dueto = "永久"
                            welcome.Tag = "vip2"
                            welcome.wretchusername = LCase(txt4(0))
                            welcome.Label_title1.Text = "3秒後進入主畫面"
                            welcome.Label_title2.Text = "您是VIP，擁有全部的功能! 到期日:" & welcome.dueto
                            welcome.Label_title2.ForeColor = Color.Blue
                            welcome.countdown2.Enabled = True
                        Case Else
                            welcome.Label_title1.Text = "...免費版認證中..."
                            welcome.Label_title2.Text = "3秒後進入主畫面"
                            welcome.Label_title2.Text = "您是免費版，每逛3000人需要重新啟動程式！"
                            welcome.Label_title2.ForeColor = Color.Blue

                            welcome.countdown2.Enabled = True

                    End Select

                    Me.Hide()
                    welcome.Show()
                    relogin.Enabled = False
                    Timer1.Enabled = False
                    Timer2.Enabled = False


                End If
                welcome.WebBrowser2.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
            Else
                MsgBox("系統異常")
                End
            End If
            Timer1.Enabled = False
        Catch ex As Exception
            MsgBox("登入未成功,可能是系統還沒載入完畢就進行登入,請再試一次")
            End
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("有欄位未輸入")
        Else
            Try
                If Mid(welcome.WebBrowser2.Url.ToString, 1, 19) <> "https://login.yahoo" Then
                    welcome.WebBrowser2.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
                    MsgBox("系統尚未就緒,請稍後再試")
                Else
                    If welcome.WebBrowser2.Document.GetElementById("username") <> Nothing Then
                        welcome.WebBrowser2.Document.GetElementById("username").SetAttribute("value", TextBox1.Text) '輸入帳號
                    End If

                    If welcome.WebBrowser2.Document.GetElementById("passwd") <> Nothing Then '檢查密碼欄位
                        welcome.WebBrowser2.Document.GetElementById("passwd").SetAttribute("value", TextBox2.Text) '輸入密碼
                    End If
                    welcome.WebBrowser2.Document.All.GetElementsByName(".save").Item(0).InvokeMember("click") '按下登入
                    welcome.Label_title2.Text = "正在為您登入您的雅虎帳號以便確認驗證"
                    Me.Hide()
                    welcome.Show()
                    welcome.Label_title1.Text = "無名驗證中,請稍後幾秒!"
                    relogin.Enabled = True
                End If
            Catch ex As Exception
                welcome.WebBrowser2.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
                MsgBox("系統尚未就緒,請稍後再試")
            End Try

        End If
        Timer2.Enabled = False
    End Sub

    Private Sub relogin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles relogin.Tick
        Try
            If welcome.WebBrowser2.Url.OriginalString Like "https://login.yahoo.com/config/login*" Then
                If welcome.WebBrowser2.Document.GetElementById("passwd") <> Nothing Then '檢查密碼欄位
                    welcome.WebBrowser2.Document.GetElementById("passwd").SetAttribute("value", TextBox2.Text) '輸入密碼
                End If
                welcome.WebBrowser2.Document.All.GetElementsByName(".save").Item(0).InvokeMember("click") '按下登入
            Else
                Timer1.Enabled = True
                relogin.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        loginenter()
    End Sub
End Class