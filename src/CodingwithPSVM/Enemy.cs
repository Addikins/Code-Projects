using System;

namespace CodingwithPSVM
{
    public class Enemy
    {
        public Enemy(EnemyClass enemyClass)
        {
            EnemyClass = enemyClass;

            MaxHealth = enemyClass.Health;
            Health = enemyClass.Health;
            Defense = enemyClass.Defense;
            Attack = enemyClass.Attack;
        }

        public EnemyClass EnemyClass { get; set; }

        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Attack { get;  set; }
        public int Level { get; set; }
        
        public void Heal(int amount)
        {
            Health += amount;
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }
        public string GetStatus()
        {
            return $@"Status:
{EnemyClass.Name}
Health:{Health}/{MaxHealth}    Defense:{Defense}    Attack:{Attack}";
        }
    }
}