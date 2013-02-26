<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcome
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcome))
        Me.Label1 = New System.Windows.Forms.Label
        Me.autologin = New System.Windows.Forms.Timer(Me.components)
        Me.countdown2 = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.passway_combo = New System.Windows.Forms.ComboBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label_title1 = New System.Windows.Forms.Label
        Me.Label_title2 = New System.Windows.Forms.Label
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "自動逛無名 Autowretch"
        '
        'autologin
        '
        Me.autologin.Interval = 1000
        '
        'countdown2
        '
        Me.countdown2.Interval = 1000
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(5, 54)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(275, 238)
        Me.WebBrowser1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.passway_combo)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 158)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(129, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(141, 49)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "設定"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox1.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 16)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "一有活動就告訴我"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox2.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(132, 16)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "啟動時檢查最新版本"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(5, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "儲存慣用驗證設定"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'passway_combo
        '
        Me.passway_combo.FormattingEnabled = True
        Me.passway_combo.Items.AddRange(New Object() {"慣用免費版認證", "慣用活動認證", "慣用電腦ID認證", "慣用無名認證"})
        Me.passway_combo.Location = New System.Drawing.Point(7, 106)
        Me.passway_combo.Name = "passway_combo"
        Me.passway_combo.Size = New System.Drawing.Size(118, 20)
        Me.passway_combo.TabIndex = 10
        Me.passway_combo.Text = "慣用免費版認證"
        '
        'Button4
        '
        Me.Button4.Image = Global.autowretch.My.Resources.Resources.foruserid
        Me.Button4.Location = New System.Drawing.Point(149, 64)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 40)
        Me.Button4.TabIndex = 9
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.autowretch.My.Resources.Resources.forid
        Me.Button3.Location = New System.Drawing.Point(3, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 40)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.autowretch.My.Resources.Resources.forparty
        Me.Button2.Location = New System.Drawing.Point(149, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.autowretch.My.Resources.Resources.forfree
        Me.Button1.Location = New System.Drawing.Point(3, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(233, 489)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(53, 12)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "官方網站"
        '
        'Label_title1
        '
        Me.Label_title1.AutoSize = True
        Me.Label_title1.ForeColor = System.Drawing.Color.Blue
        Me.Label_title1.Location = New System.Drawing.Point(12, 441)
        Me.Label_title1.Name = "Label_title1"
        Me.Label_title1.Size = New System.Drawing.Size(200, 12)
        Me.Label_title1.TabIndex = 8
        Me.Label_title1.Text = "歡迎使用自動逛無名 請選擇驗證方式"
        '
        'Label_title2
        '
        Me.Label_title2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_title2.AutoSize = True
        Me.Label_title2.ForeColor = System.Drawing.Color.Blue
        Me.Label_title2.Location = New System.Drawing.Point(11, 464)
        Me.Label_title2.Name = "Label_title2"
        Me.Label_title2.Size = New System.Drawing.Size(171, 12)
        Me.Label_title2.TabIndex = 9
        Me.Label_title2.Text = "如果您並非VIP 請選擇免費版 ^^"
        Me.Label_title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(74, 28)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(138, 169)
        Me.WebBrowser2.TabIndex = 10
        Me.WebBrowser2.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Visible = False
        '
        'welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 504)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.Label_title2)
        Me.Controls.Add(Me.Label_title1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autowretch V3.8.10 歡迎頁面"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents autologin As System.Windows.Forms.Timer
    Friend WithEvents countdown2 As System.Windows.Forms.Timer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents passway_combo As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_title1 As System.Windows.Forms.Label
    Friend WithEvents Label_title2 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
