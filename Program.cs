using System;

namespace _2023_12_29_Menu
{
    internal class Program
    {
        public static void Main(string[] args)
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
             */
            //Debut de notre programme pour une agence de voyage
            //Voici le menu.
            bool exit = true;
            do
            {
                Console.WriteLine("*************");
                Console.WriteLine("*1) opcion 1*");
                Console.WriteLine("*2) opcion 2*");
                Console.WriteLine("*3) opcion 3*");
                Console.WriteLine("*4) salir   *");
                Console.WriteLine("*************");
                Console.WriteLine("elige una de las opciones");
                int opt = Convert.ToInt16(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("has elegido la opcion 1");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("has elegido la opcion 2");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("has elegido la opcion 3");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("debes elegir una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                
            } while (exit);
        }
    }
}