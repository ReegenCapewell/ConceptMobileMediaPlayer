Imports System.IO

Public Class mainProgram
    'Declaring public variables
    Public songName As String
    Public fileName As String

    'Add song button click = open add screen
    Private Sub btnAddSong_Click(sender As Object, e As EventArgs)
        Me.Hide()
        addScreen.Show()
    End Sub

    'On program load - show correct screen + buttons
    Private Sub mainProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        addScreen.Hide()
        helpScreen.Hide()
        picBoxPlay2.Hide()
    End Sub

    'Volume slider value determines the image displayed for the volume level (high, low and mute)
    Private Sub trkBarVol_Scroll(sender As Object, e As EventArgs) Handles trkBarVol.Scroll
        mediaPlayer.settings.volume = trkBarVol.Value
        txtBoxVolPerc.Text = trkBarVol.Value
        If trkBarVol.Value < 50 Then
            picBoxVolLo.Show()
            picBoxVolMute.Hide()
            picBoxVolHi.Hide()
        End If
        If trkBarVol.Value > 50 Then
            picBoxVolLo.Hide()
            picBoxVolMute.Hide()
            picBoxVolHi.Show()
        End If
        If trkBarVol.Value = 0 Then
            picBoxVolLo.Hide()
            picBoxVolMute.Show()
            picBoxVolHi.Hide()
        End If
    End Sub

    'First play button clicked sets the media player to play a song
    Private Sub picBoxPlay_Click(sender As Object, e As EventArgs) Handles picBoxPlay.Click
        picBoxPlay.Hide()
        picBoxPlay2.Show()
        mediaPlayer.URL = lstBoxMusic.SelectedItem
        mediaPlayer.Ctlcontrols.play()
        txtBoxPlayingNow.Text = songName
    End Sub

    'Second play button displayed after the first is clicked to allow for song to pause and uccesfully resume
    Private Sub picBoxPlay2_Click(sender As Object, e As EventArgs) Handles picBoxPlay2.Click
        If mediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused Then
            mediaPlayer.Ctlcontrols.play()
            picBoxPlay2.Image = My.Resources.pause_button_512
            txtBoxPlayingNow.Text = songName
        ElseIf mediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            picBoxPlay2.Image = My.Resources._8i65B8AXT
            mediaPlayer.Ctlcontrols.pause()
            txtBoxPlayingNow.Text = songName
        End If
    End Sub

    'Next song button when clicked loops in increments of +1 through song list
    Private Sub picBoxNxtSong_Click(sender As Object, e As EventArgs) Handles picBoxNxtSong.Click
        picBoxPlay.Image = My.Resources.pause_button_512
        picBoxPlay.Show()
        If lstBoxMusic.SelectedIndex < lstBoxMusic.Items.Count - 1 Then
            lstBoxMusic.SelectedIndex = lstBoxMusic.SelectedIndex + 1
            mediaPlayer.URL = lstBoxMusic.Text
            songName = lstBoxMusic.SelectedItem
            songName = (Path.GetFileNameWithoutExtension(songName))
            lstBoxMusic.Text = songName
        ElseIf lstBoxMusic.SelectedIndex = lstBoxMusic.Items.Count - 1 Then
            lstBoxMusic.SelectedIndex = lstBoxMusic.TopIndex
            songName = lstBoxMusic.SelectedItem
            songName = (Path.GetFileNameWithoutExtension(songName))
            lstBoxMusic.Text = songName
        End If
    End Sub

    'When the user selects a different song display the name of the new song
    Private Sub lstBoxMusic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxMusic.SelectedIndexChanged
        picBoxPlay2.Hide()
        songName = lstBoxMusic.SelectedItem
        songName = (Path.GetFileNameWithoutExtension(songName))
        txtBoxPlayingNow.Text = songName
    End Sub

    'Previous song button when clicked loops in increments of -1 through song list
    Private Sub picBoxPrevSong_Click(sender As Object, e As EventArgs) Handles picBoxPrevSong.Click
        picBoxPlay.Image = My.Resources.pause_button_512
        picBoxPlay.Show()
        If lstBoxMusic.SelectedIndex < lstBoxMusic.Items.Count Then
            lstBoxMusic.SelectedIndex = lstBoxMusic.SelectedIndex - 1
            mediaPlayer.URL = lstBoxMusic.Text
            lstBoxMusic.Text = songName
        End If
        If lstBoxMusic.SelectedIndex < lstBoxMusic.TopIndex Then
            lstBoxMusic.SelectedIndex = lstBoxMusic.Items.Count - 1
            lstBoxMusic.Text = songName
        End If
    End Sub

    Private Sub picBoxHelp_Click(sender As Object, e As EventArgs) Handles picBoxHelp.Click
        Me.Hide()
        helpScreen.Show()
    End Sub

    Private Sub picBoxAdd_Click(sender As Object, e As EventArgs) Handles picBoxAdd.Click
        Me.Hide()
        addScreen.Show()
    End Sub
End Class
