This program is meant to keep casual observers from stumbling onto directories that you may not want seen.

This program uses the File.SetAttributes method in VB .NET 8, setting the attributes on the file or folder using the .NET Framework's API.
This method is subject to the limitations and security restrictions imposed by the .NET Framework. This program also sets the directory to a system directory prior to using the File.SetAttributes method, this provides an additional layer of protection and makes it more difficult for users to accidentally stumble upon the hidden directory.

Remember: Locks are for honest people.

=============FUTURE OPTION================================
The NTFS file system attributes method can be used by a VB .NET 8 program
The NTFS file system attributes method is likely more robust and secure, as it operates at a lower level and is less dependent on the .NET Framework.

NTFS example.
Imports System.Runtime.InteropServices

Module Module1
    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, SetLastError:=True)>
    Private Function SetFileAttributes(lpFileName As String, dwFileAttributes As UInteger) As Boolean
    End Function

    Const FILE_ATTRIBUTE_HIDDEN As UInteger = &H2

    Sub Main()
        Dim filePath As String = "C:\Path\To\File.txt"
        SetFileAttributes(filePath, FILE_ATTRIBUTE_HIDDEN)
    End Sub
End Module