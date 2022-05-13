Imports System.IO
Imports MySql.Data.MySqlClient
Public Class VoteAuth

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Dim conn As New MY_CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT `passkey` FROM `student_tbl` WHERE  `passkey` = @pass", conn.getConnection())


        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPass.Text


        If txtPass.Text.Trim() = "" Or txtPass.Text.Trim().ToLower() = "password" Then

            MessageBox.Show("Enter Your PIN CODE To Vote", "Missing PIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPass.Focus()
        Else

            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                Dim voteTextBox As New Vote(Me)
                Me.Hide()
                voteTextBox.Show()

            Else

                MessageBox.Show("Incorrect Pin Code", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPass.Text = ""

            End If

        End If
    End Sub

    Private Sub VoteAuth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class