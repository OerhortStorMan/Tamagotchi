using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        int hunger = 0;
        int boredom = 0;
        List<string> words = new List<string>();

        bool isAlive;
        Random generator = new Random();
        public string name = "";

        public void Feed()
        {
            // Feed() sänker Hunger
            int randomFeed = generator.Next(0, 3);
            hunger -= randomFeed;

        }   

        public void Hi()
        {
            // Hi() skriver ut ett slumpat ord från words, och anropar ReduceBoredom.
            int randomWord = generator.Next(0, words.Count);

            string tamagotchiTalk = words[randomWord];

            System.Console.WriteLine(tamagotchiTalk + ", sa " + name);

            ReduceBoredom();
        }

        public void Teach()
        {
            // Teach(string word) lägger till ett ord i words, och anropar ReduceBoredom.
            System.Console.WriteLine("Vad för ord ska din Tamagotchi lära sig?");
            string inputWord = Console.ReadLine();
            words.Add(inputWord);
            
            ReduceBoredom();
        }

        public void Tick()
        {
            // Tick() ökar hunger och boredom, och om någon av dem kommer över 10 så blir isAlive false.
            boredom++;
            hunger++;
        }

        public void PrintStats()
        {
            // PrintStats() skriver ut nuvarande hunger och bredom, och meddelar också huruvida tamagotchin lever.

            if (hunger < 0)
            {
                hunger = 0;
            }

            if (boredom < 0)
            {
                boredom = 0;
            }

            if (hunger > 10 || boredom > 10)
            {
                System.Console.WriteLine("Din tamagotchi dog!");
            }
            else
            {
                System.Console.WriteLine("Din tamagotchis stats lyder:");
                System.Console.WriteLine(hunger + " hunger");
                System.Console.WriteLine(boredom + " boredom");
            }

        }

        public bool GetAlive()
        {
            if (hunger > 10 || boredom > 10)
            {
                return isAlive = false;
            }
            else
            {
                return isAlive = true;
            }
        }

        void ReduceBoredom()
        {
            // ReduceBoredom() sänker boredom.
            boredom -= 2;

        }



    }
}
