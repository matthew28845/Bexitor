Imports System.IO
Imports System.IO.StreamReader
Public Class Form1
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("http://matthew28845.x10.mx/bexitor.html")
    End Sub

    Private Sub AboutBasicTextEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutBasicTextEditorToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If RichTextBox1.Modified = True Then
            Dim SaveOrNo As Integer
            SaveOrNo = MessageBox.Show("Would you like to save this document before creating a new one?", "Save document?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If SaveOrNo = Windows.Forms.DialogResult.Yes Then
                Dim SaveFile As SaveFileDialog = New SaveFileDialog()
                Dim File2Save As String
                SaveFile.Title = "Choose a location and name to save as."
                SaveFile.InitialDirectory = "%Documents%"
                SaveFile.Filter = "Rich text files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*"
                SaveFile.FilterIndex = 1
                SaveFile.RestoreDirectory = True
                If SaveFile.ShowDialog() = DialogResult.OK Then
                    File2Save = SaveFile.FileName
                    RichTextBox1.SaveFile(File2Save)
                    Me.Text = ("Bexitor =" & File2Save)
                End If
            ElseIf SaveOrNo = Windows.Forms.DialogResult.No Then
                RichTextBox1.Clear()
                Me.Text = "Bexitor - New File"
            End If
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFile As OpenFileDialog = New OpenFileDialog()
        Dim Filename As String
        Filename = "No file is being edited currently."
        OpenFile.Title = "Open a Text File"
        OpenFile.InitialDirectory = "%Documents%"
        OpenFile.Filter = "Rich text files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFile.FilterIndex = 1
        OpenFile.RestoreDirectory = True
        If OpenFile.ShowDialog() = DialogResult.OK Then
            If OpenFile.FileName.EndsWith(".rtf") Then
                Filename = OpenFile.FileName
                Me.Text = ("Bexitor - " & Filename)
                RichTextBox1.LoadFile(Filename, RichTextBoxStreamType.RichText)
            Else
                Filename = OpenFile.FileName
                Me.Text = ("Bexitor - " & Filename)
                RichTextBox1.LoadFile(Filename, RichTextBoxStreamType.PlainText)
            End If
        End If
    End Sub

    Private Sub DisplayCurrentFileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If RichTextBox1.Modified = True Then
            Dim SaveOrNo As Integer
            SaveOrNo = MessageBox.Show("Would you like to save this document before exiting Bexitor?", "Save document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If SaveOrNo = Windows.Forms.DialogResult.Yes Then
                Dim SaveFile As SaveFileDialog = New SaveFileDialog()
                Dim File2Save As String
                SaveFile.Title = "Choose a location and name to save as."
                SaveFile.InitialDirectory = "%Documents%"
                SaveFile.Filter = "Rich text files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*"
                SaveFile.FilterIndex = 1
                SaveFile.RestoreDirectory = True
                If SaveFile.ShowDialog() = DialogResult.OK Then
                    Close()
                End If
            Else
                Stop
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If Me.Text = "Bexitor - New File" Then
            Dim SaveFile As SaveFileDialog = New SaveFileDialog()
            Dim File2Save As String
            SaveFile.Title = "Choose a location and name to save as."
            SaveFile.InitialDirectory = "%Documents%"
            SaveFile.Filter = "Rich text files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*"
            SaveFile.FilterIndex = 1
            SaveFile.RestoreDirectory = True
            If SaveFile.ShowDialog() = DialogResult.OK Then
                File2Save = SaveFile.FileName
                RichTextBox1.SaveFile(File2Save)
                Me.Text = ("Bexitor - " & File2Save)
                Label1.Text = File2Save
            End If
        Else
            RichTextBox1.SaveFile(Label1.Text)
        End If
    End Sub

    Private Sub FormatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatToolStripMenuItem.Click

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim FontPicker As FontDialog = New FontDialog()
        FontPicker.Font = RichTextBox1.Font
        If FontPicker.ShowDialog() = DialogResult.OK Then
            Me.RichTextBox1.SelectionFont = FontPicker.Font
        End If
    End Sub

    Private Sub TextColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextColorToolStripMenuItem.Click
        Dim TextColor As ColorDialog = New ColorDialog()
        TextColor.AllowFullOpen = True
        TextColor.AnyColor = True
        TextColor.FullOpen = True
        If TextColor.ShowDialog() = DialogResult.OK Then
            Me.RichTextBox1.SelectionColor = TextColor.Color
        End If
    End Sub

    Private Sub HighlightColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighlightColorToolStripMenuItem.Click
        Dim BGColor As ColorDialog = New ColorDialog()
        BGColor.Color = Color.White
        BGColor.AllowFullOpen = True
        BGColor.AnyColor = True
        BGColor.FullOpen = True
        If BGColor.ShowDialog() = DialogResult.OK Then
            Me.RichTextBox1.SelectionBackColor = BGColor.Color
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub WordWrapToolStripMenuItem_EnabledChanged(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.EnabledChanged

    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        If WordWrapToolStripMenuItem.Checked = True Then
            RichTextBox1.WordWrap = True
        Else
            RichTextBox1.WordWrap = False
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFile As SaveFileDialog = New SaveFileDialog()
        Dim File2Save As String
        SaveFile.Title = "Choose a location and name to save as."
        SaveFile.InitialDirectory = "%Documents%"
        SaveFile.Filter = "Rich text files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveFile.FilterIndex = 1
        SaveFile.RestoreDirectory = True
        If SaveFile.ShowDialog() = DialogResult.OK Then
            File2Save = SaveFile.FileName
            RichTextBox1.SaveFile(File2Save)
            Me.Text = ("Bexitor - " & File2Save)
            Label1.Text = File2Save
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If RichTextBox1.Modified = True Then
            Dim SaveOrNo As Integer
            SaveOrNo = MessageBox.Show("Would you like to save this document before exiting Bexitor?", "Save document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If SaveOrNo = Windows.Forms.DialogResult.Yes Then
                Dim SaveFile As SaveFileDialog = New SaveFileDialog()
                Dim File2Save As String
                SaveFile.Title = "Choose a location and name to save as."
                SaveFile.InitialDirectory = "%Documents%"
                SaveFile.Filter = "Rich text files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*"
                SaveFile.FilterIndex = 1
                SaveFile.RestoreDirectory = True
                If SaveFile.ShowDialog() = DialogResult.OK Then
                    RichTextBox1.SaveFile(File2Save)
                End If
            End If
        End If
    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        RichTextBox1.ZoomFactor = (RichTextBox1.ZoomFactor + 0.1)
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        RichTextBox1.ZoomFactor = (RichTextBox1.ZoomFactor - 0.1)
    End Sub

    Private Sub ZoomTo100ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomTo100ToolStripMenuItem.Click
        RichTextBox1.ZoomFactor = 1
    End Sub
End Class