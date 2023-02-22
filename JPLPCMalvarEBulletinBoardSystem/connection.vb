
Imports MySql.Data.MySqlClient
Module connection
    Public con As MySqlConnection = New MySqlConnection
    Public strSQL As String = String.Empty
    Public cmd As MySqlCommand = New MySqlCommand
    Public dr As MySqlDataReader
    Public photoset
    Public photoset1
    Public photoset2
    Public photoset3
    Public photoset4
    Public photoset5
    'DENVER <09-23-2017>: Global Variables
    Public getSection, getMNum, getFacultyDept, getGroupBy, getName As String
    Public results() As String
    Public num As Integer = 1
    Public filterWords As String
    Public filt As Integer
    Public getPostName, getPostGroupBy As String

    Public trigger1 As Boolean = False
    Public trigger2 As Boolean = False
    Public trigger3 As Boolean = False
    Public trigger4 As Boolean = False
    Public trigger5 As Boolean = False

    'Images bool
    Public img1 As Boolean = False
    Public img2 As Boolean = False
    Public img3 As Boolean = False
    Public img4 As Boolean = False
    Public img5 As Boolean = False

    Public photoget

    Public pal1 As Boolean = False
    Public pal2 As Boolean = False
    Public pal3 As Boolean = False

    Public isLabel1 As Boolean = False
    Public isLabel2 As Boolean = False


    Public x1 As String = String.Empty



End Module
