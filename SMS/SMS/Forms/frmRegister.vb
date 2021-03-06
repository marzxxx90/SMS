﻿Imports System.Text.RegularExpressions
Imports System.Text

Public Class frmRegister
    Private pattern As String = "\[.*?\]"
    Private strParse As String, strTrim As String
    Private mc As System.Text.RegularExpressions.MatchCollection

    Private Function Parser(ByVal StrText As String) As Hashtable
        Dim SmsHash As New Hashtable
        Dim regx As New System.Text.RegularExpressions.Regex(pattern)
        If Regex.IsMatch(StrText, pattern) Then
            mc = regx.Matches(StrText) 'Check kong pila ang bracket
            For index As Integer = 0 To mc.Count - 1 ' Count sa Bracket
                'Nagkuha ug Text Fields
                strParse = mc(index).Value.Substring(0, mc(index).Value.IndexOf(":")).Trim({"["c})
                Console.WriteLine("Fields " & strParse)

                'Nagkuha ug Fields Information
                strTrim = mc(index).Value.Substring(mc(index).Value.IndexOf(":") + 1).Trim({"]"c}).Trim({" "c})
                Console.WriteLine("Value " & strTrim)

                If Not isValidKey(strParse) Then Exit For

                SmsHash.Add(strParse, strTrim)
            Next
        End If

        'If SMSHash.Count = 0 Then Exit Sub

        'Dim mysql As String = "Select * from SmsRegister"
        'Dim ds As DataSet = LoadSQL(mysql, "SmsRegister")
        'Dim dsNewRow As DataRow
        'dsNewRow = ds.Tables("SmsRegister").NewRow
        'With dsNewRow
        '    .Item("Fname") = SMSHash("FNAME")
        '    .Item("Lname") = SMSHash("LNAME")
        '    .Item("Mname") = SMSHash("MNAME")
        '    .Item("SMSNumber") = SMSHash("NUMBER")
        'End With
        'ds.Tables("SmsRegister").Rows.Add(dsNewRow)
        'SaveEntry(ds)

        'MsgBox("Success")
        'SMSHash.Clear()
        Return SMSHash
    End Function

    Private Function Parser2(ByVal smg As String) As Hashtable
        Dim SmsHash As New Hashtable

        Dim regx As New System.Text.RegularExpressions.Regex(pattern)
        If Regex.IsMatch(smg, pattern) Then
            mc = regx.Matches(smg) 'Check kong pila ang bracket
            For index As Integer = 0 To mc.Count - 1 ' Count sa Bracket
                'Nagkuha ug Text Fields
                strParse = mc(index).Value.Substring(0, mc(index).Value.IndexOf(":")).Trim({"["c})
                Console.WriteLine("Fields " & strParse)

                'Nagkuha ug Fields Information
                strTrim = mc(index).Value.Substring(mc(index).Value.IndexOf(":") + 1).Trim({"]"c}).Trim({" "c})
                Console.WriteLine("Value " & strTrim)

                If Not isValidKey(strParse) Then Exit For

                SmsHash.Add(strParse, strTrim)
            Next
        End If


        Return SmsHash
    End Function

    Private Function isValidKey(ByVal Keys As String) As Boolean
        Dim KeysCollection() As String = {"FNAME", "MNAME", "LNAME", "NUMBER", "REG_KEY"}

        If KeysCollection.Contains(Keys) Then Return True

        Return False
    End Function

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'Parser(txtParse.Text)
        'For Each DE As DictionaryEntry In SMSHash
        '    Console.WriteLine("Key " & DE.Key & " Value " & DE.Value)
        'Next


        For Each de As DictionaryEntry In Parser2(txtParse.Text)
            Console.WriteLine("Key " & de.Key & " Value " & de.Value)
            Dim strSplit As String()
            Dim str As String = de.Value
            strSplit = str.Split("/")

            Console.WriteLine(".......................")
            For Each s As String In strSplit
                Console.WriteLine("Values " & s)
            Next
        Next
    End Sub
End Class
