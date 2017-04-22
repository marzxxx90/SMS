Public Class frmMain


    Friend Sub NotYetLogin(Optional ByVal st As Boolean = True)
   
    End Sub

    Private Sub btnTextPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTextPromo.Click
        Dim formNames As New List(Of String)
        For Each Form In My.Application.OpenForms
            If Form.Name <> "frmMain" Or Not Form.name <> "frmTextPromo" Then
                formNames.Add(Form.Name)
            End If
        Next

        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next

        frmTextPromo.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(frmTextPromo)
        frmTextPromo.Show()
    End Sub

    Private Sub btnTextMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTextMessage.Click
        Dim formNames As New List(Of String)
        For Each Form In My.Application.OpenForms
            If Form.Name <> "frmMain" Or Not Form.name <> "frmTextMessages" Then
                formNames.Add(Form.Name)
            End If
        Next

        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next

        frmTextMessages.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(frmTextMessages)
        frmTextMessages.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        If LoginToolStripMenuItem.Text = "&Login" Then
            frmLogin.Show()
        Else
            Dim ans As DialogResult = MsgBox("Do you want to LOGOUT?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Logout")
            If ans = Windows.Forms.DialogResult.No Then Exit Sub

            Dim formNames As New List(Of String)
            For Each Form In My.Application.OpenForms
                If Form.Name <> "frmMain" Or Not Form.name <> "frmLogin" Then
                    formNames.Add(Form.Name)
                End If
            Next
            For Each currentFormName As String In formNames
                Application.OpenForms(currentFormName).Close()
            Next
            MsgBox("Thank you!", MsgBoxStyle.Information)
            NotYetLogin()
            frmLogin.Show()
        End If
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim formNames As New List(Of String)
        For Each Form In My.Application.OpenForms
            If Form.Name <> "frmMain" Or Not Form.name <> "frmRegister" Then
                formNames.Add(Form.Name)
            End If
        Next

        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next

        frmRegister.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(frmRegister)
        frmRegister.Show()
    End Sub
End Class
