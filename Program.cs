using System;
using System.Collections.Generic;

namespace _2023_12_29_Menu
{
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
        static List<Client> clients = new List<Client>();
        static List<Forfait> forfaits = new List<Forfait>();
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
               L’entête de l'algorithme doit comporter une description du problème en utilisant vos propres mots.  
               
               
             * Deffinition des structures de données
             * 
            //Debut de mon programme pour une agence de voyage
            //Voici le menu.
            //1 – Ajouter un client
            // 2 – vente de forfait
            // 3- administration (3.1- Ajouter un forfait ,3.2 - Supprimer un forfait)
            // 4-Quitter*/

            //List<Reservation> reservations = new List<Reservation>();
            int opt;
            do
            {
                Console.WriteLine("***********************");
                Console.WriteLine("*1) Ajouter un client *");
                Console.WriteLine("*2) Vente de forfait  *");
                Console.WriteLine("*3) Administration    *");
                Console.WriteLine("*4) quiter            *");
                Console.WriteLine("***********************");
                Console.Write("SVP choisir l'une des options: ");
                if (int.TryParse(Console.ReadLine(), out opt))
                {
                    switch (opt)
                    {
                        case 1:
                            Ajouter_client();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            //vente_forfait();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            Administration();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
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
            } while (opt != 4); 
        }
        private static void Ajouter_client()
        {
            Console.Write("Nom du client : ");
            string nom = Console.ReadLine();
            Console.Write("Prénom du client : ");
            string prenom = Console.ReadLine();
            Console.Write("Numéro de téléphone : ");
            string tel = Console.ReadLine();
            
            clients.Add(new Client { nom = nom, prenom = prenom, tel = tel });

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
            throw new NotImplementedException();
        }
    }
}