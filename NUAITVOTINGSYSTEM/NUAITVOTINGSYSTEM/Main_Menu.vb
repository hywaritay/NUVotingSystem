Public Class Main_Menu
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Hide()
        Add_election.Show()
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        Me.Hide()
        Add_Candidate.Show()
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        Me.Hide()
        Add_Student.Show()
    End Sub

    Private Sub GunaGradientButton4_Click(sender As Object, e As EventArgs) Handles GunaGradientButton4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Main_Menu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class