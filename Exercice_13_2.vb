Module Exercice_13_2
    Sub AfficherMatrice(ByVal pMatrice(,) As Double)
        Console.WriteLine(vbTab(pMatrice.ToString()))
    End Sub

    Sub Echanger(ByRef pA As Double, ByRef pB As Double)
        Dim valeurdeA As Double
        valeurdeA = pA


    End Sub

    Sub InverserLignesMatrice()

    End Sub

    Sub Main()
        Dim matrice(,) As Double = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
            }
        AfficherMatrice(matrice)
    End Sub
End Module
