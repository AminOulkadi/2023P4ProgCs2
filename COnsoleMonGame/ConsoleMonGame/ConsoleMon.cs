namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        int health;
        int energy;
        string name;

        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}
