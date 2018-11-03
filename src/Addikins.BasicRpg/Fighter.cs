using System;

namespace Addikins.BasicRpg
{
    public abstract class Fighter
    {
        public int Health { get; set; }

        public abstract void Heal(int amount);

        public int TakeDamage(int amount, bool ignoreDefense)
        {
            int actualDamage = CalculateDamage(amount, ignoreDefense);
            Health -= actualDamage;
            return actualDamage;
        }

        private int CalculateDamage(int amount, bool ignoreDefense)
        {
            int diff;
            if (!ignoreDefense)
            {
                diff = amount - GetDefense();
            }
            else
            {
                diff = amount;
            }
            return Math.Max(diff, 0);
        }

        public abstract int GetDefense();
    }
}
