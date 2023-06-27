namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        public int Health;
        public int Energy;
        public string Name;

      

        internal void TakeDamage(int damage)
        {
            Health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.Energy -= energy;
        }
    }
}
