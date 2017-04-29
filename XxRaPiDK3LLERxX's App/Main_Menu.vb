Public Class Main_Menu
    Dim myProcess As Process
    Dim myProcesses As Process() = Process.GetProcessesByName("ApplicationName")
    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Shared Sub FlushMemory()

        GC.Collect()
        GC.WaitForPendingFinalizers()
        If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
        End If
        'Dim ProcessInfo As Process For Each myProcess In myProcesses SetProcessWorkingSetSize(myProcess.Handle, -1, -1) Next myProcess End If Catch ex As Exception End Try End Sub

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FlushMemory()

    End Sub

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click

    End Sub
    Private Sub GetIPAddress()

        Dim strHostName As String

        Dim strIPAddress As String



        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()


        MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GetIPAddress()

    End Sub

    Private Sub XxRaPiDKillerxX_Friends_Click(sender As Object, e As EventArgs) Handles XxRaPiDKillerxX_Friends.Click
        MsgBox("This feature isn't ready.")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class