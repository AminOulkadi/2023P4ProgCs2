using System;
using System.IO;

class Program
{
    static void Main()
    {
        DirectoryInfo dir = new DirectoryInfo(@"C:\Users\amino\OneDrive\Documenten\Ma (school)\bewijzenmap\1.4\progM4\2023P4ProgCs2");
        FileInfo[] files = dir.GetFiles();

        Console.WriteLine("Bestanden:");
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine(files[i].Name);
        }

        DirectoryInfo[] directories = dir.GetDirectories();

        Console.WriteLine("Directories:");
        for (int i = 0; i < directories.Length; i++)
        {
            Console.WriteLine(directories[i].Name);
        }
    }
}
