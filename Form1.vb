﻿Imports System.IO
Imports System.IO.StreamReader
Public Class Form1
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("http://matthew28845.x10.mx/work.html")
    End Sub

    Private Sub AboutBasicTextEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutBasicTextEditorToolStripMenuItem.Click
        MsgBox("Bexitor, basic text editor 
Version 1.3.1 by Matthew Sigmond (matthew28845)
Some icons by Nick Nakashima
Built on January 8, 2019
Bexitor is free software.")
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
		If RichTextBox1.Modified = True Then
			Dim SaveOrNo As Integer
			SaveOrNo = MessageBox.Show("The current document is not saved. Would you like to save it before continuing?", "Save document?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
			If SaveOrNo = Windows.Forms.DialogResult.Yes Then
				Dim SaveFile As SaveFileDialog = New SaveFileDialog()
				Dim File2Save As String
				SaveFile.Title = "Choose a location and name to save as."
				SaveFile.InitialDirectory = "%Documents%"
				SaveFile.Filter = "Rich text files (*.rtf)|*.rtf"
				SaveFile.FilterIndex = 1
				SaveFile.RestoreDirectory = True
				If SaveFile.ShowDialog() = DialogResult.OK Then
					File2Save = SaveFile.FileName
					RichTextBox1.SaveFile(File2Save)
					Me.Text = ("Bexitor =" & File2Save)
				End If
			ElseIf SaveOrNo = Windows.Forms.DialogResult.No Then
				RichTextBox1.Clear()
			Else

			End If
		End If
	End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFile As OpenFileDialog = New OpenFileDialog()
		Dim Filename As String
		Filename = "No file is being edited currently."
        OpenFile.Title = "Open a Text File"
        OpenFile.InitialDirectory = "%Documents%"
        OpenFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFile.FilterIndex = 1
        OpenFile.RestoreDirectory = True
        If OpenFile.ShowDialog() = DialogResult.OK Then
            Filename = OpenFile.FileName
            Me.Text = ("Bexitor - " & Filename)
			RichTextBox1.LoadFile(Filename, RichTextBoxStreamType.PlainText)
		End If
    End Sub

    Private Sub DisplayCurrentFileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim SaveFile As SaveFileDialog = New SaveFileDialog()
        Dim File2Save As String
        SaveFile.Title = "Choose a location and name to save as."
        SaveFile.InitialDirectory = "%Documents%"
        SaveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveFile.FilterIndex = 1
        SaveFile.RestoreDirectory = True
        If SaveFile.ShowDialog() = DialogResult.OK Then
            File2Save = SaveFile.FileName
            My.Computer.FileSystem.WriteAllText(File2Save, RichTextBox1.Text, False)
            Me.Text = ("Bexitor - " & File2Save)
        End If
    End Sub

    Private Sub FormatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatToolStripMenuItem.Click

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim FontPicker As FontDialog = New FontDialog()
        If FontPicker.ShowDialog() = DialogResult.OK Then
			Me.RichTextBox1.Font = FontPicker.Font
		End If
    End Sub

    Private Sub TextColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextColorToolStripMenuItem.Click
        Dim TextColor As ColorDialog = New ColorDialog()
        TextColor.AllowFullOpen = True
        TextColor.AnyColor = True
        TextColor.FullOpen = True
        If TextColor.ShowDialog() = DialogResult.OK Then
			Me.RichTextBox1.ForeColor = TextColor.Color
		End If
    End Sub

    Private Sub HighlightColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighlightColorToolStripMenuItem.Click
        Dim BGColor As ColorDialog = New ColorDialog()
        BGColor.Color = Color.White
        BGColor.AllowFullOpen = True
        BGColor.AnyColor = True
        BGColor.FullOpen = True
        If BGColor.ShowDialog() = DialogResult.OK Then
			Me.RichTextBox1.BackColor = BGColor.Color
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

	Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)
		RichTextBox1.Find("ling")
	End Sub
End Class