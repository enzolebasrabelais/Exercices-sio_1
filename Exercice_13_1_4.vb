Module Exercice_13_1_4
    Sub Main()
        Dim devises() As String = {"ATS", "BEF", "DEM", "ESP", "FRF", "IEP", "ITL", "FIM", "LUF", "NLG", "GRD", "SIT", "PTE", "CYP", "MTL", "SKK"}
        Dim taux() As Double = {13.76, 40.33, 1.95, 166.38, 6.55, 0.78, 1936.27, 5.94, 40.33, 2.2, 340.75, 239.64, 13.76, 200.48, 0.58, 0.42, 30.12}

        Dim codeDevise As String
        Dim montant, conversionMonnaie As Double
        Dim noDevise As Integer
        Do
            Do
                Console.WriteLine("Montant en euros ou 0 ?")
                montant = Console.ReadLine()
            Loop Until montant >= 0
            Console.WriteLine("Code devise ?")
                codeDevise = Console.ReadLine()
                noDevise = 0
                While codeDevise <> devises(noDevise) And noDevise < 17
                    noDevise += 1
                End While
                If devises(noDevise) = codeDevise Then
                    conversionMonnaie = montant * taux(noDevise)
                End If
                Console.WriteLine("Montant dans l'ancienne monnaie nationale : " + conversionMonnaie.ToString())
            Loop Until montant = 0
    End Sub
End Module
