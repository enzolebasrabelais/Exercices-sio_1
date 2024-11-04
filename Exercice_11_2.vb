Module Exercice_11_2
    Function Factorielle(ByVal n As Integer) As Double
        Dim resultat As Double
        resultat = 1
        If n = 0 Then
            resultat = 1
        Else
            For i = 2 To n
                resultat = resultat * i
            Next
        End If
        Return resultat
    End Function
    Sub Main()
        Dim nombre As Double
        Do
            Do
                Console.WriteLine("Saisir un nombre >= 0")
                nombre = Console.ReadLine()
            Loop Until nombre >= 0 Or nombre = -1
            Console.WriteLine("La factorielle de ce nombre est " + Factorielle(nombre).ToString())
            If nombre = -1 Then
                Console.WriteLine("Au revoir.")
            ElseIf nombre < -1 Then
                Console.WriteLine("n > 0")
            End If
        Loop Until nombre = -1
    End Sub
End Module
