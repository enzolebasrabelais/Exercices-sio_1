Module Exercice_13_3
    Const MAXSALLES As Integer = 10  ' mis à 10 (au lieu de 50) pour test
    Const MAXJOURS As Integer = 6
    Const MAXTRANCHES As Integer = 10





    Sub Initialiser(ByRef pTab(,,) As Integer)

        ' Parcours du tableau à 3 dimensions; toutes les cases sont mises à 0

        ' (on considère ici que toutes les salles sont libres, par défaut)

        ' Le parcours début à 1, les cases en "0" sont perdues

        For noSalle = 1 To MAXSALLES
            For noJour = 1 To MAXJOURS
                For noTranche = 1 To MAXTRANCHES
                    pTab(noSalle, noJour, noTranche) = 0
                Next
            Next
        Next
    End Sub



    Sub Main()

        Dim capaciteLue, heureLue, jourLu, occupation(MAXSALLES, MAXJOURS, MAXTRANCHES) As Integer

        Dim capacité() As Integer = {20, 40, 30, 20, 10, 50, 10, 20, 20, 25} 'la première ne sera pas
        Initialiser(occupation)
        ' On place quelques cases à "occupée", choisies arbitrairement
        occupation(3, 2, 4) = 1
        occupation(1, 1, 1) = 1
        occupation(1, 2, 1) = 1
        occupation(4, 5, 1) = 1
        occupation(2, 2, 4) = 1
        occupation(8, 3, 2) = 1
        occupation(5, 3, 3) = 1
        ' ! ! ! ! !
        ' ! ! ! ! ! A COMPLETER ! ! ! ! !
        ' ! ! ! ! !

        Console.ReadLine()
    End Sub

End Module
