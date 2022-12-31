using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace espacios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string volvMenu;
            do
            {

            
             int opción;
             
             Console.WriteLine("Elije las siguientes opciones:");
             Console.WriteLine("(1) Strings");
             Console.WriteLine("(2) Juego Dados");
             Console.WriteLine("(3) Primzahlen");

             opción = Convert.ToInt32(Console.ReadLine());

            
            


                switch (opción)
                
                {
                    case 1:


                        char espacio = ' ';
                        int numespacio = 0;
                        string satz;
                        Console.WriteLine("Da tu Satz:");
                        satz = Console.ReadLine();


                        for (int i = 0; i < satz.Length; i++)
                        {

                            if (satz[i] == espacio)
                            {
                                numespacio++;

                            }
                        }
                        Console.WriteLine("Numero de espacio" + "\t\t"+ numespacio);
                        Console.ReadLine();


                        string oración;
                        Console.WriteLine("Da tu Satz:");
                        oración = Console.ReadLine();


                        char[] array = oración.ToCharArray();
                        Array.Reverse(array);

                        foreach (char c in array)
                        {
                            Console.WriteLine("La oración al reves es:");
                            Console.Write(c);
                        }
                        break;

                    case 2:



                        Console.WriteLine("Jueguito dados");
                        Console.WriteLine("-----------------------------------");

                        int jugadores;

                        Console.WriteLine("Numero de jugadores:");
                        jugadores = Convert.ToInt32(Console.ReadLine());
                        int[] spiel1 = new int[jugadores];
                        int[] spiel2 = new int[jugadores];

                        Random r = new Random();

                        string[] name = new string[jugadores];

                        for (int i = 0; i < name.Length; i++)
                        {
                            Console.WriteLine("Sus Nombres" + (i + 1));
                            name[i] = Console.ReadLine();
                        }
                        Console.Clear();


                        int[] gesamt = new int[jugadores];
                        for (int i = 0; i < name.Length; i++)
                        {
                            spiel1[i] = r.Next(1, 6);

                        }
                        for (int i = 0; i < name.Length; i++)
                        {
                            spiel2[i] = r.Next(1, 6);
                        }

                        Console.WriteLine(" Jugadores" + "\t\t" + "juego1" + "\t\t" + "Juego 2" + "\t\t" + "gesamt");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine();
                        for (int i = 0; i < name.Length; i++)
                        {
                            gesamt[i] = spiel1[i] + spiel2[i];
                            Console.WriteLine(name[i] + "\t\t\t" + spiel1[i] + "\t\t\t" + spiel2[i] + "\t\t\t" + gesamt[i]);

                        }
                        Console.WriteLine("Die Meisten");
                        int max = gesamt.Max();
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (gesamt[i] == max)
                                Console.WriteLine("Die Meisten punkte ist" + "\t\t" + gesamt[i] + "\t\t" + "von" + "\t\t" + name[i]);
                        }
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Números primos");
                        bool bandera;
                        int num1;
                        
                        Console.WriteLine("Num1:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        

                        for (int i = num1; i < num1 + 100; i++)
                        {
                            bandera = true;
                            for (int j = 2; j < i; j++)
                            {
                                if (i % j == 0)
                                {
                                    bandera = false;
                                }

                            }
                            if (i != 1 && bandera)
                            {

                                Console.Write(i);
                                break;

                            }

                        }
                        break;
                    default:
                        Console.WriteLine("Elija una opción correcta");

                        break;

                }
                Console.WriteLine("");
                Console.WriteLine("Quiere escoger otra opción? escriba si/no");

                volvMenu = Console.ReadLine();
                if (volvMenu == "si") ;
                {
                    Console.Clear();
                }
            }
            while (volvMenu == "si");
        }
    }
}

            










        
        
   

