namespace ConsoleMonGame
{
    public class Skill
    {
        public int damage;
        public int energyCost;
        public Element element;

        internal void UseOn(ConsoleMon targetMon, ConsoleMon casterMon)
        {
            targetMon.TakeDamage(damage);

            if (targetMon.Weakness == element)
            {
                int reducedDamage = damage / 2;
                targetMon.TakeDamage(reducedDamage);
            }

            casterMon.DepleteEnergy(energyCost);
        }
    }
}
