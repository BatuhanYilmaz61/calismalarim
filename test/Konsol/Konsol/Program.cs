using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.ReadLine();
            int number = 11;
            int number2 = 20;
            int sonuc = number + number2;
            Console.WriteLine(sonuc);
            Console.ReadLine();
            Console.WriteLine("Number1 is   {0}", number);
            Console.ReadLine();
            if (number == 10)
            {
                Console.WriteLine("Sonuc Doğru");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sonuc Yanlış");
                Console.ReadLine();

            }
            string[] students = new string[3]
                {"Berk","Deniz", "Kırtepe"};
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.ReadLine();

            }
            string[,] regions = new string[3, 3]

         {
            {"İstanbul","İzmir","Ankara" },
            { "Bursa","Balıkesir","Gaziantep" },
            { "Şırnak","Hakkari","Muş"}

        };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("***");
            }
            Console.ReadLine();

        }




    }
}