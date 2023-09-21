Module Module1


    Sub Main()


        Dim Word As String
        Dim Final As String = ""
        Dim Choice As Char
        Dim Letter As String

        Do
            Console.WriteLine("Do you want to encode or decode (Enter 'e' or 'd')")
            Choice = Console.ReadLine()

            If Choice = "e" Then

                Console.WriteLine("Enter the word to be encoded")
                Word = Console.ReadLine()

                For i = 1 To Len(Word)

                    Letter = Mid(Word, i, 1)

                    If Mid(Word, i, 1) = "z" Then
                        Mid(Word, i, 1) = "a"
                    Else

                        Letter = Chr(Asc(Letter) + 1)
                        Mid(Word, i, 1) = Letter

                    End If

                Next i

                Console.WriteLine("The encoded word is : " & Word)

            ElseIf Choice = "d" Then

                Console.WriteLine("Enter the word to be decoded")
                Word = Console.ReadLine()

                For i = 1 To Len(Word)

                    Letter = Mid(Word, i, 1)

                    If Mid(Word, i, 1) = "a" Then
                        Mid(Word, i, 1) = "z"
                    Else

                        Letter = Chr(Asc(Letter) - 1)
                        Mid(Word, i, 1) = Letter

                    End If

                Next i

                Console.WriteLine("The decoded word is : " & Word)
            End If
            Console.ReadLine()

        Loop Until Choice = "x"
    End Sub

End Module
