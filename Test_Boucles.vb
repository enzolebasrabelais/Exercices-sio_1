Module Test_Boucles
    Sub Main()
        Dim n As Integer
        ' Saisir avant de rentrer (ou non) dans la boucle !
        Console.WriteLine("Entrez un nombre (0 pour fin) : ")
        n = Console.ReadLine()
        While n <> 0   ' boucle de saisie des nombres
            Console.WriteLine("Le carré vaut : " + (n * n).ToString)
            Console.WriteLine("Entrez un nombre (0 pour fin) : ")
            n = Console.ReadLine()
        End While
        Console.WriteLine("n  = 0, au revoir")
        Console.ReadLine()

    End Sub
End Module
