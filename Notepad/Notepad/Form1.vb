Public Class Form1

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' OpenFileDialog1.
        End If


    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If RichTextBox1.Modified Then
            'If the text of notepad changed, the program will ask the user if they want to save the changes
            Dim ask As MsgBoxResult
            ask = MsgBox("Do you want to save the changes", MsgBoxStyle.YesNoCancel, "New Document")
            If ask = MsgBoxResult.No Then
                RichTextBox1.Clear()
            ElseIf ask = MsgBoxResult.Cancel Then
            ElseIf ask = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                RichTextBox1.Clear()
            End If
            'If textbox's text is still the same, notepad will open a new page:
        Else
            RichTextBox1.Clear()
        End If
    End Sub

   
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Developed By Abhishek Choudhary" & vbNewLine & vbNewLine &
                         "Copyright TheCrazyProgrammer.Com")
    End Sub
End Class
