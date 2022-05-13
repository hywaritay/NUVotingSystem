Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Imports System.Diagnostics
Public Class Add_Student
    Dim imgpath As String

    Private Sub Add_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MY_CONNECTION()

        connection.openConnection()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM student_tbl", connection.getConnection)
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

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Dim conn As New MY_CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command2 As New MySqlCommand("SELECT * FROM `student_tbl` WHERE `students_id` = '" & txtStudentID.Text & "'", conn.getConnection())

        adapter.SelectCommand = command2
        adapter.Fill(table)

        If table.Rows.Count > 0 Then

            MessageBox.Show("Student ID has already been Recorded!!!")

        Else
            conn.closeConnection()
            Dim connection As New MY_CONNECTION()
            Dim ms As New MemoryStream
            GunaPictureBox1.Image.Save(ms, GunaPictureBox1.Image.RawFormat)



            Dim command As New MySqlCommand("INSERT INTO `student_tbl`(`fullname`, `students_id`, `programType`, `program`, `year`, `passkey`, `image`) VALUES (@fn,@sd,@pt,@pg,@yr,@pk,@img)", connection.getConnection())

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtFullName.Text
            command.Parameters.Add("@sd", MySqlDbType.Int64).Value = txtStudentID.Text
            command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = cmbProgType.Text
            command.Parameters.Add("@pg", MySqlDbType.VarChar).Value = cmbProg.Text
            command.Parameters.Add("@yr", MySqlDbType.VarChar).Value = cmbYear.Text
            command.Parameters.Add("@pk", MySqlDbType.VarChar).Value = txtPassKey.Text
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
                Dim table2 As New DataTable()
                Dim adapter2 As New MySqlDataAdapter("SELECT * FROM student_tbl", connection.getConnection())

                adapter2.Fill(table2)
                GunaDataGridView1.AllowUserToAddRows = False

                GunaDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                GunaDataGridView1.RowTemplate.Height = 100

                Dim imgc As New DataGridViewImageColumn()

                GunaDataGridView1.DataSource = table2
                imgc = GunaDataGridView1.Columns(7)

                imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
                connection.closeConnection()

            Else
                MessageBox.Show("Unable to Insert Record")
            End If
        End If





    End Sub

    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        txtID.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtFullName.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        txtStudentID.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        cmbProgType.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        cmbProg.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        cmbYear.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
        txtPassKey.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()


    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Dim connection As New MY_CONNECTION()
        Dim ms As New MemoryStream
        GunaPictureBox1.Image.Save(ms, GunaPictureBox1.Image.RawFormat)

        Dim command As New MySqlCommand("UPDATE  `student_tbl` SET `fullname`=@fn, `students_id`=@sd, `programType`=@pt, `program`=@pg, `year`=@yr, `passkey`=@pk, `image`=@img WHERE student_id='" & txtID.Text & "'", connection.getConnection())

        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtFullName.Text
        command.Parameters.Add("@sd", MySqlDbType.Int64).Value = txtStudentID.Text
        command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = cmbProgType.Text
        command.Parameters.Add("@pg", MySqlDbType.VarChar).Value = cmbProg.Text
        command.Parameters.Add("@yr", MySqlDbType.VarChar).Value = cmbYear.Text
        command.Parameters.Add("@pk", MySqlDbType.VarChar).Value = txtPassKey.Text
        command.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray()

        connection.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Student Record has been Successfully Updated!!!")
            txtID.Text = ""
            txtStudentID.Text = ""
            txtFullName.Text = ""
            cmbProgType.SelectedIndex = 0
            cmbProg.SelectedIndex = 0
            cmbYear.SelectedIndex = 0
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT * FROM student_tbl", connection.getConnection)

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
            Dim mysc1 As New MySqlCommand("DELETE FROM student_tbl WHERE student_id='" & txtID.Text & "'", conn.getConnection())
        mysc1.ExecuteNonQuery()
            MsgBox("Record Deleted successfully!", MsgBoxStyle.Information)
            txtID.Text = ""
            txtStudentID.Text = ""
            txtFullName.Text = ""
            cmbProgType.SelectedIndex = 0
            cmbProg.SelectedIndex = 0
            cmbYear.SelectedIndex = 0

            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter("SELECT * FROM student_tbl", conn.getConnection)

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

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        Dim myuuid As Guid = Guid.NewGuid()
        Dim myuuidAsString As String = myuuid.ToString()

        txtPassKey.Text = myuuidAsString
    End Sub

    Private Sub Add_Student_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim mainMenu As New Main_Menu
        mainMenu.Show()
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        txtID.Text = ""
        txtStudentID.Text = ""
        txtFullName.Text = ""
        cmbProgType.SelectedIndex = 0
        cmbProg.SelectedIndex = 0
        cmbYear.SelectedIndex = 0
    End Sub
End Class