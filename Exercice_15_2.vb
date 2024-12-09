Module Exercice_15_2
    Const MAX As Double = 10
    Structure TMatériel
        Dim noSerie As String
        Dim modèle As String
        Dim type As String
        Dim annéeDAchat As Integer
    End Structure
    Function SaisirMatériel() As TMatériel
        Dim pc As TMatériel
        pc.noSerie = "NS23"
        pc.modèle = "Optiflex 526"
        pc.type = "PC"
        pc.annéeDAchat = 2024
        Return pc
        ' retourne un matériel saisi l'utilisateur
    End Function



    Sub AfficherUnMatériel(ByVal pUnMatériel As TMatériel)
        ' Affiche un matériel
        Console.WriteLine(pUnMatériel)
    End Sub


    Sub AfficherLesMatériels(ByVal pLesMatériels() As TMatériel, ByVal pPosLibre As Integer)
        For i = 0 To MAX - 1
            Console.WriteLine(pLesMatériels(i))
        Next
        ' Affiche tous les matériels du parc
    End Sub


    Function AjouterUnMatériel(ByVal pMatériel As TMatériel, ByVal pLesMatériels() As TMatériel, ByVal pPosLibre As Integer) As Boolean
        If pPosLibre <= MAX - 1 Then
            pLesMatériels(pPosLibre) = pMatériel
            Return True
        Else
            Return False
        End If
        ' Ajoute un matériel au parc (tableau). Si l'ajout est possible retourne True, False sinon.
    End Function


    Function SupprimerParIndex(ByVal pIndex As Integer, ByVal pLesMatériels() As TMatériel, ByVal pPosLibre As Integer) As Boolean

        ' Supprime un matériel du parc (tableau). Si la suppression est possible, retourne True, False sinon.
    End Function


    Function SupprimerParNoSérie(ByVal pNoSérie As String, ByVal pLesMatériels() As TMatériel, ByVal pPosLibre As Integer) As Boolean
        ' Supprime un matériel du parc (tableau). Si la suppression est possible (n° de série existant), retourne True, False sinon.
    End Function

    Sub Main()
        Dim choix As String
        Console.WriteLine("1. Ajouter un matériel dans le tableau.")
        Console.WriteLine("2. Supprimer un matériel (saisie index)")
        Console.WriteLine("3. Supprimer un matériel (saisie n° série).")
        Console.WriteLine("4. Lister à l'écran tous les matériels.")
        Console.WriteLine("5. Quitter.")
        Console.WriteLine("Choix ?")
        choix = Console.ReadLine()
        Select Case choix
            Case 1

        End Select
    End Sub
End Module