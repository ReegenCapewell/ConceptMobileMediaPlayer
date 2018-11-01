Imports System.IO

Public Class addScreen

    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
    Dim folderLoc As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim database As String = "/MediaPlayerDatabase1.accdb"
    Dim fullDBPath As String = folderLoc & database
    Dim dbSource As String = "Data Source = " & fullDBPath

    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String

    'Get song button for browsing media
    Private Sub btnGetSong_Click(sender As Object, e As EventArgs) Handles btnGetSong.Click
        Dim i As Integer = 0
        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "All Files|*.mp3"
        OpenFileDialog1.ShowDialog()
        If System.Windows.Forms.DialogResult.OK Then
            For Each track As String In OpenFileDialog1.FileNames
                mainProgram.lstBoxMusic.Items.Add(track)
                mainProgram.fileName = (Path.GetFileNameWithoutExtension(track))
                i = i + 1
            Next
        End If

        Dim cb As New OleDb.OleDbCommandBuilder(da)                                 'IF CODE DOESN'T WORK REFER TO BLACK BOOK ON WHAT TO DO
        Dim dsNewRow As DataRow

        'dsNewRow = ds.Tables("OriginalMusicList").NewRow()
        'dsNewRow.Item("Song Name") = mainProgram.fileName
        'dsNewRow.Item("File Name") = Path.GetFullPath(OpenFileDialog1.FileName)
        'ds.Tables("OriginalMusicList").Rows.Add(dsNewRow)
        'da.Update(ds, "OriginalMusicList")
    End Sub

    'Back button to media player
    Private Sub picBoxBkAdd_Click(sender As Object, e As EventArgs) Handles picBoxBkAdd.Click
        Me.Hide()
        mainProgram.Show()
    End Sub

    'On the add screen loading - load database open connection
    Private Sub addScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'con.ConnectionString = dbProvider & dbSource
        'con.Open()
        'sql = "SELECT * FROM OriginalMusicList"
        'da = New OleDb.OleDbDataAdapter(sql, con)
    End Sub
End Class