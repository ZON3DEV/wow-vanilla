<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernAlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerzeichnisseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonfigurationsdateienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NsTabControl1 = New Configuration.NSTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.NsTextBox1 = New Configuration.NSTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NsTextBox2 = New Configuration.NSTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.NsTextBox3 = New Configuration.NSTextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.NsTextBox4 = New Configuration.NSTextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.NsTextBox5 = New Configuration.NSTextBox()
        Me.ButtonBlue1 = New Configuration.ButtonBlue()
        Me.ButtonBlue2 = New Configuration.ButtonBlue()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.NsTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.EinstellungenToolStripMenuItem, Me.ToolBoxToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(861, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem, Me.SpeichernAlsToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ÖffnenToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ÖffnenToolStripMenuItem.Text = "&Öffnen"
        '
        'SpeichernAlsToolStripMenuItem
        '
        Me.SpeichernAlsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SpeichernAlsToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.SpeichernAlsToolStripMenuItem.Name = "SpeichernAlsToolStripMenuItem"
        Me.SpeichernAlsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SpeichernAlsToolStripMenuItem.Text = "&Speichern als..."
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BeendenToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerzeichnisseToolStripMenuItem, Me.KonfigurationsdateienToolStripMenuItem})
        Me.EinstellungenToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'VerzeichnisseToolStripMenuItem
        '
        Me.VerzeichnisseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.VerzeichnisseToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.VerzeichnisseToolStripMenuItem.Name = "VerzeichnisseToolStripMenuItem"
        Me.VerzeichnisseToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.VerzeichnisseToolStripMenuItem.Text = "Verzeichnisse"
        '
        'KonfigurationsdateienToolStripMenuItem
        '
        Me.KonfigurationsdateienToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.KonfigurationsdateienToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.KonfigurationsdateienToolStripMenuItem.Name = "KonfigurationsdateienToolStripMenuItem"
        Me.KonfigurationsdateienToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.KonfigurationsdateienToolStripMenuItem.Text = "Konfigurationsdateien"
        '
        'ToolBoxToolStripMenuItem
        '
        Me.ToolBoxToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.ToolBoxToolStripMenuItem.Name = "ToolBoxToolStripMenuItem"
        Me.ToolBoxToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ToolBoxToolStripMenuItem.Text = "ToolBox"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜberToolStripMenuItem})
        Me.HilfeToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'ÜberToolStripMenuItem
        '
        Me.ÜberToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ÜberToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.ÜberToolStripMenuItem.Name = "ÜberToolStripMenuItem"
        Me.ÜberToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ÜberToolStripMenuItem.Text = "Über..."
        '
        'NsTabControl1
        '
        Me.NsTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.NsTabControl1.Controls.Add(Me.TabPage1)
        Me.NsTabControl1.Controls.Add(Me.TabPage2)
        Me.NsTabControl1.Controls.Add(Me.TabPage3)
        Me.NsTabControl1.Controls.Add(Me.TabPage4)
        Me.NsTabControl1.Controls.Add(Me.TabPage5)
        Me.NsTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.NsTabControl1.ItemSize = New System.Drawing.Size(28, 115)
        Me.NsTabControl1.Location = New System.Drawing.Point(12, 27)
        Me.NsTabControl1.Multiline = True
        Me.NsTabControl1.Name = "NsTabControl1"
        Me.NsTabControl1.SelectedIndex = 0
        Me.NsTabControl1.Size = New System.Drawing.Size(837, 480)
        Me.NsTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.NsTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.PictureBox5)
        Me.TabPage1.Controls.Add(Me.PictureBox4)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.NsTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(119, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(714, 472)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Startseite"
        '
        'NsTextBox1
        '
        Me.NsTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox1.Enabled = False
        Me.NsTextBox1.Location = New System.Drawing.Point(3, 0)
        Me.NsTextBox1.MaxLength = 32767
        Me.NsTextBox1.Multiline = False
        Me.NsTextBox1.Name = "NsTextBox1"
        Me.NsTextBox1.ReadOnly = False
        Me.NsTextBox1.Size = New System.Drawing.Size(711, 472)
        Me.NsTextBox1.TabIndex = 0
        Me.NsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox1.UseSystemPasswordChar = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.NsTextBox2)
        Me.TabPage2.Location = New System.Drawing.Point(119, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(714, 472)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "AH Bot Config"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TextBox1.Location = New System.Drawing.Point(6, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(702, 461)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.WordWrap = False
        '
        'NsTextBox2
        '
        Me.NsTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox2.Enabled = False
        Me.NsTextBox2.Location = New System.Drawing.Point(2, 0)
        Me.NsTextBox2.MaxLength = 32767
        Me.NsTextBox2.Multiline = False
        Me.NsTextBox2.Name = "NsTextBox2"
        Me.NsTextBox2.ReadOnly = False
        Me.NsTextBox2.Size = New System.Drawing.Size(711, 472)
        Me.NsTextBox2.TabIndex = 1
        Me.NsTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox2.UseSystemPasswordChar = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.NsTextBox3)
        Me.TabPage3.Location = New System.Drawing.Point(119, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(714, 472)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "AI Bot Config"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TextBox2.Location = New System.Drawing.Point(6, 6)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(702, 461)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.WordWrap = False
        '
        'NsTextBox3
        '
        Me.NsTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox3.Enabled = False
        Me.NsTextBox3.Location = New System.Drawing.Point(2, 0)
        Me.NsTextBox3.MaxLength = 32767
        Me.NsTextBox3.Multiline = False
        Me.NsTextBox3.Name = "NsTextBox3"
        Me.NsTextBox3.ReadOnly = False
        Me.NsTextBox3.Size = New System.Drawing.Size(711, 472)
        Me.NsTextBox3.TabIndex = 1
        Me.NsTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox3.UseSystemPasswordChar = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.TextBox3)
        Me.TabPage4.Controls.Add(Me.NsTextBox4)
        Me.TabPage4.Location = New System.Drawing.Point(119, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(714, 472)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Realm Config"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TextBox3.Location = New System.Drawing.Point(6, 6)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(702, 461)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.WordWrap = False
        '
        'NsTextBox4
        '
        Me.NsTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox4.Enabled = False
        Me.NsTextBox4.Location = New System.Drawing.Point(2, 0)
        Me.NsTextBox4.MaxLength = 32767
        Me.NsTextBox4.Multiline = False
        Me.NsTextBox4.Name = "NsTextBox4"
        Me.NsTextBox4.ReadOnly = False
        Me.NsTextBox4.Size = New System.Drawing.Size(711, 472)
        Me.NsTextBox4.TabIndex = 1
        Me.NsTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox4.UseSystemPasswordChar = False
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.TextBox4)
        Me.TabPage5.Controls.Add(Me.NsTextBox5)
        Me.TabPage5.Location = New System.Drawing.Point(119, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(714, 472)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "World Config"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TextBox4.Location = New System.Drawing.Point(6, 6)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(702, 461)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.WordWrap = False
        '
        'NsTextBox5
        '
        Me.NsTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox5.Enabled = False
        Me.NsTextBox5.Location = New System.Drawing.Point(2, 0)
        Me.NsTextBox5.MaxLength = 32767
        Me.NsTextBox5.Multiline = False
        Me.NsTextBox5.Name = "NsTextBox5"
        Me.NsTextBox5.ReadOnly = False
        Me.NsTextBox5.Size = New System.Drawing.Size(711, 472)
        Me.NsTextBox5.TabIndex = 1
        Me.NsTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox5.UseSystemPasswordChar = False
        '
        'ButtonBlue1
        '
        Me.ButtonBlue1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBlue1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonBlue1.Image = Nothing
        Me.ButtonBlue1.Location = New System.Drawing.Point(755, 525)
        Me.ButtonBlue1.Name = "ButtonBlue1"
        Me.ButtonBlue1.NoRounding = False
        Me.ButtonBlue1.Size = New System.Drawing.Size(90, 36)
        Me.ButtonBlue1.TabIndex = 2
        Me.ButtonBlue1.Text = "Beenden"
        '
        'ButtonBlue2
        '
        Me.ButtonBlue2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBlue2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonBlue2.Image = Nothing
        Me.ButtonBlue2.Location = New System.Drawing.Point(12, 525)
        Me.ButtonBlue2.Name = "ButtonBlue2"
        Me.ButtonBlue2.NoRounding = False
        Me.ButtonBlue2.Size = New System.Drawing.Size(83, 31)
        Me.ButtonBlue2.TabIndex = 3
        Me.ButtonBlue2.Text = "Speichern"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(111, 525)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(107, 18)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Backup erstellen"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.Configuration.My.Resources.Resources.WIKI
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(480, 133)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(96, 29)
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Configuration.My.Resources.Resources.TRACKER
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(363, 133)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(96, 29)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Configuration.My.Resources.Resources.FORUM
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(245, 133)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(96, 29)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Configuration.My.Resources.Resources.ACTIVITY
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(128, 133)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 29)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Configuration.My.Resources.Resources.logo_white
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(194, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(318, 70)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(86, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 238)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(861, 576)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ButtonBlue2)
        Me.Controls.Add(Me.ButtonBlue1)
        Me.Controls.Add(Me.NsTabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MaNGOS Konfiguration"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.NsTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpeichernAlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerzeichnisseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KonfigurationsdateienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NsTabControl1 As NSTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents ButtonBlue1 As ButtonBlue
    Friend WithEvents NsTextBox1 As NSTextBox
    Friend WithEvents NsTextBox2 As NSTextBox
    Friend WithEvents NsTextBox3 As NSTextBox
    Friend WithEvents NsTextBox4 As NSTextBox
    Friend WithEvents NsTextBox5 As NSTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ButtonBlue2 As ButtonBlue
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
End Class
