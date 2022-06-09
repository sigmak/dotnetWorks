Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim vsm As VisualStyleManager = New VisualStyleManager()
        vsm.AddStyle("ButtonStyle1", button1)

        For Each btn As Control In Me.Controls.OfType(Of Button)
            If btn IsNot button1 Then
                vsm.ApplyStyle("ButtonStyle1", btn)
            End If
        Next



    End Sub
End Class
