Attribute VB_Name = "DateTimeDateOnlyExample"
'Rubberduck annotations
'@Folder "VBADotNetLib.Examples.DateTime.Properties"

'https://github.com/MarkJohnstoneGitHub/VBA-DotNetLib
'@Version v1.0 July 09, 2023
'@LastModified July 09, 2023

'@Reference https://learn.microsoft.com/en-us/dotnet/api/system.datetime.date?view=netframework-4.8.1#examples

Option Explicit

' The following example uses the Date property to extract the date component of
' a DateTime value with its time component set to zero (or 0:00:00, or midnight).
' It also illustrates that, depending on the format string used when displaying
' the DateTime value, the time component can continue to appear in formatted output.
'
Public Sub DateTimeDateOnly()
    Dim date1 As DateTime
    Set date1 = DateTime.CreateFromDateTime(2008, 6, 1, 7, 47, 0)
    Debug.Print date1.ToString
    
    ' Get date-only portion of date, without its time.
    Dim pvtDateOnly As DateTime
    Set pvtDateOnly = date1.DateOnly
    
    ' Display date using short date string.
    Debug.Print pvtDateOnly.ToString2("d")
    ' Display date using 24-hour clock.
    Debug.Print pvtDateOnly.ToString2("g")
    Debug.Print pvtDateOnly.ToString2("MM/dd/yyyy HH:mm")
    
' The example displays output like the following output:
'       6/1/2008 7:47:00 AM
'       6/1/2008
'       6/1/2008 12:00 AM
'       06/01/2008 00:00
End Sub
