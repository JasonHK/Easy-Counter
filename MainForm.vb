Imports MouseKeyboardActivityMonitor
Imports MouseKeyboardActivityMonitor.WinApi

Public Class MainForm

    Dim CounterValue As Integer = 0
    Dim WithEvents KeyboardListener As New KeyboardHookListener(New AppHooker())

    Private Sub CounterChange(ByVal ValueChange As Integer)

        If CounterValue = 0 And ValueChange <= -1 Then
            CounterValue = 0
        ElseIf CounterValue = 99 And ValueChange >= 1 Then
            CounterValue = 99
        Else
            CounterValue = CounterValue + ValueChange
        End If

        CounterLabel.Text = String.Format("{0:00}", CounterValue)

    End Sub

    Private Sub ResetMenuItem_Click(sender As Object, e As EventArgs) Handles ResetMenuItem.Click

        CounterValue = 0
        CounterLabel.Text = String.Format("{0:00}", CounterValue)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        KeyboardListener.Start()

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        KeyboardListener.Stop()
        KeyboardListener.Dispose()

    End Sub

    Private Sub KeyboardListener_KeyDown(sender As Object, e As KeyEventArgs) Handles KeyboardListener.KeyDown

        If e.KeyCode = Keys.Down Then
            DownPictureBox.Image = My.Resources.ArrowD3
        ElseIf e.KeyCode = Keys.Up Then
            UpPictureBox.Image = My.Resources.ArrowU3
        End If

    End Sub

    Private Sub KeyboardListener_KeyUp(sender As Object, e As KeyEventArgs) Handles KeyboardListener.KeyUp

        If e.KeyCode = Keys.Down Then
            CounterChange(-1)
            DownPictureBox.Image = My.Resources.ArrowD1
        ElseIf e.KeyCode = Keys.Up Then
            CounterChange(1)
            UpPictureBox.Image = My.Resources.ArrowU1
        End If

    End Sub

    Private Sub DownPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles DownPictureBox.MouseEnter

        DownPictureBox.Image = My.Resources.ArrowD2

    End Sub

    Private Sub DownPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DownPictureBox.MouseDown

        DownPictureBox.Image = My.Resources.ArrowD3

    End Sub

    Private Sub DownPictureBox_MouseUp(sender As Object, e As MouseEventArgs) Handles DownPictureBox.MouseUp

        CounterChange(-1)
        DownPictureBox.Image = My.Resources.ArrowD2

    End Sub

    Private Sub DownPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles DownPictureBox.MouseLeave

        DownPictureBox.Image = My.Resources.ArrowD1

    End Sub

    Private Sub UpPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles UpPictureBox.MouseEnter

        UpPictureBox.Image = My.Resources.ArrowU2

    End Sub

    Private Sub UpPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles UpPictureBox.MouseDown

        UpPictureBox.Image = My.Resources.ArrowU3

    End Sub

    Private Sub UpPictureBox_MouseUp(sender As Object, e As MouseEventArgs) Handles UpPictureBox.MouseUp

        CounterChange(1)
        UpPictureBox.Image = My.Resources.ArrowU2

    End Sub

    Private Sub UpPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles UpPictureBox.MouseLeave

        UpPictureBox.Image = My.Resources.ArrowU1

    End Sub
End Class
