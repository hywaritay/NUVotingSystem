Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Imports System.Diagnostics
Public Class Results
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Dim connection2 As New MY_CONNECTION()

        connection.openConnection()




        Dim adapter As New MySqlDataAdapter("SELECT fullname,students_id,program,image,totalvote FROM candidate_tbl where electionname ='" & cmbElection.Text & "' ", connection.getConnection)
        Dim table As New DataTable()

        adapter.Fill(table)

        GunaDataGridView1.AllowUserToAddRows = False

        GunaDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        GunaDataGridView1.RowTemplate.Height = 100

        Dim imgc As New DataGridViewImageColumn()

        GunaDataGridView1.DataSource = table
        imgc = GunaDataGridView1.Columns(3)

        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

        If table.Rows.Count > 0 Then
            Chart1.Series(0).Name = table.Rows(0).Item("fullname").ToString()
            Chart1.Series(1).Name = table.Rows(1).Item("fullname").ToString()
            Chart1.Series(0).Points.Add(table.Rows(0).Item("totalvote").ToString())
            Chart1.Series(1).Points.AddY(table.Rows(1).Item("totalvote").ToString())

        End If



    End Sub
End Class