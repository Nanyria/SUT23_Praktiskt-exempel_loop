﻿using System.Security.Cryptography.X509Certificates;

namespace SUT23_Praktiskt_exempel_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program Uppv = new Program();
            //Uppv.Uppvärmning();
            
            //Program steg1 = new Program();
            //steg1.steg1();

            //Program steg2 = new Program();
            //steg2.steg22();

            Program steg3 = new Program();
            steg3.steg3();
        }
        public void Uppvärmning()
        {
            int nr = 0;
            do
            {
                Console.WriteLine("*");
                nr++;
            } while (nr <= 4);

            Console.WriteLine();
            Console.ReadLine();
        }
        public void Steg1()
        {
            char[] ar = { '*', '*', '*', '*', '*' };
            foreach (char item in ar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        //public void steg2olöst()
        //{
        //    string text = *
        //    int nr = Int32.Parse(text);

        //    char[] ar = { '*' * nr };
        //    foreach (char item in ar)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine();
        //    Console.ReadLine();

        //    2 - olöst
        //    Console.WriteLine("Enter amount:");
        //    string a = (Console.ReadLine());
        //    int nr = Int32.Parse(Console.ReadLine());

        //    do
        //    {
        //        Console.WriteLine("*");
        //    } while (nr >= a);
        //}
        public void steg1()
        {
            Console.WriteLine("Enter amount:");
            int j = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("*");
            }

            Console.ReadLine();
        }
        public void steg22()
        {
            Console.WriteLine("Enter amount:");
            int j = Int32.Parse(Console.ReadLine());
            for (int row = 0; row < j; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        public void steg3()
        {
            Console.WriteLine("Enter amount:");
            int j = Int32.Parse(Console.ReadLine());
            for (int row = 0; row < j; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("*");
                }
                for (int col = 0; col >= row; col--)
                {
                    Console.Write("~");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }


        }


    }
        
            



            





        
    
