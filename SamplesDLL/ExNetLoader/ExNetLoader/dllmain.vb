Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.IO

Public Class dllmain

    Shared CurrentDLLPath As String = Assembly.GetExecutingAssembly().Location
    Shared CurrentLocation As String = Path.GetDirectoryName(CurrentDLLPath)

    Public Shared Function Main() As String
        Dim WelcomMessage As String = " Hi , Im Plugin Sample"
        Dim tskThread As New Task(ScanAsyc, TaskCreationOptions.LongRunning)
        tskThread.Start()
        Return WelcomMessage
    End Function

    Private Shared ScanAsyc As New Action(
  Sub()
      ' You Code Here
  End Sub)

End Class
