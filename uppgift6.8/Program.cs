using System;

namespace uppgift_6_7
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal för att veta hur många primtal som finns innan det:");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine(Prim(tal));
        }
        static int Prim(int tal)
        {
            int deltal = 0;
            int primtal = 0;
            for (int j = 1; j < tal; j++)
            {
                for (int i = 2; i < tal; i++)
                {
                    if (j % i == 0 && j != i)
                    {
                        deltal++;
                    }
                }
                if (deltal == 0)
                {
                    primtal++;
                }
                deltal = 0;
            }
            return primtal;
        }
    }
}