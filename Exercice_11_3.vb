Module Exercice_11_3
    Const c = 300000
    Function DilatationTemps(ByVal vfusee As Double, ByVal dfusee As Double) As Double
        Return ((dfusee) / (Math.Sqrt(1 - ((vfusee ^ 2) / (c ^ 2)))))
    End Function

    Function ContractionLongueurs(ByVal vfusee As Double, ByVal tfusee As Double) As Double
        Return ((tfusee) * (Math.Sqrt(1 - ((vfusee ^ 2) / (c ^ 2)))))
    End Function

    Function LoiComposition(ByVal vfusee As Double, ByVal vobus As Double) As Double
        Return ((vobus + vfusee) / ((1 + (vobus * vfusee) / (c ^ 2))))
    End Function

    Sub Main()
        Dim choix, vitesse, taille, duree, vitobus As Double
        Do
            Console.WriteLine("1. La dilatation du temps")
            Console.WriteLine("2. La contraction des longueurs")
            Console.WriteLine("3. Loi de composition des vitesses")
            Console.WriteLine("4. Quitter")
            Console.WriteLine("")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                    vitesse = Console.ReadLine()
                    Console.WriteLine("Durée écoulée dans la fusée (en secondes) ?")
                    duree = Console.ReadLine()
                    Console.WriteLine("Durée écoulée sur la terre = " + DilatationTemps(vitesse, duree).ToString() + " secondes")
                Case 2
                    Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                    vitesse = Console.ReadLine()
                    Console.WriteLine("Taille de la fusée (en kms) ?")
                    taille = Console.ReadLine()
                    Console.WriteLine("Taille de la fusée vue de la terre = " + ContractionLongueurs(vitesse, taille).ToString() + " kms.")
                Case 3
                    Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                    vitesse = Console.ReadLine()
                    Console.WriteLine("Vitesse de l'obus, dans le repère de la fusée (en km/s) ?")
                    vitobus = Console.ReadLine()
                    Console.WriteLine("Vitesse de l'obus par rapport à la terre = " + LoiComposition(vitesse, vitobus).ToString())
                Case 4
                    Console.WriteLine("Au revoir.")
                Case Else
                    Console.WriteLine("Choix erroné.")
            End Select
        Loop Until choix = 4
    End Sub
End Module
