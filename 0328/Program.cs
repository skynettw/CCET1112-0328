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
        // 以下的函式用來示範把使用者輸入的數字放到陣列中 

        static void Prog3()
        {
            const int MAX_NUM = 50;
            int[] Scores = new int[MAX_NUM]; //宣告一個有MAX_NUM個int的陣列
            int Count = 0; //這是用來記錄目前已輸入的數字位置（個數）
            int Score;
            Console.Write("score=");
            Score  = Convert.ToInt32(Console.ReadLine());
            while(Score>=0)
            {
                if (Count < MAX_NUM)
                {
                    Scores[Count++] = Score;
                    Console.Write("score=");
                    Score = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("你輸入的個數太多了。");
                    break;
                }
                
            }

            // 請寫一段程式碼列出剛剛使用者輸入的所有數字
            for(int i=0; i<Count; i++)
            {
                Console.Write($"{Scores[i]} ");
            }
            Console.WriteLine();
            // 0328作業A要求：完成這個程式，可以用Array的方法函式以及其它計算，
            // 求：總和、平均值、最大值、最小值、中位數、標準差等等 
            

        }
        static void Main(string[] args)
        {
            //Prog1();
            //Prog2();
            Prog3();
            Console.ReadLine();
        }
    }
}
