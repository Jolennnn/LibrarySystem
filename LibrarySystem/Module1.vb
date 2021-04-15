Imports System.Data.SqlClient

Module Module1
    Sub LoadBookInv(table As Object)
        Dim query As String = "SELECT Book.BookId, Book.Title, Book.Author, Book.ISBN, Book.YrPublish, Book.shelfNo, Category.categoryName FROM Book INNER JOIN Category ON Book.idCategory = Category.idCategory"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        table.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Sub LoadBorrow(table As Object)
        Dim query As String = "select * from BookBorrow"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        table.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Sub LoadBorrowers(table As Object)
        Dim query As String = "select * from Student"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        table.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Sub LoadOverdue(table As Object)
        Dim OverdueDT = DateTime.Now.AddDays(-7)
        Dim query As String = "SELECT * FROM BookBorrow WHERE date_borrowed < @date AND date_returned IS NULL"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@date", OverdueDT)
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        table.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

End Module
