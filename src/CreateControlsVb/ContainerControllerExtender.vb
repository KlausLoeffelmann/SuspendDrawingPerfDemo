Imports System.Runtime.InteropServices

Friend Module ContainerControlExtender

    <DllImport("user32.dll")>
    Public Function SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Boolean, ByVal lParam As Integer) As Integer
    End Function

    Private Const WM_SETREDRAW As Integer = 11

    <System.Runtime.CompilerServices.Extension>
    Public Sub SuspendDrawing(ByVal parent As ScrollableControl)
        SendMessage(parent.Handle, WM_SETREDRAW, False, 0)
    End Sub

    <System.Runtime.CompilerServices.Extension>
    Public Sub ResumeDrawing(ByVal parent As ScrollableControl)
        SendMessage(parent.Handle, WM_SETREDRAW, True, 0)
        parent.Refresh()
    End Sub
End Module
