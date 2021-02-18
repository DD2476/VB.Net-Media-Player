Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'edit the names if you need to

        If Not (Form1.ofd1.ShowDialog = DialogResult.Cancel) Then

            Form1.player.URL = Form1.ofd1.FileName

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form1.player.Ctlcontrols.play()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Form1.player.Ctlcontrols.pause()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Form1.player.Ctlcontrols.stop()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            Form1.FormBorderStyle = FormBorderStyle.None
            Form1.WindowState = FormWindowState.Maximized

        Else

            Form1.FormBorderStyle = FormBorderStyle.FixedDialog
            Form1.WindowState = FormWindowState.Normal

        End If

    End Sub

    Private Sub always_Tick(sender As Object, e As EventArgs) Handles always.Tick

        Me.Opacity = VScrollBar1.Value / 100

    End Sub

End Class