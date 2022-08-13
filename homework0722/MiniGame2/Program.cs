using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int win = 0;
            int same = 0;

            while (true)
            {
                int i = random.Next(1, 4); // 1~3을 컴퓨터가 선택함. 1=가위 2=바위 3=보

                Console.Write("가위 바위 보 중에 하나를 선택해주십시오: ");
                string a = Console.ReadLine();

                if (a == "가위")
                {
                    if (i == 1) // 컴퓨터가 가위를 냈을 시
                    {
                        same++; //비긴 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 가위");
                        Console.WriteLine("무승부!");
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
                            Console.WriteLine("총 {0}번 비기고, {1}번 승리하셨습니다.",same ,win);
                            break; // 게임 종료
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("다시 입력해주세요: ");
                                b = Console.ReadLine();
                                if (b == "y" || b == "Y" || b == "n" || b == "N")
                                {
                                    goto First; //잘못 입력했을 시 정정될 때까지 반복
                                }
                            }
                        }
                    }
                    if (i == 3) // 컴퓨터가 보를 골랐을 시
                    {
                        win++; //승리 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 보");
                        Console.WriteLine("승리!");
                        Console.Write("계속 진행하시겠습니까? (Y/N): ");
                        string b = Console.ReadLine();

                    Second: //y또는 n 이외를 입력했을 때, 정정하여 돌아올 곳
                        if (b == "Y" || b == "y")
                        {
                            continue; //게임 재시작
                        }
                        if (b == "N" || b == "n")
                        {
                            Console.WriteLine("게임을 종료합니다.");
                            Console.WriteLine("총 {0}번 비기고, {1}번 승리하셨습니다.", same, win);
                            break; // 게임 종료
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
                    else
                    {
                        Console.WriteLine("컴퓨터의 선택: 바위");
                        Console.WriteLine("패배!");
                        Console.WriteLine("게임이 종료되었습니다.");
                        Console.WriteLine("총 {0}번 비기고, {1}번 승리하셨습니다.", same, win);
                        break; //게임 종료
                    }
                }


                if (a == "바위")
                {
                    if (i == 2) // 컴퓨터가 바위를 냈을 시
                    {
                        same++; //비긴 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 바위");
                        Console.WriteLine("무승부!");
                        Console.Write("계속 진행하시겠습니까? (Y/N): ");
                        string b = Console.ReadLine();

                    Third: //y또는 n 이외를 입력했을 때, 정정하여 돌아올 곳
                        if (b == "Y" || b == "y")
                        {
                            continue; //게임 재시작
                        }
                        if (b == "N" || b == "n")
                        {
                            Console.WriteLine("게임을 종료합니다.");
                            Console.WriteLine("총 {0}번 비기고, {1}번 승리하셨습니다.", same, win);
                            break; // 게임 종료
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("다시 입력해주세요: ");
                                b = Console.ReadLine();
                                if (b == "y" || b == "Y" || b == "n" || b == "N")
                                {
                                    goto Third; //잘못 입력했을 시 정정될 때까지 반복
                                }
                            }
                        }
                    }
                    if (i == 1) // 컴퓨터가 가위를 골랐을 시
                    {
                        win++; //승리 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 가위");
                        Console.WriteLine("승리!");
                        Console.Write("계속 진행하시겠습니까? (Y/N): ");
                        string b = Console.ReadLine();

                    Four: //y또는 n 이외를 입력했을 때, 정정하여 돌아올 곳
                        if (b == "Y" || b == "y")
                        {
                            continue; //게임 재시작
                        }
                        if (b == "N" || b == "n")
                        {
                            Console.WriteLine("게임을 종료합니다.");
                            Console.WriteLine("총 {0}번 비기고, {1}번 승리하셨습니다.", same, win);
                            break; // 게임 종료
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("다시 입력해주세요: ");
                                b = Console.ReadLine();
                                if (b == "y" || b == "Y" || b == "n" || b == "N")
                                {
                                    goto Four; //잘못 입력했을 시 정정될 때까지 반복
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("컴퓨터의 선택: 보");
                        Console.WriteLine("패배!");
                        Console.WriteLine("게임이 종료되었습니다.");
                        Console.WriteLine("총 {0}번 비기고, {1}번 승리하셨습니다.", same, win);
                        break; //게임 종료
                    }
                }


                if (a == "보")
                {
                    if (i == 3) // 컴퓨터가 보를 냈을 시
                    {
                        same++; //비긴 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 보");
                        Console.WriteLine("무승부!");
                        Console.Write("계속 진행하시겠습니까? (Y/N): ");
                        string b = Console.ReadLine();

                    Five: //y또는 n 이외를 입력했을 때, 정정하여 돌아올 곳
                        if (b == "Y" || b == "y")
                        {
                            continue; //게임 재시작
                        }
                        if (b == "N" || b == "n")
                        {
                            Console.WriteLine("게임을 종료합니다.");
                            Console.WriteLine("총 {0}번 비기고, {1}번 승리하셨습니다.", same, win);
                            break; // 게임 종료
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("다시 입력해주세요: ");
                                b = Console.ReadLine();
                                if (b == "y" || b == "Y" || b == "n" || b == "N")
                                {
                                    goto Five; //잘못 입력했을 시 정정될 때까지 반복
                                }
                            }
                        }
                    }
                    if (i == 2) // 컴퓨터가 바위를 골랐을 시
                    {
                        win++; //승리 횟수가 올라감
                        Console.WriteLine("컴퓨터의 선택: 바위");
                        Console.WriteLine("승리!");
                        Console.Write("계속 진행하시겠습니까? (Y/N): ");
                        string b = Console.ReadLine();

                    Six: //y또는 n 이외를 입력했을 때, 정정하여 돌아올 곳
                        if (b == "Y" || b == "y")
                        {
                            continue; //게임 재시작
                        }
                        if (b == "N" || b == "n")
                        {
                            Console.WriteLine("게임을 종료합니다.");
                            Console.WriteLine("총 {0}번 비기고, {1}번 승리하셨습니다.", same, win);
                            break; // 게임 종료
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("다시 입력해주세요: ");
                                b = Console.ReadLine();
                                if (b == "y" || b == "Y" || b == "n" || b == "N")
                                {
                                    goto Six; //잘못 입력했을 시 정정될 때까지 반복
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("컴퓨터의 선택: 가위");
                        Console.WriteLine("패배!");
                        Console.WriteLine("게임이 종료되었습니다.");
                        Console.WriteLine("총 {0}번 비기고, {1}번 승리하셨습니다.", same, win);
                        break; //게임 종료
                    }
                }


                else
                {
                    Console.WriteLine("입력을 확인하지 못했습니다.");
                    continue;
                }
            }

            Console.ReadKey();
        }
    }
}
