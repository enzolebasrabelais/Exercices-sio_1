Module Exercice_9_4
    Sub Main()
        Dim representant As String, numeroSemaine, ventes, total, commission As Double
        For i = 0 To 4
            Console.WriteLine("Nom du représentant ?")
            representant = Console.ReadLine()
            numeroSemaine += 1
            Do
                Console.WriteLine("Semaine " + numeroSemaine.ToString() + ": Ventes H.T hebdomadaires (0 pour stopper la saisie) ?")
                ventes = Console.ReadLine()
            Loop Until ventes > 0
            total += ventes
            Console.WriteLine("Bilan pour " + representant)
            Console.WriteLine("Total des ventes H.T = " + total.ToString())
        Next
    End Sub

End Module
