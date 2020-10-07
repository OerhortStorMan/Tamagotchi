using System;
using System.Threading;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Du kör nu Tamagotchi game");

            Tamagotchi t1 = new Tamagotchi();
            System.Console.WriteLine("Vad vill du döpa din Tamagotchi till?");
            t1.name = Console.ReadLine(); 

            System.Console.WriteLine("Din tamagotchi heter nu " + t1.name);
            Thread.Sleep(2000);            

            bool gameIsRunning = true;
            while (gameIsRunning)
            {
                Console.Clear();
                t1.PrintStats();
                System.Console.WriteLine();

                t1.GetAlive();
                if (t1.GetAlive() == false)
                {
                    gameIsRunning = false;
                }
                else
                {
                    bool correctInput = false;
                    while (!correctInput)
                    {
                        System.Console.WriteLine("Vad vill du att din tamagotchi ska göra?:");
                    System.Console.WriteLine(@"
    [A] Lära den ett nytt ord
    [B] Hälsa på den
    [C] Mata den
    [D] Göra ingenting        
                    ");
                    string input = Console.ReadLine();
                    input = input.ToUpper(); 

                        if (input == "A")
                        {
                            t1.Teach();
                            correctInput = true;
                        } 
                        else if (input == "B")
                        {
                            t1.Hi();
                            Thread.Sleep(1750);
                            correctInput = true;
                        }
                        else if (input == "C")
                        {
                            t1.Feed();
                            System.Console.WriteLine("Du matade din tamagotchi");
                            correctInput = true;
                        }
                        else if (input == "D")
                        {
                            correctInput = true;
                        }
                        else
                        {
                            Console.Clear();
                            System.Console.WriteLine("\n Vänligen skriv en riktig input");
                        }
                    }
                                      

                    t1.Tick();
                }
            }

            System.Console.WriteLine("GAME OVER");
            Console.ReadLine();

        }
    }
}
