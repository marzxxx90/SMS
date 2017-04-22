Public Class frmMain


    Friend Sub NotYetLogin(Optional ByVal st As Boolean = True)
   
    End Sub

    Private Sub btnTextPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTextPromo.Click
        CLoseForms("frmTextPromo")

        frmTextPromo.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(frmTextPromo)
        frmTextPromo.Show()
    End Sub

    Private Sub btnTextMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTextMessage.Click
    
        CLoseForms("frmTextMessages")

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
            CLoseForms("frmLogin")
          
            MsgBox("Thank you!", MsgBoxStyle.Information)
            NotYetLogin()
            frmLogin.Show()
        End If
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        CLoseForms("frmRegister")
        frmRegister.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(frmRegister)
        frmRegister.Show()
    End Sub
End Class
