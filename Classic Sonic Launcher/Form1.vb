Public Class Form1

    Public Counter = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sonic1.Click
        Dim info As New ProcessStartInfo()
        info.FileName = Application.StartupPath + "\sonic 1\RSDKv4_64_rev02.exe"
        info.WorkingDirectory = Application.StartupPath + "\sonic 1"
        info.Arguments = ""
        Process.Start(info)
        My.Computer.Audio.Play(My.Resources.ring, AudioPlayMode.Background)
        Threading.Thread.Sleep(750)
        Me.Close()
    End Sub

    Private Sub Sonic2_Click(sender As Object, e As EventArgs) Handles Sonic2.Click
        Dim info As New ProcessStartInfo()
        info.FileName = Application.StartupPath + "\sonic 2\RSDKv4_64_rev02.exe"
        info.WorkingDirectory = Application.StartupPath + "\sonic 2"
        info.Arguments = ""
        Process.Start(info)
        My.Computer.Audio.Play(My.Resources.ring, AudioPlayMode.Background)
        Threading.Thread.Sleep(750)
        Me.Close()
    End Sub

    Private Sub Sonic3_Click(sender As Object, e As EventArgs) Handles Sonic3.Click
        Dim info As New ProcessStartInfo()
        info.FileName = Application.StartupPath + "\sonic 3\sonic3air.exe"
        info.WorkingDirectory = Application.StartupPath + "\sonic 3"
        info.Arguments = ""
        Process.Start(info)
        My.Computer.Audio.Play(My.Resources.ring, AudioPlayMode.Background)
        Threading.Thread.Sleep(750)
        Me.Close()
    End Sub

    Private Sub SonicCD_Click(sender As Object, e As EventArgs) Handles SonicCD.Click
        Dim info As New ProcessStartInfo()
        info.FileName = Application.StartupPath + "\sonic CD\RSDKv3_64.exe"
        info.WorkingDirectory = Application.StartupPath + "\sonic cd"
        info.Arguments = ""
        Process.Start(info)
        My.Computer.Audio.Play(My.Resources.ring, AudioPlayMode.Background)
        Threading.Thread.Sleep(750)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles SonicMania.Click
        Dim info As New ProcessStartInfo()
        info.FileName = Application.StartupPath + "\sonic Mania\sonicmania.exe"
        info.WorkingDirectory = Application.StartupPath + "\sonic mania"
        info.Arguments = ""
        Process.Start(info)
        My.Computer.Audio.Play(My.Resources.ring, AudioPlayMode.Background)
        Threading.Thread.Sleep(750)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


        Counter = Counter + 1
        If Counter = 5 Then My.Computer.Audio.Play(My.Resources.ring, AudioPlayMode.Background)
        If Counter = 5 Then Form2.Show()
        If Counter = 6 Then Counter = 1
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub
End Class
