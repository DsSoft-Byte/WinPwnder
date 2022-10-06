Imports System.Windows

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("mingw-inst.exe")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("zadig27.exe")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Process.Start("gaster.bat")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("https://t.me/sepfinderbot")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If My.Computer.FileSystem.FileExists("c:\iCures\iCuPrelaunch.exe") Then
            Process.Start("C:\iCures\iCuPrelaunch.exe")
        Else
            MsgBox("iCu not installed")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Open MinGW Installation Manager -> Basic Setup -> Right-click all 7 packages and add mark for Installation -> Installation Apply Changes -> Wait to it for complete
Open Windows settings, search for Edit the system environment variables -> Environment Variables -> Patch -> Add C:\MinGW\bin")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        MsgBox("Options -> List all devices -> Select Apple Mobile Device (DFU) -> Select libusbk -> Replace Driver")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label13.Text = ("" & TimeString)
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://github.com/DsSoft-Byte/WinPwnder/blob/main/version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse
        Dim sr As IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)

        Dim newestversions As String = sr.ReadToEnd
        Dim currentversion As String = Application.ProductVersion

        If newestversions.Contains(currentversion) Then
            MsgBox("You are up to date!")
        Else
            Form2.Show()
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MsgBox("Custom Update URLS and a lot more coming soon!")
    End Sub
End Class
