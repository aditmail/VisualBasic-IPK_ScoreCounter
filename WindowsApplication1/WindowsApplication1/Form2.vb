Imports System.IO

Public Class Form2
    
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fr As StreamReader
        Dim f() As String
        Dim rec As String

        Dim uts As Double
        Dim uas As Double
        Dim tugas As Double

        Dim finalScore As Double
        Dim grade As String

        fr = Form3.fr
        DataGridView1.Rows.Clear()
        DataGridView1.ColumnCount = 9
        DataGridView1.Columns(0).Name = "Name"
        DataGridView1.Columns(1).Name = "NIM"
        DataGridView1.Columns(2).Name = "Course Name"
        DataGridView1.Columns(3).Name = "Number of Credits"
        DataGridView1.Columns(4).Name = "Assignment"
        DataGridView1.Columns(5).Name = "UTS"
        DataGridView1.Columns(6).Name = "UAS"
        DataGridView1.Columns(7).Name = "Number of IP"
        DataGridView1.Columns(8).Name = "Grade"



        Do While Not fr.EndOfStream
            rec = fr.ReadLine()
            f = rec.Split(",")

            If Val(f(4)) <= 45 Then
                tugas = 0.0
            ElseIf Val(f(4)) <= 50 Then
                tugas = 1.0
            ElseIf Val(f(4)) <= 60 Then
                tugas = 2.0
            ElseIf Val(f(4)) <= 65 Then
                tugas = 2.33
            ElseIf Val(f(4)) <= 70 Then
                tugas = 2.67
            ElseIf Val(f(4)) <= 75 Then
                tugas = 3.0
            ElseIf Val(f(4)) <= 80 Then
                tugas = 3.33
            ElseIf Val(f(4)) <= 85 Then
                tugas = 3.67
            Else : tugas = 4.0
            End If

            If Val(f(5)) <= 45 Then
                uts = 0.0
            ElseIf Val(f(5)) <= 50 Then
                uts = 1.0
            ElseIf Val(f(5)) <= 60 Then
                uts = 2.0
            ElseIf Val(f(5)) <= 65 Then
                uts = 2.33
            ElseIf Val(f(5)) <= 70 Then
                uts = 2.67
            ElseIf Val(f(5)) <= 75 Then
                uts = 3.0
            ElseIf Val(f(5)) <= 80 Then
                uts = 3.33
            ElseIf Val(f(5)) <= 85 Then
                uts = 3.67
            Else : uts = 4.0
            End If

            If Val(f(6)) <= 45 Then
                uas = 0.0
            ElseIf Val(f(6)) <= 50 Then
                uas = 1.0
            ElseIf Val(f(6)) <= 60 Then
                uas = 2.0
            ElseIf Val(f(6)) <= 65 Then
                uas = 2.33
            ElseIf Val(f(6)) <= 70 Then
                uas = 2.67
            ElseIf Val(f(6)) <= 75 Then
                uas = 3.0
            ElseIf Val(f(6)) <= 80 Then
                uas = 3.33
            ElseIf Val(f(6)) <= 85 Then
                uas = 3.67
            Else : uas = 4.0
            End If

            finalScore = (Val(tugas) + Val(uts) + Val(uas)) / 3

            If finalScore <= 0 Then
                grade = "E"
            ElseIf finalScore <= 1.0 Then
                grade = "D"
            ElseIf finalScore <= 2.0 Then
                grade = "c"
            ElseIf finalScore <= 2.33 Then
                grade = "C+"
            ElseIf finalScore <= 2.67 Then
                grade = "B-"
            ElseIf finalScore <= 3.0 Then
                grade = "B"
            ElseIf finalScore <= 3.33 Then
                grade = "B+"
            ElseIf finalScore <= 3.67 Then
                grade = "A-"
            Else : grade = "A"
            End If

            rec += "," & FormatNumber(finalScore)
            rec += "," & grade
            f = rec.Split(",")
            DataGridView1.Rows.Add(f)
        Loop
        fr.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox1.Focus()
    End Sub

End Class