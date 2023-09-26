using System.Security.Cryptography.X509Certificates;

namespace SUT23_Praktiskt_exempel_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program Uppv = new Program();
            Uppv.Uppvärmning();
            
            Program steg1 = new Program();
            steg1.Steg1();
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
        public void steg2()
        {
            Console.WriteLine("Enter amount:");
            int j = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("*");
            }

            Console.ReadLine();

            Console.WriteLine("Enter amount:");
            int j = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("*");
                if (i == j)
                {
                    Console.Write(" *");
                }
            }

            Console.ReadLine();
        }


    }
        
            



            





        
    }
