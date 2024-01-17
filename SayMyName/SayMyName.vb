'Alex Wheelock
'RCET 0265
'Spring 2024
'Say My Name Again
'https://github.com/AlexWheelock/SayMyName.git

Option Strict On
Option Explicit On

Module SayMyName

    Sub Main()

        Dim userInput As String

        'asks the user for their name
        Console.WriteLine("What is your name?" & vbNewLine _
                          & "Please enter your name")
        userInput = Console.ReadLine

        'checks name for names coded in, writes associated output
        If userInput = CStr("joe") Then
            Console.WriteLine("Hello, " & userInput & "!")

        ElseIf userInput = CStr("emily") Then
            Console.WriteLine("Hello, " & userInput & "!")

        ElseIf userInput = CStr("alex") Then
            Console.WriteLine("You're an imposter, why are you entering my name?")

        ElseIf userInput = CStr("tim") Then
            Console.WriteLine("This is pretty great, right? Definitely deserves an A.")

        Else Console.WriteLine("Your name isn't in my code, loser.")

        End If

        Console.Read()

    End Sub

End Module
