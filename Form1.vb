Imports System.IO
Imports System.IO.StreamReader
Public Class Form1

    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("http://matthew28845.x10.mx/bexitor.html")
    End Sub

    Private Sub AboutBasicTextEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutBasicTextEditorToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If RichTextBox1.Modified = True Then
            Dim SaveOrNo As Integer
            SaveOrNo = MessageBox.Show("Would you like to save this document before creating a new one?", "Save document?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If SaveOrNo = Windows.Forms.DialogResult.Yes Then
                Dim SaveFile As SaveFileDialog = New SaveFileDialog()
                Dim File2Save As String
                Dim FontStyle As String
                SaveFile.Title = "Choose a location and name to save as."

                SaveFile.InitialDirectory = "%Documents%"
                SaveFile.Filter = "Rich text files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*"
                SaveFile.FilterIndex = 1
                SaveFile.RestoreDirectory = True
                If SaveFile.ShowDialog() = DialogResult.OK Then
                    File2Save = SaveFile.FileName
                    RichTextBox1.SaveFile(File2Save)
                    Me.Text = ("Bexitor =" & File2Save)
                    ToolStripStatusLabel1.Text = File2Save
                    If SaveFile.FileName.EndsWith(".rtf") Then
                        ToolStripStatusLabel1.Text = File2Save
                        ToolStripStatusLabel6.Text = RichTextBox1.SelectionFont.Name & ", " & FontStyle & ", " & Math.Round(RichTextBox1.SelectionFont.SizeInPoints) & "pt"
                    ElseIf SaveFile.FileName Then
                        ToolStripStatusLabel1.Text = File2Save
                        ToolStripStatusLabel2.Text = "Plain Text"
                        If RichTextBox1.SelectionFont.Style = 0 Then
                            FontStyle = "Regular"
                        ElseIf RichTextBox1.SelectionFont.Style = 1 Then
                            FontStyle = "Bold"
                        ElseIf RichTextBox1.SelectionFont.Style = 2 Then
                            ToolStripStatusLabel2.Text = "Rich Text"
                            If RichTextBox1.SelectionFont.Style = 0 Then
                                FontStyle = "Regular"
                            ElseIf RichTextBox1.SelectionFont.Style = 1 Then
                                FontStyle = "Bold"
                            ElseIf RichTextBox1.SelectionFont.Style = 2 Then
                                FontStyle = "Italic"
                            Else
                                FontStyle = "Bold And Italic"
                            End If
                        End If
                        ToolStripStatusLabel6.Text = RichTextBox1.SelectionFont.Name & ", " & FontStyle & ", " & Math.Round(RichTextBox1.SelectionFont.SizeInPoints) & "pt"
                    Else
                        ToolStripStatusLabel1.Text = File2Save
                        ToolStripStatusLabel2.Text = "Plain Text"
                        If RichTextBox1.SelectionFont.Style = 0 Then
                            FontStyle = "Regular"
                        ElseIf RichTextBox1.SelectionFont.Style = 1 Then
                            FontStyle = "Bold"
                        ElseIf RichTextBox1.SelectionFont.Style = 2 Then
                            FontStyle = "Italic"
                        Else
                            FontStyle = "Bold And Italic"
                        End If
                        ToolStripStatusLabel6.Text = RichTextBox1.SelectionFont.Name & ", " & FontStyle & ", " & Math.Round(RichTextBox1.SelectionFont.SizeInPoints) & "pt"
                    End If
                ElseIf SaveOrNo = Windows.Forms.DialogResult.No Then
                    RichTextBox1.Clear()
                    Me.Text = "Bexitor - New File"
                    ToolStripStatusLabel1.Text = "New File"
                    If RichTextBox1.Rtf = True Then
                        ToolStripStatusLabel2.Text = "Rich Text"
                    Else
                        ToolStripStatusLabel2.Text = "Plain Text"
                    End If
                End If
            Else
                Dim FontStyle As String
                RichTextBox1.Clear()
                ToolStripStatusLabel1.Text = "New File"
                ToolStripStatusLabel2.Text = "Plain Text"
                If RichTextBox1.SelectionFont.Style = 0 Then
                    FontStyle = "Regular"
                ElseIf RichTextBox1.SelectionFont.Style = 1 Then
                    FontStyle = "Bold"
                ElseIf RichTextBox1.SelectionFont.Style = 2 Then
                    FontStyle = "Italic"
                Else
                    FontStyle = "Bold And Italic"
                End If
                ToolStripStatusLabel6.Text = RichTextBox1.SelectionFont.Name & ", " & FontStyle & ", " & Math.Round(RichTextBox1.SelectionFont.SizeInPoints) & "pt"
                Label1.Text = "new"
            End If
        Else
            Dim FontStyle As String
            RichTextBox1.Clear()
            ToolStripStatusLabel1.Text = "New File"
            ToolStripStatusLabel2.Text = "Plain Text"
            If RichTextBox1.SelectionFont.Style = 0 Then
                FontStyle = "Regular"
            ElseIf RichTextBox1.SelectionFont.Style = 1 Then
                FontStyle = "Bold"
            ElseIf RichTextBox1.SelectionFont.Style = 2 Then
                FontStyle = "Italic"
            Else
                FontStyle = "Bold And Italic"
            End If
            ToolStripStatusLabel6.Text = RichTextBox1.SelectionFont.Name & ", " & FontStyle & ", " & Math.Round(RichTextBox1.SelectionFont.SizeInPoints) & "pt"
            Label1.Text = "new"
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFile As OpenFileDialog = New OpenFileDialog()
        Dim Filename As String
        Dim FontStyle As String
        Filename = "No file is being edited currently."
        OpenFile.Title = "Open a Text File"
        OpenFile.InitialDirectory = "%Documents%"
        OpenFile.Filter = "Rich text files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFile.FilterIndex = 3
        OpenFile.RestoreDirectory = True
        If OpenFile.ShowDialog() = DialogResult.OK Then
            If OpenFile.FileName.EndsWith(".rtf") Then
                Filename = OpenFile.FileName
                Me.Text = ("Bexitor - " & Filename)
                RichTextBox1.LoadFile(Filename, RichTextBoxStreamType.RichText)
                ToolStripStatusLabel1.Text = Filename
                ToolStripStatusLabel2.Text = "Rich Text"
                If RichTextBox1.SelectionFont.Style = 0 Then
                    FontStyle = "Regular"
                ElseIf RichTextBox1.SelectionFont.Style = 1 Then
                    FontStyle = "Bold"
                ElseIf RichTextBox1.SelectionFont.Style = 2 Then
                    FontStyle = "Italic"
                Else
                    FontStyle = "Bold And Italic"
                End If
                ToolStripStatusLabel6.Text = RichTextBox1.SelectionFont.Name & ", " & FontStyle & ", " & Math.Round(RichTextBox1.SelectionFont.SizeInPoints) & "pt"
                Label1.Text = Filename
            Else
                Filename = OpenFile.FileName
                Me.Text = ("Bexitor - " & Filename)
                RichTextBox1.LoadFile(Filename, RichTextBoxStreamType.PlainText)
                ToolStripStatusLabel1.Text = Filename
                ToolStripStatusLabel2.Text = "Plain Text"
                If RichTextBox1.SelectionFont.Style = 0 Then
                    FontStyle = "Regular"
                ElseIf RichTextBox1.SelectionFont.Style = 1 Then
                    FontStyle = "Bold"
                ElseIf RichTextBox1.SelectionFont.Style = 2 Then
                    FontStyle = "Italic"
                Else
                    FontStyle = "Bold And Italic"
                End If
                ToolStripStatusLabel6.Text = RichTextBox1.SelectionFont.Name & ", " & FontStyle & ", " & Math.Round(RichTextBox1.SelectionFont.SizeInPoints) & "pt"
                Label1.Text = Filename
            End If
        End If
    End Sub

    Public Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If Label1.Text = "new" Then
            Dim SaveFile As SaveFileDialog = New SaveFileDialog()
            Dim File2Save As String
            File2Save = ""
            SaveFile.Title = "Choose a location and name to save as."
            SaveFile.InitialDirectory = "%Documents%"
            SaveFile.Filter = "Rich text files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*"
            SaveFile.FilterIndex = 1
            SaveFile.RestoreDirectory = True
            If SaveFile.ShowDialog() = DialogResult.OK Then
                File2Save = SaveFile.FileName
                If SaveFile.FileName.EndsWith(".rtf") Then
                    RichTextBox1.SaveFile(File2Save)
                Else
                    My.Computer.FileSystem.WriteAllText(File2Save, RichTextBox1.Text, False)
                End If
                Me.Text = ("Bexitor - " & File2Save)
                Label1.Text = File2Save
            End If
        Else
            If Label1.Text.EndsWith("rtf") Then
                RichTextBox1.SaveFile(Label1.Text)
            Else
                My.Computer.FileSystem.WriteAllText(Label1.Text, RichTextBox1.Text, False)
            End If
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim FontPicker As FontDialog = New FontDialog()
        FontPicker.Font = RichTextBox1.Font
        If FontPicker.ShowDialog() = DialogResult.OK Then
            Me.RichTextBox1.SelectionFont = FontPicker.Font
            ToolStripStatusLabel2.Text = "Rich Text"
        End If
    End Sub

    Private Sub TextColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextColorToolStripMenuItem.Click
        Dim TextColor As ColorDialog = New ColorDialog()
        TextColor.AllowFullOpen = True
        TextColor.AnyColor = True
        TextColor.FullOpen = True
        If TextColor.ShowDialog() = DialogResult.OK Then
            Me.RichTextBox1.SelectionColor = TextColor.Color
            ToolStripStatusLabel2.Text = "Rich Text"
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
            ToolStripStatusLabel2.Text = "Rich Text"
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
            If SaveFile.FileName.EndsWith(".rtf") Then
                RichTextBox1.SaveFile(File2Save)
            Else
                My.Computer.FileSystem.WriteAllText(File2Save, RichTextBox1.Text, False)
            End If
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
        Dim ZoomPercent As Integer
        If RichTextBox1.ZoomFactor < 63.867 Then
            RichTextBox1.ZoomFactor = (RichTextBox1.ZoomFactor + 0.1)
            ZoomPercent = Math.Round(RichTextBox1.ZoomFactor * 100)
            ToolStripStatusLabel5.Text = (ZoomPercent & "% Zoom")
        End If
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        Dim ZoomPercent As Integer
        If RichTextBox1.ZoomFactor > 0.115 Then
            RichTextBox1.ZoomFactor = (RichTextBox1.ZoomFactor - 0.1)
            ZoomPercent = Math.Round(RichTextBox1.ZoomFactor * 100)
            ToolStripStatusLabel5.Text = (ZoomPercent & "% Zoom")
        End If
    End Sub

    Private Sub ZoomTo100ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomTo100ToolStripMenuItem.Click
        RichTextBox1.ZoomFactor = 1
        ToolStripStatusLabel5.Text = "100% Zoom"
    End Sub

    Private Sub RichTextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles RichTextBox1.SelectionChanged
        Dim FontStyle As String
        If RichTextBox1.SelectionFont.Style = 0 Then
            FontStyle = "Regular"
        ElseIf RichTextBox1.SelectionFont.Style = 1 Then
            FontStyle = "Bold"
        ElseIf RichTextBox1.SelectionFont.Style = 2 Then
            FontStyle = "Italic"
        Else
            FontStyle = "Bold And Italic"
        End If
        ToolStripStatusLabel6.Text = RichTextBox1.SelectionFont.Name & ", " & FontStyle & ", " & Math.Round(RichTextBox1.SelectionFont.SizeInPoints) & "pt"
        Dim index As Int32 = RichTextBox1.SelectionStart
        Dim currentline As Int32 = RichTextBox1.GetLineFromCharIndex(index) + 1
        Dim currentcolumn As Int32 = index - RichTextBox1.GetFirstCharIndexOfCurrentLine() + 1
        ToolStripStatusLabel7.Text = "Ln " & currentline & ", Col " & currentcolumn
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        Dim ImageChosen As Image
        Dim PickImage = New OpenFileDialog
        Dim oldClipBoard = Clipboard.GetDataObject
        PickImage.Filter = "Common image files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*"
        If PickImage.ShowDialog() = DialogResult.OK Then
            ImageChosen = Image.FromFile(PickImage.FileName)
            Clipboard.SetImage(ImageChosen)
            RichTextBox1.Paste()
            Clipboard.SetDataObject(oldClipBoard)
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

End Class