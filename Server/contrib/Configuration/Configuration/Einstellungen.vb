Imports System.Windows.Forms
Imports System.IO
Public Class Einstellungen

    Private Sub OK_Button_Click_1(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            Dim cnf1 As String = File.ReadAllText(NsTextBox1.Text)
            Form1.TextBox1.Text = cnf1

            Dim cnf2 As String = File.ReadAllText(NsTextBox2.Text)
            Form1.TextBox2.Text = cnf2

            Dim cnf3 As String = File.ReadAllText(NsTextBox3.Text)
            Form1.TextBox3.Text = cnf3

            Dim cnf4 As String = File.ReadAllText(NsTextBox4.Text)
            Form1.TextBox4.Text = cnf4
        Catch ex As Exception

        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click_1(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonBlue1_Click(sender As Object, e As EventArgs) Handles ButtonBlue1.Click
        ofd.FileName = "ahbot.conf"
        If ofd.ShowDialog = DialogResult.OK Then
            NsTextBox1.Text = ofd.FileName
            My.Settings.pathAH = NsTextBox1.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub ButtonBlue2_Click(sender As Object, e As EventArgs) Handles ButtonBlue2.Click
        ofd.FileName = "aiplayerbot.conf"
        If ofd.ShowDialog = DialogResult.OK Then
            NsTextBox2.Text = ofd.FileName
            My.Settings.pathAI = NsTextBox2.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub ButtonBlue3_Click(sender As Object, e As EventArgs) Handles ButtonBlue3.Click
        ofd.FileName = "realmd.conf"
        If ofd.ShowDialog = DialogResult.OK Then
            NsTextBox3.Text = ofd.FileName
            My.Settings.pathRLM = NsTextBox3.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub ButtonBlue4_Click(sender As Object, e As EventArgs) Handles ButtonBlue4.Click
        ofd.FileName = "mangosd.conf"
        If ofd.ShowDialog = DialogResult.OK Then
            NsTextBox4.Text = ofd.FileName
            My.Settings.pathWRLD = NsTextBox4.Text
            My.Settings.Save()
        End If
    End Sub
End Class
