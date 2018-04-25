Imports System.Data.OleDb
Public Class DBControl
    ' Creates Database Connection
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
                                         " Data Source=|DataDirectory|\SchoolMan.accdb")

    ' Preparing Database command
    Private DBCmd As OleDbCommand

    ' Database Data
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable

    ' Queries Parameters
    Public Params As New List(Of OleDbParameter)

    ' Queries Statistics
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        ' Reset query Stats
        RecordCount = 0
        Exception = ""

        Try
            ' Open a connetion
            DBCon.Open()

            ' Creates Database Command
            DBCmd = New OleDbCommand(Query, DBCon)

            ' Loads Params into DB Command
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' Clears params list
            Params.Clear()

            ' Executes commands and fills datatable
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)


        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' Closes connection
        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    End Sub

    ' Includes query and command parameters
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
End Class