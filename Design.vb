Module Design

    Public Sub Opacity(ByVal pnl As Panel, ByVal x As Integer, ByVal color As Color)    'wala pa nagamit
        pnl.BackColor() = Color.FromArgb(x, color)
    End Sub

    Public Sub BringToFrontPanel(ByVal Panel As Panel)  'para sa transitions sa panel
        Panel.BringToFront()
    End Sub
End Module
