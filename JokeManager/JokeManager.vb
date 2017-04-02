'DEVELOPED BY HAMZA AKIOUR (HTTPS://WWW.HAMZA.ES)
Imports System.Runtime.InteropServices
Public Class JokeManager

    Private Sub btnblocksys_Click(sender As Object, e As EventArgs) Handles btnblocksys.Click
        screenfake()
    End Sub

    Private Sub butpoweroff_Click(sender As Object, e As EventArgs) Handles butpoweroff.Click
        poweroff()
    End Sub

    Private Sub btnscream_Click(sender As Object, e As EventArgs) Handles btnscream.Click
        screamfake()
    End Sub

    Sub screenfake()
        'SCREEN FAKE: LAUNCH A SCREENSHOT OF THE ACTUAL STATE OF MACHINE (ON FULLSCREEN)...
        Me.Visible = False
        'Making route path of desktop
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        'Doing the screenshot
        'Only take screenshot of primary screen
        Me.Visible = False
        Threading.Thread.Sleep(500)
        Dim screenshot As New System.Drawing.Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        Dim graph As Graphics = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(0, 0, 0, 0, screenshot.Size)

        'Make new form whit actual screen as background
        fullscreen(screenshot)
        'Exit app on 1 min
        preventiontimer.Enabled = True
    End Sub

    Sub fullscreen(thisscreen)
        'DO A FULLSCREEN WHIT THE IMAGE RECEIVED (ON VAR "thisscreen")
        Dim DesktopForm As New Form

        'Set size of form (full screen size)
        DesktopForm.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        'Put the image as background
        DesktopForm.BackgroundImage = thisscreen
        'show the form on screen
        DesktopForm.Show()

        'Quit the borders on form
        DesktopForm.FormBorderStyle = DesktopForm.FormBorderStyle.None
        'Maximize the new form
        'First minimized, and then force maximized (if only maximized, when user have minimized the program, not work)
        DesktopForm.WindowState = FormWindowState.Minimized
        DesktopForm.WindowState = FormWindowState.Maximized
    End Sub

    Sub poweroff()
        'POWER OFF THE COMPUTER: POWER OFF THE MACHINE...

        'ask time for countdown
        Dim timeshutd As String = InputBox("Countdown (in sec)", "It's the time ;)", "0").Trim
        'No value = canceled
        If timeshutd = vbNullString Then
            'Aborted
        Else
            Me.Visible = False
            'if is numeric and not negative number
            If IsNumeric(timeshutd) And timeshutd >= 0 Then
                Process.Start("cmd", "/c shutdown -s -c "" "" -t " & timeshutd)
            Else
                MessageBox.Show("Omg!, ¿You don't understand what are sec? ¡Seconds!", "Stupid...")
            End If
            'Exit app on 1 min
            preventiontimer.Enabled = True
        End If
    End Sub

    Sub screamfake()
        'SCREAM FAKE: LAUNCH A ONE IMAGE + PLAY A SOUND FOR SCARE USER

        'ask time for countdown
        Dim timeshutd As String = InputBox("Countdown (in sec)", "It's the time ;)", "0").Trim
        'No value = canceled
        If timeshutd = vbNullString Then
            'Aborted
        Else
            Me.Visible = False
            'Do the countdown
            Threading.Thread.Sleep(timeshutd * 1000)
            'UP volume of sistem, do that function for 99 times for sure te new volume is 100%
            For i = 0 To 99
                SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
            Next
            'TRY to play audio (3 diferents ways for make sure)
            Try
                My.Computer.Audio.Play(My.Resources.scream, AudioPlayMode.WaitToComplete)
            Catch ex As Exception
                Try
                    AxWindowsMediaPlayer1.URL = CurDir() & "\scream.wav"
                    'AxWindowsMediaPlayer1.Ctlcontrols.play()
                Catch ax As Exception
                    Try
                        My.Computer.Audio.Play(CurDir() & "\scream.wav", AudioPlayMode.WaitToComplete)
                    Catch ix As Exception
                    End Try
                End Try
            End Try
            'Get one number random (1 to 3), and then select a terror image
            Randomize()
            Dim value As Integer = CInt(Int((3 * Rnd()) + 1))
            Select Case value
                Case "1"
                    fullscreen(My.Resources.Resources.terror1)
                Case "2"
                    fullscreen(My.Resources.Resources.terror2)
                Case "3"
                    fullscreen(My.Resources.Resources.terror3)
            End Select
            'Exit app on 1 min
            preventiontimer.Enabled = True
        End If
    End Sub
    'VOLUME FUNCTION, NOT DEVELOPED BY ME
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA

    Private Sub preventiontimer_Tick(sender As Object, e As EventArgs) Handles preventiontimer.Tick
        Application.Exit()
    End Sub

    Private Sub JokeManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

