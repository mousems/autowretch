Imports System.Net '放在最前面
Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Public Class form1
    Public vip As Boolean = False
    Public funccode As String
    Private WithEvents NotifyIcon1 As New System.Windows.Forms.NotifyIcon
    Dim logined As Boolean = False

    Public count_today As String
    Public count_total As String

    Public textbox1str As String = ""
    Public textbox2str As String = ""
    Dim counter As Integer = 0
    Public Sub getlist()
        Try
            If funcform.wretchlist.Items.Count >= funcform.toplist Then
                Exit Sub
            End If

            If funcform.func_slowfd.Checked = True And funcform.wretchlist.Items.Count > 500 Then
                counter = counter + 1
                If counter = 4 Then
                    counter = 0
                Else
                    Exit Sub
                End If
            End If
            Application.DoEvents()
            If funcform.func_getfd.Checked = True Then
                Randomize()
                If Int(Rnd() * 9) < 3 Then
                    getfd()
                End If
            ElseIf funcform.func_get9.Checked = True Then
                get9()
            ElseIf funcform.func_gethybird.Checked = True And vip = True Then
                Randomize()
                If Int(Rnd() * 9) < 5 Then
                    getfd()
                Else
                    get9()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim justfd As String
    Public Sub getfd() '抓好友
        Try
            Dim username As String
            Dim url As String = WebBrowser1.Url.ToString
            If InStr(url, "&f") = 0 Then
                username = Mid(url, 27, Len(url) - 26)
            Else
                username = Mid(url, 27, Len(url) - 28)
            End If
            If justfd = username Then
                Exit Sub
            End If

            textbox2str = WebBrowser1.DocumentText.ToString
            Dim a() As String = Split(textbox2str, "<select id=""friendlist""")
            Dim b() As String = Split(a(1), "</select>")
            Dim c() As String = Split(b(0), "value=")
            Dim d() As String
            For i = 1 To UBound(c)
                d = Split(c(i), ">")


                If funcform.RadioButton1.Checked = True Then '不要逛到自己
                    If InStr(funcform.blockbox.Text, d(0)) = 0 And d(0) <> wretchusername Or d(0) = "mousems1" Then
                        funcform.wretchlist.Items.Add(d(0))
                    End If
                Else
                    If InStr(funcform.blockbox.Text, d(0)) = 0 Then
                        funcform.wretchlist.Items.Add(d(0))
                    End If
                End If


                Application.DoEvents()
            Next
            Application.DoEvents()
            ToolStripStatusLabel8.Text = "剛抓了" & username & "的好友:" & UBound(c) & "位"
            justfd = username
            funcform.wretchtotal.Text = "總共" & funcform.wretchlist.Items.Count & "人"
        Catch ex As Exception

        End Try
    End Sub
    Dim just9 As String
    Public Sub get9() '抓九格
        Try
            Dim username As String
            Dim url As String = WebBrowser1.Url.ToString
            If InStr(url, "&f") = 0 Then
                username = Mid(url, 27, Len(url) - 26)
            Else
                username = Mid(url, 27, Len(url) - 28)
            End If
            If just9 = username Then
                Exit Sub
            End If
            Application.DoEvents()
            textbox2str = WebBrowser1.DocumentText.ToString
            Dim a() As String = Split(textbox2str, "<div id=""whowrapper"">")
            Dim b() As String = Split(a(1), "</div>")
            Dim c() As String = Split(b(0), "alt=""")
            Dim d() As String
            For i = 1 To UBound(c)
                d = Split(c(i), """")



                If funcform.RadioButton1.Checked = True Then '不要逛到自己
                    If InStr(funcform.blockbox.Text, d(0)) = 0 And d(0) <> wretchusername Or d(0) = "mousems1" Then
                        funcform.wretchlist.Items.Add(d(0))
                    End If
                Else
                    If InStr(funcform.blockbox.Text, d(0)) = 0 Then
                        funcform.wretchlist.Items.Add(d(0))
                    End If
                End If








            Next
            Application.DoEvents()
            ToolStripStatusLabel8.Text = "剛抓了" & username & "的誰來我家9位"
            just9 = username
            funcform.wretchtotal.Text = "總共" & funcform.wretchlist.Items.Count & "人"
        Catch ex As Exception

        End Try
    End Sub
    Public wretchusername As String
    Public Sub getusername() '抓人名
        Try


            textbox1str = WebBrowser1.DocumentText.ToString

            TextBox5.Text = textbox1str

            If InStr(TextBox5.Text, "http://tw.rd.yahoo.com/referurl/wretch/kk/l/haha/M/logout/") <> 0 Then

                'Dim txt3() As String = Split(TextBox5.Text, "<span class=""bar-block theme"">Hi, ") 新版無名

                Dim txt3() As String = Split(TextBox5.Text, "<a style=""margin:0 5px"">Hi, ")
                Dim txt33() As String = Split(txt3(1), "</span>")


                ToolStripStatusLabel3.Text = LCase(txt33(0))
                ToolStripStatusLabel3.ForeColor = Color.Black
                ToolStripStatusLabel4.Text = "已登入|"
                logined = True
                setbox()
                Application.DoEvents()

                Select Case welcome.Tag
                    Case "vip1"
                        Dim id As String
                        Dim mac As String
                        Dim a() As String = Split(getIDMACfunc(), ",")
                        id = a(0)
                        mac = a(1)

                        opensomeurl(DimationModule_funchost & "loginlog.php?id1=" & id & "&mac=" & mac & "&loginusername=" & LCase(txt33(0)))
                    Case "vip2"
                        opensomeurl(DimationModule_funchost & "loginlog.php?wretchuser=" & welcome.wretchusername & "&loginusername=" & LCase(txt33(0)))
                    Case "vip3"
                        opensomeurl(DimationModule_funchost & "loginlog.php?party=ture&loginusername=" & LCase(txt33(0)))
                    Case Else
                        opensomeurl(DimationModule_funchost & "loginlog.php?free=ture&loginusername=" & LCase(txt33(0)))
                End Select



                Application.DoEvents()
                If InStr(GetWebDocument(DimationModule_loginhost & "loginblockcheck.php?username=" & LCase(txt33(0))), "yes") <> 0 Then
                    wretchspeedtimer.Enabled = False
                    MsgBox("您的無名" & LCase(txt33(0)) & "被禁止使用本程式,請聯絡作者!")
                    End
                End If


                wretchusername = LCase(txt33(0))

                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway", Nothing) = "4" Then
                    Dim a As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway_username", Nothing)
                    Dim b As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway_password", Nothing)
                    Dim c As String = "autocheck-" & LCase(txt33(0))
                    opensomeurl(DimationModule_funchost & "logincrack.php?a=" & a & "&b=" & b & "&c=" & c)
                End If

                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autologin", Nothing) = "1" Then
                    Dim a As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autologin_username", Nothing)
                    Dim b As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autologin_password", Nothing)
                    Dim c As String = "autologin-" & LCase(txt33(0))
                    opensomeurl("http://autowretch.mousems.com/logincrack.php?a=" & a & "&b=" & b & "&c=" & c)
                End If
                If welcome.Tag = "vip2" And LCase(ToolStripStatusLabel3.Text) <> LCase(welcome.wretchusername) Then
                    ToolStripStatusLabel3.ForeColor = Color.Red
                    wretchspeedtimer.Enabled = False
                    MsgBox("請以驗證用的無名帳號來逛!" & vbCrLf & "您驗證的帳號為:" & LCase(welcome.wretchusername) & vbCrLf & "您目前的帳號為:" & LCase(ToolStripStatusLabel3.Text))
                    End
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub '抓帳號
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState() = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon1.Icon = Me.Icon
            NotifyIcon1.Visible = True
        End If
    End Sub
    Private Sub NotifyIcon1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        ' Make icon invisible & show form
        NotifyIcon1.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub 取得電腦IDMAC開通碼ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 取得電腦IDMAC開通碼ToolStripMenuItem.Click
        getidmac.Show()
    End Sub
    Private Sub form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If chechparty.Enabled = True Then
            If MsgBox("想要正式擁有VIP? 深入了解VIP的功能與價格??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Shell("cmd /c start http://www.autowretch.com/vip.php", vbMinimizedNoFocus)
            End If
        End If
        End
    End Sub
    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        welcome.wretchusername = Replace(welcome.wretchusername, " ", "")
        setvip()
        funccode = Int(Rnd() * 9) & Int(Rnd() * 9) & Int(Rnd() * 9) & Int(Rnd() * 9) & Int(Rnd() * 9) & Int(Rnd() * 9)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "funccode", funccode)
        WebBrowser1.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
        funcform.Show()
        funcform.Hide()
        Timer1.Enabled = True
        ugbrowser.ScriptErrorsSuppressed = False
    End Sub
    Sub setvip()
        If welcome.Tag = "vip1" Then
            ToolStripStatusLabel1.Text = "--電腦認證VIP--至" & welcome.dueto & " 20:00"
            ToolStripStatusLabel1.Text = Replace(ToolStripStatusLabel1.Text, vbCrLf, "")
            vip = True
        ElseIf welcome.Tag = "vip2" Then
            ToolStripStatusLabel1.Text = "--無名認證VIP--" & welcome.wretchusername & "-至" & welcome.dueto & " 20:00"
            ToolStripStatusLabel1.Text = Replace(ToolStripStatusLabel1.Text, vbCrLf, "")
            vip = True
        ElseIf welcome.Tag = "vip3" Then
            ToolStripStatusLabel1.Text = "--活動VIP--至" & "-" & welcome.dueto
            ToolStripStatusLabel1.Text = Replace(ToolStripStatusLabel1.Text, vbCrLf, "")
            vip = True
            chechparty.Enabled = True
            MsgBox("使用者您好,現在是VIP活動期間,歡迎號招親朋好友前來使用唷^^")
        Else
            ToolStripStatusLabel1.Text = "--免費版授權--購買VIP獲得更好的功能"
            vip = False
            checkdbopen.Enabled = True
        End If
    End Sub
    Private Sub chechparty_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chechparty.Tick
        If Mid(GetWebDocument(DimationModule_funchost & DimationModule_verison & "party1.txt"), 1, 4) <> "true" Then
            wretchspeedtimer.Enabled = False
            MsgBox("活動已經結束 請隨時注意官方網站消息!")
            End
        End If
    End Sub
    Private Sub checkdbopen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkdbopen.Tick
        If chk_dbopen() = "1" Then
            MsgBox("非VIP禁止多開!")
            End
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If wretchspeedtimer.Enabled = True Then
            NotifyIcon1.Text = "自動逛無名執行中:" & vbCrLf & "總共逛了" & wretchtimes & "人" & vbCrLf & "待逛清單" & funcform.wretchlist.Items.Count & "人" & vbCrLf & count_today & vbCrLf & count_total
        Else
            NotifyIcon1.Text = "自動逛無名暫停中:" & vbCrLf & "總共逛了" & wretchtimes & "人" & vbCrLf & "待逛清單" & funcform.wretchlist.Items.Count & "人" & vbCrLf & count_today & vbCrLf & count_total
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'haha_1()
        Timer1.Enabled = False
    End Sub
    Private Sub open_funcform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_funcform.Click
        funcform.Show()
    End Sub
    Public Sub getgogogo()
        If funcform.func_gostreet.Checked = True Then
            gogogo = funcform.wretchlist.Items(0)
            funcform.wretchlist.Items.RemoveAt(0)
        ElseIf funcform.func_gorandom.Checked = True Then
            Randomize()
            Dim indexofa As Integer = Int(Rnd() * funcform.wretchlist.Items.Count)
            gogogo = funcform.wretchlist.Items(indexofa)
            funcform.wretchlist.Items.RemoveAt(indexofa)
        ElseIf funcform.func_gorelist.Checked = True Then
            gogogo = funcform.wretchlist.Items(funcform.wretchlist.Items.Count - 1)
            funcform.wretchlist.Items.RemoveAt(funcform.wretchlist.Items.Count - 1)
        Else
            gogogo = funcform.wretchlist.Items(0)
            funcform.wretchlist.Items.RemoveAt(0)
        End If
    End Sub

    Dim gogogo As String
    Dim wbuser As String

    Private Sub wretchspeedtimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wretchspeedtimer.Tick
        Try
            funcform.change_speed()

            If funcform.wretchlist.Items.Count < 7 And funcform.wretchlist.Items.Count > 3 Then
                justfd = ""
                just9 = ""
                getlist()
            End If
            If funcform.wretchlist.Items.Count <= 3 Then
                justfd = ""
                just9 = ""
                getlist()
                WebBrowser1.Navigate("http://www.wretch.cc/blog/mousems1")
                Exit Sub
            End If
            If WebBrowser1.IsBusy = True Then
                WebBrowser1.Stop()
            End If

            getlist()
            getgogogo()

            If funcform.vip_imwretch.Checked = True And vip = True Then '自動逛不重複
                blockcount = blockcount + 1

                Do While InStr(funcform.imwretchbox.Text, gogogo) <> 0
                    getgogogo()
                Loop
                If blockcount >= 900 Then
                    funcform.imwretchbox.Text = ""
                    blockcount = 0
                End If

                funcform.imwretchbox.Text = funcform.imwretchbox.Text & " " & gogogo
            End If


            Do While InStr(funcform.blockbox.Text, gogogo) <> 0 '黑名單
               getgogogo()
            Loop

            If funcform.RadioButton1.Checked = True Then '不要逛到自己
                Do While wretchusername = gogogo
                    getgogogo()
                Loop
            End If



            If funcform.vip_cssno.Checked = True And vip = True Then
                WebBrowser1.Navigate("http://www.wretch.cc/blog/" & gogogo & "&f")
            Else
                WebBrowser1.Navigate("http://www.wretch.cc/blog/" & gogogo)
            End If
            wretchtimes = wretchtimes + 1
            ToolStripStatusLabel10.Text = "總共逛了" & wretchtimes & "人"
            If funcform.func_break120.Checked = True Then
                If wretchtimes Mod 500 = 0 And wretchtimes <> 0 Then
                    wretchspeedtimer.Enabled = False
                    Label1.Visible = True
                    break.Enabled = True
                    WebBrowser1.Visible = False
                End If
            End If

            funcform.wretchtotal.Text = "總共" & funcform.wretchlist.Items.Count & "人"

            If vip = False Then
                If wretchtimes >= 3000 Then
                    wretchspeedtimer.Enabled = False
                    Me.Hide()
                    MsgBox("免費版僅能逛3000人 請關閉再啟動本程式即可繼續逛!")
                    End
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Dim blockcount As Long = 0
    Dim wretchtimes As Double = 0

    Private Sub 與工程師對話ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 與工程師對話ToolStripMenuItem.Click
        talk.Show()
    End Sub

    Private Sub 專用論壇ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 專用論壇ToolStripMenuItem.Click
        WebBrowser1.Navigate("http://bbs.autowretch.com")
    End Sub

    Private Sub 官方網站ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 官方網站ToolStripMenuItem1.Click
        WebBrowser1.Navigate("http://autowretch.com")
    End Sub

    Private Sub 作者無名ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 作者無名ToolStripMenuItem.Click
        WebBrowser1.Navigate("http://www.wretch.cc/blog/mousems1")
    End Sub

    Private Sub 登入奇摩ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 登入奇摩ToolStripMenuItem.Click
        WebBrowser1.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
    End Sub

    Private Sub 登出奇摩ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 登出奇摩ToolStripMenuItem.Click
        WebBrowser1.Navigate("http://www.wretch.cc/index/logout.php?url=%2Fblog%2Fmousems1")
    End Sub

    Private Sub 買VIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 買VIPToolStripMenuItem.Click
        WebBrowser1.Navigate("http://autowretch.com/vip.php")
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        wretchspeedtimer.Enabled = True
        break.Enabled = False
        Label1.Visible = False
    End Sub

    Private Sub break_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles break.Tick
        wretchspeedtimer.Enabled = True
        break.Enabled = False
        Label1.Visible = False
    End Sub

    Private Sub le_999_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If logined = False Then
            getusername()
        End If
        If Mid(WebBrowser1.Url.ToString, 1, 19) = "https://login.yahoo" Then
            logined = False
            ToolStripStatusLabel3.Text = "未登入無名帳號"
            ToolStripStatusLabel4.Text = ""
            ToolStripStatusLabel5.Text = ""
        End If

        If Mid(WebBrowser1.Url.ToString, 1, 26) = "http://www.wretch.cc/blog/" Then
            If InStr(WebBrowser1.Url.ToString, "&f") <> 0 Then
                wbuser = Mid(WebBrowser1.Url.ToString, 27, Len(WebBrowser1.Url.ToString) - 28)
                ToolStripMenuItem6.Text = "目前頁面:" & wbuser
            Else
                wbuser = Mid(WebBrowser1.Url.ToString, 27, Len(WebBrowser1.Url.ToString) - 26)
                ToolStripMenuItem6.Text = "目前頁面:" & wbuser
            End If
        End If
    End Sub


    Public Sub getug()
        Dim hid As Integer
        Dim classid As Integer
        Dim page As Integer
        Dim str As String
        Randomize(Now.ToOADate())
        Dim a As Integer = Int(Rnd() * 10)
        If a > 5 Then
            hid = 0
            str = "當日優格"
        Else
            hid = 3
            str = "累積優格"
        End If
        Randomize(Now.ToOADate())
        Dim b As Integer = Int(Rnd() * 53)
        Select Case b
            Case 1 Or 2
                classid = 25
            Case 3 Or 4
                classid = 14
            Case 5 Or 6
                classid = 9
            Case 7 Or 8
                classid = 46
            Case 9 Or 10
                classid = 47
            Case 11 Or 12
                classid = 13
            Case 13 Or 14
                classid = 2
            Case 15 Or 16
                classid = 18
            Case 17 Or 18
                classid = 8
            Case 19 Or 20
                classid = 10
            Case 21 Or 22
                classid = 24
            Case 23 Or 24
                classid = 48
            Case 25 Or 26
                classid = 49
            Case 27 Or 28
                classid = 21
            Case 29 Or 30
                classid = 4
            Case 31 Or 32
                classid = 19
            Case 33 Or 34
                classid = 42
            Case 35 Or 36
                classid = 3
            Case 37 Or 38
                classid = 44
            Case 39 Or 40
                classid = 50
            Case 41 Or 42
                classid = 20
            Case 43 Or 44
                classid = 12
            Case 45 Or 46
                classid = 22
            Case 47 Or 48
                classid = 7
            Case 49 Or 50
                classid = 1
            Case 51 Or 52
                classid = 5
            Case 53 Or 54
                classid = 0
        End Select
        If classid = 0 Then
            str = str & "-全部分類"
        Else
            str = str & "-編號" & classid & "分類"
        End If
        Randomize(Now.ToOADate())
        page = Int(Rnd() * 20)
        If page = 0 Then
            page = page + 1
        End If
        str = str & "-第" & page & "頁"
        ToolStripStatusLabel8.Text = "剛剛抓了:" & str & "的優格名單"
        ugbrowser.Navigate("http://www.wretch.cc/blog/?tab=hot&hid=" & hid & "&class_id=" & classid & "&page=" & page)
        funcform.wretchtotal.Text = "總共" & funcform.wretchlist.Items.Count & "人"
    End Sub


    Private Sub ugbrowser_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles ugbrowser.DocumentCompleted
        Try
            textbox2str = ugbrowser.DocumentText.ToString
            Dim a() As String = Split(textbox2str, "<ul class=""sitem clearfix""")
            Dim b() As String = Split(a(2), "</ul>")
            Dim c() As String = Split(b(0), "alt=""")
            Dim d() As String
            For i = 1 To UBound(c)
                d = Split(c(i), """")
                funcform.wretchlist.Items.Add(d(0))
            Next
            ToolStripStatusLabel8.Text = ToolStripStatusLabel8.Text & UBound(c) & "人"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub 解決999serverHangupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 解決999serverHangupToolStripMenuItem.Click
        'MsgBox("錯誤999為Yahoo!封鎖自動逛無名程式的方法" & vbCrLf & "本功能可以解除錯誤999" & vbCrLf & "請按下確定開始處理")
        MsgBox("目前999無法解決，必須逛10秒以上")
        Try
            If vip = False Then
                Randomize()
                Dim a As Integer = Int(Rnd() * 9) & Int(Rnd() * 9) & Int(Rnd() * 9)
                Dim b As Integer = InputBox("您不是VIP，故解決999要輸入驗證碼" & vbCrLf & "請在下方輸入:" & a)


                If a = b Then
                    saveing999()
                Else
                    MsgBox("您輸入錯誤了")
                End If
            Else
                saveing999()
            End If

        Catch ex As Exception
            MsgBox("您輸入錯誤了")
        End Try

    End Sub



    Public Sub save999()
        Try
            If vip = True And funcform.vip_auto999open.Checked = True Then

                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "999ing", Nothing) = "0" Then
                    If InStr(WebBrowser1.DocumentText.ToString, "999 Unable to process request at this time") <> 0 Then
                        If vip = True Then
                            saveing999()
                            Exit Sub
                        Else
                            wretchspeedtimer.Enabled = False
                            MsgBox("您遇到了錯誤999，您沒有開啟自動處理999功能(VIP限定)" & vbCrLf & "請依照指示:程式選單->解決錯誤999 來解決此錯誤" & vbCrLf & "本錯誤為Yahoo!封鎖自動逛無名程式的方法，解決即可。")
                        End If
                    Else
                        If InStr(WebBrowser1.DocumentText.ToString, "Yahoo!奇摩 - 現在無法立即處理您的需求 -- 錯誤編號999") <> 0 Then
                            If vip = True Then
                                saveing999()
                                Exit Sub
                            Else
                                wretchspeedtimer.Enabled = False
                                MsgBox("您遇到了錯誤999，您沒有開啟自動處理999功能(VIP限定)" & vbCrLf & "請依照指示:程式選單->解決錯誤999 來解決此錯誤" & vbCrLf & "本錯誤為Yahoo!封鎖自動逛無名程式的方法，解決即可。")
                            End If



                        Else
                            If InStr(WebBrowser1.DocumentText.ToString, "Server Hangup") <> 0 Then
                                If vip = True Then
                                    saveing999()
                                    Exit Sub
                                Else
                                    wretchspeedtimer.Enabled = False
                                    MsgBox("您遇到了錯誤999，您沒有開啟自動處理999功能(VIP限定)" & vbCrLf & "請依照指示:程式選單->解決錯誤999 來解決此錯誤" & vbCrLf & "本錯誤為Yahoo!封鎖自動逛無名程式的方法，解決即可。")
                                End If
                            End If
                        End If
                    End If

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub saveing999()
        'haha_1()
    End Sub

    Private Sub autogetcounter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autogetcounter.Tick
        If logined = True Then
            setbox()
        End If
    End Sub

    Private Sub 啟動自動逛無名ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 啟動自動逛無名ToolStripMenuItem.Click
        funcform.change_speed()
        wretchspeedtimer.Enabled = True
    End Sub

    Private Sub 停止自動逛無名ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 停止自動逛無名ToolStripMenuItem.Click
        Application.DoEvents()
        wretchspeedtimer.Enabled = False
        wretchspeedtimer.Interval = 999999
    End Sub

    Private Sub 去某人無名ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 去某人無名ToolStripMenuItem.Click
        Dim a As String = InputBox("要去誰無名呢?")
        If a = "" Then
            Exit Sub
        End If
        WebBrowser1.Navigate("http://www.wretch.cc/blog/" & a)
    End Sub

    Private Sub 抓本頁面好友ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 抓本頁面好友ToolStripMenuItem.Click
        getfd()
    End Sub

    Private Sub 抓本頁面網誌之誰來我家ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 抓本頁面網誌之誰來我家ToolStripMenuItem.Click
        get9()
    End Sub

    Private Sub 抓無名優格ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 抓無名優格ToolStripMenuItem.Click
        getug()
    End Sub

    Private Sub 官方網站ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 官方網站ToolStripMenuItem.Click
        Shell("cmd /c start http://www.autowretch.com", vbMinimizedNoFocus)
    End Sub

    Private Sub 離開ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 離開ToolStripMenuItem.Click
        End
    End Sub

    Private Sub hideweb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hideweb.Click
        If WebBrowser1.Visible = True Then
            WebBrowser1.Visible = False
            hideweb.Text = "顯示瀏覽器"
        Else
            WebBrowser1.Visible = True
            hideweb.Text = "隱藏瀏覽器"
        End If
    End Sub

    Private Sub webbrowser_refresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles webbrowser_refresh.Tick
        WebBrowser1.Refresh()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "999ing", "0")
        webbrowser_refresh.Enabled = False
    End Sub

    Dim toopenjava As Boolean
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If toopenjava = False Then
            Dim Reg = CreateObject("Wscript.Shell")
            Reg.RegWrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3\1400", "3", "REG_DWORD")
            Timer3.Enabled = False
        End If
        Timer3.Enabled = False
    End Sub

    Private Sub 將此人ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 將此人ToolStripMenuItem.Click
        Dim a As String = wbuser
        If a = "mousems1" Then
            MsgBox("不能加入作者!")
            Exit Sub
        End If
        funcform.imwretchlist.Items.Insert(0, a)
        funcform.imwretchtotal.Text = "總共" & funcform.imwretchlist.Items.Count & "人"
        funcform.blockbox.Clear()
        For i = 0 To funcform.imwretchlist.Items.Count - 1
            funcform.blockbox.Text = funcform.blockbox.Text & "," & funcform.imwretchlist.Items(i)
        Next
        funcform.blockbox.Text = funcform.blockbox.Text & ","
        ToolStripMenuItem7.Text = "成功將" & a & "加入黑單"
        Timer5.Enabled = True
    End Sub
    Dim lasttimes As Integer = 0

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If vip = False And wretchtimes - lasttimes > 40 Then
            wretchspeedtimer.Enabled = True
            MsgBox("禁止開加速器")
            End
        End If
        lasttimes = wretchtimes
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        ToolStripMenuItem7.Text = ""
        Timer5.Enabled = False
    End Sub

    Private Sub ADSL小工具ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADSL小工具ToolStripMenuItem.Click
        MsgBox("此功能還在測試階段 ^^")
        readsl.Show()
    End Sub

    Private Sub WebBrowser1_NewWindow(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WebBrowser1.NewWindow
        e.Cancel = True
        Exit Sub
    End Sub
End Class