Public Class Main
    Public mouseX As Single, mouseY As Single
    Sub ulang()
        large.Hide()
        Small.Hide()
        power.Left = 819
        power.Top = 207
        R1.Left = 764
        R1.Top = 207
        R2.Left = 764
        R2.Top = 250
        R3.Left = 764
        R3.Top = 295
        W1.Left = 764
        W1.Top = 343
        R4.Left = 764
        R4.Top = 390
        W3.Left = 764
        W3.Top = 434
        R5.Left = 764
        R5.Top = 485
        W2.Left = 764
        W2.Top = 538
        OK.Left = 866
        OK.Top = 176
        N1.Left = 838
        N1.Top = 300
        N2.Left = 838
        N2.Top = 348
        N3.Left = 838
        N3.Top = 395
        N4.Left = 838
        N4.Top = 437
        N5.Left = 838
        N5.Top = 485
        R6.Left = 838
        R6.Top = 538
        N7.Left = 899
        N7.Top = 300
        N8.Left = 899
        N8.Top = 348
        N9.Left = 899
        N9.Top = 395
        N10.Left = 899
        N10.Top = 437
        N11.Left = 899
        N11.Top = 485
        N13.Left = 968
        N13.Top = 300
        N14.Left = 968
        N14.Top = 348
        N15.Left = 968
        N15.Top = 395
        N6.Left = 968
        N6.Top = 437
        N12.Left = 968
        N12.Top = 485
    End Sub
    Private Sub power_MouseMove(sender As Object, e As MouseEventArgs) Handles power.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            power.Left += (e.X - mouseX)
            power.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub OK_MouseMove(sender As Object, e As MouseEventArgs) Handles OK.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            OK.Left += (e.X - mouseX)
            OK.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub R1_MouseMove(sender As Object, e As MouseEventArgs) Handles R1.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            R1.Left += (e.X - mouseX)
            R1.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub R2_MouseMove(sender As Object, e As MouseEventArgs) Handles R2.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            R2.Left += (e.X - mouseX)
            R2.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub R3_MouseMove(sender As Object, e As MouseEventArgs) Handles R3.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            R3.Left += (e.X - mouseX)
            R3.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub R4_MouseMove(sender As Object, e As MouseEventArgs) Handles R4.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            R4.Left += (e.X - mouseX)
            R4.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub R5_MouseMove(sender As Object, e As MouseEventArgs) Handles R5.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            R5.Left += (e.X - mouseX)
            R5.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub R6_MouseMove(sender As Object, e As MouseEventArgs) Handles R6.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            R6.Left += (e.X - mouseX)
            R6.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub W1_MouseMove(sender As Object, e As MouseEventArgs) Handles W1.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            W1.Left += (e.X - mouseX)
            W1.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub W2_MouseMove(sender As Object, e As MouseEventArgs) Handles W2.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            W2.Left += (e.X - mouseX)
            W2.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub W3_MouseMove(sender As Object, e As MouseEventArgs) Handles W3.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            W3.Left += (e.X - mouseX)
            W3.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N1_MouseMove(sender As Object, e As MouseEventArgs) Handles N1.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N1.Left += (e.X - mouseX)
            N1.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N2_MouseMove(sender As Object, e As MouseEventArgs) Handles N2.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N2.Left += (e.X - mouseX)
            N2.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N3_MouseMove(sender As Object, e As MouseEventArgs) Handles N3.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N3.Left += (e.X - mouseX)
            N3.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N4_MouseMove(sender As Object, e As MouseEventArgs) Handles N4.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N4.Left += (e.X - mouseX)
            N4.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N5_MouseMove(sender As Object, e As MouseEventArgs) Handles N5.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N5.Left += (e.X - mouseX)
            N5.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N7_MouseMove(sender As Object, e As MouseEventArgs) Handles N7.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N7.Left += (e.X - mouseX)
            N7.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N6_MouseMove(sender As Object, e As MouseEventArgs) Handles N6.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N6.Left += (e.X - mouseX)
            N6.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N8_MouseMove(sender As Object, e As MouseEventArgs) Handles N8.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N8.Left += (e.X - mouseX)
            N8.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N9_MouseMove(sender As Object, e As MouseEventArgs) Handles N9.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N9.Left += (e.X - mouseX)
            N9.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N10_MouseMove(sender As Object, e As MouseEventArgs) Handles N10.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N10.Left += (e.X - mouseX)
            N10.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N11_MouseMove(sender As Object, e As MouseEventArgs) Handles N11.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N11.Left += (e.X - mouseX)
            N11.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N13_MouseMove(sender As Object, e As MouseEventArgs) Handles N13.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N13.Left += (e.X - mouseX)
            N13.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N14_MouseMove(sender As Object, e As MouseEventArgs) Handles N14.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N14.Left += (e.X - mouseX)
            N14.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N15_MouseMove(sender As Object, e As MouseEventArgs) Handles N15.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N15.Left += (e.X - mouseX)
            N15.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub N12_MouseMove(sender As Object, e As MouseEventArgs) Handles N12.MouseMove
        If e.Button = 0 Then
            mouseX = e.X
            mouseY = e.Y
        Else
            N12.Left += (e.X - mouseX)
            N12.Top += (e.Y - mouseY)
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sample.Hide()
        large.Hide()
        Small.Hide()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Sample.Show()
    End Sub

    Private Sub GunaButton1_MouseLeave(sender As Object, e As EventArgs) Handles GunaButton1.MouseLeave
        Sample.Hide()
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        large.Show()
        Small.Hide()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Small.Show()
        large.Hide()
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        large.Hide()
        Small.Hide()
    End Sub

    Private Sub bt_clear_Click(sender As Object, e As EventArgs) Handles bt_clear.Click
        Call ulang()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        GunaTransfarantPictureBox1.Image = My.Resources.Large_Grid
    End Sub
End Class
