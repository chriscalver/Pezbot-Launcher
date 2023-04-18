Public Class Form1

    Public KillCam As String = "0"
    Public DeathPointLoss As String = "0"
    Public SuicidePointLoss As String = "0"
    Public Grenades As String = "0"
    Public Level55 As String = "0"
    Public AirSupport As String = "0"
    Public FastBots As String = "0"
    Public Chatter As String = "0"

    Private SelectedMap As String
    Private BotNumber As Integer
    Private SkillLevel As Double
    Private TimeLimit As Integer
    Private KillLimit As Integer
    Private DMType As String
    Private directory = My.Application.Info.DirectoryPath

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim pezbotdirectory = directory & "\usermaps\"

        Dim dirinfo As New System.IO.DirectoryInfo(pezbotdirectory)
        Dim files() As System.IO.FileInfo
        files = dirinfo.GetFiles("*.iwd", IO.SearchOption.AllDirectories)

        'Dim savdirinfo As New System.IO.DirectoryInfo(directory)
        'Dim savfiles() As System.IO.FileInfo
        'savfiles = savdirinfo.GetFiles("*.sav", IO.SearchOption.TopDirectoryOnly)

        comboMap.Items.Add("mp_convoy.iwd(Ambush)")
        comboMap.Items.Add("mp_backlot.iwd(Backlot)")
        comboMap.Items.Add("mp_bloc.iwd(Bloc)")
        comboMap.Items.Add("mp_bog.iwd(Bog)")
        comboMap.Items.Add("mp_countdown.iwd(Countdown)")
        comboMap.Items.Add("mp_crash.iwd(Crash)")
        comboMap.Items.Add("mp_crossfire.iwd(Crossfire)")
        comboMap.Items.Add("mp_citystreets.iwd(District)")
        comboMap.Items.Add("mp_farm.iwd(Downpour)")
        comboMap.Items.Add("mp_overgrown.iwd(Overgrown)")
        comboMap.Items.Add("mp_pipeline.iwd(Pipeline)")
        comboMap.Items.Add("mp_shipment.iwd(Shipment)")
        comboMap.Items.Add("mp_showdown.iwd(Showdown)")
        comboMap.Items.Add("mp_strike.iwd(Strike)")
        comboMap.Items.Add("mp_vacant.iwd(Vacant)")
        comboMap.Items.Add("mp_cargoship.iwd(Wet Work)")
        comboMap.Items.Add("mp_crash_snow.iwd(Winter Crash)")
        comboMap.Items.Add("mp_broadcast.iwd(Broadcast)")
        comboMap.Items.Add("mp_carentan.iwd(Chinatown)")
        comboMap.Items.Add("mp_creek.iwd(Creek)")
        comboMap.Items.Add("mp_killhouse.iwd(Killhouse)")


        For Each file In files

            Dim MPname As String = file.Name
            Dim testForMP As String = MPname.Substring(0, 2)

            If file.Name = "PeZBOT.iwd" Or file.Name = "pezbot.iwd" Then
                'Do nothing
            Else
                If testForMP = "mp" Then
                    comboMap.Items.Add(file.Name)
                End If
            End If
        Next

        'Dim Count = savfiles.Count()
        'lblSavedGame.Text = Count

        'If Count = 0 Then
        ' lblSavedGame.Hide()
        ' comboSaves.Hide()
        '   btnReSave.Hide()

        'End If

        'For Each file In savfiles
        ' comboSaves.Items.Add(file.Name)

        ' Next

        Me.comboMap.SelectedIndex = 0

        Dim nums As Integer = 0
        Do While nums < 20
            nums += 1
            comboBots.Items.Add(nums)
        Loop
        Me.comboBots.SelectedIndex = 0

        Dim skill As Integer = 0
        Do While skill < 10
            skill += 1
            comboSkillLevel.Items.Add(skill)
        Loop
        Me.comboSkillLevel.SelectedIndex = 0

        Dim timelimit As Integer = 5
        Do While timelimit < 60
            timelimit += 5
            comboTime.Items.Add(timelimit)
        Loop
        Me.comboTime.SelectedIndex = 0

        Dim kills As Integer = 0
        Do While kills < 1000
            kills += 50
            comboKills.Items.Add(kills)
        Loop
        Me.comboKills.SelectedIndex = 0
        Me.comboDMType.SelectedIndex = 0
    End Sub

    Private Function RemoveBracketsAntContents(inputString As String) As String
        Dim i As Integer
        While i < inputString.Length
            Dim bracketDepth As Integer = 0
            Dim firstBracketIndex As Integer = 0
            Do
                If inputString(i) = "(" Then
                    If firstBracketIndex = 0 Then
                        firstBracketIndex = i
                    End If
                    bracketDepth += 1
                End If
                i += 1
            Loop Until i = inputString.Length OrElse inputString(i) = ")"
            If i = inputString.Length Then Exit While
            Do
                If inputString(i) = ")" Then
                    bracketDepth -= 1
                End If
                i += 1
            Loop Until bracketDepth = 0
            inputString = inputString.Remove(firstBracketIndex, i - firstBracketIndex)
            i = i - (i - firstBracketIndex)
        End While
        inputString = inputString.Replace("  ", " ")
        Return inputString
    End Function


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        SelectedMap = comboMap.SelectedItem
        Dim TempMap As String = RemoveBracketsAntContents(SelectedMap)
        SelectedMap = TempMap.Remove(TempMap.Length - 4)

        BotNumber = comboBots.SelectedItem
        SkillLevel = comboSkillLevel.SelectedItem
        SkillLevel /= 10

        TimeLimit = comboTime.SelectedItem
        KillLimit = comboKills.SelectedItem

        Dim file As System.IO.StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter("PB.bat", False)
        file.WriteLine("@echo off")
        file.WriteLine("start iw3mp.exe +set sv_punkbuster 0 +set fs_game ""mods/PeZBOT""" & " " & "+set g_gametype" & " " & DMType & " " & "+map" & " " & SelectedMap & " " & "+set svr_pezbots_skill" & " " & SkillLevel & " " & "+set scr_dm_timelimit" & " " & TimeLimit & " " & "+set scr_dm_scorelimit" & " " & KillLimit & " " & "+set svr_pezbots_axis" & " " & BotNumber & " " & "+set scr_game_allowkillcam" & " " & KillCam & " " & "+set scr_game_deathpointloss" & " " & DeathPointLoss & " " & "+set scr_game_suicidepointloss" & " " & SuicidePointLoss & " " & "+set set svr_pezbots_grenadepickup" & " " & Grenades & " " & "+set set svr_pezbots_XPcheat" & " " & Level55 & " " & "+set svr_pezbots_dewards" & " " & AirSupport & " " & "+set svr_pezbots_playstyle" & " " & FastBots & " " & "+set svr_pezbots_chatter" & " " & Chatter)

        file.Close()

        'Shell("PB.bat")

    End Sub

    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles lblSettings.Click
        Form2.Show()
    End Sub


    Private Sub comboTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboDMType.SelectedIndexChanged
        DMType = comboDMType.SelectedItem

        If DMType = "Free for All Mode" Then
            lblDMMsg1.Show()
            lblDMmsg2.Hide()
            DMType = "DM"
        Else
            lblDMMsg1.Hide()
            lblDMmsg2.Show()
            DMType = "WAR"
        End If
        btnStart.Show()

    End Sub

    Private Sub lblMap_Click(sender As Object, e As EventArgs) Handles lblMap.Click

    End Sub
End Class
