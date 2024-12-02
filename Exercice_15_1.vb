Imports System.Xml.Schema

Module Exercice_15_1
    Const MAX As Integer = 2



    Structure TClient
        Dim code As String
        Dim nom As String
        Dim adresse As String

    End Structure



    Structure TCommande

        Dim numéro As Integer
        Dim dateC As String
        Dim montant As Double
        Dim codeClient As String

    End Structure



    Sub AfficherUnClient(ByVal pUnClient As TClient)
        Console.WriteLine("Code client : " + pUnClient.code)
        Console.WriteLine("Nom : " + pUnClient.nom)
        Console.WriteLine("Adresse : " + pUnClient.adresse)

    End Sub



    Function ClientPourUneCommande(ByVal pNuméroCommande As Integer, ByVal pTabCommandes() As TCommande, ByVal pTabClients() As TClient) As TClient

        ' retourne le client, de type TClient correspondant au n° de commande

        ' passé en paramètre. Si le n° de commande n'existe pas. Retourne un

        ' client, de type TClient, 'vide', à l'exception du champ code qui sera

        ' mis à X
        Dim i As Integer
        For i = 0 To MAX
            If pTabCommandes(i).numéro = pNuméroCommande Then
                For j = 0 To MAX
                    While pTabCommandes(i).codeClient <> pTabClients(j).code
                        j += 1
                    End While
                    If pTabClients(j).code = pTabCommandes(i).codeClient Then
                        Return pTabClients(j)
                    End If
                Next


            End If
        Next
        pTabClients(i).nom = ""
        pTabClients(i).adresse = ""
        pTabClients(i).code = "X"
        Console.WriteLine("Client ou commande non trouvé(e)")
        Return pTabClients(i)
    End Function



    Function MontantCommandé(ByVal pCodeClient As String, ByVal pTabCommandes() As TCommande) As Double
        Dim total As Double
        For i = 0 To MAX
            If pCodeClient = pTabCommandes(i).codeClient Then
                total += pTabCommandes(i).montant
            End If
        Next
        Return total
    End Function



    Sub Main()

        Dim lesClients(MAX), client As TClient
        Dim lesCommandes(MAX) As TCommande
        Dim choix, montantclient As Double
        Dim codeduClient As String
        Dim numeroCommande As Integer

        lesClients(0).code = "C01"
        lesClients(0).nom = "NomC01"
        lesClients(0).adresse = "AdresseC01"
        lesClients(1).code = "C02"
        lesClients(1).nom = "NomC02"
        lesClients(1).adresse = "AdresseC02"
        lesClients(2).code = "C03"
        lesClients(2).nom = "NomC03"
        lesClients(2).adresse = "AdresseC03"
        lesCommandes(0).numéro = 1
        lesCommandes(0).dateC = "01-01-01"
        lesCommandes(0).montant = 100
        lesCommandes(0).codeClient = "C02"
        lesCommandes(1).numéro = 2
        lesCommandes(1).dateC = "02-01-02"
        lesCommandes(1).montant = 200
        lesCommandes(1).codeClient = "C01"
        lesCommandes(2).numéro = 3
        lesCommandes(2).dateC = "02-01-03"
        lesCommandes(2).montant = 300
        lesCommandes(2).codeClient = "C02"
        ' A COMPLETER
        Do
            Console.WriteLine("1. Montant total des commandes passées par un client (code client)")
            Console.WriteLine("2. Détails d'un client pour une commande (n° de commande)")
            Console.WriteLine("3. Quitter")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine()

            Select Case choix
                Case 1
                    Console.WriteLine("Code client ?")
                    codeduClient = Console.ReadLine()
                    montantclient = MontantCommandé(codeduClient, lesCommandes)
                    Console.WriteLine("Montant commandé : " + montantclient.ToString())
                Case 2
                    Console.WriteLine("Numéro commande ?")
                    numeroCommande = Console.ReadLine()
                    client = ClientPourUneCommande(numeroCommande, lesCommandes, lesClients)
                    Console.WriteLine("Code client : " + client.code.ToString())
                    Console.WriteLine("Nom : " + client.nom.ToString())
                    Console.WriteLine("Adresse : " + client.adresse.ToString())

                Case 3
                    Console.WriteLine("Au revoir")
            End Select
        Loop Until choix = 3
        Console.ReadLine()
    End Sub
End Module
