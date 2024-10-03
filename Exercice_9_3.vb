Module Exercice_9_3
    Sub Main()
        Dim n, i, nombrePairs As Double
        Do
            Console.WriteLine("Entrez un nombre > à 0")
            n = Console.ReadLine()
        Loop Until n > 0
        Console.WriteLine("Les " + n.ToString() + " premiers nombres pairs sont :")
        For i = 0 To n

            nombrePairs += 2
            Console.WriteLine(nombrePairs.ToString())

        Next

    End Sub
End Module
