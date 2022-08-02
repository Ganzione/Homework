using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
        }
    }

    class Test
    {
        int[] answer; //배열 생성
        public Test() // 입력한 숫자가 올바른 숫자인지 판별
        {
            SetAnswer(); // 정답 설정
            int time = 0; //시도 횟수

            Console.WriteLine("정답이라고 생각되는 세자리 숫자를 입력해주세요.");

            while (true)
            {
                Console.Write("입력 : ");
                string input = Console.ReadLine();
                char[] inputArr = new char[3];

                inputArr = input.ToCharArray();
                time += 1;

                int inputNum = 0;

                if (!int.TryParse(input, out inputNum) || (inputNum < 100 || inputNum > 999))
                {
                    Console.WriteLine("잘못된 값을 입력하셨습니다. 3자리의 정수를 써주세요");
                    continue;
                } // 숫자를 제대로 입력했는지 확인

                if (inputArr[0].Equals(inputArr[1]) || inputArr[1].Equals(inputArr[2]) || inputArr[0].Equals(inputArr[2]))
                {
                    Console.WriteLine("중복된 값을 입력하셨습니다. 중복되지 않은 숫자 3자리를 입력해주세요");
                    continue;
                } // 입력한 숫자가 중복되는지 확인

                if (IsCorrectAnswer(inputNum))
                {
                    Console.WriteLine("정답입니다!!");
                    Console.WriteLine("총 {0}번 진행하셨습니다.", time);
                    Console.ReadKey();
                    break;
                } // 정답을 맞췄을 경우 while문 종료
            }
        }

        public void SetAnswer() // 중복 없이 정답 생성하는 메소드
        {
            int k = 0;
            answer = new int[3];
            while (k < 3)
            {
                bool isSet = true;
                answer[k] = new Random().Next(1, 10);
                for (int i = k - 1; i >= 0; i--)
                {
                    if (answer[k] == answer[i])
                    {
                        isSet = false;
                        break;
                    }
                }
                if (isSet)
                {
                    k++;
                }
            }
        }

        public bool IsCorrectAnswer(int inputNum) // 입력한 숫자와 정답을 비교하는 메소드
        {
            int s = 0;
            int b = 0;
            int[] input = { inputNum % 10, (inputNum / 10) % 10, (inputNum / 100) % 10 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (input[i] == answer[j])
                    {
                        if (i == j)
                        {
                            s++;
                        }
                        else
                        {
                            b++;
                        }
                    }
                }
            }
            if (s == 0 && b ==0)
            {
                Console.WriteLine("아웃입니다!");
            }
            else if (s == 3)
                {
                    return true;
                }
            else
            {
                Console.WriteLine($"스트라이크 : {s} 볼 : {b}");
            }
            return false;
        }
    }
}