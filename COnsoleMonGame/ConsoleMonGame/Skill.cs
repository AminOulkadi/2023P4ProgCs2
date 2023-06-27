namespace ConsoleMonGame
{
    internal class Skill
    {
        public int damage;
        public int energyCost;
        public Element element;

        internal void UseOn(ConsoleMon targetMon, ConsoleMon casterMon)
        {
            targetMon.TakeDamage(damage);

            if (targetMon.weakness == element)
            {
                int reducedDamage = damage / 2;
                targetMon.TakeDamage(reducedDamage);
            }

            casterMon.DepleteEnergy(energyCost);
        }
    }
}
