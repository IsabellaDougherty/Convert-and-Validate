'Isabella Dougherty
'RCET0265
'Spring 2023
'



Imports System

Module ConvertAndValidate
    Sub Main()

        'for testing the function add this to your Sub Main()

        Dim aValidNumber As Integer
        Dim usernResponse As String

        Do
            Console.WriteLine($"Enter a number:")
            usernResponse = Console.ReadLine()
            If ConversionValid(usernResponse, aValidNumber) = True Then
                aValidNumber = CInt(usernResponse)
                Console.WriteLine($"{usernResponse} converted successfully to {aValidNumber}!")
            Else
                Console.WriteLine($"Oops, {usernResponse} does not seem to be a number")
            End If
        Loop

    End Sub

    'make this work


    Function ConversionValid(convertThisString, toThisInteger) As Boolean

        Dim status As Boolean = True

        Try
            toThisInteger = CInt(convertThisString)
        Catch ex As Exception
            status = False
        End Try

        Return status

    End Function
End Module
