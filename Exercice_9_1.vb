Module Exercice_9_1
    Sub Main()
        Dim note, cpt, cpt2, pourcentage, somme As Double
        cpt = 0
        somme = 0
        Console.WriteLine("Entrez une note (-1 pour fin) :")
        note = Console.ReadLine()
        While note <> -1
            If note > 10 Then
                cpt += 1
                cpt2 += 1
                somme += note
                Console.WriteLine("Entrez une note (-1 pour fin) :")
                note = Console.ReadLine()
            Else
                cpt2 += 1
                Console.WriteLine("Entrez une note (-1 pour fin) :")
                note = Console.ReadLine()
                If note <> -1 Then
                    somme += note
                End If
            End If
        End While
        pourcentage = somme / cpt

        Console.WriteLine("Vous avez " + (pourcentage.ToString) + " de notes > à 10")

    End Sub
End Module
