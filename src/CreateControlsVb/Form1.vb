Partial Public Class Form1
    Inherits Form

    Public Sub New()
        InitializeComponent()

        Text = $"WinForms PerfTest - {FrameworkAndOsInfo.Get45PlusFromRegistry()} on {FrameworkAndOsInfo.GetOsName()}"
    End Sub

    Private Function CreatePanelDynamic() As CustomPanel
        Return New CustomPanel() With {.Top = 12, .Left = 12, .Height = 426, .Width = 200, .Visible = True}
    End Function

    Private Function CreateTextBoxDynamic() As TextBox
        Return New TextBox() With {.Text = "12354", .Width = 100, .Height = 20, .Left = 0}
    End Function

    Private Function LaunchPerfTest(ByVal requestDestroyHandle As Boolean) As Long

        Dim sw = Stopwatch.StartNew()

        For outerLoop As Integer = 0 To 99
            Dim top As Integer = 0

            Dim pnlCtrl As CustomPanel = Me.CreatePanelDynamic()
            Controls.Add(pnlCtrl)

            For innerLoop As Integer = 0 To 49
                Dim newTextBox As TextBox = CreateTextBoxDynamic()
                newTextBox.Top = top
                pnlCtrl.Controls.Add(newTextBox)
                top += 20
            Next innerLoop

            If requestDestroyHandle Then
                ' ?
                pnlCtrl.RequestDestroyHandle()
            End If

            pnlCtrl.Controls.Clear()
            Controls.Remove(pnlCtrl)
        Next outerLoop

        sw.Stop()
        Return sw.ElapsedMilliseconds

    End Function

    Private Sub BtnStartPerformanceTest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStartPerformanceTest.Click

        Dim destroyPanelHandle As Boolean = chkDestroyPanelHandle.Checked

        Try
            btnStartPerformanceTest.Enabled = False
            Cursor = Cursors.WaitCursor
            pBarRunsDone.Value = 0
            pBarRunsDone.Maximum = CInt(Fix(nupRuns.Value))

            Dim resultTable = New List(Of Long)()
            Dim result = 0L

            For count = 0 To pBarRunsDone.Maximum - 1
                If chkSuspenLayout.Checked Then
                    SuspendLayout()
                    SuspendDrawing()
                End If

                result = LaunchPerfTest(destroyPanelHandle)
                resultTable.Add(result)
                dgvResults.Rows.Add($"{count + 1}", $"{result / 1000.0F:#,##0.000} sec.")
                pBarRunsDone.Value = count + 1
                If chkSuspenLayout.Checked Then
                    ResumeLayout()
                    ResumeDrawing()
                End If

                Application.DoEvents()
            Next count

            lblAverageRunTime.Text = $"Average run time:{resultTable.Average() / 1000.0F:#,##0.000}"

        Catch e1 As System.Exception

        Finally
            btnStartPerformanceTest.Enabled = True
            Cursor = Cursors.Arrow
        End Try
    End Sub
End Class