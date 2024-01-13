'Alex Wheelock
'RCET 0265
'Spring 2024
'Say My Name
'https://github.com/AlexWheelock/SayMyName.git

Module Module1

    Sub Main()

        Dim userInput As String

        Console.WriteLine("What is your name?") 'asks the user for their name
        Console.WriteLine("Please enter your name")

        userInput = Console.ReadLine
        Console.WriteLine("Hello," & " " & userInput & "!")

        Console.Read()

    End Sub

End Module
