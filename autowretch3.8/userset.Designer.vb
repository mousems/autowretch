<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userset
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.logintest = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.func_autologin_pass = New System.Windows.Forms.TextBox
        Me.func_autologin_id = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.relogin = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(238, 83)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(42, 48)
        Me.WebBrowser1.TabIndex = 15
        Me.WebBrowser1.Visible = False
        '
        'logintest
        '
        Me.logintest.Interval = 4000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 48)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "存檔"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'func_autologin_pass
        '
        Me.func_autologin_pass.Location = New System.Drawing.Point(82, 69)
        Me.func_autologin_pass.Name = "func_autologin_pass"
        Me.func_autologin_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.func_autologin_pass.Size = New System.Drawing.Size(100, 22)
        Me.func_autologin_pass.TabIndex = 13
        '
        'func_autologin_id
        '
        Me.func_autologin_id.Location = New System.Drawing.Point(82, 40)
        Me.func_autologin_id.Name = "func_autologin_id"
        Me.func_autologin_id.Size = New System.Drawing.Size(100, 22)
        Me.func_autologin_id.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(13, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "無名密碼"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "無名帳號"
        '
        'relogin
        '
        Me.relogin.Interval = 2000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "下次則會自動以該帳號登入驗證"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "帳密資料將會以加密形式儲存於電腦內"
        '
        'userset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 99)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.func_autologin_pass)
        Me.Controls.Add(Me.func_autologin_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(277, 133)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(277, 133)
        Me.Name = "userset"
        Me.Text = "設定自動無名驗證之帳密"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents logintest As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents func_autologin_pass As System.Windows.Forms.TextBox
    Friend WithEvents func_autologin_id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents relogin As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
