﻿using System;
using System.Collections.Generic;

namespace _2023_12_29_Menu
{
    struct Reservation
    {
        public Forfait forfait;
        public Client client;
    }
    struct Client
    {
        public string nom;
        public string prenom;
        public string tel;
    }
    struct Forfait
    {
        public string ville;
        public Transport transport;
        public Hebergement hebergement;
        public Loisir loisir;
    }

    struct Transport
    {
        public DetailTransport det_transport;
        public string type_transport;
    }

    struct DetailTransport
    {
        public double prix_total;
        public int duree;
        public string nom_compagnie;
    }

    struct Hebergement
    {
        public int etoiles;
        public double prix_nuit;
        public string nom_hotel;
    }

    struct Loisir
    {
        public string description;
        public double prix_activite;
    }
    internal class Program
    {
        //Deffinition des variables globales
        static List<Client> clients = new List<Client>();
        static List<Forfait> forfaits = new List<Forfait>();
        private static List<Reservation> reservations = new List<Reservation>();
        private static void Main(string[] args)
        {
            /*
             * deffinion du problemme
             * Algorithmes et structures de données
             * Projets
               Equipe de 2 ou individuel
               
               Projet  
               Pour les besoins de gestion d’une agence de voyage, on veut un système qui nous 
               permet d’offrir des infos aux clients potentiels.
               Chaque offre du voyagiste est composée des forfaits suivants : destination, transport, 
               hébergement et loisir.
               La destination indique seulement le nom de la ville alors que le transport peut être 
               par air, mer ou terrestre et pour chacun on ne liste que le prix total, durée du 
               voyage et le nom de la compagnie. Pour l’hébergement, on ne listera que le nombre 
               d’étoiles de l’hôtel, le prix de la nuitée et le nom de l’hôtel. Finalement, pour 
               les loisirs, on ne liste que la description du loisir et le coût associé.
               Un client appelle le voyagiste et fait une réservation. On notera alors le nom, prénom 
               et numéro de téléphone du client et l’offre qu’il a choisie. 
               Le gérant veut lister à la fin de la journée les offres qu’il a vendues. Écrire 
               l’algorithme qui donne la liste des clients (nom, prénom, num téléphone) ainsi que 
               l’offre choisie.
                            
               BESOINS
               Proposer une démarche (algorithme) pour la saisie et le stockage des données 
               ainsi que l'affichage éventuel des informations
               
               Traduire l’algorithme en C#. 
               On prévoira un système de menu pour le projet.
                         
               Recommandations importantes
               
               Vous devez fournir un découpage approprié de la solution choisie.
               L’entête de l'algorithme doit comporter une description du problème en utilisant vos propres mots. */ 
               
               
            int opt;
            do
            {
                Console.WriteLine("***********************");
                Console.WriteLine("*1) Ajouter un client *");
                Console.WriteLine("*2) Vente de forfait  *");
                Console.WriteLine("*3) Administration    *");
                Console.WriteLine("*4) Liste de ventes   *");
                Console.WriteLine("*5) quiter            *");
                Console.WriteLine("***********************");
                Console.Write("SVP choisir l'une des options: ");
                if (int.TryParse(Console.ReadLine(), out opt))
                {
                    switch (opt)
                    {
                        case 1:
                            AjouterClient();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            VenteForfait();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            Administration();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            ListeVentes();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 5:
                            Console.WriteLine("vous allez sortir");
                            break;
                            
                        default:
                            Console.WriteLine("Saisir une option valide");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Veuiller saisir un nombre valide");
                    Console.Clear();
                }
            } while (opt != 5); 
        }

        private static void VenteForfait()
        {
            Console.WriteLine("liste de clients disponibles:");
            for (int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine($"[{i+1}] Client: {clients[i].prenom} {clients[i].nom}");
            }
            Console.Write("Veuiller saisir le numero du client: ");
            int choixClient = Convert.ToInt16(Console.ReadLine());
            if (choixClient > 0 && choixClient <= clients.Count)
            {
                Console.WriteLine("liste de forfaits disponibles:");
                for (int i = 0; i < forfaits.Count; i++)
                {
                    Console.WriteLine($"[{i+1}] Forfait: {forfaits[i].ville}");
                }

                Console.Write("Veuiller saisir le numero du forfait: ");
                int choixForfait = Convert.ToInt16(Console.ReadLine());
                if (choixForfait > 0 && choixForfait <= clients.Count)
                {
                    Client clientChoisi = clients[choixClient - 1];
                    Forfait forfaitChoisi = forfaits[choixForfait - 1];

                    Reservation newReservation = new Reservation();
                    newReservation.client = clientChoisi;
                    newReservation.forfait = forfaitChoisi;
                    reservations.Add(newReservation);
                }
            }
            else
            {
                Console.WriteLine("choix invalide de client");
            }
        }

        private static void ListeVentes()
        {
            Console.WriteLine("Liste de ventes d'aujourd'hui:");
            foreach (var reservation in reservations)
            {
                Console.WriteLine($"Client: {reservation.client.prenom} {reservation.client.nom}");
                Console.WriteLine($"Numero de téléphone: {reservation.client.tel}");
                Console.WriteLine($"Ville: {reservation.forfait.ville}");
                Console.WriteLine($"Type de transport {reservation.forfait.transport.type_transport}");
                Console.WriteLine($"Compagnie de transport {reservation.forfait.transport.det_transport.nom_compagnie}");
                Console.WriteLine($"Duréé du voyage {reservation.forfait.transport.det_transport.duree}");
                Console.WriteLine($"Prix du transport {reservation.forfait.transport.det_transport.prix_total}");
                Console.WriteLine($"Nom du hotel {reservation.forfait.hebergement.nom_hotel}");
                Console.WriteLine($"Etoiles du hotel {reservation.forfait.hebergement.etoiles}");
                Console.WriteLine($"Prix du hotel par nuit {reservation.forfait.hebergement.prix_nuit}");
                Console.WriteLine($"Description du loisir {reservation.forfait.loisir.description}");
                Console.WriteLine($"Prix du loisir {reservation.forfait.loisir.prix_activite}");
            }
        }

        private static void AjouterClient()
        {
            Client newClient = new Client();
            Console.Write("Nom du client : ");
            newClient.nom = Console.ReadLine();
            Console.Write("Prénom du client : ");
            newClient.prenom = Console.ReadLine();
            Console.Write("Numéro de téléphone : ");
            newClient.tel = Console.ReadLine();
            clients.Add(newClient);
            Console.WriteLine("Client ajouté avec succès.");
        }
        private static void Administration()
        {
            int adminchoix;
            do
            {
                Console.WriteLine("******************************");
                Console.WriteLine("*Menu d'administration:      *");
                Console.WriteLine("*1) Ajouter un forfait       *");
                Console.WriteLine("*2) Supprimer un forfait     *");
                Console.WriteLine("*0) Retour au menu principal *");
                Console.WriteLine("******************************");
                Console.Write("Choix : ");
                if (int.TryParse(Console.ReadLine(), out adminchoix))
                {
                    switch (adminchoix)
                    {
                        case 1:
                            AjouterForfait();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            SuprimerForfait();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 0:
                            Console.WriteLine("Retour au menu principal");
                            break;
                        default:
                            Console.WriteLine("Veuillez reessaier, choix invalide");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Veuiller saisir un nombre valide");
                }
            } while (adminchoix!=0);
        }
        private static void AjouterForfait()
        {
            int choix;
            bool exit = true;
            Forfait newForfait = new Forfait();
            Console.WriteLine("Destination");
            newForfait.ville = Console.ReadLine();
            do
            {
                Console.WriteLine("mode de transport: ");
                Console.WriteLine("1) air");
                Console.WriteLine("2) terrestre");
                Console.WriteLine("3) maritime");
                Console.Write("Choix: ");
                if (int.TryParse(Console.ReadLine(),out choix))
                {
                    switch (choix)
                    {
                        case 1:
                            newForfait.transport.type_transport = "air";
                            exit = false;
                            break;
                        case 2:
                            newForfait.transport.type_transport = "terrestre";
                            exit = false;
                            break;
                        case 3:
                            newForfait.transport.type_transport = "air";
                            exit = false;
                            break;
                        default:
                            Console.WriteLine("Veuillez reessaier, choix invalide");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Veuiller saisir un nombre valide");
                }
            } while (exit);

            Console.WriteLine("Prix totale du transport: ");
            newForfait.transport.det_transport.prix_total = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Durée du voyage (en jours): ");
            newForfait.transport.det_transport.duree = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nom de la compagnie de transport : ");
            newForfait.transport.det_transport.nom_compagnie = Console.ReadLine();
            Console.Write("Nombre d'étoiles de l'hôtel : ");
            newForfait.hebergement.etoiles = Convert.ToInt16(Console.ReadLine());
            Console.Write("Prix de la nuitée : ");
            newForfait.hebergement.prix_nuit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nom de l'hôtel : ");
            newForfait.hebergement.nom_hotel = Console.ReadLine();
            Console.Write("Description de l'activité de loisir : ");
            newForfait.loisir.description = Console.ReadLine();
            Console.Write("Coût de l'activité de loisir : ");
            newForfait.loisir.prix_activite = Convert.ToDouble(Console.ReadLine());
            forfaits.Add((newForfait));
            Console.WriteLine("Forfait ajouté!");
        }
        private static void SuprimerForfait()
        {
            int choix;
            if (forfaits.Count == 0)
            {
                Console.WriteLine("Aucun forfait pour supprimmer!");
                return;
            }
            //Lists all available offers
            Console.WriteLine("Forfaits disponibles:");
            for (int i = 0; i < forfaits.Count; i++)
            {
                Console.WriteLine($"[{i+1}] Ville: {forfaits[i].ville}"); //i+1 prints the user-expected value for the offer
            }

            Console.Write("Veuillez choisir le forfait à supprimer: ");
            choix = int.Parse(Console.ReadLine());
            if (choix > 0 && choix <= forfaits.Count)
            {
                int forfaitASupprimmer = choix - 1; //operation made to make the index equal to the one on the list
                Console.WriteLine($"le forfait choisi est {forfaits[forfaitASupprimmer].ville}");
                Console.Write("Veuillez confirmer la suppression (O/N): ");
                string conf = Console.ReadLine();
                if (conf.ToUpper() == "O")
                {
                    forfaits.RemoveAt(forfaitASupprimmer); // This instruction deletes the list item with that index number
                    Console.WriteLine("Forfait supprimé!");
                }
                else
                {
                    Console.WriteLine("Suppression annulée");
                }
            }
            else
            {
                Console.WriteLine("Choix invalide");
            }
        }
    }
}