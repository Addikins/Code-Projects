using System;

namespace Addikins.BasicRpg
{
    public abstract class Fighter
    {
        public int Health { get; set; }

        public abstract void Heal(int amount);

        public void TakeDamage(int amount, bool ignoreDefense)
        {
            if (!ignoreDefense)
            {
                Health -= amount - GetDefense();
            }
            else
            {
                Health -= amount;
            }
        }

        public abstract int GetDefense();
    }
}
