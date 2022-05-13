Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Imports System.Diagnostics
Public Class Vote

    Dim voteAuthObj As VoteAuth


    Public Sub New(ByVal voteAuthobj2 As VoteAuth)

        ' This call is required by the designer.
        InitializeComponent()
        voteAuthObj = voteAuthobj2
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Vote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaTextBox1.Text = voteAuthObj.txtPass.Text

        Dim connection As New MY_CONNECTION()

        connection.openConnection()
        Dim adapter2 As New MySqlDataAdapter("SELECT `election_id`, `election_name` FROM election", connection.getConnection)
        Dim table2 As New DataTable()

        adapter2.Fill(table2)

        cmbElection.DataSource = table2

        cmbElection.ValueMember = "election_name"
        cmbElection.DisplayMember = "election_name"


    End Sub

    Private Sub cmbElection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbElection.SelectedIndexChanged
        Dim connection As New MY_CONNECTION()

        connection.openConnection()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM candidate_tbl where electionname ='" & cmbElection.Text & "' ", connection.getConnection)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            GunaRadioButton1.Text = table.Rows(0).Item("fullname").ToString()
            GunaRadioButton2.Text = table.Rows(1).Item("fullname").ToString()
        End If




    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Dim connection1 As New MY_CONNECTION()
        Dim connection2 As New MY_CONNECTION()



        connection1.openConnection()

        Dim cmd As New MySqlCommand("SELECT electionstartdate,electionenddate FROM election where election_name ='" & cmbElection.Text & "' ", connection1.getConnection)
        Dim reader As MySqlDataReader = cmd.ExecuteReader



        If GunaRadioButton1.Checked Then

            While reader.Read

                If (Date.Compare(Date.Now.ToShortDateString(), reader(0)) >= 0) And (Date.Compare(Date.Now.ToShortDateString(), reader(1)) < 0) Then

                    Dim connection3 As New MY_CONNECTION()
                    connection3.openConnection()
                    Dim adapter3 As New MySqlDataAdapter("SELECT * FROM voter_tbl where passkey ='" & GunaTextBox1.Text & "' and election_name='" & cmbElection.Text & "' ", connection3.getConnection)
                    Dim table3 As New DataTable()
                    adapter3.Fill(table3)

                    If table3.Rows.Count > 0 Then
                        MessageBox.Show("You have already cast your vote for this election")
                    Else
                        Dim adapter As New MySqlDataAdapter("SELECT * FROM candidate_tbl where electionname ='" & cmbElection.Text & "' ", connection2.getConnection)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        Dim votecount As New Integer
                        votecount = table.Rows(0).Item("totalvote")
                        votecount = votecount + 1

                        connection2.openConnection()
                        Dim command3 As New MySqlCommand("UPDATE  `candidate_tbl` SET  totalvote='" & votecount & "' where fullname ='" & GunaRadioButton1.Text & "' ", connection2.getConnection())
                        Dim command As New MySqlCommand("INSERT INTO voter_tbl(passkey,election_name) VALUES ('" & GunaTextBox1.Text & "','" & cmbElection.Text & "')", connection3.getConnection)
                        If command3.ExecuteNonQuery() = 1 And command.ExecuteNonQuery() = 1 Then
                            MessageBox.Show("vote casted successfully")
                        Else
                            MessageBox.Show("unable to caste successfully")
                        End If
                    End If

                Else
                    MsgBox("Voting has beeen closed or not yet started")
                End If
            End While

        ElseIf GunaRadioButton2.Checked Then

            While reader.Read
                If (Date.Compare(Date.Now.ToShortDateString(), reader(0)) >= 0) And (Date.Compare(Date.Now.ToShortDateString(), reader(1)) < 0) Then

                    Dim connection3 As New MY_CONNECTION()
                    connection3.openConnection()
                    Dim adapter3 As New MySqlDataAdapter("SELECT * FROM voter_tbl where passkey ='" & GunaTextBox1.Text & "' and election_name='" & cmbElection.Text & "' ", connection3.getConnection)
                    Dim table3 As New DataTable()
                    adapter3.Fill(table3)

                    If table3.Rows.Count > 0 Then
                        MessageBox.Show("You have already cast your vote for this election")
                    Else
                        Dim adapter As New MySqlDataAdapter("SELECT * FROM candidate_tbl where electionname ='" & cmbElection.Text & "' ", connection2.getConnection)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        Dim votecount As New Integer
                        votecount = table.Rows(0).Item("totalvote")
                        votecount = votecount + 1

                        connection2.openConnection()
                        Dim command3 As New MySqlCommand("UPDATE  `candidate_tbl` SET  totalvote='" & votecount & "' where fullname ='" & GunaRadioButton2.Text & "' ", connection2.getConnection())
                        Dim command As New MySqlCommand("INSERT INTO voter_tbl(passkey,election_name) VALUES ('" & GunaTextBox1.Text & "','" & cmbElection.Text & "')", connection3.getConnection)
                        If command3.ExecuteNonQuery() = 1 And command.ExecuteNonQuery() = 1 Then
                            MessageBox.Show("vote casted successfully")

                        Else
                            MessageBox.Show("unable to caste successfully")
                        End If
                    End If
                Else
                    MsgBox("Voting has beeen closed or not yet started")
                End If
            End While

        End If

        connection1.closeConnection()
        connection2.closeConnection()

    End Sub
End Class