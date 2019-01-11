Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Nama As String = TextBox1.Text
        Dim NIM As String = TextBox2.Text

        If Nama = String.Empty Then
            MessageBox.Show("Enter Your Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NIM = String.Empty Then
            MessageBox.Show("Enter Your NIM!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Nama <> String.Empty Then
            Form3.Show()
            Me.Hide()
        End If

        Form3.TextBox7.Text = Nama
        Form3.TextBox6.Text = NIM

    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
        If IsNumeric(TextBox2.Text) = False Then
            MsgBox("Maaf Data Yang anda masukkan harus angka...!", vbInformation)

        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

End Class
