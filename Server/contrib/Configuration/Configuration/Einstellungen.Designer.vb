<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einstellungen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New Configuration.ButtonBlue()
        Me.Cancel_Button = New Configuration.ButtonBlue()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NsTextBox1 = New Configuration.NSTextBox()
        Me.ButtonBlue1 = New Configuration.ButtonBlue()
        Me.ButtonBlue2 = New Configuration.ButtonBlue()
        Me.NsTextBox2 = New Configuration.NSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonBlue3 = New Configuration.ButtonBlue()
        Me.NsTextBox3 = New Configuration.NSTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonBlue4 = New Configuration.ButtonBlue()
        Me.NsTextBox4 = New Configuration.NSTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(322, 353)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(173, 30)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK_Button.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.OK_Button.Image = Nothing
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.NoRounding = False
        Me.OK_Button.Size = New System.Drawing.Size(80, 24)
        Me.OK_Button.TabIndex = 1
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Cancel_Button.Image = Nothing
        Me.Cancel_Button.Location = New System.Drawing.Point(89, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.NoRounding = False
        Me.Cancel_Button.Size = New System.Drawing.Size(81, 24)
        Me.Cancel_Button.TabIndex = 2
        Me.Cancel_Button.Text = " Abbrechen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AH Bot Config:"
        '
        'NsTextBox1
        '
        Me.NsTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox1.Enabled = False
        Me.NsTextBox1.Location = New System.Drawing.Point(25, 47)
        Me.NsTextBox1.MaxLength = 32767
        Me.NsTextBox1.Multiline = False
        Me.NsTextBox1.Name = "NsTextBox1"
        Me.NsTextBox1.ReadOnly = True
        Me.NsTextBox1.Size = New System.Drawing.Size(407, 23)
        Me.NsTextBox1.TabIndex = 2
        Me.NsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox1.UseSystemPasswordChar = False
        '
        'ButtonBlue1
        '
        Me.ButtonBlue1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBlue1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonBlue1.Image = Nothing
        Me.ButtonBlue1.Location = New System.Drawing.Point(449, 47)
        Me.ButtonBlue1.Name = "ButtonBlue1"
        Me.ButtonBlue1.NoRounding = False
        Me.ButtonBlue1.Size = New System.Drawing.Size(29, 23)
        Me.ButtonBlue1.TabIndex = 3
        Me.ButtonBlue1.Text = "..."
        '
        'ButtonBlue2
        '
        Me.ButtonBlue2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBlue2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonBlue2.Image = Nothing
        Me.ButtonBlue2.Location = New System.Drawing.Point(449, 115)
        Me.ButtonBlue2.Name = "ButtonBlue2"
        Me.ButtonBlue2.NoRounding = False
        Me.ButtonBlue2.Size = New System.Drawing.Size(29, 23)
        Me.ButtonBlue2.TabIndex = 6
        Me.ButtonBlue2.Text = "..."
        '
        'NsTextBox2
        '
        Me.NsTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox2.Enabled = False
        Me.NsTextBox2.Location = New System.Drawing.Point(25, 115)
        Me.NsTextBox2.MaxLength = 32767
        Me.NsTextBox2.Multiline = False
        Me.NsTextBox2.Name = "NsTextBox2"
        Me.NsTextBox2.ReadOnly = True
        Me.NsTextBox2.Size = New System.Drawing.Size(407, 23)
        Me.NsTextBox2.TabIndex = 5
        Me.NsTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox2.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "AI Player Bot Config:"
        '
        'ButtonBlue3
        '
        Me.ButtonBlue3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBlue3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonBlue3.Image = Nothing
        Me.ButtonBlue3.Location = New System.Drawing.Point(449, 187)
        Me.ButtonBlue3.Name = "ButtonBlue3"
        Me.ButtonBlue3.NoRounding = False
        Me.ButtonBlue3.Size = New System.Drawing.Size(29, 23)
        Me.ButtonBlue3.TabIndex = 9
        Me.ButtonBlue3.Text = "..."
        '
        'NsTextBox3
        '
        Me.NsTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox3.Enabled = False
        Me.NsTextBox3.Location = New System.Drawing.Point(25, 187)
        Me.NsTextBox3.MaxLength = 32767
        Me.NsTextBox3.Multiline = False
        Me.NsTextBox3.Name = "NsTextBox3"
        Me.NsTextBox3.ReadOnly = True
        Me.NsTextBox3.Size = New System.Drawing.Size(407, 23)
        Me.NsTextBox3.TabIndex = 8
        Me.NsTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox3.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Realm Config:"
        '
        'ButtonBlue4
        '
        Me.ButtonBlue4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBlue4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonBlue4.Image = Nothing
        Me.ButtonBlue4.Location = New System.Drawing.Point(449, 261)
        Me.ButtonBlue4.Name = "ButtonBlue4"
        Me.ButtonBlue4.NoRounding = False
        Me.ButtonBlue4.Size = New System.Drawing.Size(29, 23)
        Me.ButtonBlue4.TabIndex = 12
        Me.ButtonBlue4.Text = "..."
        '
        'NsTextBox4
        '
        Me.NsTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox4.Enabled = False
        Me.NsTextBox4.Location = New System.Drawing.Point(25, 261)
        Me.NsTextBox4.MaxLength = 32767
        Me.NsTextBox4.Multiline = False
        Me.NsTextBox4.Name = "NsTextBox4"
        Me.NsTextBox4.ReadOnly = True
        Me.NsTextBox4.Size = New System.Drawing.Size(407, 23)
        Me.NsTextBox4.TabIndex = 11
        Me.NsTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox4.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "World Config:"
        '
        'ofd
        '
        Me.ofd.Filter = "Konfigurationsdatei|*.conf|Distributionsdatei|*.dist|Alle Dateitypen|*.*"
        '
        'Einstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(507, 395)
        Me.Controls.Add(Me.ButtonBlue4)
        Me.Controls.Add(Me.NsTextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonBlue3)
        Me.Controls.Add(Me.NsTextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonBlue2)
        Me.Controls.Add(Me.NsTextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonBlue1)
        Me.Controls.Add(Me.NsTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Einstellungen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Einstellungen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As ButtonBlue
    Friend WithEvents Cancel_Button As ButtonBlue
    Friend WithEvents Label1 As Label
    Friend WithEvents NsTextBox1 As NSTextBox
    Friend WithEvents ButtonBlue1 As ButtonBlue
    Friend WithEvents ButtonBlue2 As ButtonBlue
    Friend WithEvents NsTextBox2 As NSTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonBlue3 As ButtonBlue
    Friend WithEvents NsTextBox3 As NSTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonBlue4 As ButtonBlue
    Friend WithEvents NsTextBox4 As NSTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ofd As OpenFileDialog
End Class
