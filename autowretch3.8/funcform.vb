Imports System.Net '放在最前面
Imports System.Text
Imports System.IO
Imports System.Security.Cryptography

Public Class funcform
    Public toplist As Long = 3000
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub func_speed_05_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_speed_05.CheckedChanged
        If Form1.vip = False Then
            func_speed_30.Checked = True
            func_speed_05.Checked = False
        End If
        change_speed()
    End Sub

    Private Sub func_speed_07_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_speed_07.CheckedChanged
        If Form1.vip = False Then
            func_speed_30.Checked = True
            func_speed_07.Checked = False
        End If
        change_speed()
    End Sub

    Private Sub func_speed_10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_speed_10.CheckedChanged
        If Form1.vip = False Then
            func_speed_30.Checked = True
            func_speed_10.Checked = False
        End If

        change_speed()
    End Sub

    Private Sub func_speed_12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_speed_12.CheckedChanged
        If Form1.vip = False Then
            func_speed_30.Checked = True
            func_speed_12.Checked = False
        End If
        change_speed()
    End Sub

    Private Sub func_speed_14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_speed_14.CheckedChanged
        If Form1.vip = False Then
            func_speed_30.Checked = True
            func_speed_14.Checked = False
        End If
        change_speed()
    End Sub
    '設定速度
    Public manuspeed As Integer

    Public Sub change_speed()
        If func_speed_05.Checked = True And Form1.vip = True Then
            Form1.wretchspeedtimer.Interval = 500
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", "05")
        ElseIf func_speed_07.Checked = True And Form1.vip = True Then
            Form1.wretchspeedtimer.Interval = 700
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", "07")
        ElseIf func_speed_10.Checked = True And Form1.vip = True Then
            Form1.wretchspeedtimer.Interval = 1000
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", "10")
        ElseIf func_speed_12.Checked = True And Form1.vip = True Then
            Form1.wretchspeedtimer.Interval = 1200
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", "12")
        ElseIf func_speed_14.Checked = True And Form1.vip = True Then
            Form1.wretchspeedtimer.Interval = 1400
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", "14")
        ElseIf func_speed_16.Checked = True And form1.vip = True Then
            form1.wretchspeedtimer.Interval = 1600
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", "16")
        ElseIf func_speed_18.Checked = True And form1.vip = True Then
            form1.wretchspeedtimer.Interval = 1800
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", "18")
        ElseIf func_speed_20.Checked = True And form1.vip = True Then
            form1.wretchspeedtimer.Interval = 2000
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", "20")
        ElseIf func_speed_30.Checked = True Then
            Form1.wretchspeedtimer.Interval = 3000
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", "30")
        ElseIf func_speed_40.Checked = True Then
            If HScrollBar1.Value > 20 Or HScrollBar1.Value < 3 Then
                form1.wretchspeedtimer.Enabled = False
                MsgBox("請勿作弊")
                End
            End If
            form1.wretchspeedtimer.Interval = HScrollBar1.Value * 1000
        
        Else
            form1.wretchspeedtimer.Interval = 3000
            func_speed_30.Checked = True
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", "30")
        End If
    End Sub

    '新增待逛
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a As String = InputBox("請您輸入帳號以便將它加入清單")
        If a <> "" Then
            wretchlist.Items.Insert(0, a)
        End If
        wretchtotal.Text = "總共" & wretchlist.Items.Count & "人"
    End Sub
    '刪除待逛
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            wretchlist.Items.RemoveAt(wretchlist.SelectedIndex)
        Catch ex As Exception
            MsgBox("您必須要選清單中的某人才能進行刪除")
        End Try
        wretchtotal.Text = "總共" & wretchlist.Items.Count & "人"
    End Sub
    '清空清單
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        wretchlist.Items.Clear()
        wretchtotal.Text = "總共" & wretchlist.Items.Count & "人"
    End Sub
    '去他無名
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Form1.WebBrowser1.Navigate("http://www.wretch.cc/blog/" & (wretchlist.Items(wretchlist.SelectedIndex)))
        Catch ex As Exception
            MsgBox("必須要選擇你要去的那個人才能去!")
        End Try
    End Sub
    '儲存待逛
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If wretchlist.Items.Count = 0 Then
            MsgBox("待逛清單是空的，沒辦法存檔")
            Exit Sub
        End If

        If wretchlist.Items.Count > 999999 Then
            MsgBox("名單數大於1,000,000會無法儲存，僅儲存前999,999筆!")
        End If

        If Form1.wretchspeedtimer.Enabled = True Then
            Dim a As Integer = MsgBox("這將會停止目前的自動逛動作 您確定嗎?", MsgBoxStyle.OkCancel)
            If a = 2 Then
                Exit Sub
            End If
        End If




        Form1.wretchspeedtimer.Enabled = False

        TextBox3.Text = ""

        If wretchlist.Items.Count > 999999 Then
            For i = 0 To 999999
                TextBox3.Text = TextBox3.Text & vbCrLf & wretchlist.Items(i)
            Next
        Else
            For i = 0 To wretchlist.Items.Count - 1
                TextBox3.Text = TextBox3.Text & vbCrLf & wretchlist.Items(i)
            Next
        End If


        If Dir("C:\autowretchpretouse.txt") <> "" Then
            Kill("C:\autowretchpretouse.txt")
        End If
        My.Computer.FileSystem.WriteAllText("C:\autowretchpretouse.txt", TextBox3.Text & vbCrLf, True)
        MsgBox("存檔完畢")
    End Sub
    '讀取待逛
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Dim myStream As Stream
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = openFileDialog1.OpenFile()

            If Not (myStream Is Nothing) Then

                Dim url As String = openFileDialog1.FileName
                myStream.Close()
                Dim fileNum As Integer
                Dim txt As String

                Dim countfd As Integer = 0
                '處理例外事件
                fileNum = FreeFile()                                            '取得可用的檔案編號
                FileOpen(fileNum, url, OpenMode.Input)                       '開啟檔案
                Do Until EOF(fileNum)
                    txt = LineInput(fileNum)
                    Trim(txt)

                    If countfd <> 0 Then
                        wretchlist.Items.Add(txt)
                    End If

                    countfd = countfd + 1

                Loop
                FileClose(fileNum)                                              '關閉檔案
                MsgBox("共載入待逛清單" & countfd - 1 & "人")
                wretchtotal.Text = "總共" & wretchlist.Items.Count & "人"

            End If
        End If

    End Sub


    '新增黑單
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim a As String = InputBox("請輸入帳號以便加入黑名單")
        If a <> "" Then
            If a = "mousems" Then
                MsgBox("不能加入作者!")
                Exit Sub
            End If
            imwretchlist.Items.Insert(0, a)
            imwretchtotal.Text = "總共" & imwretchlist.Items.Count & "人"

            blockbox.Clear()
            For i = 0 To imwretchlist.Items.Count - 1
                blockbox.Text = blockbox.Text & "," & imwretchlist.Items(i)
            Next
            blockbox.Text = blockbox.Text & ","
        End If
    End Sub
    '刪除黑單
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Try
            imwretchlist.Items.RemoveAt(imwretchlist.SelectedIndex)
        Catch ex As Exception
            MsgBox("必須要選擇你要刪的那個人才能刪!")
        End Try
        imwretchtotal.Text = "總共" & imwretchlist.Items.Count & "人"

        blockbox.Clear()
        For i = 0 To imwretchlist.Items.Count - 1
            blockbox.Text = blockbox.Text & "," & imwretchlist.Items(i)
        Next
        blockbox.Text = blockbox.Text & ","
    End Sub
    '去他無名
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Try
            Form1.WebBrowser1.Navigate("http://www.wretch.cc/blog/" & (imwretchlist.Items(imwretchlist.SelectedIndex)))
        Catch ex As Exception
            MsgBox("必須要選擇你要去的那個人才能去!")
        End Try
    End Sub
    '儲存黑單
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If imwretchlist.Items.Count = 0 Then
            MsgBox("黑名單是空的，沒辦法存檔")
            Exit Sub
        End If

        If imwretchlist.Items.Count > 19999 Then
            MsgBox("黑名單數大於20000會無法儲存，僅儲存前19999筆!")
        End If




        TextBox3.Text = ""

        If imwretchlist.Items.Count > 19999 Then
            For i = 0 To 19998
                TextBox3.Text = TextBox3.Text & vbCrLf & imwretchlist.Items(i)
            Next
        Else
            For i = 0 To imwretchlist.Items.Count - 1
                TextBox3.Text = TextBox3.Text & vbCrLf & imwretchlist.Items(i)
            Next
        End If


        If Dir("C:\autowretchnottouse.txt") <> "" Then
            Kill("C:\autowretchnottouse.txt")
        End If
        My.Computer.FileSystem.WriteAllText("C:\autowretchnottouse.txt", TextBox3.Text & vbCrLf, True)
        MsgBox("存檔完畢")
    End Sub
    '讀取黑單
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        Dim myStream As Stream
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = openFileDialog1.OpenFile()

            If Not (myStream Is Nothing) Then

                Dim url As String = openFileDialog1.FileName
                myStream.Close()
                Dim fileNum As Integer
                Dim txt As String

                Dim countfd As Integer = 0
                '處理例外事件
                fileNum = FreeFile()                                            '取得可用的檔案編號
                FileOpen(fileNum, url, OpenMode.Input)                       '開啟檔案
                Do Until EOF(fileNum)
                    txt = LineInput(fileNum)
                    Trim(txt)

                    If countfd <> 0 Then
                        imwretchlist.Items.Add(txt)
                        blockbox.Text = blockbox.Text & "," & txt
                    End If

                    blockbox.Text = blockbox.Text & ","
                    countfd = countfd + 1

                Loop
                FileClose(fileNum)                                              '關閉檔案
                MsgBox("共載入黑名單" & countfd - 1 & "人")
                imwretchtotal.Text = "總共" & imwretchlist.Items.Count & "人"

            End If
        End If


    End Sub
    '清除黑單
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        imwretchlist.Items.Clear()
        imwretchtotal.Text = "總共" & imwretchlist.Items.Count & "人"
    End Sub

    '設定上限
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim a As Double = Int(Val(InputBox("請設定待逛清單上限人數")))
            If a > 3000 And Form1.vip = False Then
                MsgBox("只有VIP可以設定3千以上")
                topwretchlist.Text = "程式抓到3000人就不抓"
                toplist = 3000
                Exit Sub
            End If
            toplist = a
            topwretchlist.Text = "程式抓到" & a & "人就不抓"
        Catch ex As Exception
            MsgBox("請正確輸入正整數")
        End Try
    End Sub

    Private Sub funcform_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        e.Cancel = True
    End Sub


    Private Sub funcform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.vip = True Then
            toplist = 100000
            topwretchlist.Text = "程式抓到100000人就不抓"
        End If
        setvipfunc()
        setregfunc()
        autologinset()
        WebBrowser4.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
        WebBrowser1.Navigate("http://autowretch.com/exe3stats.html")
        ''haha()
    End Sub

    '自動登入設定
    Public Sub autologinset()

        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autologin", Nothing) = "1" Then
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autogo", Nothing) = "1" Then
                autorun.Checked = True
            End If
            autologin = True
            func_autologin_on.Checked = True
            func_autologin_id.Enabled = False
            func_autologin_pass.Enabled = False
            func_autologin_id.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autologin_username", Nothing)
            Dim pass As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autologin_password", Nothing)
            Dim pass2 As String = ""
            For i = 1 To Len(pass)
                pass2 = Chr(Asc(Mid(pass, i, 1)) - 5) & pass2
            Next
            func_autologin_pass.Text = pass2
            login_timer.Enabled = True
            Form1.ToolStripStatusLabel3.Text = "程式正在幫您登入無名中 ...  帳號:" & func_autologin_id.Text & "   密碼:經過加密,用戶請安心"
            Form1.ToolStripStatusLabel3.ForeColor = Color.Red
            loginisture.Text = "此帳密有經過驗證,可以啟動功能"
            loginisture.ForeColor = Color.Blue
        End If
    End Sub

    '載入上次功能
    Public Sub setregfunc()
        Select Case My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autogetug", Nothing)
            Case "1"
                If Form1.vip = True Then
                    autogetug.Checked = True
                Else
                    autogetug.Checked = False
                End If
            Case "0"
                autogetug.Checked = False
            Case Else
                autogetug.Checked = False
        End Select



        Select Case My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autogetfd", Nothing)
            Case "1"
                func_getfd.Checked = True
            Case "2"
                If Form1.vip = True Then
                    func_get9.Checked = True
                Else
                    func_getfd.Checked = True
                End If
            Case "3"
                If Form1.vip = True Then
                    func_gethybird.Checked = True
                Else
                    func_getfd.Checked = True
                End If
            Case Else
                func_getfd.Checked = True
        End Select

        Select Case My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", Nothing)
            Case "05"
                If Form1.vip = True Then
                    func_speed_05.Checked = True
                End If
            Case "07"
                If Form1.vip = True Then
                    func_speed_07.Checked = True
                End If
            Case "10"
                If Form1.vip = True Then
                    func_speed_10.Checked = True
                End If

            Case "12"
                If Form1.vip = True Then
                    func_speed_12.Checked = True
                End If
            Case "14"
                If Form1.vip = True Then
                    func_speed_14.Checked = True
                End If
            Case "16"
                If form1.vip = True Then
                    func_speed_16.Checked = True
                End If
            Case "18"
                If form1.vip = True Then
                    func_speed_18.Checked = True
                End If
            Case "20"
                If form1.vip = True Then
                    func_speed_20.Checked = True
                End If
            Case "30"
                func_speed_30.Checked = True
            Case Else

                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", Nothing) Is Nothing Then
                    func_speed_30.Checked = True
                Else

                    Dim a As Long = Val(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", Nothing)) / 1000
                    If a >= 3 And a <= 30 Then
                        func_speed_40.Checked = True
                        HScrollBar1.Value = a
                        Label14.Text = HScrollBar1.Value & "秒/20秒"
                        change_speed()
                    End If
                End If

        End Select

        Select Case My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "golist", Nothing)
            Case "1"
                func_gostreet.Checked = True
            Case "2"
                func_gorandom.Checked = True
            Case "3"
                func_gorelist.Checked = True
            Case Else
                func_gostreet.Checked = True
        End Select

        Select Case My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "slowfd", Nothing)
            Case "1"
                func_slowfd.Checked = True
            Case "2"
                func_famalfd.Checked = True
            Case Else
                func_slowfd.Checked = True
        End Select

        Select Case My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "break120", Nothing)
            Case "1"
                func_break120.Checked = True
            Case "2"
                func_break120flase.Checked = True
            Case Else
                func_break120.Checked = True
        End Select

        Select Case My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "vip_imwretch", Nothing)
            Case "1"
                vip_imwretchim.Checked = True
            Case "2"
                If Form1.vip = True Then
                    vip_imwretch.Checked = True
                Else
                    vip_imwretchim.Checked = True
                    vip_imwretch.Checked = False
                End If
            Case Else
                vip_imwretchim.Checked = True
        End Select

        Select Case My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "vip_auto999", Nothing)
            Case "1"
                vip_auto999stop.Checked = True
            Case "2"
                If Form1.vip = True Then
                    vip_auto999open.Checked = True
                Else
                    vip_auto999stop.Checked = True
                    vip_auto999open.Checked = False
                End If
            Case Else
                vip_auto999stop.Checked = True
        End Select

        Select Case My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "vip_css", Nothing)
            Case "1"
                vip_cssyes.Checked = True
            Case "2"
                If Form1.vip = True Then
                    vip_cssno.Checked = True
                Else
                    vip_cssyes.Checked = True
                    vip_cssno.Checked = False
                End If
            Case Else
                vip_cssyes.Checked = True
        End Select


        Select Case My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "removelist10", Nothing)
            Case "1"
                func_removelist10.Checked = True
            Case "2"
                func_removelist10.Checked = False
            Case Else
                func_removelist10.Checked = True
        End Select

        Select Case My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "myself", Nothing)
            Case "1"
                RadioButton1.Checked = True
            Case "2"
                RadioButton2.Checked = True
            Case Else
                RadioButton1.Checked = True
        End Select



        cansetreg = True
    End Sub

    '設定vip功能
    Public Sub setvipfunc()
        If Form1.vip = True Then
            func_gethybird.Enabled = True
            autogetug.Enabled = True
            func_speed_05.Enabled = True
            func_speed_07.Enabled = True
            func_speed_10.Enabled = True
            func_speed_12.Enabled = True
            func_speed_14.Enabled = True
            func_speed_16.Enabled = True
            func_speed_18.Enabled = True
            func_speed_20.Enabled = True
            func_speed_40.Enabled = True
            func_get9.Enabled = True
            vip_imwretch.Enabled = True
            vip_cssno.Enabled = True
            vip_auto999open.Enabled = True
        End If
        Dim Reg = CreateObject("Wscript.Shell")

        If Reg.regread("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3\1400") = 0 Then
            openjavascript.Checked = True
        ElseIf Reg.regread("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3\1400") = 3 Then
            stopjavascript.Checked = True
        End If
    End Sub

    '詳細VIP網站
    Private Sub LinkLabel24_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel24.LinkClicked
        Shell("cmd /c start http://www.autowretch.com/vip.php", vbMinimizedNoFocus)
    End Sub

    '啟動JAVASCRIPT
    Private Sub openjavascript_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openjavascript.CheckedChanged
        Dim Reg = CreateObject("Wscript.Shell")
        Reg.RegWrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3\1400", "0", "REG_DWORD")
    End Sub
    '關閉JAVASCRIPT
    Private Sub stopjavascript_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopjavascript.CheckedChanged
        Dim Reg = CreateObject("Wscript.Shell")
        Reg.RegWrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3\1400", "3", "REG_DWORD")
    End Sub
    '防作弊
    Public Sub checkvip()
        If func_gethybird.Checked = True And Form1.vip = False Then
            func_getfd.Checked = True
            func_gethybird.Checked = False
        End If
        If autogetug.Checked = True And Form1.vip = False Then
            autogetug.Checked = False
        End If
        If vip_imwretch.Checked = True And Form1.vip = False Then
            vip_imwretch.Checked = False
            vip_imwretchim.Checked = True
        End If
        If vip_auto999open.Checked = True And Form1.vip = False Then
            vip_auto999open.Checked = False
            vip_auto999stop.Checked = True
        End If
        If vip_cssno.Checked = True And Form1.vip = False Then
            vip_cssno.Checked = False
            vip_cssyes.Checked = True
        End If
        change_speed()
    End Sub

    Private Sub func_gethybird_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_gethybird.CheckedChanged
        checkvip()
        If func_gethybird.Checked = True Then
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autogetfd", "3")
        End If
    End Sub

    Private Sub autogetug_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autogetug.CheckedChanged
        checkvip()
        If autogetug.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autogetug", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autogetug", "0")
        End If
    End Sub

    Private Sub vip_imwretch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip_imwretch.CheckedChanged
        checkvip()
    End Sub

    Private Sub vip_auto999open_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip_auto999open.CheckedChanged
        checkvip()
    End Sub

    Private Sub vip_cssno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip_cssno.CheckedChanged
        checkvip()
    End Sub

    Private Sub func_getfd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_getfd.CheckedChanged
        If func_getfd.Checked = True Then
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autogetfd", "1")
        End If
    End Sub

    Private Sub func_get9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_get9.CheckedChanged
        If func_get9.Checked = True Then
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autogetfd", "2")
        End If
    End Sub

    Private Sub func_speed_16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_speed_16.CheckedChanged
        If form1.vip = False Then
            func_speed_30.Checked = True
            func_speed_16.Checked = False
        End If
        change_speed()
    End Sub

    Private Sub func_speed_18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_speed_18.CheckedChanged
        If form1.vip = False Then
            func_speed_30.Checked = True
            func_speed_18.Checked = False
        End If
        change_speed()
    End Sub

    Private Sub func_speed_20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_speed_20.CheckedChanged
        If form1.vip = False Then
            func_speed_30.Checked = True
            func_speed_20.Checked = False
        End If
        change_speed()
    End Sub

    Private Sub func_speed_30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_speed_30.CheckedChanged
        change_speed()
    End Sub

    Private Sub func_speed_40_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_speed_40.CheckedChanged
        change_speed()
    End Sub

    Private Sub func_gostreet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_gostreet.CheckedChanged
        If func_gostreet.Checked = True Then
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "golist", "1")
        Else
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "golist", "2")
        End If
    End Sub

    Private Sub func_slowfd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_slowfd.CheckedChanged
        If func_slowfd.Checked = True Then
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "slowfd", "1")
        Else
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "slowfd", "2")
        End If
    End Sub

    Private Sub func_break120_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_break120.CheckedChanged
        If func_break120.Checked = True Then
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "break120", "1")
        Else
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "break120", "2")
        End If
    End Sub

    Private Sub vip_imwretchim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip_imwretchim.CheckedChanged
        If vip_imwretchim.Checked = True Then
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "vip_imwretch", "1")
        Else
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "vip_imwretch", "2")
        End If
    End Sub

    Private Sub vip_auto999stop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip_auto999stop.CheckedChanged
        If vip_auto999stop.Checked = True Then
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "vip_auto999", "1")
        Else
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "vip_auto999", "2")
        End If
    End Sub

    Private Sub vip_cssyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip_cssyes.CheckedChanged
        If vip_cssyes.Checked = True Then
            WebBrowser1.ScriptErrorsSuppressed = True
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "vip_css", "1")
        Else
            WebBrowser1.ScriptErrorsSuppressed = False
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "vip_css", "2")
        End If
    End Sub
    Public cansetreg As Boolean = False
    Dim autologin As Boolean = False
    Private Sub func_autologin_on_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_autologin_on.CheckedChanged
        If func_autologin_on.Checked = True Then
            autorun.Enabled = True
        Else
            autorun.Enabled = False
            autorun.Checked = False
        End If
        If func_autologin_on.Checked = True And autologin = False Then
            If loginisture.Text = "此帳密有經過驗證,可以啟動功能" Then

            Else
                func_autologin_on.Checked = False
                func_autologin_id.Enabled = True
                func_autologin_pass.Enabled = True
                loginisture.Text = "輸入完畢後請先測試帳號有無正確再打勾"
                loginisture.ForeColor = Color.Red
                MsgBox("請先測試帳號有無正確才能打勾")
                Exit Sub
            End If


            If Len(func_autologin_id.Text) <> 0 And Len(func_autologin_pass.Text) <> 0 Then
            Else
                MsgBox("您缺少輸入欄位")
                func_autologin_on.Checked = False
                Exit Sub
            End If

            func_autologin_id.Enabled = False
            func_autologin_pass.Enabled = False



            Dim pass As String = ""
            For i = 1 To Len(func_autologin_pass.Text)
                pass = Chr(Asc(Mid(func_autologin_pass.Text, i, 1)) + 5) & pass
            Next
            Try
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autologin_username", func_autologin_id.Text)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autologin_password", pass)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autologin", "1")
            Catch ex As Exception
                func_autologin_on.Checked = False
                func_autologin_id.Enabled = True
                func_autologin_pass.Enabled = True
                MsgBox("發生錯誤,無法儲存密碼,vista請以系統管理員啟動,win7請關閉UAC")
            End Try
        Else
            If autologin = False Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autologin", "0")
            End If

            func_autologin_id.Enabled = True
            func_autologin_pass.Enabled = True
        End If
    End Sub

    Private Sub autorun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autorun.CheckedChanged
        If autorun.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autogo", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autogo", "0")
        End If
    End Sub

    Private Sub logintest_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logintest.Tick
        If WebBrowser4.Url.OriginalString Like "https://login.yahoo.com/config/login*" Then
            WebBrowser4.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
            loginisture.Text = "請先測試帳號有無正確再打勾"
            loginisture.ForeColor = Color.Red
            Button3.Enabled = True
            MsgBox("帳密錯誤")
            func_autologin_test.Enabled = True
            If func_autologin_on.Checked = False Then
                func_autologin_id.Enabled = True
                func_autologin_pass.Enabled = True
            End If
        Else
            loginisture.Text = "此帳密有經過驗證,可以啟動功能"
            loginisture.ForeColor = Color.Blue
            Button3.Enabled = True
            MsgBox("帳密正確,可以啟動功能囉!")
            WebBrowser4.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
            func_autologin_test.Enabled = True
            If func_autologin_on.Checked = False Then
                func_autologin_id.Enabled = True
                func_autologin_pass.Enabled = True
            End If
        End If
        logintest.Enabled = False
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If func_autologin_id.Text <> "" And func_autologin_pass.Text <> "" Then
            If Form1.WebBrowser1.Url.OriginalString Like "https://login.yahoo.com/config/login*" Then
                If Form1.WebBrowser1.Document.GetElementById("username") <> Nothing Then
                    Form1.WebBrowser1.Document.GetElementById("username").SetAttribute("value", func_autologin_id.Text) '輸入帳號
                End If

                If Form1.WebBrowser1.Document.GetElementById("passwd") <> Nothing Then '檢查密碼欄位
                    Form1.WebBrowser1.Document.GetElementById("passwd").SetAttribute("value", func_autologin_pass.Text) '輸入密碼
                End If

                Form1.WebBrowser1.Document.All.GetElementsByName(".save").Item(0).InvokeMember("click") '按下登入
                relogin3.Enabled = True
            Else
                ''haha()
                form1.WebBrowser1.Navigate("http://www.wretch.cc/index/logout.php?url=%2Fblog%2Fmousems1")
                MsgBox("瀏覽器沒有在登入頁面,請再試一次")
                form1.WebBrowser1.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
            End If
        Else
            MsgBox("有欄位沒有填寫")
        End If
    End Sub

    Private Sub func_autologin_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_autologin_test.Click
        If func_autologin_id.Text = "" Or func_autologin_pass.Text = "" Then
            MsgBox("帳密沒有填齊")
            Exit Sub
        End If
        loginisture.Text = "登入測試中...請稍候"
        func_autologin_test.Enabled = False
        func_autologin_id.Enabled = False
        func_autologin_pass.Enabled = False
        Button3.Enabled = False


        If WebBrowser4.Url.ToString Like "https://login.yahoo.com/config/login*" Then
            If WebBrowser4.Document.GetElementById("username") <> Nothing Then
                WebBrowser4.Document.GetElementById("username").SetAttribute("value", func_autologin_id.Text) '輸入帳號
            End If

            If WebBrowser4.Document.GetElementById("passwd") <> Nothing Then '檢查密碼欄位
                WebBrowser4.Document.GetElementById("passwd").SetAttribute("value", func_autologin_pass.Text) '輸入密碼
            End If

            WebBrowser4.Document.All.GetElementsByName(".save").Item(0).InvokeMember("click") '按下登入

            relogin2.Enabled = True
        Else
            WebBrowser4.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
            'haha()
            MsgBox("系統尚未準備完成,請再試一次")
            func_autologin_test.Enabled = True
            Button3.Enabled = True
            loginisture.Text = "請先測試帳號有無正確再打勾"
            If func_autologin_on.Checked = False Then
                func_autologin_id.Enabled = True
                func_autologin_pass.Enabled = True
            End If
        End If
    End Sub

    Private Sub login_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_timer.Tick
        Try
            If form1.WebBrowser1.IsBusy = True Then
                form1.WebBrowser1.Stop()
            End If
            If form1.WebBrowser1.Url.OriginalString Like "https://login.yahoo.com/config/login*" Then
                If form1.WebBrowser1.Document.GetElementById("username") <> Nothing Then
                    form1.WebBrowser1.Document.GetElementById("username").SetAttribute("value", func_autologin_id.Text) '輸入帳號
                End If

                If form1.WebBrowser1.Document.GetElementById("passwd") <> Nothing Then '檢查密碼欄位
                    form1.WebBrowser1.Document.GetElementById("passwd").SetAttribute("value", func_autologin_pass.Text) '輸入密碼
                End If

                form1.WebBrowser1.Document.All.GetElementsByName(".save").Item(0).InvokeMember("click") '按下登入
                login_timer.Enabled = False
                relogin.Enabled = True

            Else
                form1.WebBrowser1.Navigate("http://www.wretch.cc/index/logout.php?url=%2Fblog%2Fmousems1")
                form1.WebBrowser1.Navigate("http://www.wretch.cc/IDintegration/?ref=%2525252Fblog%2525252Fmousems1")
            End If
            autologin = False
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub autostarttime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autostarttime.Tick
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "autogo", Nothing) = "1" Then
            Form1.wretchspeedtimer.Enabled = True
        End If
    End Sub

    Private Sub func_removelist10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_removelist10.CheckedChanged
        If func_removelist10.Checked = True Then
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "removelist10", "1")
            autoremove.Enabled = True
        Else
            If cansetreg = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "removelist10", "2")
            End If
            autoremove.Enabled = False
        End If
    End Sub

    Private Sub autoremove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autoremove.Tick
        If wretchlist.Items.Count > 100 Then
            For i = 0 To 14
                wretchlist.Items.RemoveAt(i)
            Next
        End If
    End Sub

    Private Sub LinkLabel25_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Shell("cmd /c start http://www.wretch.cc/blog/mousems1", vbMinimizedNoFocus)
    End Sub

    Private Sub LinkLabel31_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel31.LinkClicked
        Shell("cmd /c start http://mousems.info", vbMinimizedNoFocus)
    End Sub

    Private Sub LinkLabel26_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel26.LinkClicked
        Shell("cmd /c start ymsgr:sendIM?autowretch", vbMinimizedNoFocus)
    End Sub

    Private Sub LinkLabel28_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel28.LinkClicked
        Shell("cmd /c start http://settings.messenger.live.com/Conversation/IMMe.aspx?invitee=3a30779771e1fc47@apps.messenger.live.com&mkt=zh-tw", vbMinimizedNoFocus)
    End Sub

    Private Sub LinkLabel29_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel29.LinkClicked
        Shell("cmd /c start mailto:admin@mousems.com", vbMinimizedNoFocus)
    End Sub

    Private Sub LinkLabel27_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel27.LinkClicked
        Shell("cmd /c start http://www.autowretch.com", vbMinimizedNoFocus)
    End Sub

    Private Sub LinkLabel30_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel30.LinkClicked
        Shell("cmd /c start http://bbs.autowretch.com", vbMinimizedNoFocus)
    End Sub

    Private Sub checkjava_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkjava.Tick

        Dim Reg = CreateObject("Wscript.Shell")

        If Reg.regread("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3\1400") = 0 Then
            openjavascript.Checked = True
        ElseIf Reg.regread("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3\1400") = 3 Then
            stopjavascript.Checked = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        WebBrowser1.Navigate("http://mousems.tk/autowretch/exe3stats.html")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            Button2.Enabled = False
            Form1.wretchspeedtimer.Enabled = False
            wretchlist2.Items.Clear()

            For i = 1 To wretchlist.Items.Count
                wretchlist2.Items.Add(wretchlist.Items(0))
                wretchlist.Items.RemoveAt(0)
            Next

            wretchlist.Items.Clear()

            Dim ofb As Integer
            Dim a As Integer = wretchlist2.Items.Count

            For i = 0 To a - 1

                ofb = wretchlist.Items.Count

                If ofb <= 3 Then
                    wretchlist.Items.Add(wretchlist2.Items(0))
                    wretchlist2.Items.RemoveAt(0)
                Else
                    Randomize()
                    ofb = Val(Int(Rnd() * (ofb - 1)))
                    wretchlist.Items.Insert(ofb, wretchlist2.Items(0))
                    wretchlist2.Items.RemoveAt(0)
                End If

            Next
            Button2.Enabled = True
            MsgBox("洗亂完成 請再次開啟逛無名")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "myself", "1")
        Else
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "myself", "0")
        End If
    End Sub

    Private Sub func_break120flase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_break120flase.CheckedChanged

    End Sub

    Private Sub autowash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autowash.CheckedChanged
        If autowash.Checked = True Then
            MsgBox("提醒您,如果多開時使用本功能,可能會有當機之虞")
            autowashtimer.Enabled = True
        Else
            autowashtimer.Enabled = False
        End If
    End Sub

    Private Sub autowashtimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autowashtimer.Tick
        Try
            Dim ab As Boolean = False
            If Form1.wretchspeedtimer.Enabled = True Then
                ab = True
            End If

            Button2.Enabled = False
            Form1.wretchspeedtimer.Enabled = False
            wretchlist2.Items.Clear()

            For i = 1 To wretchlist.Items.Count
                wretchlist2.Items.Add(wretchlist.Items(0))
                wretchlist.Items.RemoveAt(0)
            Next

            wretchlist.Items.Clear()

            Dim ofb As Integer
            Dim a As Integer = wretchlist2.Items.Count

            For i = 0 To a - 1

                ofb = wretchlist.Items.Count

                If ofb <= 3 Then
                    wretchlist.Items.Add(wretchlist2.Items(0))
                    wretchlist2.Items.RemoveAt(0)
                Else
                    Randomize()
                    ofb = Val(Int(Rnd() * (ofb - 1)))
                    wretchlist.Items.Insert(ofb, wretchlist2.Items(0))
                    wretchlist2.Items.RemoveAt(0)
                End If

            Next
            Button2.Enabled = True

            If ab = True Then Form1.wretchspeedtimer.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Try
            imwretchlist.Items.Add(wretchlist.Items(wretchlist.SelectedIndex))
            wretchlist.Items.RemoveAt(wretchlist.SelectedIndex)
        Catch ex As Exception
            MsgBox("必須要選擇你要去的那個人才能去!")
        End Try
    End Sub



    Dim a As Boolean = False
    Private Sub WebBrowser4_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser4.DocumentCompleted
        If a = False Then
            'haha()
            a = True
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub relogin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles relogin.Tick
        Try

            If Form1.WebBrowser1.Url.OriginalString Like "https://login.yahoo.com/config/login*" Then
                If Form1.WebBrowser1.Document.GetElementById("passwd") <> Nothing Then '檢查密碼欄位
                    Form1.WebBrowser1.Document.GetElementById("passwd").SetAttribute("value", func_autologin_pass.Text) '輸入密碼
                End If

                Form1.WebBrowser1.Document.All.GetElementsByName(".save").Item(0).InvokeMember("click") '按下登入
            Else
                relogin.Enabled = False
                autostarttime.Enabled = True
            End If

        Catch ex As Exception
            relogin.Enabled = False
            autostarttime.Enabled = True
        End Try

    End Sub

    Private Sub relogin2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles relogin2.Tick
        Try
            If WebBrowser4.Url.ToString Like "https://login.yahoo.com/config/login*" Then
                If WebBrowser4.Document.GetElementById("passwd") <> Nothing Then '檢查密碼欄位
                    WebBrowser4.Document.GetElementById("passwd").SetAttribute("value", func_autologin_pass.Text) '輸入密碼
                End If

                WebBrowser4.Document.All.GetElementsByName(".save").Item(0).InvokeMember("click") '按下登入
            Else
                relogin2.Enabled = False
                logintest.Enabled = True
            End If
        Catch ex As Exception
            relogin2.Enabled = False
            logintest.Enabled = True
        End Try

    End Sub

    Private Sub relogin3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles relogin3.Tick
        Try


            If Form1.WebBrowser1.Url.OriginalString Like "https://login.yahoo.com/config/login*" Then

                If Form1.WebBrowser1.Document.GetElementById("passwd") <> Nothing Then '檢查密碼欄位
                    Form1.WebBrowser1.Document.GetElementById("passwd").SetAttribute("value", func_autologin_pass.Text) '輸入密碼
                End If

                Form1.WebBrowser1.Document.All.GetElementsByName(".save").Item(0).InvokeMember("click") '按下登入
            Else
                relogin3.Enabled = False
            End If
        Catch ex As Exception
            relogin3.Enabled = False
        End Try
    End Sub

    Private Sub func_gorelist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles func_gorelist.CheckedChanged
        If func_gorelist.Checked = True Then
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "golist", "3")
        Else
            If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "golist", "1")
        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Shell("cmd /c start http://bbs.autowretch.com/bbs_freevip.php", vbMinimizedNoFocus)
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Shell("cmd /c start http://bbs.autowretch.com/viewthread.php?tid=19&extra=page%3D1", vbMinimizedNoFocus)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Shell("cmd /c start http://autowretch.com/vip.php", vbMinimizedNoFocus)
    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        If cansetreg = True Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "speed", HScrollBar1.Value * 1000)
        func_speed_40.Checked = True
        Label14.Text = HScrollBar1.Value & "秒/20秒"
        change_speed()
    End Sub
End Class