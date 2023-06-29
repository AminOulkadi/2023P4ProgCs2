using System;
using System.IO;

class Program
{
    static void Main()
    {       
        string bestandsnaam = "stringsplit.txt";
        string pad = @"C:\Users\amino\OneDrive\Documenten\Ma (school)\bewijzenmap\1.4\progM4\2023P4ProgCs2\SplitOpdracht\SplitOpdracht";

        string bestandspad = Path.Combine(pad, bestandsnaam);

        try
        {
            string content = File.ReadAllText(bestandspad);

            string[] keyValue = content.Split(':');

            Console.WriteLine("Cijferlijst: " + keyValue[0]);

            string[] cijfersPerVak = keyValue[1].Split(',');

            Console.WriteLine("Cijfers per vak:");
            foreach (string cijfer in cijfersPerVak)
            {
                Console.WriteLine(cijfer);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Het opgegeven bestand kon niet worden gevonden.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Er is een fout opgetreden tijdens het verwerken van het bestand: " + e.Message);
        }

        Console.ReadLine();
    }
}
