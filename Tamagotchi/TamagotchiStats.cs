using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        int hunger = 5;
        int boredom = 5;
        List<string> words = new List<string>();

        // här så skapar jag ett start ord så att det inte blir error 
        // om man försöker hälsa på den innan man lärt den ett ord
        bool isAlive;
        Random generator = new Random();
        public string name = "";

        public void Feed()
        {
            // Feed() sänker Hunger med 1-3 snäpp
            int randomFeed = generator.Next(1, 3);
            hunger -= randomFeed;

        }

        bool playedBefore = false;
        public void Hi()
        {
            // Hi() skriver ut ett slumpat ord från words, och anropar ReduceBoredom.
            if (!playedBefore)
            {
                words.Add("Hej");
                playedBefore = true;
            }

            // plockar en random position i listan från plats 0 till den högsta
            int randomWord = generator.Next(0, words.Count);

            string tamagotchiWord = words[randomWord];

            System.Console.WriteLine(tamagotchiWord + ", sa " + name);

            ReduceBoredom();
        }

        public void Teach()
        {
            // Teach(string word) lägger till ett ord i words, och anropar ReduceBoredom.

            System.Console.WriteLine("Vad för ord eller fras ska din Tamagotchi lära sig?");
            string inputWord = Console.ReadLine();

            // lägger till inputen till listan
            words.Add(inputWord);

            ReduceBoredom();
        }

        public void Tick()
        {
            // Tick() ökar hunger och boredom
            boredom++;
            hunger++;
        }

        public void PrintStats()
        {
            // PrintStats() skriver ut nuvarande hunger och bredom, och meddelar också huruvida tamagotchin lever.

            // gör så man inte kan overfeeda eller låta den ha för kul. detta är skolarbete så det ska inte vara alldeles för kul. 
            if (hunger < 0)
            {
                hunger = 0;
            }

            if (boredom < 0)
            {
                boredom = 0;
            }

            // ifall tamagotchin har över 10 på sina stats så får man meddelandet att den dog
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
            // här kollar vi ifall tamagotchin har över 10 på något av sina stats. 
            // isåfall så blir isAlive false och gameIsRunning i program.cs blir också false
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