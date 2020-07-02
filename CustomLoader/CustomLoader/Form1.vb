Imports System.IO
Imports System.Security.Principal
Imports System.Threading

Public Class Form1


#Region " Declare's "

    Private Shared processName As String = String.Empty
    Public Local_Path As String = Path.GetDirectoryName(Application.ExecutablePath)

#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsAdmin() = True Then
            GameOpenMonitor.Enabled = True
        Else
            Try
                Process.Start(New ProcessStartInfo() With {
                    .WorkingDirectory = Environment.CurrentDirectory,
                    .FileName = Application.ExecutablePath,
                    .UseShellExecute = True,
                    .Verb = "runas"
                })
            Catch
                Throw New Exception("Could not elevate privileges")
            End Try

            End
        End If
    End Sub

    Private Sub GameOpenMonitor_Tick(sender As Object, e As EventArgs) Handles GameOpenMonitor.Tick
        processName = CorrectProcessString(ProcessTextBox.Text)
        Dim p As Process() = Process.GetProcessesByName(processName)
        If p.Count = 1 Then
            StatusLabel.Text = "The game is running!"
            StatusLabel.ForeColor = Color.Lime
            StartNetLoader()
            GameOpenMonitor.Enabled = False
        End If
    End Sub

    Public Sub StartNetLoader()
        Dim path As String = Local_Path & "\" & "ASIExNet.dll"
        If Not My.Computer.FileSystem.FileExists(path) = True Then
            Throw New Exception("ASIExNet.dll Not Found")
        End If
        Dim Exepath As String = Local_Path & "\" & "NetLoader.exe"
        If Not My.Computer.FileSystem.FileExists(Exepath) = True Then
            Throw New Exception("NetLoader Not Found")
        End If

        If IsProcessRunning(processName) = True Then
            Process.Start("NetLoader.exe", processName & ".exe")
            End
        End If
        End
    End Sub

    Private Function CorrectProcessString(ByVal processA As String) As String
        ' Another method would be :
        ' Dim ProcessName As String = Path.GetFileNameWithoutExtension(processA)
        ' Return ProcessName
        Dim ProcessName As String = processA
        If ProcessName.ToLower.EndsWith(".exe") Then ProcessName = ProcessName.Substring(0, ProcessName.Length - 4)
        Return ProcessName
    End Function

    Private Function IsProcessRunning(ByVal p As String) As Boolean
        Return Process.GetProcessesByName(p).Length <> 0
    End Function

    Private Function IsAdmin() As Boolean
        Dim Principle As WindowsPrincipal = New WindowsPrincipal(WindowsIdentity.GetCurrent())
        Return Principle.IsInRole(WindowsBuiltInRole.Administrator)
    End Function

    Private Sub ThreadException(ByVal sender As Object, ByVal e As ThreadExceptionEventArgs)
        HandleException(e.Exception.Message, e.Exception.ToString())
    End Sub

    Private Sub UnhandledException(ByVal sender As Object, ByVal args As UnhandledExceptionEventArgs)
        Dim e As Exception = CType(args.ExceptionObject, Exception)
        HandleException(e.Message, e.ToString())
    End Sub

    Private Sub HandleException(ByVal message As String, ByVal [error] As String)
        MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End
    End Sub

    Private Sub AnimaButton1_Click(sender As Object, e As EventArgs) Handles AnimaButton1.Click
        End
    End Sub

End Class
