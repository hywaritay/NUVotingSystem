Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Imports System.Diagnostics
Public Class Add_Candidate
    Dim imgpath As String
    Private Sub Add_Candidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MY_CONNECTION()

        connection.openConnection()
        Dim adapter2 As New MySqlDataAdapter("SELECT `election_id`, `election_name` FROM election", connection.getConnection)
        Dim table2 As New DataTable()

        adapter2.Fill(table2)

        cmbElection.DataSource = table2

        cmbElection.ValueMember = "election_name"
        cmbElection.DisplayMember = "election_name"

        Dim adapter As New MySqlDataAdapter("SELECT * FROM candidate_tbl", connection.getConnection)
        Dim table As New DataTable()

        adapter.Fill(table)

        GunaDataGridView1.AllowUserToAddRows = False

        GunaDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        GunaDataGridView1.RowTemplate.Height = 100

        Dim imgc As New DataGridViewImageColumn()

        GunaDataGridView1.DataSource = table
        imgc = GunaDataGridView1.Columns(7)

        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs) Handles GunaLabel4.Click

    End Sub

    Private Sub GunaTextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs) Handles GunaLabel5.Click

    End Sub

    Private Sub GunaTextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click

        Dim connection As New MY_CONNECTION()
        Dim ms As New MemoryStream
        GunaPictureBox1.Image.Save(ms, GunaPictureBox1.Image.RawFormat)

        Dim command As New MySqlCommand("INSERT INTO `candidate_tbl`(`fullname`, `students_id`, `programType`, `program`, `year`, `electionname`, `image`) VALUES (@fn,@sd,@pt,@pg,@yr,@en,@img)", connection.getConnection())

        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtFullName.Text
        command.Parameters.Add("@sd", MySqlDbType.Int64).Value = txtStudentID.Text
        command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = cmbProgType.Text
        command.Parameters.Add("@pg", MySqlDbType.VarChar).Value = cmbProg.Text
        command.Parameters.Add("@yr", MySqlDbType.VarChar).Value = cmbYear.Text
        command.Parameters.Add("@en", MySqlDbType.VarChar).Value = cmbElection.Text
        command.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray()

        connection.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Student Record has been Successfully Inserted!!!")
            txtID.Text = ""
            txtStudentID.Text = ""
            txtFullName.Text = ""
            cmbProgType.SelectedIndex = 0
            cmbProg.SelectedIndex = 0
            cmbYear.SelectedIndex = 0
            cmbElection.SelectedIndex = 0
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT * FROM candidate_tbl", connection.getConnection)

            adapter.Fill(table)
            GunaDataGridView1.AllowUserToAddRows = False

            GunaDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            GunaDataGridView1.RowTemplate.Height = 100

            Dim imgc As New DataGridViewImageColumn()

            GunaDataGridView1.DataSource = table
            imgc = GunaDataGridView1.Columns(7)

            imgc.ImageLayout = DataGridViewImageCellLayout.Stretch


        Else
            MessageBox.Show("Unable to Insert Record")
        End If

        connection.closeConnection()

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                GunaPictureBox1.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        txtID.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtFullName.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        txtStudentID.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        cmbProgType.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        cmbProg.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        cmbYear.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
        cmbElection.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Dim connection As New MY_CONNECTION()
        Dim ms As New MemoryStream
        GunaPictureBox1.Image.Save(ms, GunaPictureBox1.Image.RawFormat)

        Dim command As New MySqlCommand("UPDATE  `candidate_tbl` SET `fullname`=@fn, `students_id`=@sd, `programType`=@pt, `program`=@pg, `year`=@yr, `electionname`=@en, `image`=@img Where candidate_id = '" & txtID.Text & "'", connection.getConnection())

        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtFullName.Text
        command.Parameters.Add("@sd", MySqlDbType.Int64).Value = txtStudentID.Text
        command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = cmbProgType.Text
        command.Parameters.Add("@pg", MySqlDbType.VarChar).Value = cmbProg.Text
        command.Parameters.Add("@yr", MySqlDbType.VarChar).Value = cmbYear.Text
        command.Parameters.Add("@en", MySqlDbType.VarChar).Value = cmbElection.Text
        command.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray()

        connection.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Candidate Record has been Successfully Updated!!!")
            txtID.Text = ""
            txtStudentID.Text = ""
            txtFullName.Text = ""
            cmbProgType.SelectedIndex = 0
            cmbProg.SelectedIndex = 0
            cmbYear.SelectedIndex = 0
            cmbElection.SelectedIndex = 0
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT * FROM candidate_tbl", connection.getConnection)

            adapter.Fill(table)

            GunaDataGridView1.AllowUserToAddRows = False

            GunaDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            GunaDataGridView1.RowTemplate.Height = 100

            Dim imgc As New DataGridViewImageColumn()

            GunaDataGridView1.DataSource = table
            imgc = GunaDataGridView1.Columns(7)

            imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

        Else
            MessageBox.Show("Unable to Update Record")
        End If

        connection.closeConnection()
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        Dim conn As New MY_CONNECTION()
        Try

            conn.openConnection()
            Dim mysc1 As New MySqlCommand("DELETE FROM candidate_tbl WHERE candidate_id='" & txtID.Text & "'", conn.getConnection())
            mysc1.ExecuteNonQuery()
            MsgBox("Record Deleted successfully!", MsgBoxStyle.Information)
            txtID.Text = ""
            txtStudentID.Text = ""
            txtFullName.Text = ""
            cmbProgType.SelectedIndex = 0
            cmbProg.SelectedIndex = 0
            cmbYear.SelectedIndex = 0
            cmbElection.SelectedIndex = 0

            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT * FROM candidate_tbl", conn.getConnection)

            adapter.Fill(table)

            GunaDataGridView1.AllowUserToAddRows = False

            GunaDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            GunaDataGridView1.RowTemplate.Height = 100

            Dim imgc As New DataGridViewImageColumn()

            GunaDataGridView1.DataSource = table
            imgc = GunaDataGridView1.Columns(7)

            imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
            conn.closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.closeConnection()
        End Try

    End Sub

    Private Sub Add_Candidate_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave

    End Sub

    Private Sub Add_Candidate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim mainMenu As New Main_Menu
        mainMenu.Show()
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        txtID.Text = ""
        txtStudentID.Text = ""
        txtFullName.Text = ""
        cmbProgType.SelectedIndex = 0
        cmbProg.SelectedIndex = 0
        cmbYear.SelectedIndex = 0
        cmbElection.SelectedIndex = 0
    End Sub
End Class