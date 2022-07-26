using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework0722
{
    internal class homework0726
    {
        static void Main(string[] args)
        {
            string a, b, c; //a,c= 숫자, b=부호
            int d = 0; //결과값

            Console.Write("input1: ");
            a = Console.ReadLine();
            int a1 = int.Parse(a);

            Console.Write("input2: ");
            b = Console.ReadLine();

            Console.Write("input3: ");
            c = Console.ReadLine();
            int c1 = int.Parse(c);

            switch (b) //첫번째 계산
            {
                case "+":
                    d = a1 + c1;
                    Console.WriteLine(d);
                    break;

                case "-":
                    d = a1 - c1;
                    Console.WriteLine(d);
                    break;

                case "/":
                    d = a1 / c1;
                    Console.WriteLine(d);
                    break;

                case "*":
                    d = a1 * c1;
                    Console.WriteLine(d);
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

            while (true) //반복
            {
                Console.Write("계속할까요?(Y/N): ");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                {
                    Console.Write("input2: ");
                    b = Console.ReadLine();

                    Console.Write("input3: ");
                    c = Console.ReadLine();
                    c1 = int.Parse(c);

                    switch (b) //첫번째 이후 계산
                    {
                        case "+":
                            Console.WriteLine(d + c1);
                            break;

                        case "-":
                            Console.WriteLine(d - c1);
                            break;

                        case "/":
                            Console.WriteLine(d / c1);
                            break;

                        case "*":
                            Console.WriteLine(d * c1);
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    continue;
                }

                else if (answer == "n" || answer == "N")
                {
                    break;
                }
                else
                {
                    Console.Write("다시 적어주세요. ");
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}

