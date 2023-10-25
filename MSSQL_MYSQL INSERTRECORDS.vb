Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class MSSQL_MYSQL_INSERTRECORDS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Myconnection = New MySqlConnection(MyconnectionString)
        Try
            Myconnection.Open()

            Dim selectedYear As String = Year.SelectedItem.ToString()
            Dim selectedCourse As String = Course.SelectedItem.ToString()


            Dim query As String = "INSERT INTO tbl_info (Idno,first_name,middle_name,last_name,Year,Course) VALUES (@id,@Fname,@Mname,@Lname,@Year,@Course)"
            Dim cmd As New MySqlCommand(query, Myconnection)

            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@Fname", txtFname.Text)
            cmd.Parameters.AddWithValue("@Mname", txtMname.Text)
            cmd.Parameters.AddWithValue("@Lname", txtLname.Text)
            cmd.Parameters.AddWithValue("@Year", selectedYear)
            cmd.Parameters.AddWithValue("@Course", selectedCourse)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Insert Sucesss")
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            Myconnection.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MSconnection = New SqlConnection(MSconnectionString)
        Try
            MSconnection.Open()

            Dim selectedYear As String = Year.SelectedItem.ToString()
            Dim selectedCourse As String = Course.SelectedItem.ToString()

            Dim query As String = "INSERT INTO tbl_info (Idno,first_name,middle_name,last_name,Year,Course) VALUES (@ID,@Fname,@Mname,@Lname,@Year,@Course)"
            Dim MScommand As New SqlCommand(query, MSconnection)
            MScommand.Parameters.AddWithValue("@Id", txtID.Text)
            MScommand.Parameters.AddWithValue("@Fname", txtFname.Text)
            MScommand.Parameters.AddWithValue("@Mname", txtMname.Text)
            MScommand.Parameters.AddWithValue("@Lname", txtLname.Text)
            MScommand.Parameters.AddWithValue("@Year", selectedYear)
            MScommand.Parameters.AddWithValue("@Course", selectedCourse)
            MScommand.ExecuteNonQuery()

            MessageBox.Show("Records Inserted Successfully")
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            MSconnection.Close()
        End Try
    End Sub

    Private Sub MSSQL_MYSQL_INSERTRECORDS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class