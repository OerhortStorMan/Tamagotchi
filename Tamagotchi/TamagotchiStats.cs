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
            hunger -= 3;

        }   

        public void Hi()
        {
            // Hi() skriver ut ett slumpat ord från words, och anropar ReduceBoredom.
            ReduceBoredom();
        }

        public void Teach()
        {
            // Teach(string word) lägger till ett ord i words, och anropar ReduceBoredom.
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
            if (hunger > 10 || boredom > 10)
            {
                System.Console.WriteLine("Din tamagotchi är död");
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
