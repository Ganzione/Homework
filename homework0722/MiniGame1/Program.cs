using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int win = 0; //승리 횟수

            while (true)
            {
                int i = random.Next(1, 10); //컴퓨터가 1~9 중 하나를 랜덤 선택한다.

                Console.Write("홀 또는 짝 중에 하나를 적어주십시오: ");
                string a = Console.ReadLine();

                if (a == "짝") //사용자가 짝을 입력했을 시
                {
                    if (i % 2 == 0) //사용자가 짝을 입력했을 때, 컴퓨터가 짝수를 골랐을 시
                    {
                        win++; //승리 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 짝");
                        Console.WriteLine("승리!");
                        Console.Write("계속 진행하시겠습니까? (Y/N): ");
                        string b = Console.ReadLine();

                        First: //y또는 n 이외를 입력했을 때, 정정하여 돌아올 곳
                        if (b == "Y" || b == "y")
                        {
                            continue; //게임 재시작
                        }
                        if (b == "N" || b == "n")
                        {
                            Console.WriteLine("게임을 종료합니다.");
                            Console.WriteLine("총 {0}번 승리하셨습니다.", win);
                            break; // 게임 종료
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("다시 입력해주세요: ");
                                b = Console.ReadLine();
                                if(b == "y" || b == "Y" || b == "n" || b == "N")
                                {
                                    goto First; //잘못 입력했을 시 정정될 때까지 반복
                                }
                            }
                        }
                    }
                    else //사용자가 짝을 입력했을 때, 컴퓨터가 홀수를 골랐을 시
                    {
                        Console.WriteLine("컴퓨터의 선택: 홀");
                        Console.WriteLine("패배!");
                        Console.WriteLine("게임이 종료되었습니다.");
                        Console.WriteLine("총 {0}번 승리하셨습니다.", win);
                        break; //게임 종료
                    }
                }
                if (a == "홀") //사용자가 홀을 입력했을 시
                {
                    if (i % 2 != 0) //사용자가 홀을 입력했을 때, 컴퓨터가 홀수를 골랐을 시
                    {
                        win++;
                        Console.WriteLine("컴퓨터의 선택: 홀");
                        Console.WriteLine("승리!");
                        Console.Write("계속 진행하시겠습니까? (Y/N): ");
                        string b = Console.ReadLine();

                        Second: //y또는 n 이외를 입력했을 때, 정정하여 돌아올 곳
                        if (b == "Y" || b == "y")
                        {
                            continue;
                        }
                        if (b == "N" || b == "n")
                        {
                            Console.WriteLine("게임을 종료합니다.");
                            Console.WriteLine("총 {0}번 승리하셨습니다.", win);
                            break;
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("다시 입력해주세요: ");
                                b = Console.ReadLine();
                                if (b == "y" || b == "Y" || b == "n" || b == "N")
                                {
                                    goto Second; //잘못 입력했을 시 정정될 때까지 반복
                                }
                            }
                        }
                    }
                    else //사용자가 홀을 입력했을 때, 컴퓨터가 짝수를 골랐을 시
                    {
                        Console.WriteLine("컴퓨터의 선택: 짝");
                        Console.WriteLine("패배!");
                        Console.WriteLine("게임이 종료되었습니다.");
                        Console.WriteLine("총 {0}번 승리하셨습니다.", win);
                        break;
                    }
                }
                else //사용자가 홀 또는 짝 이외의 것을 입력했을 때, 정정될 때까지 반복
                {
                    Console.WriteLine("입력을 확인하지 못했습니다.");
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
