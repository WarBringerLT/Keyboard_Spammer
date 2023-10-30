
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class Form1

    Public Spam_Enabled = False
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYUP As Integer = &H101
    Private Const VK_F10 As Integer = &H79

    ' Delegate and callback function for the hook
    Private Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Private HookCallback As LowLevelKeyboardProc
    Private HookID As IntPtr = IntPtr.Zero

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelTime.Text = My.Computer.Clock.LocalTime.ToString
        Me.KeyPreview = True
        HookCallback = New LowLevelKeyboardProc(AddressOf KeyboardHookCallback)
        HookID = SetHook(HookCallback)

    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Unhook the keyboard when the form is closing
        UnhookWindowsHookEx(HookID)
    End Sub
    Private Function KeyboardHookCallback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        If nCode >= 0 AndAlso wParam = CType(WM_KEYUP, IntPtr) Then
            Dim vkCode As Integer = Marshal.ReadInt32(lParam)
            If vkCode = VK_F10 Then
                If Spam_Enabled = True Then
                    ' F10 key is released, set the variable to false
                    Spam_Enabled = False

                    ' Optional: Display a message or perform other actions
                    MsgBox("Emergency F10 key pressed. Spamming disabled.", vbOKOnly, Me.Text)
                End If

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
        If Spam_Enabled = False Then
            ButtonStartStop.ForeColor = Color.Red
            ButtonStartStop.Text = "STOP"
            Spam_Enabled = True


            If CheckBox_DelayOnStart.Checked = True Then
                Dim delayDuration As Integer = CInt(NumericUpDown_StartDelay.Value)
                Delay(delayDuration)
            End If
            Start_Spam()
        Else
            ButtonStartStop.ForeColor = Color.Lime
            ButtonStartStop.Text = "START"
            Spam_Enabled = False
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

    ' Function to check if a key is valid (in this case, any key including F1-F12)
    Private Function IsValidKey(keyCode As Keys) As Boolean
        ' Check if the key is in the range of F1-F12
        Return keyCode >= Keys.F1 And keyCode <= Keys.F12 Or True
    End Function
    Sub Start_Spam()
        While Spam_Enabled = True
            Dim RepeatTimes = 0

            If RadioButton_RepeatIndefinitely.Checked = True Then ' SET-UP Repeat Times
                RepeatTimes = 90000
            Else
                RepeatTimes = NumericUpDown_RepeatTimes.Value
            End If

            If CheckBox_MsgBoxOnStart.Checked = True Then
                MsgBox("Starting SPAM. Will begin spamming as soon as you click OK", MsgBoxStyle.OkOnly, Me.Text)
            End If

            For i = 0 To RepeatTimes ' SPAM

                If CheckBox_KeyPressBeforeText.Checked = True Then ' If enabled, Send Keybind to open Chat
                    SendKeys.Send(Textbox_OpenChatKeybind.Text)
                End If

                SendKeys.Send(TextBox_TextToSpam.Text)
                If CheckBox_PressEnterEOM.Checked = True Then
                    SendKeys.Send("{ENTER}")
                End If
                Delay(NumericUpDown_SendDelay.Value)
            Next


            ' END
            If CheckBox_MsgBoxWhenComplete.Checked = True Then
                MsgBox("Spam Complete!", MessageBoxButtons.OK, Me.Text)
            End If
            Spam_Enabled = False

        End While
        ButtonStartStop.ForeColor = Color.Lime
        ButtonStartStop.Text = "START"
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
End Class
