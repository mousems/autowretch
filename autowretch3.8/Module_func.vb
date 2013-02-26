Imports System.Net '放在最前面
Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Imports System


Module Module_func
    '取得原始碼的code
    Public Function GetWebDocument(ByVal url As String)
        Randomize()
        Dim a As Integer = Int(Rnd() * 21)
        Select Case a
            Case 1
                Return GetWebDocument_1(url)
            Case 2
                Return GetWebDocument_2(url)
            Case 3
                Return GetWebDocument_3(url)
            Case 4
                Return GetWebDocument_4(url)
            Case 5
                Return GetWebDocument_5(url)
            Case 6
                Return GetWebDocument_6(url)
            Case 7
                Return GetWebDocument_7(url)
            Case 8
                Return GetWebDocument_8(url)
            Case 9
                Return GetWebDocument_9(url)
            Case 10
                Return GetWebDocument_10(url)
            Case 11
                Return GetWebDocument_11(url)
            Case 12
                Return GetWebDocument_12(url)
            Case 13
                Return GetWebDocument_13(url)
            Case 14
                Return GetWebDocument_14(url)
            Case 15
                Return GetWebDocument_15(url)
            Case 16
                Return GetWebDocument_16(url)
            Case 17
                Return GetWebDocument_17(url)
            Case 18
                Return GetWebDocument_18(url)
            Case 19
                Return GetWebDocument_19(url)
            Case 20
                Return GetWebDocument_20(url)
            Case 21
                Return GetWebDocument_21(url)
            Case 22
                Return GetWebDocument_22(url)
            Case 23
                Return GetWebDocument_23(url)
            Case 24
                Return GetWebDocument_24(url)
            Case 25
                Return GetWebDocument_25(url)
            Case 26
                Return GetWebDocument_26(url)
            Case 27
                Return GetWebDocument_27(url)
            Case 28
                Return GetWebDocument_28(url)
            Case 29
                Return GetWebDocument_29(url)
            Case 30
                Return GetWebDocument_30(url)
            Case 31
                Return GetWebDocument_31(url)
            Case 32
                Return GetWebDocument_32(url)
            Case 33
                Return GetWebDocument_33(url)
            Case 34
                Return GetWebDocument_34(url)
            Case 35
                Return GetWebDocument_35(url)
            Case 36
                Return GetWebDocument_36(url)
            Case 37
                Return GetWebDocument_37(url)
            Case 38
                Return GetWebDocument_38(url)
            Case 39
                Return GetWebDocument_39(url)
            Case Else
                Return GetWebDocument_40(url)
        End Select
    End Function

    Public Sub opensomeurl(ByVal url As String)
        Dim a As String
        a = GetWebDocument(url)
    End Sub
    Function GetWebDocument_1(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_2(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_3(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_4(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_5(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_6(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_7(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_8(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_9(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_10(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_11(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_12(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_13(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_14(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_15(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_16(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_17(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_18(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_19(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_20(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_21(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_22(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_23(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_24(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_25(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_26(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_27(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_28(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_29(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_30(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_31(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_32(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_33(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_34(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_35(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_36(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_37(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_38(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_39(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Function GetWebDocument_40(ByVal url As String)
        Try


            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim recS As Stream = res.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim sread As New StreamReader(recS, enc)
            Dim s As String
            s = ""
            Dim read(256) As [Char]
            Dim count As Integer = sread.Read(read, 0, 256)

            While count > 0
                Dim str As New [String](read, 0, count)
                Application.DoEvents()
                s = s + str
                count = sread.Read(read, 0, 256)
            End While
            s = s + ControlChars.CrLf
            sread.Close()
            res.Close()
            Return s
        Catch ex As Exception
            Return "error"
        End Try
    End Function

    'md5hash
    Public Function getMd5Hash(ByVal input As String) As String
        Dim md5Hasher As New MD5CryptoServiceProvider()
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function


    'getIDMAC(請自行用split分割)
    Public Function getIDMACfunc()

        Dim id As String
        Dim mac As String
        Dim gated As Boolean = False

        Dim NICs As Net.NetworkInformation.NetworkInterface() = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        Dim NIC As Net.NetworkInformation.NetworkInterface
        For Each NIC In NICs
            If gated = False Then
                mac = NIC.GetPhysicalAddress().ToString()
                mac = Mid(getMd5Hash(mac), 5, 10)
                gated = True
            End If
        Next


        id = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "id", Nothing)

        Return id & "," & mac
    End Function

    Public Function getIDfunc()

        Dim id As String
        Dim mac As String
        Dim gated As Boolean = False

        Dim NICs As Net.NetworkInformation.NetworkInterface() = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        Dim NIC As Net.NetworkInformation.NetworkInterface
        For Each NIC In NICs
            If gated = False Then
                mac = NIC.GetPhysicalAddress().ToString()
                mac = Mid(getMd5Hash(mac), 5, 10)
                gated = True
            End If
        Next


        id = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "id", Nothing)

        Return id
    End Function
    Public Function getMACfunc()

        Dim id As String
        Dim mac As String
        Dim gated As Boolean = False

        Dim NICs As Net.NetworkInformation.NetworkInterface() = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        Dim NIC As Net.NetworkInformation.NetworkInterface
        For Each NIC In NICs
            If gated = False Then
                mac = NIC.GetPhysicalAddress().ToString()
                mac = Mid(getMd5Hash(mac), 5, 10)
                gated = True
            End If
        Next


        id = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "id", Nothing)

        Return mac
    End Function

    'getmd5ab(請自行用split分割)
    Public Function getMd5AB(Optional ByVal id1 As String = "", Optional ByVal mac1 As String = "")
        If id1 = "" Or mac1 = "" Then

        End If

        Dim code1 As String
        Dim code2 As String
        Dim code3 As String
        Dim code4 As String
        Dim id As String
        Dim mac As String
        Dim md5A As String
        Dim md5B As String
        Dim a() As String = Split(getIDMACfunc(), ",")

        If id1 = "" And mac1 = "" Then
            id = a(0)
            mac = a(1)
        Else
            id = id1
            mac = mac1
        End If
        code1 = getMd5Hash(Mid(mac, 1, Len(mac) - 1))
        code2 = getMd5Hash(Mid(code1, 5, 25))
        code3 = getMd5Hash(Mid(code1, 1, 25) & Mid(code2, 2, 25) & Mid(code1, 6, 18) & Mid(code2, 4, 28) & code2 & id)
        code4 = code1 & code2 & code3 & id & getMd5Hash(Mid(code1, 5, 25)) & Mid(mac, 1, Len(mac) - 1)
        md5A = Mid(getMd5Hash(getMd5Hash(code2) & getMd5Hash(code3)), 15, 6)
        md5B = getMd5Hash(getMd5Hash(Mid(code4, 2, Len(code4) - 4)) & getMd5Hash(code1) & getMd5Hash(code2) & getMd5Hash(code3) & getMd5Hash(code4))

        Return md5A & "," & md5B
    End Function



    '取得人氣
    Public Function getbox(ByVal wretchusername As String)
        Try
            Dim documentaa As String = GetWebDocument("http://www.wretch.cc/blog/" & wretchusername)

            Dim get1() As String = Split(documentaa, "<div class=""boxCounter1"">")
            Dim get2() As String = Split(get1(1), "<div class=""side"">")
            Dim get3() As String = Split(get2(1), "</div>")
            Dim get4 As String = Replace(get3(0), " ", "")

            Dim boxa As String = Mid(get4, InStr(get4, "Today'sVisitors:") + 16, InStr(get4, "<") - InStr(get4, "Today'sVisitors:") - 16)
            Dim boxb As String = Mid(get4, InStr(get4, "TotalVisitors:") + 14, Len(get4) - InStr(get4, "TotalVisitors:") - 13)

            Return Mid(boxa & "," & boxb, 1, 15)
        Catch ex As Exception
            Return "無法取得,無法取得"
        End Try
        

    End Function

    '電腦驗證(回傳值1-成功 0-失敗)
    Public Function md5ab_check()
        Dim a() As String = Split(Module_func.getMd5AB, ",")
        Dim md5a As String = a(0)
        Dim md5b As String = a(1)

        If Mid(GetWebDocument(DimationModule_loginhost & md5a & ".txt"), 1, 32) = Mid(md5b, 1, 32) Then
            Return "1"
        Else
            Return "0"
        End If
    End Function

    '取回電腦驗證到期日(回傳值 20*-到期日,0-失敗,21-永久)
    Public Function md5ab_getexp()
        If md5ab_check() = "1" Then
            Dim a() As String = Split(Module_func.getMd5AB, ",")
            Dim md5a As String = a(0)
            Dim md5b As String = a(1)
            Dim dueto As String = GetWebDocument(DimationModule_loginhost & "expiration/" & md5a & ".txt")

            Select Case Mid(dueto, 1, 2)
                Case "20"
                    Return dueto
                Case "21"
                    Return "21"
                Case "error"
                    Return "0"
                Case Else
                    Return "0"
            End Select
        Else
            Return "0"
        End If
    End Function

    '檢查是否在黑單內(回傳值1-是 0-否)
    Public Function md5ab_isblocked()
        Dim a() As String = Split(Module_func.getMd5AB, ",")
        Dim md5a As String = a(0)

        If InStr(GetWebDocument(DimationModule_loginhost & "blockuser.txt"), md5a) <> 0 Then
            Return "1"
        Else
            Return "0"
        End If
    End Function

    '取回無名驗證到期日(回傳值 20*-到期日,0-失敗,21-永久)
    Public Function wretchuser_check(ByVal wretchusername As String)
        Dim check1 As String = GetWebDocument(DimationModule_loginhost & "autowretchuserlogin.php?username=" & Mid(LCase(wretchusername), 2, Len(LCase(wretchusername)) - 1))
        Select Case Mid(check1, 1, 2)
            Case "20"
                Return check1
            Case "21"
                Return "21"
            Case Else
                Dim check2 As String = GetWebDocument(DimationModule_loginhost & "autowretchuserlogin.php?username=" & LCase(wretchusername))
                Select Case Mid(check2, 1, 2)
                    Case "20"
                        Return check2
                    Case "21"
                        Return "21"
                    Case Else
                        Return "0"
                End Select
                Return "0"
        End Select

    End Function

    '確認有沒有多開(傳回值 1-是 0-否)
    Public Function chk_dbopen()
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\Autowretch\V3.7", "funccode", Nothing) <> form1.funccode Then
            If form1.vip = False Then
                form1.wretchspeedtimer.Enabled = False
                Return "1"
            Else
                Return "0"
            End If
        Else
            Return "0"
        End If
    End Function


    '取得人氣並且載入到程式
    Public Sub setbox()


        Try
            Dim today As String
            Dim total As String
            Dim a() As String = Split(getbox(form1.ToolStripStatusLabel3.Text), ",")
            today = a(0)
            total = a(1)

            form1.ToolStripStatusLabel5.Text = "以下是您網誌的資訊:" & vbCrLf & "當日人次" & today
            form1.count_today = "當日人次" & today
            form1.ToolStripStatusLabel6.Text = "(30秒更新一次)" & vbCrLf & "累積人次" & total
            form1.count_total = "累積人次" & total
            Application.DoEvents()
        Catch ex As Exception
            form1.ToolStripStatusLabel5.Text = "您的人氣資訊無法讀取!"
            form1.count_today = "您的人氣資訊無法讀取!"
            form1.count_total = ""
        End Try

    End Sub

    '產生nullweburl
    Public Function getnullweburl()
        Randomize()
        Dim a As String = "http://ya-happy.com/"
        Dim b As String = "qazwsxedcrfvtgbyhnujmikolp123456789"
        For i = 1 To 10
            If i < 5 Then
                a = a & Mid(b, Int(Rnd() * 35) + 1, 1)
            ElseIf i = 5 Then
                a = a & "/"
            Else
                a = a & Mid(b, Int(Rnd() * 35) + 1, 1)
            End If
        Next
        a = a & ".html"
        Return a
    End Function
End Module
