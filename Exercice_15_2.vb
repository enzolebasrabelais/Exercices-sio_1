Module Exercice_15_2
    Const MAX As Double = 10
    Structure TMatériel
        Dim noSerie As String
        Dim modèle As String
        Dim type As String
        Dim annéeDAchat As Integer
    End Structure
    Function SaisirMatériel() As TMatériel
        Dim pc, tabMateriels() = {pc} As TMatériel
        pc.noSerie = "NS23"
        pc.modèle = "Optiflex 526"
        pc.type = "PC"
        pc.annéeDAchat = 2024
        Return
        ' retourne un matériel saisi l'utilisateur
    End Function



    Sub AfficherUnMatériel(ByVal pUnMatériel As TMatériel)
        ' Affiche un matériel
        Console.WriteLine("n° de série : " + pUnMatériel.noSerie)
        Console.WriteLine("Modèle : " + pUnMatériel.modèle)
        Console.WriteLine("Type : " + pUnMatériel.type)
        Console.WriteLine("Année d'achat : " + pUnMatériel.annéeDAchat)
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
            pPosLibre += 1
            Return True
        Else
            Return False

        End If
        ' Ajoute un matériel au parc (tableau). Si l'ajout est possible retourne True, False sinon.
    End Function


    Function SupprimerParIndex(ByVal pIndex As Integer, ByVal pLesMatériels() As TMatériel, ByVal pPosLibre As Integer) As Boolean
        If pIndex = -1 Then
            Return False
        Else
            For i = pIndex To pPosLibre - 2
                pLesMatériels(i) = pLesMatériels(i + 1)
            Next
            pPosLibre -= 1
        End If
        Return True
        ' Supprime un matériel du parc (tableau). Si la suppression est possible, retourne True, False sinon.
    End Function


    Function SupprimerParNoSérie(ByVal pNoSérie As String, ByVal pLesMatériels() As TMatériel, ByVal pPosLibre As Integer) As Boolean
        ' Supprime un matériel du parc (tableau). Si la suppression est possible (n° de série existant), retourne True, False sinon.
    End Function

    Sub Main()
        Dim choix, noserie As String
        Dim materiel As TMatériel
        Dim vPosLibre, index As Integer
        Do
            SaisirMatériel()
            materiel = SaisirMatériel()

            vPosLibre = 0
            Console.WriteLine("1. Ajouter un matériel dans le tableau.")
            Console.WriteLine("2. Supprimer un matériel (saisie index)")
            Console.WriteLine("3. Supprimer un matériel (saisie n° série).")
            Console.WriteLine("4. Lister à l'écran tous les matériels.")
            Console.WriteLine("5. Quitter.")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Console.WriteLine("n° de série ?")
                    materiel.noSerie = Console.ReadLine()
                    Console.WriteLine("Modèle ?")
                    materiel.modèle = Console.ReadLine()
                    Console.WriteLine("Type ?")
                    materiel.type = Console.ReadLine()
                    Console.WriteLine("Année d'achat ?")
                    materiel.annéeDAchat = Console.ReadLine()
                    AjouterUnMatériel(materiel, tMateriels, vPosLibre)
                    If AjouterUnMatériel(materiel, tMateriels, vPosLibre) = False Then
                        Console.WriteLine("Ajout impossible.")
                    Else
                        Console.WriteLine("Ajout effectué.")
                    End If

                Case 2
                    Console.WriteLine("n° d'index du matériel à supprimer ?")
                    index = Console.ReadLine()
                    SupprimerParIndex(index, tMateriels, vPosLibre)
                    If SupprimerParIndex(index, tMateriels, vPosLibre) = False Then
                        Console.WriteLine("Suppression impossible.")
                    Else
                        Console.WriteLine("Suppression réussie.")
                    End If
                Case 3
                    Console.WriteLine("n° de série du matériel à supprimer ?")
                    noserie = Console.ReadLine()
                    SupprimerParNoSérie(noserie, tMateriels, vPosLibre)
                    If SupprimerParNoSérie(noserie, tMateriels, vPosLibre) = False Then
                        Console.WriteLine("Suppression impossible.")
                    Else
                        Console.WriteLine("Suppression réussie.")
                    End If
                Case 4
                    AfficherLesMatériels(tMateriels, vPosLibre)
                Case 5
                    Console.WriteLine("Au revoir")
            End Select
        Loop Until choix = 5
    End Sub
End Module