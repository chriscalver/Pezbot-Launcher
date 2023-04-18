Public Class Form2

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If rbtnKillCam.Checked = True Then
            Form1.KillCam = "1"
        Else
            Form1.KillCam = "0"
        End If

        If rbtnDeathPoint.Checked = True Then
            Form1.DeathPointLoss = "1"
        Else
            Form1.DeathPointLoss = "0"
        End If

        If rbtnSuicidePoint.Checked = True Then
            Form1.SuicidePointLoss = "1"
        Else
            Form1.SuicidePointLoss = "0"
        End If

        If rbtnGrenades.Checked = True Then
            Form1.Grenades = "1"
        Else
            Form1.Grenades = "0"
        End If

        If rbtnLevel55.Checked = True Then
            Form1.Level55 = "1"
        Else
            Form1.Level55 = "0"
        End If

        If rbtnAirSupport.Checked = True Then
            Form1.AirSupport = "1"
        Else
            Form1.AirSupport = "0"
        End If

        If rbtnFastBots.Checked = True Then
            Form1.FastBots = "1"
        Else
            Form1.FastBots = "0"
        End If

        If rbtnChatter.Checked = True Then
            Form1.Chatter = "1"
        Else
            Form1.Chatter = "0"
        End If

        Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.KillCam = "1" Then
            rbtnKillCam.Checked = True
        End If

        If Form1.DeathPointLoss = "1" Then
            rbtnDeathPoint.Checked = True
        End If

        If Form1.SuicidePointLoss = "1" Then
            rbtnSuicidePoint.Checked = True
        End If

        If Form1.Grenades = "1" Then
            rbtnGrenades.Checked = True
        End If

        If Form1.Level55 = "1" Then
            rbtnLevel55.Checked = True
        End If

        If Form1.AirSupport = "1" Then
            rbtnAirSupport.Checked = True
        End If

        If Form1.FastBots = "1" Then
            rbtnFastBots.Checked = True
        End If

        If Form1.Chatter = "1" Then
            rbtnChatter.Checked = True
        End If
    End Sub
End Class