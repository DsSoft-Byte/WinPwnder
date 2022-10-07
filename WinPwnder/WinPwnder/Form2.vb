Imports System.IO.Compression
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists("C:\Users\Public\Downloads\Updater\WP") Then
            MsgBox("Extracted update file detected. Updater halted. Use WinPwnder Cleanup feature in settings.")
            Button2.Enabled = False

        Else

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Computer.FileSystem.FileExists("C:\Users\Public\Downloads\File\WP.zip") Then
            MsgBox("The Update file has been downloaded, or is obsolete but present. ERROR Code 01")
        Else
            My.Computer.Network.DownloadFile(
        "https://raw.githubusercontent.com/DsSoft-Byte/WinPwnder/main/WP.zip",
        "C:\Users\Public\Downloads\File\WP.zip")
            Module1.Main()
            Process.Start("C:\Users\Public\Downloads\Updater\WinPwnder\Updater\iCuUpdater.exe")
            Me.Close()
            Form1.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
Module Module1

    Sub Main()
        Dim startPath As String = "C:\Users\Public\Downloads"
        Dim zipPath As String = "C:\Users\Public\Downloads\File\WP.zip"
        Dim extractPath As String = "C:\Users\Public\Downloads\Updater"

        ZipFile.ExtractToDirectory(zipPath, extractPath)
    End Sub

End Module