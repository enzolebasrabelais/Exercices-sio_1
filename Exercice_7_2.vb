Module Exercice_7_2
    Sub Main()
        Dim nbJour, distanceKms, tarifEssence, tarifDiesel As Double
        Console.WriteLine("Nombre de jours de location ?")
        nbJour = Console.ReadLine()
        Console.WriteLine("Distance à parcourir (en kms) ?")
        distanceKms = Console.ReadLine()
        tarifEssence = (nbJour * 30) + (distanceKms * 0.85)
        tarifDiesel = (nbJour * 35) + (distanceKms * 0.65)
        If tarifEssence < tarifDiesel Then
            Console.WriteLine("Meilleur choix : Essence, coût total : " + tarifEssence.ToString)
        ElseIf tarifDiesel < tarifEssence Then
            Console.WriteLine("Meilleur choix : Diesel, coût total : " + tarifDiesel.ToString)
        Else
            Console.WriteLine("Il n'y a pas de meilleur choix, coût total : " + tarifDiesel.ToString)
        End If
        Console.WriteLine("Au revoir")
    End Sub
End Module
