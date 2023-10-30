<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        LabelFooter = New Label()
        TextBox_TextToSpam = New TextBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        NumericUpDown_MessageDelay = New NumericUpDown()
        Label13 = New Label()
        CheckBox_AlwaysOnTop = New CheckBox()
        Label11 = New Label()
        NumericUpDown_SendDelay = New NumericUpDown()
        Label9 = New Label()
        Label8 = New Label()
        CheckBox_PressEnterEOM = New CheckBox()
        Label7 = New Label()
        CheckBox_MsgBoxOnStart = New CheckBox()
        CheckBox_DelayOnStart = New CheckBox()
        Label6 = New Label()
        NumericUpDown_RepeatTimes = New NumericUpDown()
        RadioButton_RepeatTimes = New RadioButton()
        RadioButton_RepeatIndefinitely = New RadioButton()
        Label5 = New Label()
        Textbox_OpenChatKeybind = New TextBox()
        CheckBox_KeyPressBeforeText = New CheckBox()
        Label4 = New Label()
        Label3 = New Label()
        CheckBox_MsgBoxWhenComplete = New CheckBox()
        Label2 = New Label()
        NumericUpDown_StartDelay = New NumericUpDown()
        Label1 = New Label()
        ButtonStartStop = New Button()
        LabelTime = New Label()
        Clock = New Timer(components)
        Label10 = New Label()
        Label12 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(NumericUpDown_MessageDelay, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_SendDelay, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_RepeatTimes, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_StartDelay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelFooter
        ' 
        LabelFooter.AutoSize = True
        LabelFooter.Location = New Point(-3, 446)
        LabelFooter.Name = "LabelFooter"
        LabelFooter.Size = New Size(201, 15)
        LabelFooter.TabIndex = 0
        LabelFooter.Text = "Created By: WarBringerLT @ 2023-Q4"
        ' 
        ' TextBox_TextToSpam
        ' 
        TextBox_TextToSpam.BackColor = Color.Black
        TextBox_TextToSpam.BorderStyle = BorderStyle.None
        TextBox_TextToSpam.ForeColor = Color.Yellow
        TextBox_TextToSpam.Location = New Point(12, 22)
        TextBox_TextToSpam.Multiline = True
        TextBox_TextToSpam.Name = "TextBox_TextToSpam"
        TextBox_TextToSpam.PlaceholderText = "Enter the text here "
        TextBox_TextToSpam.Size = New Size(742, 207)
        TextBox_TextToSpam.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Black
        GroupBox1.BackgroundImageLayout = ImageLayout.Zoom
        GroupBox1.Controls.Add(TextBox_TextToSpam)
        GroupBox1.ForeColor = Color.Yellow
        GroupBox1.Location = New Point(12, 7)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(760, 235)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Text to spam:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(NumericUpDown_MessageDelay)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(CheckBox_AlwaysOnTop)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(NumericUpDown_SendDelay)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(CheckBox_PressEnterEOM)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(CheckBox_MsgBoxOnStart)
        GroupBox2.Controls.Add(CheckBox_DelayOnStart)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(NumericUpDown_RepeatTimes)
        GroupBox2.Controls.Add(RadioButton_RepeatTimes)
        GroupBox2.Controls.Add(RadioButton_RepeatIndefinitely)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Textbox_OpenChatKeybind)
        GroupBox2.Controls.Add(CheckBox_KeyPressBeforeText)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(CheckBox_MsgBoxWhenComplete)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(NumericUpDown_StartDelay)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(ButtonStartStop)
        GroupBox2.ForeColor = Color.Yellow
        GroupBox2.Location = New Point(11, 242)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(761, 184)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Settings"
        ' 
        ' NumericUpDown_MessageDelay
        ' 
        NumericUpDown_MessageDelay.BackColor = Color.Black
        NumericUpDown_MessageDelay.BorderStyle = BorderStyle.None
        NumericUpDown_MessageDelay.ForeColor = Color.Chartreuse
        NumericUpDown_MessageDelay.Location = New Point(606, 126)
        NumericUpDown_MessageDelay.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        NumericUpDown_MessageDelay.Name = "NumericUpDown_MessageDelay"
        NumericUpDown_MessageDelay.Size = New Size(82, 19)
        NumericUpDown_MessageDelay.TabIndex = 28
        NumericUpDown_MessageDelay.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(503, 125)
        Label13.Name = "Label13"
        Label13.Size = New Size(209, 15)
        Label13.TabIndex = 27
        Label13.Text = "9.  Message Delay                               ms"
        ' 
        ' CheckBox_AlwaysOnTop
        ' 
        CheckBox_AlwaysOnTop.AutoSize = True
        CheckBox_AlwaysOnTop.Location = New Point(33, 123)
        CheckBox_AlwaysOnTop.Name = "CheckBox_AlwaysOnTop"
        CheckBox_AlwaysOnTop.Size = New Size(101, 19)
        CheckBox_AlwaysOnTop.TabIndex = 26
        CheckBox_AlwaysOnTop.Text = "Always on top"
        CheckBox_AlwaysOnTop.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(11, 124)
        Label11.Name = "Label11"
        Label11.Size = New Size(16, 15)
        Label11.TabIndex = 25
        Label11.Text = "8."
        ' 
        ' NumericUpDown_SendDelay
        ' 
        NumericUpDown_SendDelay.BackColor = Color.Black
        NumericUpDown_SendDelay.BorderStyle = BorderStyle.None
        NumericUpDown_SendDelay.ForeColor = Color.Chartreuse
        NumericUpDown_SendDelay.Location = New Point(606, 106)
        NumericUpDown_SendDelay.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        NumericUpDown_SendDelay.Name = "NumericUpDown_SendDelay"
        NumericUpDown_SendDelay.Size = New Size(82, 19)
        NumericUpDown_SendDelay.TabIndex = 24
        NumericUpDown_SendDelay.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(501, 105)
        Label9.Name = "Label9"
        Label9.Size = New Size(212, 15)
        Label9.TabIndex = 23
        Label9.Text = "7.   Keypress Delay                               ms"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(501, 79)
        Label8.Name = "Label8"
        Label8.Size = New Size(16, 15)
        Label8.TabIndex = 22
        Label8.Text = "6."
        ' 
        ' CheckBox_PressEnterEOM
        ' 
        CheckBox_PressEnterEOM.AutoSize = True
        CheckBox_PressEnterEOM.Location = New Point(528, 79)
        CheckBox_PressEnterEOM.Name = "CheckBox_PressEnterEOM"
        CheckBox_PressEnterEOM.Size = New Size(176, 19)
        CheckBox_PressEnterEOM.TabIndex = 2
        CheckBox_PressEnterEOM.Text = "Press Enter (Send) at the end"
        CheckBox_PressEnterEOM.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(11, 102)
        Label7.Name = "Label7"
        Label7.Size = New Size(16, 15)
        Label7.TabIndex = 21
        Label7.Text = "4."
        ' 
        ' CheckBox_MsgBoxOnStart
        ' 
        CheckBox_MsgBoxOnStart.AutoSize = True
        CheckBox_MsgBoxOnStart.Location = New Point(33, 100)
        CheckBox_MsgBoxOnStart.Name = "CheckBox_MsgBoxOnStart"
        CheckBox_MsgBoxOnStart.Size = New Size(171, 19)
        CheckBox_MsgBoxOnStart.TabIndex = 20
        CheckBox_MsgBoxOnStart.Text = "Show message box on Start"
        CheckBox_MsgBoxOnStart.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_DelayOnStart
        ' 
        CheckBox_DelayOnStart.AutoSize = True
        CheckBox_DelayOnStart.Checked = True
        CheckBox_DelayOnStart.CheckState = CheckState.Checked
        CheckBox_DelayOnStart.Location = New Point(33, 27)
        CheckBox_DelayOnStart.Name = "CheckBox_DelayOnStart"
        CheckBox_DelayOnStart.Size = New Size(102, 19)
        CheckBox_DelayOnStart.TabIndex = 19
        CheckBox_DelayOnStart.Text = "Delay on Start:"
        CheckBox_DelayOnStart.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(503, 29)
        Label6.Name = "Label6"
        Label6.Size = New Size(16, 15)
        Label6.TabIndex = 18
        Label6.Text = "5."
        ' 
        ' NumericUpDown_RepeatTimes
        ' 
        NumericUpDown_RepeatTimes.BackColor = Color.Black
        NumericUpDown_RepeatTimes.BorderStyle = BorderStyle.None
        NumericUpDown_RepeatTimes.ForeColor = Color.Chartreuse
        NumericUpDown_RepeatTimes.Location = New Point(594, 29)
        NumericUpDown_RepeatTimes.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        NumericUpDown_RepeatTimes.Name = "NumericUpDown_RepeatTimes"
        NumericUpDown_RepeatTimes.Size = New Size(45, 19)
        NumericUpDown_RepeatTimes.TabIndex = 17
        NumericUpDown_RepeatTimes.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' RadioButton_RepeatTimes
        ' 
        RadioButton_RepeatTimes.AutoSize = True
        RadioButton_RepeatTimes.Checked = True
        RadioButton_RepeatTimes.Location = New Point(528, 28)
        RadioButton_RepeatTimes.Name = "RadioButton_RepeatTimes"
        RadioButton_RepeatTimes.Size = New Size(155, 19)
        RadioButton_RepeatTimes.TabIndex = 16
        RadioButton_RepeatTimes.TabStop = True
        RadioButton_RepeatTimes.Text = "Repeat                     Times"
        RadioButton_RepeatTimes.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_RepeatIndefinitely
        ' 
        RadioButton_RepeatIndefinitely.AutoSize = True
        RadioButton_RepeatIndefinitely.Location = New Point(528, 52)
        RadioButton_RepeatIndefinitely.Name = "RadioButton_RepeatIndefinitely"
        RadioButton_RepeatIndefinitely.Size = New Size(123, 19)
        RadioButton_RepeatIndefinitely.TabIndex = 15
        RadioButton_RepeatIndefinitely.Text = "Repeat Indefinitely"
        RadioButton_RepeatIndefinitely.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(178, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(251, 15)
        Label5.TabIndex = 14
        Label5.Text = "before the 'Text to Spam' (good for open chat)"
        ' 
        ' Textbox_OpenChatKeybind
        ' 
        Textbox_OpenChatKeybind.BackColor = Color.Black
        Textbox_OpenChatKeybind.BorderStyle = BorderStyle.None
        Textbox_OpenChatKeybind.Enabled = False
        Textbox_OpenChatKeybind.ForeColor = Color.Lime
        Textbox_OpenChatKeybind.Location = New Point(117, 78)
        Textbox_OpenChatKeybind.Name = "Textbox_OpenChatKeybind"
        Textbox_OpenChatKeybind.PlaceholderText = "PRESS KEY"
        Textbox_OpenChatKeybind.Size = New Size(69, 16)
        Textbox_OpenChatKeybind.TabIndex = 13
        ' 
        ' CheckBox_KeyPressBeforeText
        ' 
        CheckBox_KeyPressBeforeText.AutoSize = True
        CheckBox_KeyPressBeforeText.Location = New Point(33, 77)
        CheckBox_KeyPressBeforeText.Name = "CheckBox_KeyPressBeforeText"
        CheckBox_KeyPressBeforeText.Size = New Size(86, 19)
        CheckBox_KeyPressBeforeText.TabIndex = 12
        CheckBox_KeyPressBeforeText.Text = "Press Letter"
        CheckBox_KeyPressBeforeText.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(16, 15)
        Label4.TabIndex = 11
        Label4.Text = "3."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(16, 15)
        Label3.TabIndex = 9
        Label3.Text = "2."
        ' 
        ' CheckBox_MsgBoxWhenComplete
        ' 
        CheckBox_MsgBoxWhenComplete.AutoSize = True
        CheckBox_MsgBoxWhenComplete.Location = New Point(33, 52)
        CheckBox_MsgBoxWhenComplete.Name = "CheckBox_MsgBoxWhenComplete"
        CheckBox_MsgBoxWhenComplete.Size = New Size(178, 19)
        CheckBox_MsgBoxWhenComplete.TabIndex = 8
        CheckBox_MsgBoxWhenComplete.Text = "Show message box on Finish"
        CheckBox_MsgBoxWhenComplete.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(224, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 15)
        Label2.TabIndex = 7
        Label2.Text = "miliseconds (1000ms=1s)"
        ' 
        ' NumericUpDown_StartDelay
        ' 
        NumericUpDown_StartDelay.BackColor = Color.Black
        NumericUpDown_StartDelay.BorderStyle = BorderStyle.None
        NumericUpDown_StartDelay.ForeColor = Color.Chartreuse
        NumericUpDown_StartDelay.Location = New Point(136, 28)
        NumericUpDown_StartDelay.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        NumericUpDown_StartDelay.Name = "NumericUpDown_StartDelay"
        NumericUpDown_StartDelay.Size = New Size(82, 19)
        NumericUpDown_StartDelay.TabIndex = 6
        NumericUpDown_StartDelay.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(22, 15)
        Label1.TabIndex = 5
        Label1.Text = "1.  "
        ' 
        ' ButtonStartStop
        ' 
        ButtonStartStop.BackColor = Color.Black
        ButtonStartStop.FlatStyle = FlatStyle.Flat
        ButtonStartStop.Font = New Font("Visitor TT1 BRK", 24F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonStartStop.ForeColor = Color.Lime
        ButtonStartStop.Location = New Point(6, 146)
        ButtonStartStop.Name = "ButtonStartStop"
        ButtonStartStop.Size = New Size(749, 32)
        ButtonStartStop.TabIndex = 4
        ButtonStartStop.Text = "Start"
        ButtonStartStop.UseVisualStyleBackColor = False
        ' 
        ' LabelTime
        ' 
        LabelTime.AutoSize = True
        LabelTime.Location = New Point(645, 446)
        LabelTime.Name = "LabelTime"
        LabelTime.Size = New Size(49, 15)
        LabelTime.TabIndex = 5
        LabelTime.Text = ">TIME<"
        ' 
        ' Clock
        ' 
        Clock.Enabled = True
        Clock.Interval = 1000
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(248, 429)
        Label10.Name = "Label10"
        Label10.Size = New Size(312, 15)
        Label10.TabIndex = 25
        Label10.Text = "To Force Terminate spam (Force STOP) you can PRESS F11 "
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.Red
        Label12.Location = New Point(261, 444)
        Label12.Name = "Label12"
        Label12.Size = New Size(283, 15)
        Label12.TabIndex = 26
        Label12.Text = "To KILL you can PRESS F11 if unable to close this app"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(784, 461)
        Controls.Add(Label12)
        Controls.Add(Label10)
        Controls.Add(LabelTime)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(LabelFooter)
        DoubleBuffered = True
        ForeColor = Color.Yellow
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(800, 500)
        MinimizeBox = False
        MinimumSize = New Size(800, 500)
        Name = "Form1"
        Text = "WarBringerLT's Keyboard Spammer "
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(NumericUpDown_MessageDelay, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_SendDelay, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_RepeatTimes, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_StartDelay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelFooter As Label
    Friend WithEvents TextBox_TextToSpam As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonStartStop As Button
    Friend WithEvents LabelTime As Label
    Friend WithEvents Clock As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown_StartDelay As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox_MsgBoxWhenComplete As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Textbox_OpenChatKeybind As TextBox
    Friend WithEvents CheckBox_KeyPressBeforeText As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown_RepeatTimes As NumericUpDown
    Friend WithEvents RadioButton_RepeatTimes As RadioButton
    Friend WithEvents RadioButton_RepeatIndefinitely As RadioButton
    Friend WithEvents CheckBox_DelayOnStart As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox_MsgBoxOnStart As CheckBox
    Friend WithEvents CheckBox_PressEnterEOM As CheckBox
    Friend WithEvents NumericUpDown_SendDelay As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox_AlwaysOnTop As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents NumericUpDown_MessageDelay As NumericUpDown
    Friend WithEvents Label13 As Label
End Class
