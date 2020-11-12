using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>();

            games.Add("Castlevania: Symphony of the Night");
            games.Add("Breath of Fire III");
            games.Add("Legend of Zelda: Twilight Princess");
            games.Add("Legend of Zelda: Breath of the Wild");
            games.Add("Rogue Legacy");
            games.Add("Final Fantasy XIV");
            games.Add("Final Fantasy IX");
            games.Add("Final Fantasy XII");
            games.Add("Dead Cells");
            games.Add("BloodStained: Ritual of the Night");
            games.Add("Moss");
            games.Add("Elder Scrolls V: Skyrim VR");
            games.Add("Rocket League");
            games.Add("Superhot VR");
            games.Add("Crypt of the Necrodancer");
            games.Add("Mages of Mystralia");
            games.Add("Mighty No.9");
            games.Add("Hyper Light Drifter");
            games.Add("Child of Light");
            games.Add("Magicka");
            games.Add("Transistor");
            games.Add("Neverwinter");
            games.Add("TERA");
            games.Add("World of Warcraft");
            games.Add("Abyss Odessy");
            games.Add("Mirror's Edge");
            games.Add("Left 4 Dead 2");
            games.Add("Guacamelee!");
            games.Add("Don't Starve");
            games.Add("Portal 2");
            games.Add("World of Goo");
            games.Add("Aquaria");
            games.Add("SpaceChem");

            
                for (int i = 0; i < games.Count; i++ ) 
                {
                    foreach (string game in games) 
                    { 
                        if (game.Length == i)
                        {
                        Console.WriteLine(game);
                        }
                    }
                }

            Console.WriteLine("\n \n");
            Console.WriteLine("NO ORDER: \n");
            for (int i = 0; i < games.Count; i++)
            {

                Console.WriteLine(games[i]);
                
            }

            List<string> sortedGames = games.OrderBy(x => x.Length).ToList();

            Console.WriteLine("\nORDERED BY NAME LENGTH: \n");
            for (int i = 0; i < sortedGames.Count; i++)
            {

                Console.WriteLine(sortedGames[i]);


            }
        }
    }
}
