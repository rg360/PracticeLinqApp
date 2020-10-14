using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            List<string> gamesList = new List<string>()
            {   
                "1942(1984)",
                "Arkanoid(1986)",
                "Balloon Fight(1984)",
                "Baraduke(1985)",
                "Bomb Jack(1984)",
                "Bubble Bobble(1986)",
                "BurgerTime(1982)",
                "Contra(1987)",
                "Centipede(1981)",
                "Defender(1981)"
            };

            //var game = gamesList.Where(x => x.Contains("84"));

            //order by length

            var game = gamesList.OrderBy(x => x.Length);

            foreach (var y in game)
            {
                Console.WriteLine(y);
            }
        }
    }
}
