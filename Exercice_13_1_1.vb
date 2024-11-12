Module Exercice_13_1_1
    Sub Main()
        Dim mois() As String = {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"}, nombre As Integer
        Do
            Console.WriteLine("Entrez un nombre : ")
            nombre = Console.ReadLine()
        Loop Until nombre >= 1 And nombre <= 12
        Console.WriteLine(mois(nombre - 1))
        Console.ReadLine()
    End Sub
End Module
