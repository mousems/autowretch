Public Class readsl

    Private Sub readsl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Dir(My.Application.Info.DirectoryPath & "\adslid.txt") <> "" Then
            Dim a() As String = Split(My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\adslid.txt"), ",")
            TextBox1.Text = a(0)
            TextBox2.Text = a(1)
            TextBox3.Text = a(2)
        End If
        testnet()
    End Sub
    Public Function testnet()
        Try
            Dim a As String = GetWebDocument("http://login.autowretch.com/localhostip.php")

            If Val(a) > 0 Then
                Label4.Text = "目前有連上網-IP:" & a
                Return True
            Else
                Return False
                Label4.Text = "目前無連上網"
            End If
        Catch ex As Exception
            Label4.Text = "目前無連上網"
            Return False
        End Try

        
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        testnet()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Timer1.Enabled = True
            num = 0
        Else
            Timer1.Enabled = False
        End If
    End Sub
    Dim num As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        num = num + 1
        If num = 56 Then
            Shell("cmd.exe /c Rasdial " & TextBox1.Text & " /disconnect")
            Label4.Text = "撥號中"

        End If
        If num = 60 Then
            Shell("cmd.exe /c Rasdial " & TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text)
            Timer2.Enabled = True
            num = 0
        End If
        Label5.Text = "還有" & 60 - num & "秒重新撥號"

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        testnet()
        Timer2.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Shell("cmd.exe /c Rasdial " & TextBox1.Text & " /disconnect")
        Label4.Text = "斷線中"
        Timer2.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Shell("cmd.exe /c Rasdial " & TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text)
        Label4.Text = "撥號中"
        Timer2.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Dir(My.Application.Info.DirectoryPath & "\adslid.txt") <> "" Then
            Kill(My.Application.Info.DirectoryPath & "\adslid.txt")
        End If

        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\adslid.txt", TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text, False)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub
End Class