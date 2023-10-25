Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Myconnection = New MySqlConnection(MyconnectionString)
            Myconnection.Open()
            If Myconnection.State = ConnectionState.Open Then
                MessageBox.Show("Connection Successful")
            Else
                MessageBox.Show("Connection Falied")
            End If
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            If Myconnection IsNot Nothing Then
                Myconnection.Close()
            End If
            MSSQL_MYSQL_INSERTRECORDS.Show()
            Me.Hide()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MSconnection = New SqlConnection(MSconnectionString)
        Try
            MSconnection.Open()
            If MSconnection.State = ConnectionState.Open Then
                MessageBox.Show("Connection Success")
            Else
                MessageBox.Show("Connection Falied")

            End If
        Catch ex As SqlException
            MessageBox.Show("Error:" & ex.Message)
        Finally
            If MSconnection IsNot Nothing Then
                MSconnection.Close()
            End If
            MSSQL_MYSQL_INSERTRECORDS.Show()
            Me.Hide()

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
