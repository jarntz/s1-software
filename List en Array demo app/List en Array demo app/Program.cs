using System;
using System.Collections.Generic;

namespace List_en_Array_demo_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Array");

            // Maakt meerdere string variables aan in 1 keer
            string[] PokemonArray = new string[3];

            // Array
            PokemonArray[0] = "Khydon";
            PokemonArray[1] = "Pikachu";
            PokemonArray[2] = "Slaking";
            // PokemonArray[3] = "Mewtwo";

            // Print namen van Array naar Console
            Console.WriteLine("\nPokemon 1: " + PokemonArray[0]);

            // List aanmaken, Je hoeft van te voren geen aantal aan te geven en is eindeloos.
            List<string> PokemonList = new List<string>();
            PokemonList.Add("Rhydon");
            PokemonList.Add("Pikachu");
            PokemonList.Add("Slaking");
            PokemonList.Add("Mewtwo");

            // Sorteer list alfabetisch
            PokemonList.Sort();

            // Voor elke string variable in PokemonList doe een statement
            foreach (string pokemon in PokemonList)
            {
                Console.WriteLine(pokemon);
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
