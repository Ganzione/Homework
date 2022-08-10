using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    internal class Program
    {
        int[] number;
        Random my_rand;
        public Program()
        {
            number = new int[7];
            my_rand = new Random();
        }
        void MakeNumber()
        {
            int a;
            for (int i = 0; i < number.Length; i++)
            {
                a = my_rand.Next(1, 46);
                if (true == CheckSame(i, a))
                {
                    number[i] = a;
                }
                else
                {
                    i--;
                }
            }
        }
        void ShowNumber()
        {
            Console.WriteLine("생성된 로또 번호는 다음과 같습니다.");
            for (int i = 0; i < number.Length; i++)
            {
                if (i == number.Length - 1)
                {
                    Console.WriteLine(" 보너스 번호는 " + number[i]);
                }
                else
                {
                    Console.Write(" " + number[i]);
                }
            }
        }
        bool CheckSame(int index, int value)
        {
            for (int i = 0; i < index; i++)
            {
                if (value == number[i])
                {
                    return false;
                }
            }
            return true;
        }
        void run()
        {
            MakeNumber();
            ShowNumber();
        }
        public static void Main(String[] args)
        {
            Program p;
            p = new Program();
            p.run();
            Console.ReadKey();
        }
    }
}
