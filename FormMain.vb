Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formHome = New FormHome()
        switchForm(formHome)
    End Sub
    Private Sub switchForm(form As Form)
        pnlMain.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        pnlMain.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub
End Class
