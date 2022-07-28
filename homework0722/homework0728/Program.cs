using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework0728
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            
            for(a = 0; a < 6; a++)
            {
                for(b = 0; b < a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(); //삼각형1

            for(a = 0; a < 5; a++)
            {
                for(b = 0; b < (4 -a); b++)
                {
                    Console.Write(" ");
                }
                for (c = 0; c <= a; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(); //삼각형2

            for (a = 0; a < 5; a++)
            {
                for(b = 0; b < (4 -a); b++)
                {
                    Console.Write(" ");
                }
                for(c = 0; c <= a; c++)
                {
                    Console.Write("*");
                }
                for(d = 0; d < a; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(); //삼각형3

            for (a = 0; a < 5; a++)
            {
                for (b = 0; b < (4 - a); b++)
                {
                    Console.Write(" ");
                }
                for (c = 0; c <= a; c++)
                {
                    Console.Write("*");
                }
                for (d = 0; d < a; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); //다이아몬드 위쪽
            }
            for (a = 1; a < 5; a++)
            {
                for (b = 0; b < a; b++)
                {
                    Console.Write(" ");
                }
                for (c = 9; c > (2*a); c--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            } //다이아몬드 아래쪽

            Console.ReadKey();
        }
    }
}
