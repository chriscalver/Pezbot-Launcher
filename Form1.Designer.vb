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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.comboMap = New System.Windows.Forms.ComboBox()
        Me.comboBots = New System.Windows.Forms.ComboBox()
        Me.comboSkillLevel = New System.Windows.Forms.ComboBox()
        Me.comboTime = New System.Windows.Forms.ComboBox()
        Me.comboKills = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.lblMap = New System.Windows.Forms.Label()
        Me.lblBots = New System.Windows.Forms.Label()
        Me.lblSkill = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblKills = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.lblBotTeam = New System.Windows.Forms.Label()
        Me.comboDMType = New System.Windows.Forms.ComboBox()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.lblSix = New System.Windows.Forms.Label()
        Me.lblDMMsg1 = New System.Windows.Forms.Label()
        Me.lblDMmsg2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(107, 637)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(162, 37)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'comboMap
        '
        Me.comboMap.BackColor = System.Drawing.Color.Gainsboro
        Me.comboMap.FormattingEnabled = True
        Me.comboMap.Location = New System.Drawing.Point(107, 200)
        Me.comboMap.Name = "comboMap"
        Me.comboMap.Size = New System.Drawing.Size(244, 24)
        Me.comboMap.TabIndex = 1
        '
        'comboBots
        '
        Me.comboBots.BackColor = System.Drawing.Color.Gainsboro
        Me.comboBots.FormattingEnabled = True
        Me.comboBots.Location = New System.Drawing.Point(107, 273)
        Me.comboBots.Name = "comboBots"
        Me.comboBots.Size = New System.Drawing.Size(60, 24)
        Me.comboBots.TabIndex = 2
        '
        'comboSkillLevel
        '
        Me.comboSkillLevel.BackColor = System.Drawing.Color.Gainsboro
        Me.comboSkillLevel.FormattingEnabled = True
        Me.comboSkillLevel.Location = New System.Drawing.Point(107, 346)
        Me.comboSkillLevel.Name = "comboSkillLevel"
        Me.comboSkillLevel.Size = New System.Drawing.Size(60, 24)
        Me.comboSkillLevel.TabIndex = 3
        '
        'comboTime
        '
        Me.comboTime.BackColor = System.Drawing.Color.Gainsboro
        Me.comboTime.FormattingEnabled = True
        Me.comboTime.Location = New System.Drawing.Point(107, 419)
        Me.comboTime.Name = "comboTime"
        Me.comboTime.Size = New System.Drawing.Size(71, 24)
        Me.comboTime.TabIndex = 4
        '
        'comboKills
        '
        Me.comboKills.BackColor = System.Drawing.Color.Gainsboro
        Me.comboKills.FormattingEnabled = True
        Me.comboKills.Location = New System.Drawing.Point(107, 492)
        Me.comboKills.Name = "comboKills"
        Me.comboKills.Size = New System.Drawing.Size(71, 24)
        Me.comboKills.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 52.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblTitle.Location = New System.Drawing.Point(44, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(3, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitle.Size = New System.Drawing.Size(370, 116)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "PeZBot "
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblTitle.UseMnemonic = False
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTitle2.Location = New System.Drawing.Point(66, 95)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(263, 32)
        Me.lblTitle2.TabIndex = 7
        Me.lblTitle2.Text = "Deathmatch Launcher"
        '
        'lblMap
        '
        Me.lblMap.AutoSize = True
        Me.lblMap.BackColor = System.Drawing.Color.Transparent
        Me.lblMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMap.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMap.Location = New System.Drawing.Point(99, 166)
        Me.lblMap.Name = "lblMap"
        Me.lblMap.Size = New System.Drawing.Size(150, 25)
        Me.lblMap.TabIndex = 8
        Me.lblMap.Text = "Map Selection"
        '
        'lblBots
        '
        Me.lblBots.AutoSize = True
        Me.lblBots.BackColor = System.Drawing.Color.Transparent
        Me.lblBots.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBots.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblBots.Location = New System.Drawing.Point(99, 239)
        Me.lblBots.Name = "lblBots"
        Me.lblBots.Size = New System.Drawing.Size(160, 25)
        Me.lblBots.TabIndex = 9
        Me.lblBots.Text = "Number of Bots"
        '
        'lblSkill
        '
        Me.lblSkill.AutoSize = True
        Me.lblSkill.BackColor = System.Drawing.Color.Transparent
        Me.lblSkill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkill.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSkill.Location = New System.Drawing.Point(99, 312)
        Me.lblSkill.Name = "lblSkill"
        Me.lblSkill.Size = New System.Drawing.Size(273, 25)
        Me.lblSkill.TabIndex = 10
        Me.lblSkill.Text = "Bot Skill Level (10 hardest)"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTime.Location = New System.Drawing.Point(99, 385)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(180, 25)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "Time Limit (MIns)"
        '
        'lblKills
        '
        Me.lblKills.AutoSize = True
        Me.lblKills.BackColor = System.Drawing.Color.Transparent
        Me.lblKills.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKills.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblKills.Location = New System.Drawing.Point(99, 458)
        Me.lblKills.Name = "lblKills"
        Me.lblKills.Size = New System.Drawing.Size(120, 25)
        Me.lblKills.TabIndex = 12
        Me.lblKills.Text = "Score Limit"
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSettings.Location = New System.Drawing.Point(562, 15)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(171, 25)
        Me.lblSettings.TabIndex = 13
        Me.lblSettings.Text = "Additional Options"
        '
        'lblBotTeam
        '
        Me.lblBotTeam.AutoSize = True
        Me.lblBotTeam.BackColor = System.Drawing.Color.Transparent
        Me.lblBotTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotTeam.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblBotTeam.Location = New System.Drawing.Point(99, 531)
        Me.lblBotTeam.Name = "lblBotTeam"
        Me.lblBotTeam.Size = New System.Drawing.Size(182, 25)
        Me.lblBotTeam.TabIndex = 15
        Me.lblBotTeam.Text = "Deathmatch Type"
        '
        'comboDMType
        '
        Me.comboDMType.BackColor = System.Drawing.Color.Gainsboro
        Me.comboDMType.FormattingEnabled = True
        Me.comboDMType.Items.AddRange(New Object() {"Free for All Mode", "Suicide Mode"})
        Me.comboDMType.Location = New System.Drawing.Point(107, 565)
        Me.comboDMType.Name = "comboDMType"
        Me.comboDMType.Size = New System.Drawing.Size(184, 24)
        Me.comboDMType.TabIndex = 14
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.BackColor = System.Drawing.Color.Transparent
        Me.lblOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOne.ForeColor = System.Drawing.SystemColors.Window
        Me.lblOne.Location = New System.Drawing.Point(43, 184)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(52, 55)
        Me.lblOne.TabIndex = 16
        Me.lblOne.Text = "1"
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.BackColor = System.Drawing.Color.Transparent
        Me.lblTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwo.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTwo.Location = New System.Drawing.Point(43, 256)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(52, 55)
        Me.lblTwo.TabIndex = 17
        Me.lblTwo.Text = "2"
        '
        'lblThree
        '
        Me.lblThree.AutoSize = True
        Me.lblThree.BackColor = System.Drawing.Color.Transparent
        Me.lblThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThree.ForeColor = System.Drawing.SystemColors.Window
        Me.lblThree.Location = New System.Drawing.Point(43, 328)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(52, 55)
        Me.lblThree.TabIndex = 18
        Me.lblThree.Text = "3"
        '
        'lblFour
        '
        Me.lblFour.AutoSize = True
        Me.lblFour.BackColor = System.Drawing.Color.Transparent
        Me.lblFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFour.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFour.Location = New System.Drawing.Point(43, 400)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(52, 55)
        Me.lblFour.TabIndex = 19
        Me.lblFour.Text = "4"
        '
        'lblFive
        '
        Me.lblFive.AutoSize = True
        Me.lblFive.BackColor = System.Drawing.Color.Transparent
        Me.lblFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFive.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFive.Location = New System.Drawing.Point(43, 472)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(52, 55)
        Me.lblFive.TabIndex = 20
        Me.lblFive.Text = "5"
        '
        'lblSix
        '
        Me.lblSix.AutoSize = True
        Me.lblSix.BackColor = System.Drawing.Color.Transparent
        Me.lblSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSix.ForeColor = System.Drawing.SystemColors.Window
        Me.lblSix.Location = New System.Drawing.Point(43, 544)
        Me.lblSix.Name = "lblSix"
        Me.lblSix.Size = New System.Drawing.Size(52, 55)
        Me.lblSix.TabIndex = 21
        Me.lblSix.Text = "6"
        '
        'lblDMMsg1
        '
        Me.lblDMMsg1.AutoSize = True
        Me.lblDMMsg1.BackColor = System.Drawing.Color.Transparent
        Me.lblDMMsg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDMMsg1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDMMsg1.Location = New System.Drawing.Point(104, 592)
        Me.lblDMMsg1.Name = "lblDMMsg1"
        Me.lblDMMsg1.Size = New System.Drawing.Size(179, 20)
        Me.lblDMMsg1.TabIndex = 22
        Me.lblDMMsg1.Text = "Classic Deathmatch"
        Me.lblDMMsg1.Visible = False
        '
        'lblDMmsg2
        '
        Me.lblDMmsg2.AutoSize = True
        Me.lblDMmsg2.BackColor = System.Drawing.Color.Transparent
        Me.lblDMmsg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDMmsg2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDMmsg2.Location = New System.Drawing.Point(104, 592)
        Me.lblDMmsg2.Name = "lblDMmsg2"
        Me.lblDMmsg2.Size = New System.Drawing.Size(242, 20)
        Me.lblDMmsg2.TabIndex = 23
        Me.lblDMmsg2.Text = "Take on a Team of PeZBots"
        Me.lblDMmsg2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(762, 707)
        Me.Controls.Add(Me.lblSix)
        Me.Controls.Add(Me.lblFive)
        Me.Controls.Add(Me.lblFour)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.lblBotTeam)
        Me.Controls.Add(Me.comboDMType)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.lblKills)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblSkill)
        Me.Controls.Add(Me.lblBots)
        Me.Controls.Add(Me.lblMap)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.comboKills)
        Me.Controls.Add(Me.comboTime)
        Me.Controls.Add(Me.comboSkillLevel)
        Me.Controls.Add(Me.comboBots)
        Me.Controls.Add(Me.comboMap)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDMmsg2)
        Me.Controls.Add(Me.lblDMMsg1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pezbot Launcher 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents comboMap As ComboBox
    Friend WithEvents comboBots As ComboBox
    Friend WithEvents comboSkillLevel As ComboBox
    Friend WithEvents comboTime As ComboBox
    Friend WithEvents comboKills As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents lblMap As Label
    Friend WithEvents lblBots As Label
    Friend WithEvents lblSkill As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblKills As Label
    Friend WithEvents lblSettings As Label
    Friend WithEvents lblBotTeam As Label
    Friend WithEvents comboDMType As ComboBox
    Friend WithEvents lblOne As Label
    Friend WithEvents lblTwo As Label
    Friend WithEvents lblThree As Label
    Friend WithEvents lblFour As Label
    Friend WithEvents lblFive As Label
    Friend WithEvents lblSix As Label
    Friend WithEvents lblDMMsg1 As Label
    Friend WithEvents lblDMmsg2 As Label
End Class
