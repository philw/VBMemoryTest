Imports System.Threading

Module Module1

    Sub Main()

        Dim DigitString As String
        Dim Rnd As New Random
        Dim UserNumber As String
        Dim Length As Integer = 4

        Do
            DigitString = ""
            For N = 1 To Length
                DigitString &= Rnd.Next(0, 10)
            Next

            Console.Clear()
            Console.WriteLine("Memorise this number: " & DigitString)
            Thread.Sleep(3000)
            Console.Clear()
            Console.Write("What was the number? ")
            UserNumber = Console.ReadLine

            If UserNumber = DigitString Then
                Console.WriteLine("Well done!")
            Else
                Console.WriteLine("Wrong the number was: " & DigitString)
            End If

            Console.Write("Press the Enter key for another number")
            Console.ReadLine()

        Loop

    End Sub

End Module
