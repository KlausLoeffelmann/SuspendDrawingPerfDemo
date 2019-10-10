Imports Microsoft.Win32

Friend Class FrameworkAndOsInfo

    Public Shared Function GetOsName() As String
        Dim os_info = System.Environment.OSVersion

        Dim version = os_info.Version.Major.ToString() & "." & os_info.Version.Minor.ToString()

        Dim os As String = $"Unknown ({os_info.Version.Build})"

        Select Case version
            Case "10.0"
                os = $"Win 10 ({os_info.Version.Build})"
            Case "6.3"
                os = $"Win 8.1 ({os_info.Version.Build})"
            Case "6.2"
                os = $"Win 8 ({os_info.Version.Build})"
            Case "6.1"
                os = $"Win 7 ({os_info.Version.Build})"
            Case "6.0"
                os = $"Win Vista ({ os_info.Version.Build})"
            Case "5.2"
                os = $"Win XP 64-Bit Edition ({os_info.Version.Build})"
            Case "5.1"
                os = $"Win XP ({os_info.Version.Build})"
            Case "5.0"
                os = $"Win 2000 ({os_info.Version.Build})"
        End Select
        Return os
    End Function

    Public Shared Function Get45PlusFromRegistry() As String
        Const subkey As String = "SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\"

        Dim CheckFor45PlusVersion =
            Function(releaseKey As Integer)
                Select Case releaseKey
                    Case Is >= 528040
                        Return "4.8 or later"
                    Case Is >= 461808
                        Return "4.7.2"
                    Case Is >= 461308
                        Return "4.7.1"
                    Case Is >= 460798
                        Return "4.7"
                    Case Is >= 394802
                        Return "4.6.2"
                    Case Is >= 394254
                        Return "4.6.1"
                    Case Is >= 393295
                        Return "4.6"
                    Case Is >= 379893
                        Return "4.5.2"
                    Case Is >= 378675
                        Return "4.5.1"
                    Case Is >= 378389
                        Return "4.5"
                End Select
                Return "No 4.5 or later version detected"
            End Function

        Using ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey)
            If ndpKey IsNot Nothing AndAlso ndpKey.GetValue("Release") IsNot Nothing Then
                Return $".NET Framework Version: {CheckFor45PlusVersion(Integer.Parse(ndpKey.GetValue("Release").ToString))}"
            Else
                Return "A .NET Framework Version >= 4.5 was not detected."
            End If
        End Using
    End Function

End Class
