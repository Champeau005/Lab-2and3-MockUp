'Program Name:Spring Break Travel Specials
'Date: 12/19/23
'Author:Tabitha Champeau
'Purpose: The Student Center on campus has created special Spring Break travel specials on three trips.
'A student can choose one of three Spring Break trips. The program must display each of the Spring Break
'travel specials upon request. The student can then select a trip for purchase. 
Public Class frmSpringBreak
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes Program
        Close()
    End Sub

    Private Sub cboSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelect.SelectedIndexChanged
        'Allows user to select trip, display picture associated with trip, and enable purchase button
        If cboSelect.SelectedItem = "Myrtle Beach" Then
            pbxDestination.Visible = True
            pbxDestination.BackgroundImage = Lab_2and3_MockUp.My.Resources.Resources.Myrtle
            btnPurchase.Enabled = True
        ElseIf cboSelect.SelectedItem = "Key West" Then
            pbxDestination.Visible = True
            pbxDestination.BackgroundImage = Lab_2and3_MockUp.My.Resources.Resources.KeyWest
            btnPurchase.Enabled = True
        ElseIf cboSelect.SelectedItem = "Venice Beach" Then
            pbxDestination.Visible = True
            pbxDestination.BackgroundImage = Lab_2and3_MockUp.My.Resources.Resources.VeniceBeach
            btnPurchase.Enabled = True
        End If
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        'disables purchase button and displays message Enjoy Your Trip!
        btnPurchase.Enabled = False
        lblEnjoy.Visible = True
    End Sub
End Class
