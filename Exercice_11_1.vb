Module Exercice_11_1
    Function PerimetreCercle(ByVal pRayon As Double) As Double
        Return 2 * Math.PI * pRayon
    End Function
    Function SurfaceCercle(ByVal pRayon As Double) As Double
        Return Math.PI * pRayon * pRayon
    End Function
    Function PerimetreRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        Return 2 * (pLongueur + pLargeur)
    End Function
    Function SurfaceRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        Return pLongueur * pLargeur
    End Function
    Sub Main()
        Dim choix, rayon As Integer
        Console.WriteLine("1. Calcul du périmètre d'un cercle.")
        Console.WriteLine("2. Calcul de la surface d'un cercle.")
        Console.WriteLine("3. Calcul du périmètre d'un rectangle.")
        Console.WriteLine("4. Calcul de la surface d'un rectangle.")
        Console.WriteLine("5. Quitter.")
        choix = Console.ReadLine()
        Select Case choix
            Case 1
                Do
                    Console.WriteLine("Rayon du cercle ? (Rayon > 0)")
                    rayon = Console.ReadLine()
                Loop Until rayon > 0
                Console.WriteLine("")
        End Select
    End Sub
End Module
