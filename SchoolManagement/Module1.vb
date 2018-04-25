Imports System.Data.OleDb
Module Module1
    ' Creates Database Connection
    Public DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
                                         " Data Source=|DataDirectory|\SchoolMan.accdb")

End Module
