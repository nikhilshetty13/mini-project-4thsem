Public Class Form1
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles cancelbutton.Click
        Me.Close() 'closes form'
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles minimizebutton.Click
        Me.WindowState = FormWindowState.Minimized 'minimizes form'
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles maximizebutton.Click
        If WindowState = FormWindowState.Normal Then  'maximizes or normalizes form'
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles Menubutton.Click
        If Panel1.Width = 247 Then
            Timer2.Enabled = True
        ElseIf Panel1.Width <= 60 Then
            Timer1.Enabled = True
        End If
    End Sub


    Private Sub BunifuImageButton2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub header_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If Panel1.Width >= 247 Then
            Me.Timer1.Enabled = False
        Else
            Me.Panel1.Width = Panel1.Width + 10
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Panel1.Width <= 50 Then
            Me.Timer2.Enabled = False
        Else
            Me.Panel1.Width = Panel1.Width - 10
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BunifuCustomLabel4_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel4.Click

    End Sub

    Private Sub GunaLineTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_3(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BunifuFlatButton5_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click

    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click

    End Sub
End Class
