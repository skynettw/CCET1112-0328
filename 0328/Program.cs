using System;

namespace _0328
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Scores = {78, 89, 90, 95, 63, 72, 98, 55, 43 };
            //    Scores[0] : 78, Scores[1] : 89
            int Total = 0;
            for(int i=0; i<Scores.Length; i++)
            {
                Total += Scores[i];
            }
            Console.WriteLine($"Total:{Total}");
            Console.ReadLine();
        }
    }
}
