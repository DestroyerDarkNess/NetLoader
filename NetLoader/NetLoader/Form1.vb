Imports System.IO
Imports System.Reflection
Imports NetLoader.LogFuncs
Imports NetLoader.LibraryCheck

Public Class Form1


    Public Local_Path As String = Path.GetDirectoryName(Application.ExecutablePath)
    Public Plugin_Folder As String = "NetPlugins"
    Public PluginDir As String = Local_Path & "\" & Plugin_Folder
    Public ProcessN As String = String.Empty
    Public ProcessNameH As String = String.Empty
    Public CurrentName As String = Path.GetFileName(Application.ExecutablePath)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try : AddHandler Application.ThreadException, AddressOf Application_Exception_Handler _
                 : Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException, False) _
                 : Catch : End Try
        Dim arguments As String() = Environment.GetCommandLineArgs()
        ProcessN = arguments(0)

        If LCase(Path.GetFileName(ProcessN)) = LCase(CurrentName) Then
            MsgBox("Error : PROCESS_DETACH [ " & ProcessN & " ]")
            End
        End If

        ProcessNameH = Path.GetFileNameWithoutExtension(ProcessN)
        Timer1.Enabled = True
        Starting()
    End Sub

    Private Sub Application_Exception_Handler(ByVal sender As Object, ByVal e As System.Threading.ThreadExceptionEventArgs)
        Dim ex As Exception = CType(e.Exception, Exception)
        WriteLog(ex.Message, InfoType.Exception)
    End Sub

    Public Sub Starting()

        If Not My.Computer.FileSystem.DirectoryExists(PluginDir) = True Then
            My.Computer.FileSystem.CreateDirectory(PluginDir)
        End If

        If My.Computer.FileSystem.FileExists(LogFile) = True Then
            My.Computer.FileSystem.DeleteFile(LogFile)
        End If

        WriteLog(" - Session started .", InfoType.Information)
        WriteLog(" ", InfoType.None)
        WriteLog("NetLoader v.01 beta loaded.", InfoType.Information)
        WriteLog("Developers: Destroyer, IdiotForever", InfoType.Information)
        WriteLog("Copyright (c) 2020", InfoType.Information)
        WriteLog(" ", InfoType.None)
        WriteLog("Working directory: " & PluginDir, InfoType.Information)
        WriteLog("Installing pre-game hooks...", InfoType.Information)
        WriteLog("Hooks installed.", InfoType.Information)
        WriteLog(" ", InfoType.None)
        WriteLog("Process Attached : " & ProcessN, InfoType.Information)

        Dim Files As List(Of String) = FileDirSearcher.GetFilePaths(PluginDir, SearchOption.TopDirectoryOnly).ToList

        For Each Plug As String In Files
            If LCase(Path.GetExtension(Plug)) = ".dll" Then
                Dim PlugName As String = Path.GetFileNameWithoutExtension(Plug)
                If IsNetAssembly(Plug) = True Then
                    WriteLog("Loading .Net DLL '" & Plug & "'...", InfoType.Information)
                    Try

                        Dim assem As System.Reflection.Assembly = System.Reflection.Assembly.LoadFrom(Plug)
                        Dim ty As Type = assem.GetType(PlugName & ".dllmain")
                        Dim class1 As Object = Activator.CreateInstance(ty)
                        Dim strMsg As String = String.Empty
                        Dim myMember() As System.Reflection.MethodInfo = class1.GetType.GetMethods()
                        For Each member As System.Reflection.MethodInfo In myMember
                            If member.Name = "Main" Then
                                strMsg = member.Invoke(Nothing, Nothing, Nothing, Nothing, Nothing)
                                Exit For
                            End If
                        Next

                        WriteLog("New Plugin: " & PlugName, InfoType.None)
                        WriteLog(PlugName & " : " & strMsg, InfoType.None)

                    Catch ex As Exception
                        WriteLog(PlugName & ": .Net DLL died due to an error. " & "[" & ex.Message & "]", InfoType.Exception)
                    End Try

                End If

            End If
            WriteLog(" ", InfoType.None)
        Next

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim p As Process() = Process.GetProcessesByName(ProcessNameH)
        If p.Count = 0 Then
            WriteLog(" ", InfoType.None)
            WriteLog("Terminate Process : " & ProcessN, InfoType.Information)
            WriteLog("Tanks For Using.", InfoType.None)
            End
        End If
    End Sub


End Class
