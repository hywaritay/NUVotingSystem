Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Add_election
    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click

    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        If Len(Trim(txtElectionName.Text)) = 0 Then
            MessageBox.Show("please enter election name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtElectionName.Focus()
            Exit Sub
        End If

        If Len(Trim(election_start_date.Text)) = 0 Then
            MessageBox.Show("please enter election start date ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            election_start_date.Focus()
            Exit Sub
        End If

        If Len(Trim(election_end_date.Text)) = 0 Then
            MessageBox.Show("please enter election end date ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            election_end_date.Focus()
            Exit Sub
        End If



        ' add the new user
        Dim conn As New MY_CONNECTION()

        conn.openConnection()

        Dim command As New MySqlCommand("INSERT INTO election(election_name, electionstartdate, electionenddate) VALUES ('" & txtElectionName.Text & "','" & election_start_date.Text & "','" & election_end_date.Text & "')", conn.getConnection)




        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Election Successfully Added!!!", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT * FROM election", conn.getConnection)

            adapter.Fill(table)

            GunaDataGridView1.DataSource = table


        Else

            MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If

        conn.closeConnection()

        txtElectionName.Text = " "


    End Sub

    Private Sub Add_election_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MY_CONNECTION()

        connection.openConnection()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM election", connection.getConnection)
        Dim table As New DataTable()

        adapter.Fill(table)

        GunaDataGridView1.DataSource = table



    End Sub

    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        GunaTextBox1.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtElectionName.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        election_start_date.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        election_end_date.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()

    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        Dim conn As New MY_CONNECTION()
        Try

            conn.openConnection()
            Dim mysc2 As New MySqlCommand("UPDATE election SET election_name='" & txtElectionName.Text & "',electionstartdate='" & election_start_date.Text & "',electionenddate='" & election_end_date.Text & "' " & "WHERE election_id='" & GunaTextBox1.Text & "'", conn.getConnection())
            mysc2.ExecuteNonQuery()
            MsgBox("election successfully updated!", MsgBoxStyle.Information)
            GunaTextBox1.Text = ""
            txtElectionName.Text = ""


            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT * FROM election", conn.getConnection)

            adapter.Fill(table)

            GunaDataGridView1.DataSource = table
            conn.closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.closeConnection()
        End Try

    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        Dim conn As New MY_CONNECTION()
        Try

            conn.openConnection()
            Dim mysc1 As New MySqlCommand("DELETE FROM election WHERE election_id='" & GunaTextBox1.Text & "'", conn.getConnection())
            mysc1.ExecuteNonQuery()
            MsgBox("Record Deleted successfully!", MsgBoxStyle.Information)
            GunaTextBox1.Text = ""
            txtElectionName.Text = ""


            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT * FROM election", conn.getConnection)

            adapter.Fill(table)

            GunaDataGridView1.DataSource = table
            conn.closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.closeConnection()
        End Try

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GunaGradientButton4_Click(sender As Object, e As EventArgs) Handles GunaGradientButton4.Click
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub Add_election_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class