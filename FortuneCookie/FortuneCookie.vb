'Jessica McArthur
'RCET0265
'Fall 2020
'Fortune Cookie
'https://github.com/jmcarth4/FortuneCookie


Option Explicit On
Option Strict On

Module FortuneCookie

    Sub Main()
        Dim unknown As Integer

        'A random integer is generated. 
        Console.WriteLine("Earthling! Here is your fortune!")
        Randomize()
        unknown = CInt(Int((3 * Rnd()) + 1))
        Console.WriteLine(unknown)

        'A wise saying is connected to each possible integer. The sage advice displays when that integer is randomly generated. 
        If unknown = 1 Then
            Console.WriteLine("Eat Cheese")
        ElseIf unknown = 2 Then
            Console.WriteLine("Tell them everything!!")
        ElseIf unknown = 3 Then
            Console.WriteLine("Soy prudent!")
        End If

        'nice inforation to guide the user to a safe exit. 
        Console.WriteLine("Please press enter to exit.")
        Console.ReadLine()
    End Sub

End Module
