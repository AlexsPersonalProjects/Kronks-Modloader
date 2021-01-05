'PROGRAM DETAILS
'This program is designed to make my life easier. Instead of sending over a zip folder, and having to install the mods yourself, this program will automatically load in the mods I've bundled.
'Eventually, I'd like to set it up so that you can select different pack versions, but we'll see how ambitious I get

Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Class Form1
    'GLOBALS
    Dim strMinecraftFolder As String                            'String of location of .minecraft folder
    Dim strFileName As String                                   'String of location of zip of mods
    Dim strModsFolder As String                                 'Strong of location of mods folder, genereated from strMinecraftFolder
    Dim savePath As String = "C:\Kronk\ModloaderSettings.txt"   'String containing the saved path for .minecraft folder, May contain more settings in the future


    'For when the form loads
    'Selects .minecraft folder, prompts user for mods folder, and then updates the text
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FolderSelect()
        'strMinecraftFolder = "C:\Users\Alex\Desktop\.minecraft"
        strModsFolder = strMinecraftFolder + "\mods"
        FileSelect()
        UpdateText()
    End Sub
    'For selecting folders
    'If there is a saved path for the .minecraft folder, it just sets that as the strMinecraftFolder
    'Otherwise, it prompts the user to select their .minecraft folder, and also determines the strModsFolder
    'Lastly, it updates the text
    Private Sub FolderSelect()
        If My.Computer.FileSystem.FileExists(savePath) Then
            strMinecraftFolder = My.Computer.FileSystem.ReadAllText(savePath)
        Else
            Dim fd As FolderBrowserDialog = New FolderBrowserDialog()
            fd.ShowDialog()
            strMinecraftFolder = fd.SelectedPath

            SaveMinecraftFolder()
        End If
        strModsFolder = strMinecraftFolder + "\mods"
        UpdateText()
    End Sub

    'For selecting the mods file
    'Runs the open file dialog, and applies the correct settngs
    'Lastly, it updates the text
    Private Sub FileSelect()
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Select mods.zip"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If
        UpdateText()
    End Sub

    'Simple sub, it just extracts the zip file to the mods folder
    Private Sub ExtractMods()
        IO.Compression.ZipFile.ExtractToDirectory(strFileName, strModsFolder)
    End Sub

    'For saving the old mod list
    'Because we all make mistakes, this makes it so that the mods folder that is getting replaced is saved, and not lost into the shadow realm. Or the recycle bin.
    Private Sub SaveOldMods()
        If My.Computer.FileSystem.DirectoryExists(strModsFolder) Then
            If My.Computer.FileSystem.DirectoryExists(strMinecraftFolder + "\OLDMODS") Then
                My.Computer.FileSystem.DeleteDirectory(strMinecraftFolder + "\OLDMODS", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            My.Computer.FileSystem.RenameDirectory(strModsFolder, "OLDMODS")
        End If
    End Sub

    'For saving the .minecraft folder.
    'Because it was very annoying getting to it
    'Creates a directory of C:\Kronk and then overwrites it with strMinecraftFolder
    Private Sub SaveMinecraftFolder()
        My.Computer.FileSystem.CreateDirectory("C:\Kronk")
        Dim SaveData As FileStream = File.Create(savePath)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(strMinecraftFolder)
        SaveData.Write(info, 0, info.Length)
        SaveData.Close()
    End Sub
    'For updating the text
    Private Sub UpdateText()
        txtMinecraftFolderPath.Text = strMinecraftFolder
        txtModpackPath.Text = strFileName
    End Sub
    'For moving the mods
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        SaveOldMods()
        ExtractMods()
    End Sub

    'For resetting
    'Did you change your minecraft directory? Probably not. Did you enter the wrong directory. Yes. Yes you did. Now you can fix it.
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        My.Computer.FileSystem.DeleteFile(savePath)
        FolderSelect()
        SaveMinecraftFolder()
        FileSelect()
    End Sub

    'For help
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MsgBox("If you are having issues, please hit the reset button, and make sure that you go through and select the correct folder. Also, make sure you select show hidden folders in the file explorer to be able to get to your .minecraft folder")

    End Sub
End Class
