Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports System.Threading.Tasks
Imports System.Web.UI.WebControls
Imports SMSSenderApp.Cls

Public Class SQLControl




    Private DBCon As New SqlConnection(String.Format("Server={0};Database={1};User Id=sa;Password=13112020;", ClsDef.MyServer, ClsDef.MyDataBase))


    Private DBCmd As SqlCommand

    ' DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    ' QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)


    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String
    Public RuningQuery As String

    Public Sub New()
    End Sub

    ' ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(DBName As String)
        If ClsDef.MyServer Is Nothing Then Return

        If DBName Is Nothing Then DBName = ClsDef.MyDataBase & "_Files"
        If DBName = "" Then DBName = ClsDef.MyDataBase & "_Files"

        DBCon = New SqlConnection(String.Format("Server={0};Database={1};User Id=sa;Password=13112020;", ClsDef.MyServer, DBName))
    End Sub
    Public Sub New(ServerName As String, DBName As String)


        DBCon = New SqlConnection(String.Format("Server={0};Database={1};User Id=sa;Password=13112020;", ServerName, DBName))
    End Sub
    ' EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String, Optional ReturnIdentity As Boolean = False)
        'If IsRemoteUser = False Then
        '    If ClsDef.MyServer Is Nothing Then DBDT = New DataTable : Return
        'End If

        RuningQuery = Query

        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try

            DBCon.Open()

            ' CREATE DB COMMAND

            DBCmd = New SqlCommand(Query, DBCon)


            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATASET
            DBCmd.CommandTimeout = 0
            DBDT = New DataTable

            DBDA = New SqlDataAdapter(DBCmd)
            DBDA.SelectCommand.CommandTimeout = 700000
            RecordCount = DBDA.Fill(DBDT)
            DBDT.CaseSensitive = False

            If ReturnIdentity = True Then
                Dim ReturnQuery As String = "SELECT @@IDENTITY As LastID;"
                ' @@IDENTITY - SESSION
                ' SCOPE_IDENTITY() - SESSION & SCOPE
                ' IDENT_CURRENT(tablename) - LAST IDENT IN TABLE, ANY SCOPE, ANY SESSION
                DBCmd = New SqlCommand(ReturnQuery, DBCon)
                DBDT = New DataTable
                DBDA = New SqlDataAdapter(DBCmd)
                RecordCount = DBDA.Fill(DBDT)
            End If
        Catch ex As Exception
            ' CAPTURE ERROR

            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub
    
    Public Sub ExecStored(Query As String, Optional ReturnIdentity As Boolean = False)
        If ClsDef.MyServer Is Nothing Then DBDT = New DataTable : Return
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            DBCon.Open()

            ' CREATE DB COMMAND
            Dim DBCmdStored As New SqlCommand(Query, DBCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmdStored.Parameters.Add(p))

            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATASET
            DBCmdStored.CommandTimeout = 0
            DBDT = New DataTable

            DBDA = New SqlDataAdapter(DBCmdStored)
            DBDA.SelectCommand.CommandTimeout = 0
            RecordCount = DBDA.Fill(DBDT)

            If ReturnIdentity = True Then
                Dim ReturnQuery As String = "SELECT @@IDENTITY As LastID;"
                ' @@IDENTITY - SESSION
                ' SCOPE_IDENTITY() - SESSION & SCOPE
                ' IDENT_CURRENT(tablename) - LAST IDENT IN TABLE, ANY SCOPE, ANY SESSION
                DBCmdStored = New SqlCommand(ReturnQuery, DBCon)
                DBDT = New DataTable
                DBDA = New SqlDataAdapter(DBCmdStored)
                RecordCount = DBDA.Fill(DBDT)
            End If
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    Public Function ExecInteger(Query As String) As Object
        If ClsDef.MyServer Is Nothing Then Return Nothing
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New SqlCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

            Dim I
            For Each R As DataRow In DBDT.Rows
                I = Val(R(0).ToString)
            Next

            Return I
        Catch ex As Exception
            ' CAPTURE ERROR

            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
            Return 0
        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()

        End Try

    End Function
    Public Function ExecString(Query As String) As String
        If ClsDef.MyServer Is Nothing Then Return ""
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New SqlCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

            Dim I As String
            For Each R As DataRow In DBDT.Rows
                I = R(0).ToString
            Next

            Return I
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
            Return 0
        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()

        End Try

    End Function

    ' ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Public Sub AddParmStructured(Name As String, Value As Object, StructTypeName As String)
        Dim NewParam As New SqlParameter(Name, Value) With {
            .SqlDbType = SqlDbType.Structured,
            .TypeName = StructTypeName
        }
        Params.Add(NewParam)
    End Sub
    Public Sub AddParmImage(Name As String, Value As Drawing.Image)
        If Value IsNot Nothing Then
            Dim mstr As IO.MemoryStream = New IO.MemoryStream
            Dim arrImage() As Byte
            Dim myimage As Drawing.Image = Value
            myimage.Save(mstr, Imaging.ImageFormat.Png)
            arrImage = mstr.GetBuffer

            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary, arrImage.Length) With {
                .Value = arrImage, .Direction = ParameterDirection.Input
            }
            Params.Add(NewParam)
        Else
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary) With {
        .Value = DBNull.Value
    }
            Params.Add(NewParam)
        End If



    End Sub
    Public Sub AddParmFile(Name As String, filePath As String)
        If filePath IsNot Nothing Then
            Dim mstr As IO.MemoryStream = New IO.MemoryStream
            Dim arrImage() As Byte = System.IO.File.ReadAllBytes(filePath)


            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary, arrImage.Length) With {
                .Value = arrImage, .Direction = ParameterDirection.Input
            }
            Params.Add(NewParam)
        Else
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary) With {
        .Value = DBNull.Value
    }
            Params.Add(NewParam)
        End If



    End Sub
    Public Sub AddParmFile(Name As String, Arr() As Byte)
        If Arr IsNot Nothing Then


            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary, Arr.Length) With {
                .Value = Arr, .Direction = ParameterDirection.Input
            }
            Params.Add(NewParam)
        Else
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary) With {
        .Value = DBNull.Value
    }
            Params.Add(NewParam)
        End If



    End Sub
    Public Sub AddParmFileStream(Name As String, Stream As IO.MemoryStream)

        Dim Arr() As Byte = Stream.ToArray
        If Arr IsNot Nothing Then


            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary, Arr.Length) With {
                .Value = Arr, .Direction = ParameterDirection.Input
            }
            Params.Add(NewParam)
        Else
            Dim NewParam As New SqlParameter(Name, SqlDbType.VarBinary) With {
            .Value = DBNull.Value
        }
            Params.Add(NewParam)
        End If



    End Sub
    Public Function StreamToByteArray(inputStream As Stream) As Byte()
        Dim bytes = New Byte() {}
        Using memoryStream = New MemoryStream()
            Dim count As Integer
            While ((count = inputStream.Read(bytes, 0, bytes.Length)) > 0)
                memoryStream.Write(bytes, 0, count)
            End While
            Return memoryStream.ToArray()
        End Using
    End Function


    ' ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean


        If String.IsNullOrEmpty(Exception) Then Return False

        If Report = True Then

            If Exception.Contains("transport-level") Or Exception.Contains("network-related") Or Exception.Contains("SQL Network") Or Exception.Contains("Connection Timeout Expired") Then

                ' Then
                'Dim Frm As New FrmConnectionError
                'If HomePage IsNot Nothing Then
                '    Frm.ShowDialog(HomePage)
                'Else
                '    Frm.ShowDialog(HomePage)
                'End If


            Else
                'If Debugger.IsAttached = False Then
                '    Dim Ex As New Exception("Sql Error:" & Exception & RuningQuery)
                '    With LogifyAlert.Instance
                '        .Tags("Company Name") = Dexef.Definition.CLSDef.CmpName
                '        .Tags("Phone Number") = Dexef.Definition.CLSDef.CmpPhone1 & ClsDef.CmpPhone2
                '        .Tags("Serveer") = Dexef.Definition.CLSDef.MyServer
                '        .Tags("DataBase name") = Dexef.Definition.CLSDef.MyDataBase
                '        .Send(Ex)
                '    End With

                'End If

                MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
            End If
        End If

        Return True
    End Function
End Class
