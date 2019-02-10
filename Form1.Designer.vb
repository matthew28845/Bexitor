<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighlightColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutBasicTextEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources._new
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.load
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.favicon__3_
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.UndoToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.cut
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.copy
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.paste
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.favicon_16_
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.favicon_17_
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.TextColorToolStripMenuItem, Me.HighlightColorToolStripMenuItem, Me.WordWrapToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.textblack
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'TextColorToolStripMenuItem
        '
        Me.TextColorToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.text
        Me.TextColorToolStripMenuItem.Name = "TextColorToolStripMenuItem"
        Me.TextColorToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TextColorToolStripMenuItem.Text = "Text Color"
        '
        'HighlightColorToolStripMenuItem
        '
        Me.HighlightColorToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.bg
        Me.HighlightColorToolStripMenuItem.Name = "HighlightColorToolStripMenuItem"
        Me.HighlightColorToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.HighlightColorToolStripMenuItem.Text = "Highlight Color"
        '
        'WordWrapToolStripMenuItem
        '
        Me.WordWrapToolStripMenuItem.Checked = True
        Me.WordWrapToolStripMenuItem.CheckOnClick = True
        Me.WordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WordWrapToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.favicon_18_
        Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.WordWrapToolStripMenuItem.Text = "Word Wrap"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebsiteToolStripMenuItem, Me.AboutBasicTextEditorToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'WebsiteToolStripMenuItem
        '
        Me.WebsiteToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.favicon_5_
        Me.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem"
        Me.WebsiteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WebsiteToolStripMenuItem.Text = "Website"
        '
        'AboutBasicTextEditorToolStripMenuItem
        '
        Me.AboutBasicTextEditorToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.favicon_6_
        Me.AboutBasicTextEditorToolStripMenuItem.Name = "AboutBasicTextEditorToolStripMenuItem"
        Me.AboutBasicTextEditorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutBasicTextEditorToolStripMenuItem.Text = "About Bexitor"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AcceptsTab = True
        Me.RichTextBox1.AutoWordSelection = True
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.EnableAutoDragDrop = True
        Me.RichTextBox1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ShowSelectionMargin = True
        Me.RichTextBox1.Size = New System.Drawing.Size(800, 426)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(660, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Image = Global.Bexitor.My.Resources.Resources.favicon__4_
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Bexitor - New File"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents WebsiteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AboutBasicTextEditorToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TextColorToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HighlightColorToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OnToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OffToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
End Class
