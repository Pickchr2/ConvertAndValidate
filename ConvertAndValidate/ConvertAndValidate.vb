'Christopher Pickens
'RCET0265
'Spring 2023
'ConvertAndValidate
'https://github.com/Pickchr2/ConvertAndValidate.git

Option Compare Text
Option Explicit On
Option Strict On

Imports System
Module ConvertAndValidate
    Sub Main(args As String())
        Dim userInput As String
        Dim quit As Boolean

        Do Until quit
            Console.WriteLine($"Enter a number:")
            userInput = Console.ReadLine()
            Select Case userInput
                Case "Q"
                    quit = True
                Case Else

            End Select
        Loop
    End Sub

    Function ConversionValid(convertThisString As String, toThisInteger As Integer) As Boolean
        Dim status As Boolean = True

        Try
            toThisInteger = CInt(convertThisString)
        Catch ex As Exception
            status = False
        End Try
         Return status
    End Function
End Module
