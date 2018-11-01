<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainProgram
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainProgram))
        Me.mediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.txtBoxPlayingNow = New System.Windows.Forms.TextBox()
        Me.lblMusic = New System.Windows.Forms.Label()
        Me.trkBarVol = New System.Windows.Forms.TrackBar()
        Me.txtBoxVolPerc = New System.Windows.Forms.TextBox()
        Me.picBoxVolMute = New System.Windows.Forms.PictureBox()
        Me.picBoxVolLo = New System.Windows.Forms.PictureBox()
        Me.picBoxVolHi = New System.Windows.Forms.PictureBox()
        Me.picBoxNxtSong = New System.Windows.Forms.PictureBox()
        Me.picBoxPlay = New System.Windows.Forms.PictureBox()
        Me.picBoxPause = New System.Windows.Forms.PictureBox()
        Me.picBoxPrevSong = New System.Windows.Forms.PictureBox()
        Me.lstBoxMusic = New System.Windows.Forms.ListBox()
        Me.picBoxPlay2 = New System.Windows.Forms.PictureBox()
        Me.AddScreenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picBoxHelp = New System.Windows.Forms.PictureBox()
        Me.picBoxAdd = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radBtnLight = New System.Windows.Forms.RadioButton()
        Me.radBtnDark = New System.Windows.Forms.RadioButton()
        CType(Me.mediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBarVol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxVolMute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxVolLo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxVolHi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxNxtSong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxPrevSong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxPlay2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddScreenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mediaPlayer
        '
        Me.mediaPlayer.Enabled = True
        Me.mediaPlayer.Location = New System.Drawing.Point(12, 12)
        Me.mediaPlayer.Name = "mediaPlayer"
        Me.mediaPlayer.OcxState = CType(resources.GetObject("mediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mediaPlayer.Size = New System.Drawing.Size(260, 196)
        Me.mediaPlayer.TabIndex = 0
        '
        'txtBoxPlayingNow
        '
        Me.txtBoxPlayingNow.Location = New System.Drawing.Point(12, 216)
        Me.txtBoxPlayingNow.Name = "txtBoxPlayingNow"
        Me.txtBoxPlayingNow.ReadOnly = True
        Me.txtBoxPlayingNow.Size = New System.Drawing.Size(260, 20)
        Me.txtBoxPlayingNow.TabIndex = 11
        '
        'lblMusic
        '
        Me.lblMusic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMusic.AutoSize = True
        Me.lblMusic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMusic.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMusic.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblMusic.Location = New System.Drawing.Point(13, 361)
        Me.lblMusic.Name = "lblMusic"
        Me.lblMusic.Size = New System.Drawing.Size(45, 26)
        Me.lblMusic.TabIndex = 13
        Me.lblMusic.Text = "Music"
        '
        'trkBarVol
        '
        Me.trkBarVol.Location = New System.Drawing.Point(45, 313)
        Me.trkBarVol.Maximum = 100
        Me.trkBarVol.Name = "trkBarVol"
        Me.trkBarVol.Size = New System.Drawing.Size(190, 45)
        Me.trkBarVol.TabIndex = 24
        '
        'txtBoxVolPerc
        '
        Me.txtBoxVolPerc.Location = New System.Drawing.Point(242, 313)
        Me.txtBoxVolPerc.Name = "txtBoxVolPerc"
        Me.txtBoxVolPerc.ReadOnly = True
        Me.txtBoxVolPerc.Size = New System.Drawing.Size(30, 20)
        Me.txtBoxVolPerc.TabIndex = 25
        '
        'picBoxVolMute
        '
        Me.picBoxVolMute.Image = Global.UniversalMobileMediaPlayer.My.Resources.Resources.sound_volume_speaker_audio_music_mute_512
        Me.picBoxVolMute.Location = New System.Drawing.Point(13, 313)
        Me.picBoxVolMute.Name = "picBoxVolMute"
        Me.picBoxVolMute.Size = New System.Drawing.Size(26, 32)
        Me.picBoxVolMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxVolMute.TabIndex = 23
        Me.picBoxVolMute.TabStop = False
        '
        'picBoxVolLo
        '
        Me.picBoxVolLo.Image = Global.UniversalMobileMediaPlayer.My.Resources.Resources.Volume_Low_512
        Me.picBoxVolLo.Location = New System.Drawing.Point(13, 313)
        Me.picBoxVolLo.Name = "picBoxVolLo"
        Me.picBoxVolLo.Size = New System.Drawing.Size(26, 32)
        Me.picBoxVolLo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxVolLo.TabIndex = 22
        Me.picBoxVolLo.TabStop = False
        '
        'picBoxVolHi
        '
        Me.picBoxVolHi.Image = Global.UniversalMobileMediaPlayer.My.Resources.Resources.speaker_1_512
        Me.picBoxVolHi.Location = New System.Drawing.Point(13, 313)
        Me.picBoxVolHi.Name = "picBoxVolHi"
        Me.picBoxVolHi.Size = New System.Drawing.Size(26, 32)
        Me.picBoxVolHi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxVolHi.TabIndex = 21
        Me.picBoxVolHi.TabStop = False
        '
        'picBoxNxtSong
        '
        Me.picBoxNxtSong.Image = Global.UniversalMobileMediaPlayer.My.Resources.Resources._1098_fast_forward_outline_button_icon
        Me.picBoxNxtSong.Location = New System.Drawing.Point(179, 249)
        Me.picBoxNxtSong.Name = "picBoxNxtSong"
        Me.picBoxNxtSong.Size = New System.Drawing.Size(56, 58)
        Me.picBoxNxtSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxNxtSong.TabIndex = 20
        Me.picBoxNxtSong.TabStop = False
        '
        'picBoxPlay
        '
        Me.picBoxPlay.Image = Global.UniversalMobileMediaPlayer.My.Resources.Resources._8i65B8AXT
        Me.picBoxPlay.Location = New System.Drawing.Point(107, 241)
        Me.picBoxPlay.Name = "picBoxPlay"
        Me.picBoxPlay.Size = New System.Drawing.Size(66, 66)
        Me.picBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxPlay.TabIndex = 19
        Me.picBoxPlay.TabStop = False
        '
        'picBoxPause
        '
        Me.picBoxPause.Image = Global.UniversalMobileMediaPlayer.My.Resources.Resources.pause_button_512
        Me.picBoxPause.Location = New System.Drawing.Point(107, 241)
        Me.picBoxPause.Name = "picBoxPause"
        Me.picBoxPause.Size = New System.Drawing.Size(66, 66)
        Me.picBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxPause.TabIndex = 18
        Me.picBoxPause.TabStop = False
        '
        'picBoxPrevSong
        '
        Me.picBoxPrevSong.BackColor = System.Drawing.SystemColors.Control
        Me.picBoxPrevSong.Cursor = System.Windows.Forms.Cursors.Default
        Me.picBoxPrevSong.Image = Global.UniversalMobileMediaPlayer.My.Resources.Resources._5175
        Me.picBoxPrevSong.Location = New System.Drawing.Point(45, 249)
        Me.picBoxPrevSong.Name = "picBoxPrevSong"
        Me.picBoxPrevSong.Size = New System.Drawing.Size(56, 58)
        Me.picBoxPrevSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxPrevSong.TabIndex = 17
        Me.picBoxPrevSong.TabStop = False
        '
        'lstBoxMusic
        '
        Me.lstBoxMusic.FormattingEnabled = True
        Me.lstBoxMusic.Location = New System.Drawing.Point(65, 367)
        Me.lstBoxMusic.Name = "lstBoxMusic"
        Me.lstBoxMusic.Size = New System.Drawing.Size(207, 17)
        Me.lstBoxMusic.Sorted = True
        Me.lstBoxMusic.TabIndex = 27
        '
        'picBoxPlay2
        '
        Me.picBoxPlay2.Image = Global.UniversalMobileMediaPlayer.My.Resources.Resources.pause_button_512
        Me.picBoxPlay2.Location = New System.Drawing.Point(107, 241)
        Me.picBoxPlay2.Name = "picBoxPlay2"
        Me.picBoxPlay2.Size = New System.Drawing.Size(66, 66)
        Me.picBoxPlay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxPlay2.TabIndex = 28
        Me.picBoxPlay2.TabStop = False
        '
        'picBoxHelp
        '
        Me.picBoxHelp.Image = CType(resources.GetObject("picBoxHelp.Image"), System.Drawing.Image)
        Me.picBoxHelp.InitialImage = CType(resources.GetObject("picBoxHelp.InitialImage"), System.Drawing.Image)
        Me.picBoxHelp.Location = New System.Drawing.Point(12, 401)
        Me.picBoxHelp.Name = "picBoxHelp"
        Me.picBoxHelp.Size = New System.Drawing.Size(74, 50)
        Me.picBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxHelp.TabIndex = 29
        Me.picBoxHelp.TabStop = False
        '
        'picBoxAdd
        '
        Me.picBoxAdd.Image = CType(resources.GetObject("picBoxAdd.Image"), System.Drawing.Image)
        Me.picBoxAdd.Location = New System.Drawing.Point(219, 401)
        Me.picBoxAdd.Name = "picBoxAdd"
        Me.picBoxAdd.Size = New System.Drawing.Size(53, 50)
        Me.picBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxAdd.TabIndex = 30
        Me.picBoxAdd.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Choose Theme"
        '
        'radBtnLight
        '
        Me.radBtnLight.AutoSize = True
        Me.radBtnLight.Location = New System.Drawing.Point(107, 403)
        Me.radBtnLight.Name = "radBtnLight"
        Me.radBtnLight.Size = New System.Drawing.Size(48, 17)
        Me.radBtnLight.TabIndex = 32
        Me.radBtnLight.TabStop = True
        Me.radBtnLight.Text = "Light"
        Me.radBtnLight.UseVisualStyleBackColor = True
        '
        'radBtnDark
        '
        Me.radBtnDark.AutoSize = True
        Me.radBtnDark.Location = New System.Drawing.Point(107, 426)
        Me.radBtnDark.Name = "radBtnDark"
        Me.radBtnDark.Size = New System.Drawing.Size(48, 17)
        Me.radBtnDark.TabIndex = 33
        Me.radBtnDark.TabStop = True
        Me.radBtnDark.Text = "Dark"
        Me.radBtnDark.UseVisualStyleBackColor = True
        '
        'mainProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 452)
        Me.Controls.Add(Me.radBtnDark)
        Me.Controls.Add(Me.radBtnLight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBoxAdd)
        Me.Controls.Add(Me.picBoxHelp)
        Me.Controls.Add(Me.picBoxPlay2)
        Me.Controls.Add(Me.lstBoxMusic)
        Me.Controls.Add(Me.txtBoxVolPerc)
        Me.Controls.Add(Me.picBoxVolMute)
        Me.Controls.Add(Me.picBoxVolLo)
        Me.Controls.Add(Me.picBoxVolHi)
        Me.Controls.Add(Me.picBoxNxtSong)
        Me.Controls.Add(Me.picBoxPlay)
        Me.Controls.Add(Me.picBoxPause)
        Me.Controls.Add(Me.picBoxPrevSong)
        Me.Controls.Add(Me.lblMusic)
        Me.Controls.Add(Me.txtBoxPlayingNow)
        Me.Controls.Add(Me.mediaPlayer)
        Me.Controls.Add(Me.trkBarVol)
        Me.Name = "mainProgram"
        Me.Text = "Universal Media Player"
        CType(Me.mediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBarVol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxVolMute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxVolLo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxVolHi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxNxtSong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxPrevSong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxPlay2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddScreenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents txtBoxPlayingNow As TextBox
    Friend WithEvents lblMusic As Label
    Friend WithEvents picBoxPrevSong As PictureBox
    Friend WithEvents picBoxPause As PictureBox
    Friend WithEvents picBoxPlay As PictureBox
    Friend WithEvents picBoxNxtSong As PictureBox
    Friend WithEvents picBoxVolHi As PictureBox
    Friend WithEvents picBoxVolLo As PictureBox
    Friend WithEvents picBoxVolMute As PictureBox
    Friend WithEvents trkBarVol As TrackBar
    Friend WithEvents txtBoxVolPerc As TextBox
    Friend WithEvents lstBoxMusic As ListBox
    Friend WithEvents AddScreenBindingSource As BindingSource
    Friend WithEvents picBoxPlay2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents picBoxHelp As PictureBox
    Friend WithEvents picBoxAdd As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents radBtnLight As RadioButton
    Friend WithEvents radBtnDark As RadioButton
End Class
