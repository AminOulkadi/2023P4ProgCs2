using ConsoleMonGame;
using System;
using System.IO;

internal class ConsoleMonFactory
{
    internal void Load(string datafile)
    {
        string[] lines = File.ReadAllLines(datafile);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
            string[] typeSplit = line.Split('|');
            string[] consoleMonData = typeSplit[0].Split(",");

            ConsoleMon dataMon = new ConsoleMon();
            dataMon.Name = consoleMonData[0];
            dataMon.Energy = consoleMonData.Length;
            dataMon.Health = consoleMonData.Length;

            Console.WriteLine(dataMon.Name);
            Console.WriteLine(dataMon.Energy);
            Console.WriteLine(dataMon.Health);
        }
    }
}
