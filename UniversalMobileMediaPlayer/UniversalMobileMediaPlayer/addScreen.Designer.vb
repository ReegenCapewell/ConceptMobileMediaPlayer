<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addScreen
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
        Me.lblAddGenre = New System.Windows.Forms.Label()
        Me.lblAddMusic = New System.Windows.Forms.Label()
        Me.btnGetSong = New System.Windows.Forms.Button()
        Me.txtBoxGenreAdd = New System.Windows.Forms.TextBox()
        Me.picBoxBkAdd = New System.Windows.Forms.PictureBox()
        Me.lblHelpGenre = New System.Windows.Forms.Label()
        CType(Me.picBoxBkAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAddGenre
        '
        Me.lblAddGenre.AutoSize = True
        Me.lblAddGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddGenre.Font = New System.Drawing.Font("Agency FB", 14.0!)
        Me.lblAddGenre.Location = New System.Drawing.Point(11, 75)
        Me.lblAddGenre.Name = "lblAddGenre"
        Me.lblAddGenre.Size = New System.Drawing.Size(47, 26)
        Me.lblAddGenre.TabIndex = 0
        Me.lblAddGenre.Text = "Genre"
        '
        'lblAddMusic
        '
        Me.lblAddMusic.AutoSize = True
        Me.lblAddMusic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddMusic.Font = New System.Drawing.Font("Agency FB", 14.0!)
        Me.lblAddMusic.Location = New System.Drawing.Point(11, 342)
        Me.lblAddMusic.Name = "lblAddMusic"
        Me.lblAddMusic.Size = New System.Drawing.Size(45, 26)
        Me.lblAddMusic.TabIndex = 1
        Me.lblAddMusic.Text = "Music"
        '
        'btnGetSong
        '
        Me.btnGetSong.Location = New System.Drawing.Point(80, 344)
        Me.btnGetSong.Name = "btnGetSong"
        Me.btnGetSong.Size = New System.Drawing.Size(191, 26)
        Me.btnGetSong.TabIndex = 2
        Me.btnGetSong.Text = "Get Song"
        Me.btnGetSong.UseVisualStyleBackColor = True
        '
        'txtBoxGenreAdd
        '
        Me.txtBoxGenreAdd.Location = New System.Drawing.Point(80, 81)
        Me.txtBoxGenreAdd.Name = "txtBoxGenreAdd"
        Me.txtBoxGenreAdd.Size = New System.Drawing.Size(191, 20)
        Me.txtBoxGenreAdd.TabIndex = 5
        '
        'picBoxBkAdd
        '
        Me.picBoxBkAdd.Image = Global.UniversalMobileMediaPlayer.My.Resources.Resources.arrow_left_512
        Me.picBoxBkAdd.Location = New System.Drawing.Point(12, 12)
        Me.picBoxBkAdd.Name = "picBoxBkAdd"
        Me.picBoxBkAdd.Size = New System.Drawing.Size(39, 40)
        Me.picBoxBkAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxBkAdd.TabIndex = 6
        Me.picBoxBkAdd.TabStop = False
        '
        'lblHelpGenre
        '
        Me.lblHelpGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHelpGenre.Font = New System.Drawing.Font("Agency FB", 14.0!)
        Me.lblHelpGenre.Location = New System.Drawing.Point(80, 114)
        Me.lblHelpGenre.Name = "lblHelpGenre"
        Me.lblHelpGenre.Size = New System.Drawing.Size(191, 148)
        Me.lblHelpGenre.TabIndex = 7
        Me.lblHelpGenre.Text = "Genres that can be inputted: Rock, Country, Dubstep, Classical, Rap, Pop, RnB Ple" & _
    "ase enter the genre in the same way for the song to be succesfully added"
        '
        'addScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 452)
        Me.Controls.Add(Me.lblHelpGenre)
        Me.Controls.Add(Me.picBoxBkAdd)
        Me.Controls.Add(Me.txtBoxGenreAdd)
        Me.Controls.Add(Me.btnGetSong)
        Me.Controls.Add(Me.lblAddMusic)
        Me.Controls.Add(Me.lblAddGenre)
        Me.Name = "addScreen"
        Me.Text = "Add New Song"
        CType(Me.picBoxBkAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddGenre As Label
    Friend WithEvents lblAddMusic As Label
    Friend WithEvents btnGetSong As Button
    Friend WithEvents txtBoxGenreAdd As TextBox
    Friend WithEvents picBoxBkAdd As PictureBox
    Friend WithEvents lblHelpGenre As Label
End Class
