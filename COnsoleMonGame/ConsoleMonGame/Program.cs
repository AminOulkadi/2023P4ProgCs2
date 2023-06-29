using ConsoleMonGame;

class Program
{
    static void TestFactoryFunctions()
    {
        Console.WriteLine("TestFactoryFunctions");
        ConsoleMonFactory factory = new ConsoleMonFactory();
        factory.Load("monsterdata.txt");
    }
    static void Main(string[] args)
    {
        TestSkillFunctions();
    }

    static void TestSkillFunctions()
    {
        Console.WriteLine("TestSkillFunctions");
        ConsoleMon casterMon = new ConsoleMon();
        ConsoleMon targetMon = new ConsoleMon();
        Skill skill = new Skill()
        {
            damage = 100,
            energyCost = 20,
        };
        skill.UseOn(targetMon, casterMon);

        Console.WriteLine(targetMon.Health == -150);

        Console.WriteLine(casterMon.Energy == -20);
    }
}
