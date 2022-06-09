'사용법:
'Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
'    Dim vsm As VisualStyleManager = New VisualStyleManager()
'    vsm.AddStyle("ButtonStyle1", button1)

'    For Each btn As Control In Me.Controls.OfType(Of Button)
'        If btn IsNot button1 Then
'            vsm.ApplyStyle("ButtonStyle1", btn)
'        End If
'    Next
'End Sub

Public Class VisualStyleManager
    Public ReadOnly StyleDicionary As New Dictionary(Of String, VisualStyle)

    Public Sub AddStyle(ByVal name As String, ByVal control As Control)
        StyleDicionary.Add(name, New VisualStyle(control))
    End Sub

    Public Sub ApplyStyle(ByVal stylename As String, ByVal control As Control)
        Dim vs As New VisualStyle(control)
        If StyleDicionary.TryGetValue(stylename, vs) Then
            control.BackColor = vs.CBackColor
            control.ForeColor = vs.CForeColor
            control.Font = vs.CFont
        End If
    End Sub


End Class

Public Class VisualStyle
    Public ReadOnly Property CBackColor As Color
    Public ReadOnly Property CForeColor As Color
    Public ReadOnly Property CFont As Font

    Public Sub New(ByVal control As Control)
        CBackColor = control.BackColor
        CForeColor = control.ForeColor
        CFont = control.Font
    End Sub

End Class