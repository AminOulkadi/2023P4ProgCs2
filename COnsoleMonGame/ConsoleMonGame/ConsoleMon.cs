namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        int health;
        int energy;
        string name;

        internal class Skill
        {
            internal int damage;
            internal int energyCost;

            internal void UseOn(ConsoleMon target, ConsoleMon caster)
            {
                caster.DepleteEnergy(energyCost);
                target.TakeDamage(damage);
            }
        }


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
