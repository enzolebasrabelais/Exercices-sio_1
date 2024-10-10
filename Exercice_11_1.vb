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
        Dim choix, rayon, longueur, largeur As Integer
        Do


            Console.WriteLine("1. Calcul du périmètre d'un cercle.")
            Console.WriteLine("2. Calcul de la surface d'un cercle.")
            Console.WriteLine("3. Calcul du périmètre d'un rectangle.")
            Console.WriteLine("4. Calcul de la surface d'un rectangle.")
            Console.WriteLine("5. Quitter.")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Do
                        Console.WriteLine("Rayon du cercle ? (Rayon > 0)")
                        rayon = Console.ReadLine()
                    Loop Until rayon > 0
                    Console.WriteLine("Périmètre: " + PerimetreCercle(rayon).ToString)
                Case 2
                    Do
                        Console.WriteLine("Rayon du cercle ? (Rayon > 0)")
                        rayon = Console.ReadLine()
                    Loop Until rayon > 0
                    Console.WriteLine("Surface: " + SurfaceCercle(rayon).ToString)
                Case 3
                    Do
                        Console.WriteLine("Longueur du rectangle ? (Longueur > 0)")
                        longueur = Console.ReadLine()
                    Loop Until longueur > 0
                    Do
                        Console.WriteLine("Largeur du rectangle ? (Largueur > 0)")
                        largeur = Console.ReadLine()
                    Loop Until largeur > 0
                    Console.WriteLine("Périmètre: " + PerimetreRectangle(longueur, largeur).ToString)
                Case 4
                    Do
                        Console.WriteLine("Longueur du rectangle ? (Longueur > 0)")
                        longueur = Console.ReadLine()
                    Loop Until longueur > 0
                    Do
                        Console.WriteLine("Largeur du rectangle ? (Largueur > 0)")
                        largeur = Console.ReadLine()
                    Loop Until largeur > 0
                    Console.WriteLine("Surface: " + SurfaceRectangle(longueur, largeur).ToString)
                Case 5
                    Console.WriteLine("Au revoir")

            End Select
            If choix > 5 Then
                Console.WriteLine("Choix erroné")
            End If
        Loop Until choix = 5
        Console.ReadLine()
    End Sub
End Module
