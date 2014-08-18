Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class frmLogin
    Dim MysqlConn As MySqlConnection
    Dim intCount As Integer
    Private Sub ClearDataField()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearDataField()
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        'If Username and Password is Blank
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MessageBox.Show("Please enter in your Username and Password!")
        Else
            Try
                'Connect to MySQL
                MysqlConn = New MySqlConnection()
                MysqlConn.ConnectionString = "server=203.175.174.208; user id=tenmensc_admin; password=TMCadmin2014; database=tenmensc_tmcpos;"

                'Check Connection

                MysqlConn.Open()
                Dim myAdapter As New MySqlDataAdapter
                Dim sqlquerry = "SELECT staffID, staffName, staffRole, staffLock FROM staff WHERE staffUsername = '" & txtUsername.Text & "' AND staffPassword = '" & txtPassword.Text & "'"
                Dim myCommand As New MySqlCommand()
                myCommand.Connection = MysqlConn
                myCommand.CommandText = sqlquerry
                'Starting The Query
                Dim mydata As MySqlDataReader
                mydata = myCommand.ExecuteReader
                myAdapter.SelectCommand = myCommand
                    'To check the Username and password and to validate the login
                    If mydata.HasRows = 0 Then
                        'Count the error input
                        MessageBox.Show("Invalid password")
                        intCount = intCount + 1
                    Else
                    Dim user_number As String = UCase(txtUsername.Text)
                    mydata.Read()
                    Dim user_lock As Integer
                    user_lock = mydata("staffLock")
                    Dim user_type As String
                    user_type = mydata("staffRole")
                    Dim user_name As String
                    user_name = mydata("staffName")
                    Dim user_id As Integer
                    user_id = mydata("staffID")
                        Dim Success As Boolean

                        If user_lock = 1 Then
                            MsgBox("User Account is locked")
                        Else
                            Select Case (user_type)
                            Case "admin"
                                MsgBox("Welcome admin")
                                Success = True
                                Case 2
                                    MsgBox("Welcome Staff")
                                    Success = True
                                Case 3
                                    MsgBox("Welcome Member")
                                    Success = True
                                Case Else
                                    MsgBox("User Role does not exist! Please contact the system administrator.")
                                    Success = False
                            End Select
                            'Disconnect SQL
                            MysqlConn.Close()
                            MysqlConn.Dispose()

                            'Success status - Boolean
                            If Success = True Then
                            MsgBox("Welcome " + user_name)
                            frmMain.Login(user_id)
                            ClearDataField()
                            Else
                                Me.Dispose()
                            End If
                        End If
                    End If
            Catch myerror As MySqlException
                MessageBox.Show("Cannot connect to database: " & myerror.Message)
            End Try
        End If

        'If the error input is 3 times and above error message will prompt
        If intCount > 2 Then
            MessageBox.Show("You have enter the wrong login details more than 3 times", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
End Class