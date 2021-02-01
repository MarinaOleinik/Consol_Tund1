using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_Tund1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Beep();
            int a = rnd.Next(1, 50);
            Console.WriteLine(a);
            string text = "";

            switch (a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    text = "один";break;
                case 21 : text = "два";break;
                case 31 : text = "три"; break;
                case 44 : text = "четыре"; break;
                case 50 : text = "пять"; break;
                default:
                    text = "Viga!";
                    break;
            }
            Console.WriteLine(text);
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace...");
                nupp = Console.ReadKey();
            } while (nupp.Key!=ConsoleKey.Backspace);

            if (a>=1 && a<=10)
            {text = "11111"; }
            else if (a >= 11 && a <= 20)
            {text = "2222222";}
            else if (a >= 21 && a <= 30)
            {text = "333333";}
            else if (a >= 31 && a <= 40)
            {text = "444444";}
            else if (a >= 41 && a <= 50)
            {text = "555555";}
            Console.WriteLine(text);

            StreamWriter file = new StreamWriter(@"..\..\text.txt",true);
            file.WriteLine(text);
            file.Close();
            StreamReader filest = new StreamReader(@"..\..\text.txt");
            text = filest.ReadToEnd();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("Failis oli text:\n{0}", text);

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }
            Random r = new Random();
            int[] numbers2 = new int[6];
            for (int k = 0; k < numbers2.Length; k++)
            {
                numbers2[k] = r.Next(1, 200);
            }
            foreach (int i in numbers2)
            {
                Console.Write(i);
            }
            int[,] numbers3 = new int[4,10];
            for (int i = 0; i < numbers3.GetLength(0); i++)
            {
                for (int j = 0; j < numbers3.GetLength(1); j++)
                {
                    numbers3[i, j] = 1;
                    Console.Write(numbers3[i, j]);
                }
                Console.WriteLine();
            }   
            Console.ReadLine();
        }

    }
}
