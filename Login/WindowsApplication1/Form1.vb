Public Class Form1


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static C As Integer
        C = C + 1
        If C = 1 Then
            Label1.ForeColor = Color.Red
        ElseIf C = 2 Then
            Label1.ForeColor = Color.Black
        Else : C = 2
            C = 0

        End If

    End Sub

End Class