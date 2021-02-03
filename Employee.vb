Imports MySql.Data.MySqlClient

Module Employee
    'Connectors, Commands, etc.
    Private dbConn As MySqlConnection   'Connection
    Private sqlCommand As MySqlCommand  'the query
    Private DA As MySqlDataAdapter      'kani mufill sa DataTable
    Private DT As DataTable             'Table consist of Data

    Private strConn = "server=localhost; user=root; database="
    '--------------------------
    'Establishing Connection towards the Form
    Public Sub dbConnection()
        Try
            dbConn = New MySqlConnection(strConn & "db_hotelmanagement")
            dbConn.Open()
            'MessageBox.Show("Database Loaded Successfully")

        Catch ex As Exception
            ErrorMessage("Error 0001: DbConnection" & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub
    'Displaying records to Tables
    Public Sub displayRecords(ByVal SQL As String, ByVal DG As DataGridView)
        Try
            dbConn.Open()
            DA = New MySqlDataAdapter(SQL, dbConn)
            DT = New DataTable
            DA.Fill(DT)
            DG.DataSource = DT

            DG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            ErrorMessage("Error 0002: displayRecords " & ex.Message)
        Finally
            dbConn.Close()
        End Try

    End Sub
    'displaying records to TextBoxes
    Public Sub displayRecords2(ByVal SQL As String, ByVal tb As Object)
        Try
            dbConn.Open()
            DA = New MySqlDataAdapter(SQL, dbConn)
            DT = New DataTable
            DA.Fill(DT)
            tb.Text = CStr(DT.Rows(0)("Username"))

        Catch ex As Exception
            ErrorMessage("Error 0002: displayRecords " & ex.Message)
        Finally
            dbConn.Close()
        End Try

    End Sub
    'Load to ComboBoxes
    Public Sub loadToComboBox(ByVal SQL As String, ByVal cbo As ComboBox)
        Try
            dbConn.Open()
            DA = New MySqlDataAdapter(SQL, dbConn)
            DT = New DataTable
            DA.Fill(DT)
            cbo.DataSource = DT
            cbo.ValueMember = DT.Columns(0).ToString
            cbo.DisplayMember = DT.Columns(1).ToString

        Catch ex As Exception
            MessageBox.Show("Error 0003: loadToComboBox" & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub
    'SQL Proccess , insert, update , delete
    Public Sub SQLProcess(ByVal SQL As String, ByVal val() As String, ByVal value() As String)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(SQL, dbConn)

            With sqlCommand
                Dim i = 0
                For Each record In val
                    ' MsgBox(val(i) & " " & value(i))
                    .Parameters.AddWithValue(val(i), value(i))
                    i = i + 1
                Next
                .CommandType = CommandType.Text
                .ExecuteNonQuery()

            End With

        Catch ex As Exception
            ErrorMessage("Error 0004: SQLProcess" & ex.Message)
        Finally

            dbConn.Close()
        End Try
    End Sub
    'SQP PROCESS -issue: sa update nko gnagamit kay dli mugana sa update ang isa ka SQLPROCESS
    Public Sub SQLProcess(ByVal SQL As String)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(SQL, dbConn)
            With sqlCommand
                '.CommandText = SQL
                .CommandType = CommandType.Text
                '.Connection = dbConn
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            ErrorMessage("Error 103: SQL Process" & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub
    'counting Records
    Public Function recordCount(ByVal SQL As String)
        Dim row = 0
        Try
            dbConn.Open()
            DA = New MySqlDataAdapter(SQL, dbConn)
            DT = New DataTable
            DA.Fill(DT)
            row = DT.Rows.Count + 1
        Catch ex As Exception
            MessageBox.Show("Error 0005: recordCount" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return row
    End Function
    'ID generator
    Public Function IDGenerator(ByVal combobox As ComboBox) As String
        Dim id As String
        Dim count = recordCount("select *from tbl_employee")
        If (combobox.SelectedValue.ToString = 1) Then   'Administrator
            id = "A" & count
        Else
            id = "R" & count
        End If
        Return id
    End Function
    'ErrorMessage
    Sub ErrorMessage(ByVal msg)
        MessageBox.Show(msg)
    End Sub
    'Room Category Values
    Public Function RoomCategory(ByVal price As Object, ByVal sc As Object, ByVal desc As RichTextBox, ByVal CategoryName As String)
        Try
            dbConn.Open()
            DA = New MySqlDataAdapter("select *from tbl_roomcategory where CategoryName = '" & CategoryName & "';", dbConn)
            DT = New DataTable
            DA.Fill(DT)


            desc.Text = DT.Rows(0).Item(2)  'for description
            price.Text = DT.Rows(0).Item(3)  'for price
            sc.Text = DT.Rows(0).Item(4)     'for service Charge 

        Catch ex As Exception
            ErrorMessage("Error 0006: RoomCategory " & ex.Message)
        Finally
            dbConn.Close()

        End Try
        Return CategoryName
    End Function
    Public Sub roomStatus(ByVal btn() As Bunifu.Framework.UI.BunifuFlatButton, ByVal SQL As String)
        Try
            dbConn.Open()
            DA = New MySqlDataAdapter(SQL, dbConn)
            DT = New DataTable
            DA.Fill(DT)
            Dim a = 0

            While (a < DT.Rows.Count)
                For i As Integer = 0 To btn.Length - 1

                    If (btn(i).Normalcolor.ToString = "Color [Maroon]") Then

                    Else
                        If (DT.Rows(a).Item(0).ToString = btn(i).Text) Then
                            btn(i).Normalcolor = Color.Maroon


                        Else
                            btn(i).Normalcolor = Color.FromArgb(247, 191, 1)

                        End If
                    End If
                Next
                a += 1
            End While


        Catch ex As Exception
            ErrorMessage("Error 000X: roomStatus " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub
    Public Sub displayRecordsList(ByVal SQL As String, ByVal list As ListBox)
        Try
            dbConn.Open()
            DA = New MySqlDataAdapter(SQL, dbConn)
            DT = New DataTable
            DA.Fill(DT)
            list.DataSource = DT
            list.DisplayMember = DT.Columns(0).ToString

        Catch ex As Exception
            ErrorMessage("Error 000X: displayRecordsList " & ex.Message)
        Finally
            dbConn.Close()
        End Try

    End Sub

    Public Function retrieveID(ByVal SQL As String)
        Dim id = ""
        Try
            dbConn.Open()
            DA = New MySqlDataAdapter(SQL, dbConn)
            DT = New DataTable
            DA.Fill(DT)
            id = DT.Rows(0).Item(0)


        Catch ex As Exception
            'ErrorMessage("Error 000X: retrieveID " & ex.Message)

        Finally
            dbConn.Close()
        End Try
        Return id
    End Function
    Public Sub roomStatusRepair(ByVal btn() As Bunifu.Framework.UI.BunifuFlatButton, ByVal SQL As String)
        Try
            dbConn.Open()
            DA = New MySqlDataAdapter(SQL, dbConn)
            DT = New DataTable
            DA.Fill(DT)
            Dim a = 0

            While (a < DT.Rows.Count)
                For i As Integer = 0 To btn.Length - 1

                    If (DT.Rows(a).Item(1).ToString = "3") Then

                        'ErrorMessage(DT.Rows(a).Item(0).ToString)
                        If (btn(i).Text.Equals(DT.Rows(a).Item(0).ToString)) Then
                            btn(i).Normalcolor = Color.Blue
                        End If
                    Else

                    End If

                Next
                a += 1
            End While


        Catch ex As Exception
            ErrorMessage("Error 000X: roomStatus " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub


End Module
