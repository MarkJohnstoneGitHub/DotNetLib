Attribute VB_Name = "DateTimeUtcNowExample"
'Rubberduck annotations
'@Folder "VBADotNetLib.Examples.DateTime.Properties"

'https://github.com/MarkJohnstoneGitHub/VBA-DotNetLib
'@Version v1.0 July 09, 2023
'@LastModified July 09, 2023

'@DotNetReference https://learn.microsoft.com/en-us/dotnet/api/system.datetime.utcnow?view=netframework-4.8.1#examples

Option Explicit

Private Const datePatt As String = "M/d/yyyy hh:mm:ss tt"

'/*
'This code example produces the following results:
'
'UtcNow: .......... 5/6/2005 09:34:42 PM, Kind = Utc
'Now: ............. 5/6/2005 02:34:42 PM, Kind = Local
'
'Utc: ............. 5/6/2005 02:34:42 PM, Kind = Utc
'  ToLocalTime:     5/6/2005 07:34:42 AM, Kind = Local
'  ToUniversalTime: 5/6/2005 02:34:42 PM, Kind = Utc
'
'Local: ........... 5/6/2005 02:34:42 PM, Kind = Local
'  ToLocalTime:     5/6/2005 02:34:42 PM, Kind = Local
'  ToUniversalTime: 5/6/2005 09:34:42 PM, Kind = Utc
'
'Unspecified: ..... 5/6/2005 02:34:42 PM, Kind = Unspecified
'  ToLocalTime:     5/6/2005 07:34:42 AM, Kind = Local
'  ToUniversalTime: 5/6/2005 09:34:42 PM, Kind = Utc

'*/

'@Description("The following example uses the SpecifyKind method to demonstrate how the Kind property influences the ToLocalTime and ToUniversalTime conversion methods.")
Public Sub DateTimeUtcNow()
    ' Get the date and time for the current moment, adjusted
    ' to the local time zone.
    Dim saveNow As DateTime
    Set saveNow = DateTime.Now
    
    ' Get the date and time for the current moment expressed
    ' as coordinated universal time (UTC).
    
    Dim saveUtcNow As DateTime
    Set saveUtcNow = DateTime.UtcNow
    Dim myDt As DateTime
    
    ' Display the value and Kind property of the current moment
    ' expressed as UTC and local time.
    DisplayNow "UtcNow: ..........", saveUtcNow
    DisplayNow "Now: .............", saveNow
    Debug.Print
    
    ' Change the Kind property of the current moment to
    ' DateTimeKind.Utc and display the result.

    Set myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.DateTimeKind_Utc)
    Display "Utc: .............", myDt

    ' Change the Kind property of the current moment to
    ' DateTimeKind.Local and display the result.
    
    Set myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.DateTimeKind_Local)
    Display "Local: ...........", myDt

    ' Change the Kind property of the current moment to
    ' DateTimeKind.Unspecified and display the result.

    Set myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.DateTimeKind_Unspecified)
    Display "Unspecified: .....", myDt


End Sub

' Display the value and Kind property for DateTime.Now and DateTime.UtcNow.
Private Sub DisplayNow(ByVal title As String, ByVal inputDt As DateTime)
    Dim dtString As String
    dtString = inputDt.ToString2(datePatt)
    Debug.Print title & " " & dtString & ", Kind = " & DateTimeKindHelper.ToString(inputDt.kind)
End Sub


' Display the value and Kind property of a DateTime structure, the
' DateTime structure converted to local time, and the DateTime
' structure converted to universal time.
Private Sub Display(ByVal title As String, ByVal inputDt As DateTime)
    Dim dispDt As DateTime
    Set dispDt = inputDt
    Dim dtString As String

    ' Display the original DateTime.
    
    dtString = dispDt.ToString2(datePatt)
    Debug.Print title & " " & dtString & ", Kind = " & DateTimeKindHelper.ToString(dispDt.kind)

    ' Convert inputDt to local time and display the result.
    ' If inputDt.Kind is DateTimeKind.Utc, the conversion is performed.
    ' If inputDt.Kind is DateTimeKind.Local, the conversion is not performed.
    ' If inputDt.Kind is DateTimeKind.Unspecified, the conversion is
    ' performed as if inputDt was universal time.
    
     Set dispDt = inputDt.ToLocalTime()
     dtString = dispDt.ToString2(datePatt)
     Debug.Print "  ToLocalTime:     " & dtString & ", Kind = " & DateTimeKindHelper.ToString(dispDt.kind)
     
    ' Convert inputDt to universal time and display the result.
    ' If inputDt.Kind is DateTimeKind.Utc, the conversion is not performed.
    ' If inputDt.Kind is DateTimeKind.Local, the conversion is performed.
    ' If inputDt.Kind is DateTimeKind.Unspecified, the conversion is
    ' performed as if inputDt was local time.

    Set dispDt = inputDt.ToUniversalTime()
    dtString = dispDt.ToString2(datePatt)
    
    Debug.Print "  ToUniversalTime: " & dtString & ", Kind = " & DateTimeKindHelper.ToString(dispDt.kind)
    Debug.Print
End Sub
