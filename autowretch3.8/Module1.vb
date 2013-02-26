﻿Imports System
Imports System.Security.Cryptography
Imports System.Text

Module md5

    ' Hash an input string and return the hash as
    ' a 32 character hexadecimal string.
    Function getMd5Hash(ByVal input As String) As String
        ' Create a new instance of the MD5CryptoServiceProvider object.
        Dim md5Hasher As New MD5CryptoServiceProvider()

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function

End Module
' This code example produces the following output:
'
' The MD5 hash of Hello World! is: ed076287532e86365e841e92bfc50d8c.
' Verifying the hash...
' The hashes are the same.
