Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Diagnostics

Public Class Form1


    Public Version = "1.02a"
    Public Spam_Enabled = False
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYUP As Integer = &H101
    Private Const VK_F10 As Integer = &H79
    Private Const VK_F11 As Integer = 122
    ' Delegate and callback function for the hook
    Private Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Private HookCallback As LowLevelKeyboardProc
    Private HookID As IntPtr = IntPtr.Zero






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelTime.Text = My.Computer.Clock.LocalTime.ToString
        Me.KeyPreview = True
        HookCallback = New LowLevelKeyboardProc(AddressOf KeyboardHookCallback)
        HookID = SetHook(HookCallback)
        Me.Text += Version

    End Sub






    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Unhook the keyboard when the form is closing
        Terminate()
    End Sub

    Private Sub Terminate()
        Process.Start("cmd", "/k taskKill /f /im Keyboard_Spammer.exe & exit")
    End Sub


    Private Function KeyboardHookCallback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        If nCode >= 0 AndAlso wParam = CType(WM_KEYUP, IntPtr) Then
            Dim vkCode As Integer = Marshal.ReadInt32(lParam)
            If vkCode = VK_F10 Then
                If Spam_Enabled = True Then
                    ' F10 key is released, set the variable to false
                    Stop_Spam()
                    Me.TopMost = False
                    MsgBox("Emergency F10 key pressed. Spamming disabled.", vbOKOnly, Me.Text)
                    If CheckBox_AlwaysOnTop.Checked = True Then
                        Me.TopMost = True
                    End If
                End If
            ElseIf vkCode = VK_F11 Then
                Terminate()
            End If
        End If
        ' Call the next hook in the chain
        Return CallNextHookEx(HookID, nCode, wParam, lParam)
    End Function

    ' Set up the low-level keyboard hook
    Private Function SetHook(ByVal proc As LowLevelKeyboardProc) As IntPtr
        Using curProcess As Process = Process.GetCurrentProcess()
            Using curModule As ProcessModule = curProcess.MainModule
                Return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0)
            End Using
        End Using
    End Function

    ' Windows API functions for hook management
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal lpfn As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function UnhookWindowsHookEx(ByVal hhk As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetModuleHandle(ByVal lpModuleName As String) As IntPtr
    End Function

    Private Sub Clock_Tick(sender As Object, e As EventArgs) Handles Clock.Tick
        LabelTime.Text = My.Computer.Clock.LocalTime.ToString
    End Sub

    Private Sub ButtonStartStop_Click(sender As Object, e As EventArgs) Handles ButtonStartStop.Click
        If Spam_Enabled = True Then
            Stop_Spam()
        Else
            If CheckBox_MsgBoxOnStart.Checked = True Then
                Me.TopMost = False
                MsgBox("Starting SPAM. Countdown (" + NumericUpDown_StartDelay.Value.ToString + "ms) will begin as soon as you click OK", MsgBoxStyle.OkOnly, Me.Text)
                If CheckBox_AlwaysOnTop.Checked = True Then
                    Me.TopMost = True
                End If
            End If
            Start_Spam()

        End If






    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_KeyPressBeforeText.CheckedChanged
        If CheckBox_KeyPressBeforeText.Checked = True Then
            Textbox_OpenChatKeybind.Enabled = True
        Else
            Textbox_OpenChatKeybind.Enabled = False
        End If
    End Sub

    Private Sub Textbox_OpenChatKeybind_KeyDown(sender As Object, e As KeyEventArgs) Handles Textbox_OpenChatKeybind.KeyDown
        ' Check if the pressed key is a valid key
        If IsValidKey(e.KeyCode) Then
            ' Update the TextBox text with the pressed key
            Textbox_OpenChatKeybind.Text = e.KeyCode.ToString()
        End If

        ' Suppress the key press event to prevent the character from being added to the TextBox
        e.SuppressKeyPress = True
    End Sub

    Private Function IsValidKey(keyCode As Keys) As Boolean
        Return True

    End Function

    Sub Stop_Spam()
        Spam_Enabled = False ' HALT the spam
        ButtonStartStop.ForeColor = Color.Lime
        ButtonStartStop.Text = "START"
        If CheckBox_MsgBoxWhenComplete.Checked = True Then
            Me.TopMost = False
            MsgBox("Spam Complete!", MessageBoxButtons.OK, Me.Text)
            If CheckBox_AlwaysOnTop.Checked = True Then
                Me.TopMost = True
            End If
        End If

    End Sub

    Sub Start_Spam()

        Dim RepeatTimes = 0
        Dim Spam_Text As String = TextBox_TextToSpam.Text

        Spam_Enabled = True ' HALT the spam
        ButtonStartStop.ForeColor = Color.Orange
        ButtonStartStop.Text = "STARTING... (DELAY: " + Str(NumericUpDown_StartDelay.Value).ToString + ")"


        Thread.Sleep(NumericUpDown_StartDelay.Value)

        ButtonStartStop.ForeColor = Color.Red
        ButtonStartStop.Text = "STOP"

        If RadioButton_RepeatIndefinitely.Checked = False Then ' SET-UP Repeat Times
            RepeatTimes = NumericUpDown_RepeatTimes.Value
        Else
            RepeatTimes = 99999999
        End If

        If CheckBox_KeyPressBeforeText.Checked = True Then ' If enabled, Send Keybind to open Chat
            If Textbox_OpenChatKeybind.Text = "" Then
                Me.TopMost = False
                MsgBox("Please bind any key to Setting #3", MsgBoxStyle.OkOnly, Me.Text)
                If CheckBox_AlwaysOnTop.Checked = True Then
                    Me.TopMost = True
                End If
                Stop_Spam()
            End If

        End If



        For i = 1 To RepeatTimes ' SPAM
            If Spam_Enabled = True Then
                Delay(NumericUpDown_MessageDelay.Value)
                If CheckBox_KeyPressBeforeText.Checked = True Then
                    SendKeys.SendWait(Textbox_OpenChatKeybind.Text)
                End If
                For Each letter As Char In Spam_Text
                    SendKeys.SendWait(letter)
                    Delay(NumericUpDown_SendDelay.Value)
                Next
                If CheckBox_PressEnterEOM.Checked = True Then
                    SendKeys.SendWait("{ENTER}")
                    Delay(NumericUpDown_SendDelay.Value)
                End If

            End If


        Next

        ' END
        Stop_Spam()


    End Sub

    Private Sub CheckBox_DelayOnStart_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DelayOnStart.CheckedChanged
        If CheckBox_DelayOnStart.Checked = True Then
            NumericUpDown_StartDelay.Enabled = True
        Else
            NumericUpDown_StartDelay.Enabled = False
        End If
    End Sub

    Private Sub Delay(milliseconds As Integer)
        ' Pause the execution of the current thread for the specified duration
        Thread.Sleep(milliseconds)
    End Sub

    Private Sub CheckBox_AlwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_AlwaysOnTop.CheckedChanged
        If CheckBox_AlwaysOnTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class