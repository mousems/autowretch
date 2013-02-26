Public Class welcome
    Public party As Boolean = False
    Public wretchusername As String
    Public dueto As String
    Dim check1pass As Boolean = True
    Dim check2pass As Boolean = True
    Public TextBox1str As String = ""

    Private Sub welcome_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Mid(WebBrowser1.Version.ToString, 1, 1) <> "8" And Mid(WebBrowser1.Version.ToString, 1, 1) <> "9" Then
            If MsgBox("您的Interent Explorer瀏覽器的版本為" & Mid(WebBrowser1.Version.ToString, 1, 1) & vbCrLf & "必須採用第8,9版才能正常使用本程式之功能" & vbCrLf & "請問要不要至微軟官網下載呢?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Shell("cmd /c start http://downloads.yahoo.com/tw/internetexplorer/", vbMinimizedNoFocus)
            End If
        End If

        Dim isAdmin As Boolean
        isAdmin = My.User.IsInRole("administrators")
        If isAdmin Then
        Else
            MsgBox("您的登入身分並不是系統管理員,如果不是管理員,程式有些地方會有錯誤,建議修正!")
        End If
        WebBrowser1.Navigate(DimationModule_funchost & "welcome.html")
        autologin.Enabled = True
        openlize()

    End Sub

    Public autologin_passway_un As String
    Public autologin_passway_ps As String
    Public logintime As Integer = 7
    Dim passwayValue As String 'passway:驗證方式:1-免費版,2-活動,3-電腦,4-無名
    Public autousercheck As Boolean = False


    Public Sub openlize()
        check1pass = False
        check2pass = False

        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway", Nothing) Is Nothing Then
            '第一次使用程式
            My.Computer.Registry.CurrentUser.CreateSubKey("MouseMs\Autowretch\V3.7") '建立資料區
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway", "1")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "checkparty", "1")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "checkver", "1")
            Label_title1.Text = "請選擇認證方式,並請設定上方慣用認證方式"


            Dim id As String
            id = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "id", Nothing)

            If Len(id) <> 7 Then
                Randomize()
                Dim rndstr As String = Int(Rnd() * 9) & Int(Rnd() * 9) & Int(Rnd() * 9) & Int(Rnd() * 9) & Int(Rnd() * 9) & Int(Rnd() * 9) & Int(Rnd() * 9)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "id", rndstr)
            End If

        Else
            passwayValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway", Nothing)
            Select Case passwayValue
                'passway:驗證方式:1-免費版,2-活動,3-電腦,4-無名
                Case "1"
                    passway_combo.Text = "慣用免費版認證"
                Case "2"
                    passway_combo.Text = "慣用活動認證"
                Case "3"
                    passway_combo.Text = "慣用電腦ID認證"
                Case "4"
                    passway_combo.Text = "慣用無名認證"
                    autologin_passway_un = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway_username", Nothing)
                    autologin_passway_ps = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway_password", Nothing)
                    Dim pass2 As String = ""
                    For i = 1 To Len(autologin_passway_ps)
                        pass2 = Chr(Asc(Mid(autologin_passway_ps, i, 1)) - 5) & pass2
                    Next
                    autologin_passway_ps = pass2
                Case Else
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", _
                    "passway", "1")
                    Exit Sub
            End Select
            Label_title2.Text = "系統將以慣用認證方式進行認證..." & logintime
            autologin.Enabled = True
        End If




        If Mid(GetWebDocument(DimationModule_funchost & DimationModule_verison & "close.txt"), 1, 4) = "true" Then
            MsgBox("很抱歉，此版本有重大錯誤，為了安全起見，請下載最新版本！")
            End
        End If


        Dim ver As String = GetWebDocument(DimationModule_funchost & "ver.txt")

        If Label_title1.Text = "請選擇認證方式,並請設定上方慣用認證方式" Then
            If Mid(GetWebDocument(DimationModule_funchost & DimationModule_verison & "party1.txt"), 1, 4) = "true" Then
                MsgBox("提醒您，現在有辦活動唷！請使用活動入口登入")
                party = True
            End If
            If Mid(ver, 1, 6) <> DimationModule_verison And Mid(ver, 2, 1) = "." And Mid(ver, 1, 6) <> DimationModule_lastverison Then
                If MsgBox("目前有最新版本" & ver & "您要至官方網站嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Shell("cmd /c start http://www.autowretch.com", vbMinimizedNoFocus)
                End If
            End If
        Else
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "checkparty", Nothing) = 1 Then
                If Mid(GetWebDocument(DimationModule_funchost & DimationModule_verison & "party1.txt"), 1, 4) = "true" Then
                    MsgBox("提醒您，現在有辦活動唷！請使用活動入口登入")
                    party = True
                End If
            Else
                If Mid(GetWebDocument(DimationModule_funchost & DimationModule_verison & "party1.txt"), 1, 4) = "true" Then
                    party = True
                End If
                check1pass = True
                CheckBox1.Checked = False
                check1pass = False
            End If



            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "checkver", Nothing) = 1 Then
                If Mid(ver, 1, 6) <> DimationModule_verison And Mid(ver, 2, 1) = "." And Mid(ver, 1, 6) <> DimationModule_lastverison Then
                    If MsgBox("目前有最新版本" & ver & "您要至官方網站嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Shell("cmd /c start http://www.autowretch.com", vbMinimizedNoFocus)
                    End If
                End If
            Else
                check2pass = True
                CheckBox2.Checked = False
                check2pass = False
                If Mid(ver, 1, 6) <> DimationModule_verison And Mid(ver, 2, 1) = "." And Mid(ver, 1, 6) <> DimationModule_lastverison Then
                    Me.Text = Me.Text & "  -最新版本V" & ver
                End If
            End If
        End If

    End Sub

    Private Sub autologin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autologin.Tick
        If logintime = 5 Then
            WebBrowser1.Refresh()
        End If
        If logintime = 0 Then
            countdown2.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False

            Select Case passwayValue
                Case "1"
                    Label_title1.Text = "...免費版認證中..."
                    Label_title2.Text = "3秒後進入主畫面"
                    Label_title2.Text = "您是免費版，每逛3000人需要重新啟動程式！"
                    Label_title2.ForeColor = Color.Blue

                    countdown2.Enabled = True
                Case "2"
                    Label_title1.Text = "活動入口檢查中..."
                    If party = True Then
                        MsgBox("活動截止日:" & GetWebDocument(DimationModule_funchost & DimationModule_verison & ".txt") & vbCrLf & "活動期間任何VIP功能都可以自由使用!")
                        Me.Tag = "vip3"
                        form1.Show()
                        Me.Hide()
                    Else
                        Label_title1.Text = "...免費版認證中..."
                        Label_title1.Text = "3秒後進入主畫面"
                        Label_title2.Text = "您是免費版，每逛3000人需要重新啟動程式！"
                        Label_title2.ForeColor = Color.Blue
                        countdown2.Enabled = True
                        MsgBox("現在沒有辦活動！入口尚未開啟！")
                    End If
                Case "3"
                    Label_title1.Text = "...電腦ID認證中..."
                    check1()
                Case "4"
                    Label_title1.Text = "...無名帳號認證中..."
                    autousercheck = True
                    Me.Hide()
                    countdown2.Enabled = False
                    autologin.Enabled = False
                    checkusername.Show()
            End Select

            autologin.Enabled = False
            Exit Sub
        Else
            logintime = logintime - 1
            Label_title2.Text = "系統將以慣用認證方式進行認證..." & logintime
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("cmd /c start http://autowretch.com/", vbMinimizedNoFocus)
    End Sub
    Dim num2 As Integer = 3
    Private Sub countdown2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countdown2.Tick
        If num2 = 0 Then
            autologin.Enabled = False
            countdown2.Enabled = False
            Me.Hide()
            form1.Show()
        Else
            num2 = num2 - 1
            Label_title1.Text = num2 & "秒後進入主畫面"
        End If
    End Sub

    Sub check1()

        If md5ab_isblocked() = "1" Then
            MsgBox("您無法使用本程式，請聯絡作者" & vbCrLf & "即時通autowretch" & vbCrLf & "msn/email admin@mousems.com")
            End
        End If

        If md5ab_check() = 1 Then
            Dim midabsss As String
            midabsss = md5ab_getexp()
            Select Case Mid(midabsss, 1, 2)
                Case "20"
                    dueto = midabsss
                    Me.Tag = "vip1"
                    Label_title1.Text = "3秒後進入主畫面"
                    Label_title2.Text = "您是VIP，擁有全部的功能! 到期日:" & dueto
                    Label_title2.ForeColor = Color.Blue
                    countdown2.Enabled = True
                Case "21"
                    dueto = "永久"
                    Me.Tag = "vip1"
                    Label_title1.Text = "3秒後進入主畫面"
                    Label_title2.Text = "您是VIP，擁有全部的功能! 到期日:" & dueto
                    Label_title2.ForeColor = Color.Blue
                    countdown2.Enabled = True
                Case "0"
                    MsgBox("您的帳號有經過開通,但是沒有設定到期日,可能工程師疏漏了,請通知他設定後即可使用VIP!")
                    End
                Case Else
                    MsgBox("您的帳號有經過開通,但是沒有設定到期日,可能工程師疏漏了,請通知他設定後即可使用VIP!")
                    End
            End Select
        Else
            Label_title1.Text = "3秒後進入主畫面"
            Label_title2.Text = "您是免費版，每逛3000人需要重新啟動程式！"
            Label_title2.ForeColor = Color.Blue
            countdown2.Enabled = True
        End If
    End Sub


    Dim a As Boolean = False
    Private Sub WebBrowser2_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        If a = False Then
            a = True
        Else
            Exit Sub
        End If
        WebBrowser2.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Mid(WebBrowser2.Url.ToString, 1, 19) = "https://login.yahoo" Then
            checkusername.Label4.Visible = False
            checkusername.GroupBox1.Enabled = True
            checkusername.Button1.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If check1pass = False Then
            If CheckBox1.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "checkparty", "1")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "checkparty", "0")
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If check2pass = False Then
            If CheckBox2.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "checkver", "1")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "checkver", "0")
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Select Case passway_combo.Text
            Case "慣用免費版認證"
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway", "1")
                MsgBox("儲存完畢!")
            Case "慣用活動認證"
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway", "2")
                MsgBox("儲存完畢!")
            Case "慣用電腦ID認證"
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "passway", "3")
                MsgBox("儲存完畢!")
            Case "慣用無名認證"
                userset.Show()
                Me.Hide()
                passway_combo.Text = "無名認證"
                autologin.Enabled = False
                countdown2.Enabled = False
            Case Else
                passway_combo.Text = "免費版認證"
                MsgBox("未知的認證方式")
                Exit Sub
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label_title1.Text = "3秒後進入主畫面"
        Label_title2.Text = "您是免費版，每逛3000人需要重新啟動程式！"
        Label_title2.ForeColor = Color.Blue
        countdown2.Enabled = True
        autologin.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label_title1.Text = "活動入口檢查中..."
        countdown2.Enabled = False
        autologin.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        If party = True Then
            dueto = GetWebDocument(DimationModule_funchost & DimationModule_verison & "party2.txt")
            MsgBox("活動截止日:" & dueto & vbCrLf & "活動期間任何VIP功能都可以自由使用!")
            Me.Tag = "vip3"
            form1.Show()
            Me.Hide()
        Else
            Label_title1.Text = "3秒後進入主畫面"
            Label_title2.Text = "您是免費版，每逛3000人需要重新啟動程式！"
            Label_title2.ForeColor = Color.Blue
            countdown2.Enabled = True
            MsgBox("現在沒有辦活動！入口尚未開啟！")
        End If
        autologin.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label_title1.Text = "電腦驗證中..."
        countdown2.Enabled = False
        autologin.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        check1()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        countdown2.Enabled = False
        autologin.Enabled = False
        checkusername.Show()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub
End Class
