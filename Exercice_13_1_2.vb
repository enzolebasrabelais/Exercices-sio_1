Module Exercice_13_1_2
    Const nbReels = 10
    Sub PlusPetitPlusGrand(ByRef reels() As Integer)
        Dim min, max As Integer
        For numero = 0 To nbReels - 1
            Console.WriteLine("Nombre n°" + numero.ToString() + " ?")
            reels(numero) = Console.ReadLine()
        Next
        max = reels(0)
        min = reels(0)
        For numero = 0 To reels.Length - 1
            If reels(numero) > max Then
                max = reels(numero)
            End If
            If reels(numero) < min Then
                min = reels(numero)
            End If
        Next
        Console.WriteLine("Min = " + min.ToString())
        Console.WriteLine("Max = " + max.ToString())
        Console.WriteLine("Au revoir.")
    End Sub
    Sub Main()
        Dim valeurs(nbReels - 1) As Integer
        PlusPetitPlusGrand(valeurs)
    End Sub
End Module
