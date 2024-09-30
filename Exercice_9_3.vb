Module Exercice_9_3
    Sub Main()
        Dim n, i, nombrePairs As Double
        Do
            Console.WriteLine("Entrez un nombre > à 0")
            n = Console.ReadLine()
        Loop Until n > 0
        For i = 0 To n
            nombrePairs += 2
            If nombrePairs < n Or nombrePairs = n Then
                Console.WriteLine("Les nombres pairs jusqu'à " + n.ToString() + ":" + nombrePairs.ToString())
            End If

        Next

    End Sub
End Module
