Imports System.Text.RegularExpressions
Imports System.IO
Public Class frmTextPromo
    Private Sub frmTextPromo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getSN()
        Label3.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub chkTrueFalse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrueFalse.CheckedChanged
        DataGridView1.Rows.Clear()
        If chkTrueFalse.Checked Then
            DataGridView1.Rows.Add("T", "True")
            DataGridView1.Rows.Add("F", "False")
            Exit Sub
        End If
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add("A") : DataGridView1.Rows.Add("B") : DataGridView1.Rows.Add("C")
    End Sub

    Private Function ParseKeyWords(ByVal str As String) As String
        Dim pattern As String = "(-)|(/)"
        For Each result As String In Regex.Matches(str, pattern)
            If result Then

            End If
            Console.WriteLine("'{0}'", result)
        Next

        Return 0
    End Function

    Private Function getSN() As String
        Dim MySql As String = "SELECT * FROM TBLMAIN_TEXTPROMO ORDER BY DOCID DESC LIMIT 1"
        Dim ds As DataSet = LoadSQL(MySql, "TBLMAIN_TEXTPROMO")

        If ds.Tables(0).Rows.Count = 0 Then Return ""
        Dim sn As String = ""
        Dim i As Integer = 0
        sn = ds.Tables(0).Rows(0).Item("Series_Number")

        sn = sn.Replace("SN#", "")

        i = sn + 1

        SNUMBER.Text = String.Format("{0:D9}", i)
        Return sn
    End Function

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim mysql As String = "SELECT * FROM TBLMAIN_TEXTPROMO"
        Dim ds As DataSet = LoadSQL(mysql, "TBLMAIN_TEXTPROMO")

        Dim dsnewrow As DataRow

        dsnewrow = ds.Tables(0).NewRow

        With dsnewrow
            .Item("Series_Number") = "SN#" & SNUMBER.Text
            ' .Item("Availby") = cboTextPromoFor.Text
            .Item("Promo_Name") = txtPromoName.Text
            .Item("Keywords") = txtKeywords.Text
            .Item("userid") = 1
            .Item("Updated_at") = Now.ToShortDateString
            .Item("Created_at") = Now.ToShortDateString
        End With
        ds.Tables(0).Rows.Add(dsnewrow)
        database.SaveEntry(ds)


        'Dim mysql1 As String = "SELECT * FROM TBL_QUESTION"
        'Dim ds1 As DataSet = LoadSQL(mysql1, "TBL_QUESTION")

        'Dim dsnewrow1 As DataRow
        'dsnewrow = ds1.Tables(0).NewRow

        ''With dsnewrow1
        '    .Item("QUESTION") = txtQuestion.Text
        '    .Item("AVAILBY") = cboTextPromoFor.Text
        '    .Item("STATUS") = 0
        'End With
        'ds.Tables(0).Rows.Add(dsnewrow1)
        'database.SaveEntry(ds1)


        ''Dim mysql1 As String = "SELECT * FROM TBL_QUESTION ORDER BY ID DESC ROWS 1"
        ''Dim ds1 As DataSet = LoadSQL(mysql1, "TBL_QUESTION")

        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    Dim mysql2 As String = "SELECT * FROM TBL_ANSWER "
        '    Dim ds2 As DataSet = LoadSQL(mysql2, "TBL_ANSWER")

        '    If row.Cells(0).Value Is Nothing Then Exit For

        '    Dim dsnewrow2 As DataRow
        '    dsnewrow1 = ds2.Tables(0).NewRow
        '    With dsnewrow2
        '        .Item("QUESTIONID") = ds1.Tables(0).Rows(0).Item(0)
        '        .Item("ANSWER") = row.Cells(0).Value
        '        .Item("ISCORRECT") = IIf(row.Cells(1).Value, 1, 0)
        '    End With
        '    ds2.Tables(0).Rows.Add(dsnewrow2)
        '    database.SaveEntry(ds2)
        'Next
        MsgBox("Successfully saved.")
    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub
End Class