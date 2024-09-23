Module Exercice_7_3
    Sub Main()
        Dim nbHeures, tauxHoraire, salaireHebdo As Double
        Console.WriteLine("Nombre d'heures travaillees hebdomadaire ?")
        nbHeures = Console.ReadLine()
        If nbHeures < 39 Then
            Console.WriteLine("Vous ne travaillez pas assez !")
            salaireHebdo = 0
            Console.WriteLine("Salaire hebdomadaire : " + salaireHebdo.ToString)
        Else
            Console.WriteLine("Taux horaire ?")
            tauxHoraire = Console.ReadLine()
        End If



    End Sub
End Module
