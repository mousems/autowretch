Public Class getidmac

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NICs As Net.NetworkInformation.NetworkInterface() = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        Dim NIC As Net.NetworkInformation.NetworkInterface
        For Each NIC In NICs
            ListBox1.Items.Add(NIC.GetPhysicalAddress().ToString())
        Next

        TextBox2.Text = Mid(getMd5Hash(ListBox1.Items(0)), 5, 10)


        TextBox1.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "id", Nothing)
        MsgBox("開通碼說明:如果是購買VIP 需要開通VIP 請將ID與mac交給作者")
    End Sub

End Class