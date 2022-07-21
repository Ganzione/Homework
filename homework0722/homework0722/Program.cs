using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework0722
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b; //입력받는 수
            float c, d, e, f, g; //연산값을 저장

            Console.Write("input float1 : ");
            a = Console.ReadLine();
            float a1 = float.Parse(a); //입력받은 문자를 정수로 변환
            Console.Write("input float2 : ");
            b = Console.ReadLine();
            float b1 = float.Parse(b); //입력받은 문자를 정수로 변환


            c = a1 + b1;
            Console.WriteLine("+ : " + c);
            d = a1 - b1;
            Console.WriteLine("- : " + d);
            e = a1 % b1;
            Console.WriteLine("% : " + e);
            f = a1 / b1;
            Console.WriteLine("/ : " + f);
            g = a1 * b1;
            Console.WriteLine("* : " + g);
            Console.ReadKey();
        }
    }
}
