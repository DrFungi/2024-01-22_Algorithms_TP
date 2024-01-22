using System;

namespace _2023_12_29_Menu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Aqui comienza nuestro codigo para desarrollar una agencia de
            //viajes que plantea un cierto menu.
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