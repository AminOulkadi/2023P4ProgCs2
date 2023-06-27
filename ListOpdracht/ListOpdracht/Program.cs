using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Eerste lijst maken
        List<string> birds = new List<string> { "uil", "kraai", "hond", "papegaai" };

        // Tweede lijst maken
        List<string> birds2 = new List<string> { "meeuw", "duif" };

        // Lijsten combineren
        birds.AddRange(birds2);

        // "hond" uit birds verwijderen
        birds.Remove("hond");

        // De inhoud van de gecombineerde lijst afdrukken
        foreach (string bird in birds)
        {
            Console.WriteLine(bird);
        }

        Console.ReadLine();
    }
}
