using System.Xml.Linq;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        public int Health;
        public int Energy;
        public string Name;
        public Element weakness;

        internal void TakeDamage(int damage)
        {
            Health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            Energy -= energy;
        }
    }
}
