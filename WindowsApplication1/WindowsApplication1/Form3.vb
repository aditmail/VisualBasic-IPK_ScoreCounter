Imports System.IO

Public Class Form3
    Public fr As StreamReader
    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        MenuStrip1.Enabled = False
        inputBoxEnable(True)
        ComboBox1.Focus()
        buttonSaveCancel(True)
    End Sub

    Sub inputBoxEnable(ByVal s As Boolean)
        'clear input textbox
        GroupBox1.Visible = s
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
    Sub buttonSaveCancel(ByVal s As Boolean)
        ToolStrip1.Items(0).Enabled = s
        ToolStrip1.Items(1).Enabled = s
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        GroupBox1.Visible = False
        inputBoxEnable(False)
        MenuStrip1.Enabled = True
        buttonSaveCancel(False)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim f1, f2, f3, f4, f5, f6, f7 As String
        Dim fs As StreamWriter

        f1 = TextBox1.Text
        f2 = TextBox2.Text
        f3 = TextBox3.Text
        f4 = TextBox4.Text
        f5 = TextBox5.Text
        f6 = TextBox7.Text
        f7 = TextBox6.Text

        If ComboBox1.SelectedItem = "Sistem Informasi" Then
            fs = New StreamWriter("SI.txt", True)
            fs.WriteLine(f6 & "," & f7 & "," & f1 & "," & f2 & "," & f3 & "," & f4 & "," & f5)
            fs.Close()
        ElseIf ComboBox1.SelectedItem = "Teknik Informatika" Then
            fs = New StreamWriter("TIF.txt", True)
            fs.WriteLine(f6 & "," & f7 & "," & f1 & "," & f2 & "," & f3 & "," & f4 & "," & f5)
            fs.Close()
        ElseIf ComboBox1.SelectedItem = "Teknik Industri" Then
            fs = New StreamWriter("TEKIN.txt", True)
            fs.WriteLine(f6 & "," & f7 & "," & f1 & "," & f2 & "," & f3 & "," & f4 & "," & f5)
            fs.Close()
        ElseIf ComboBox1.SelectedItem = "Ilmu dan Teknologi Pangan" Then
            fs = New StreamWriter("ITP.txt", True)
            fs.WriteLine(f6 & "," & f7 & "," & f1 & "," & f2 & "," & f3 & "," & f4 & "," & f5)
            fs.Close()
        ElseIf ComboBox1.SelectedItem = "Teknik Lingkungan" Then
            fs = New StreamWriter("TEKLING.txt", True)
            fs.WriteLine(f6 & "," & f7 & "," & f1 & "," & f2 & "," & f3 & "," & f4 & "," & f5)
            fs.Close()
        ElseIf ComboBox1.SelectedItem = "Teknik Sipil" Then
            fs = New StreamWriter("TEKSIL.txt", True)
            fs.WriteLine(f6 & "," & f7 & "," & f1 & "," & f2 & "," & f3 & "," & f4 & "," & f5)
            fs.Close()
        ElseIf ComboBox1.SelectedItem = "Akuntansi" Then
            fs = New StreamWriter("AKUN.txt", True)
            fs.WriteLine(f6 & "," & f7 & "," & f1 & "," & f2 & "," & f3 & "," & f4 & "," & f5)
            fs.Close()
        ElseIf ComboBox1.SelectedItem = "Hubungan Internasional" Then
            fs = New StreamWriter("HI.txt", True)
            fs.WriteLine(f6 & "," & f7 & "," & f1 & "," & f2 & "," & f3 & "," & f4 & "," & f5)
            fs.Close()
        ElseIf ComboBox1.SelectedItem = "Manajemen" Then
            fs = New StreamWriter("MENE.txt", True)
            fs.WriteLine(f6 & "," & f7 & "," & f1 & "," & f2 & "," & f3 & "," & f4 & "," & f5)
            fs.Close()
        ElseIf ComboBox1.SelectedItem = "Ilmu Komunikasi" Then
            fs = New StreamWriter("ILKOM.txt", True)
            fs.WriteLine(f6 & "," & f7 & "," & f1 & "," & f2 & "," & f3 & "," & f4 & "," & f5)
            fs.Close()
        End If


        MessageBox.Show("1 New Added Record ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        inputBoxEnable(False)
        buttonSaveCancel(False)
        MenuStrip1.Enabled = True

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim y As String

        y = MessageBox.Show("Are You Sure Want to Quit ?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If y = vbYes Then
            Me.Close()
        End If
    End Sub


    Private Sub SistemInformasiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SistemInformasiToolStripMenuItem.Click
        Form2.Close()
        fr = New StreamReader("SI.txt")
        Form2.Show()
    End Sub

    Private Sub TeknikInformatikaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TeknikInformatikaToolStripMenuItem.Click
        Form2.Close()
        fr = New StreamReader("TIF.txt")
        Form2.Show()
    End Sub

    Private Sub TeknikIndustriToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TeknikIndustriToolStripMenuItem.Click
        Form2.Close()
        fr = New StreamReader("TEKIN.txt")
        Form2.Show()
    End Sub

    Private Sub IlmuDanTeknologiPanganToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IlmuDanTeknologiPanganToolStripMenuItem.Click
        Form2.Close()
        fr = New StreamReader("ITP.txt")
        Form2.Show()
    End Sub

    Private Sub TeknikSipilToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TeknikSipilToolStripMenuItem.Click
        Form2.Close()
        fr = New StreamReader("TEKSIL.txt")
        Form2.Show()
    End Sub

    Private Sub TeknikLingkunganToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TeknikLingkunganToolStripMenuItem.Click
        Form2.Close()
        fr = New StreamReader("TEKLING.txt")
        Form2.Show()
    End Sub

    Private Sub AkuntansiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AkuntansiToolStripMenuItem.Click
        Form2.Close()
        fr = New StreamReader("AKUN.txt")
        Form2.Show()
    End Sub

    Private Sub HIToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HIToolStripMenuItem.Click
        Form2.Close()
        fr = New StreamReader("HI.txt")
        Form2.Show()
    End Sub

    Private Sub ManajemenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManajemenToolStripMenuItem.Click
        Form2.Close()
        fr = New StreamReader("MENE.txt")
        Form2.Show()
    End Sub

    Private Sub IlmuKomunikasiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IlmuKomunikasiToolStripMenuItem.Click
        Form2.Close()
        fr = New StreamReader("ILKOM.txt")
        Form2.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Form4.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click

    End Sub

    Private Sub InputNilaiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InputNilaiToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub MelihatDataNilaiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MelihatDataNilaiToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub SistemGradeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SistemGradeToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox1.Focus()
    End Sub
End Class