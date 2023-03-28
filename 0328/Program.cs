using System;
using System.Linq;

namespace _0328
{
    class Program
    {
        static void Prog1()
        {
            int[] Scores = { 78, 89, 90, 95, 63, 72, 98, 55, 43 };
            //    Scores[0]:78, Scores[1]:89
            int Total = 0;
            /*
            for(int i=0; i<Scores.Length; i+=2) // 取所有的偶數項目相加 
            {
                Total += Scores[i];
            }
            */
            foreach (int Score in Scores)
            {
                Total += Score;
            }
            int Max = Scores.Max();
            Console.WriteLine($"Total:{Total}");
        }
        // Check是用來列出傳入的陣列a中所有的奇數 
        static void Check(int[] ary)
        {
            Console.WriteLine("以下是所有的奇數：");
            foreach(int d in ary)
            {
                if (d%2==1)
                {
                    Console.Write($"{d},");
                }
            }
            Console.WriteLine();
        }
        static void Prog2()
        {
            int[] Scores = { 89, 34, 55, 90, 85 };
            Check(Scores);  // 呼叫函式的方法
        }
        static void Main(string[] args)
        {
            //Prog1();
            Prog2();
            Console.ReadLine();
        }
    }
}
