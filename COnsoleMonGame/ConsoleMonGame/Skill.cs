namespace ConsoleMonGame
{
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
}
