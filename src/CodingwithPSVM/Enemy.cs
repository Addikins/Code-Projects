using System;

namespace CodingwithPSVM
{
    public class Enemy : Fighter
    {
        public Enemy(EnemyClass enemyClass)
        {
            EnemyClass = enemyClass;

            Health = enemyClass.Health;
            Defense = enemyClass.Defense;
            Attack = enemyClass.Attack;
        }

        public EnemyClass EnemyClass { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }

        public override void Heal(int amount)
        {
            Health += amount;
            if (Health > EnemyClass.Health)
            {
                Health = EnemyClass.Health;
            }
        }

        public override void TakeDamage(int attack)
        {
            Health -= attack - Defense;
        }

        public string GetStatus()
        {
            return $@"Status:
{EnemyClass.Name}
Health:{Health}/{EnemyClass.Health}    Defense:{Defense}    Attack:{Attack}";
        }
    }
}
