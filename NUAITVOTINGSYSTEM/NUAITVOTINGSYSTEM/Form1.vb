Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim conn As New MY_CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `adminlogin_tbl` WHERE `username` = @usn AND `password` = @pass", conn.getConnection())

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUser.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPass.Text

        If txtUser.Text.Trim() = "" Or txtUser.Text.Trim().ToLower() = "username" Then

            MessageBox.Show("Enter Your Username To Login", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUser.Focus()
        ElseIf txtPass.Text.Trim() = "" Or txtPass.Text.Trim().ToLower() = "password" Then

            MessageBox.Show("Enter Your Password To Login", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPass.Focus()
        Else

            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                Me.Hide()
                Main_Menu.Show()
            Else

                MessageBox.Show("This Username Or Password Doesn't Exists", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If


    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Dim voteAuthobj As New VoteAuth
        Me.Hide()
        voteAuthobj.Show()

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Dim resultobj As New Results
        Me.Hide()
        resultobj.Show()
    End Sub
End Class
