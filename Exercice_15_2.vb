Module Exercice_15_2
    Function SaisirMatériel() As TMatériel

        ' retourne un matériel saisi l'utilisateur
    End Function



    Sub AfficherUnMatériel(By??? pUnMatériel As TMatériel)

        ' Affiche un matériel
    End Sub


        SubAfficherLesMatériels(By??? pLesMatériels() As TMatériel, By??? pPosLibre As Integer)

' Affiche tous les matériels du parc
     E
 

FunctionAjouterUnMatériel(By??? pMatériel As TMatériel, By??? pLesMatériels() As TMatériel, _

By??? pPosLibre As Integer) As Boolean

' Ajoute un matériel au parc (tableau). Si l'ajout est possible retourne True, False sinon.



    Function SupprimerParIndex(By??? pIndex As Integer, By??? pLesMatériels() As TMatériel, _

By??? pPosLibre As Integer) As Boolean

' Supprime un matériel du parc (tableau). Si la suppression est possible, retourne True, False sinon.

 

FunctionSupprimerParNoSérie(By??? pNoSérie As String, By??? pLesMatériels() As TMatériel, By??? pPosLibre As Integer) As Boolean
' Supprime un matériel du parc (tableau). Si la suppression est possible (n° de série existant), retourne True, False sinon.
End Function
End Module