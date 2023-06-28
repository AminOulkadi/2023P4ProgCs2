using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string[] content;


        string filePath = "leesdezefile.txt";


        content = File.ReadAllLines(filePath);


        for (int i = 0; i < content.Length; i++)
        {
            Console.WriteLine(content[i]);
        }



        Console.ReadLine();
    }
}