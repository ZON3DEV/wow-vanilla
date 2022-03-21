Imports System.IO
Imports System.Net
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Einstellungen.NsTextBox1.Text = My.Settings.pathAH
        Einstellungen.NsTextBox2.Text = My.Settings.pathAI
        Einstellungen.NsTextBox3.Text = My.Settings.pathRLM
        Einstellungen.NsTextBox4.Text = My.Settings.pathWRLD
        CheckBox1.CheckState = My.Settings.BackUP
    End Sub

    Private Sub ButtonBlue1_Click(sender As Object, e As EventArgs) Handles ButtonBlue1.Click
        End
    End Sub

    Private Sub SpeichernAlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernAlsToolStripMenuItem.Click
        If NsTabControl1.SelectedTab Is TabPage2 Then
            Try
                My.Computer.FileSystem.CopyFile(Einstellungen.NsTextBox1.Text, Einstellungen.NsTextBox1.Text & ".dist")
            Catch ex As Exception

            End Try
            Dim Writer As New StreamWriter(Einstellungen.NsTextBox1.Text, False)
            Writer.Write(TextBox1.Text)
            Writer.Close()
        End If
        If NsTabControl1.SelectedTab Is TabPage3 Then
            Try
                My.Computer.FileSystem.CopyFile(Einstellungen.NsTextBox2.Text, Einstellungen.NsTextBox2.Text & ".dist")
            Catch ex As Exception

            End Try
            Dim Writer As New StreamWriter(Einstellungen.NsTextBox2.Text, False)
            Writer.Write(TextBox2.Text)
            Writer.Close()
        End If
        If NsTabControl1.SelectedTab Is TabPage4 Then
            Try
                My.Computer.FileSystem.CopyFile(Einstellungen.NsTextBox3.Text, Einstellungen.NsTextBox3.Text & ".dist")
            Catch ex As Exception

            End Try
            Dim Writer As New StreamWriter(Einstellungen.NsTextBox3.Text, False)
            Writer.Write(TextBox3.Text)
            Writer.Close()
        End If
        If NsTabControl1.SelectedTab Is TabPage5 Then
            Try
                My.Computer.FileSystem.CopyFile(Einstellungen.NsTextBox4.Text, Einstellungen.NsTextBox4.Text & ".dist")
            Catch ex As Exception

            End Try
            Dim Writer As New StreamWriter(Einstellungen.NsTextBox4.Text, False)
            Writer.Write(TextBox4.Text)
            Writer.Close()
        End If
    End Sub

    Private Sub ButtonBlue2_Click(sender As Object, e As EventArgs) Handles ButtonBlue2.Click
        If CheckBox1.Checked = True Then
            If NsTabControl1.SelectedTab Is TabPage2 Then
                Dim Writer As New StreamWriter("ahbot.conf", False)
                Writer.Write(TextBox1.Text)
                Writer.Close()
            End If
            If NsTabControl1.SelectedTab Is TabPage3 Then
                Dim Writer As New StreamWriter("aiplayerbot.conf", False)
                Writer.Write(TextBox2.Text)
                Writer.Close()
            End If
            If NsTabControl1.SelectedTab Is TabPage4 Then
                Dim Writer As New StreamWriter("realmd.conf", False)
                Writer.Write(TextBox3.Text)
                Writer.Close()
            End If
            If NsTabControl1.SelectedTab Is TabPage5 Then
                Dim Writer As New StreamWriter("mangosd.conf", False)
                Writer.Write(TextBox4.Text)
                Writer.Close()
            End If
        Else
            If NsTabControl1.SelectedTab Is TabPage2 Then
                Dim Writer As New StreamWriter("ahbot.conf", False)
                Writer.Write(TextBox1.Text)
                Writer.Close()
            End If
            If NsTabControl1.SelectedTab Is TabPage3 Then
                Dim Writer As New StreamWriter("aiplayerbot.conf", False)
                Writer.Write(TextBox2.Text)
                Writer.Close()
            End If
            If NsTabControl1.SelectedTab Is TabPage4 Then
                Dim Writer As New StreamWriter("realmd.conf", False)
                Writer.Write(TextBox3.Text)
                Writer.Close()
            End If
            If NsTabControl1.SelectedTab Is TabPage5 Then
                Dim Writer As New StreamWriter("mangosd.conf", False)
                Writer.Write(TextBox4.Text)
                Writer.Close()
            End If
        End If
    End Sub

    Private Sub KonfigurationsdateienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KonfigurationsdateienToolStripMenuItem.Click
        Einstellungen.ShowDialog()
    End Sub
End Class
