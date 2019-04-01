using System;
using System.Collections.Generic;
using Addikins.BasicRpg.Items;
using Addikins.BasicRpg.UserInterface;

namespace Addikins.BasicRpg
{
    public class Game
    {
        private Random Random = new Random();
        private UserInput UserInput = new UserInput();

        public void Start()
        {
            var hero = CreateHero();
            Console.WriteLine(hero.GetStatus());
            Console.WriteLine("\n        ----->");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(
                $@"The moon illuminates the dense, tall grass in the plains of your homeland. 
There is a light breeze and the call of an owl in the distance.
                                                ");
            Console.ReadKey();
            Console.WriteLine(
                $@"You are a {hero.HeroClass.Name} living in a world of many wonders, and just as many dangers.
The peace and harmony of your people... Your family and friends knew it well for many years...
                                                ");
            Console.ReadKey();
            Console.WriteLine($@"That tranquility has been broken
                                                ");
            Console.ReadKey();
            Console.WriteLine($@"A lurking danger has scurried it's way into the kingdom, and it has little plans to stay quiet
                                                ");
            Console.ReadKey();
            Console.WriteLine($@"The wind changes direction, the bitter cold air now presses your face. Your 'HorseType', who has safely ferried you home from many battles, is restless
                                                ");
            Console.ReadKey();
            Console.WriteLine($@"A foul stench pierces your senses. Blood has been shed tonight.

                                                ----->");
            Console.ReadKey();
            Console.Clear();
            GameLoop(hero); 
        }

        private void GameLoop(Hero hero)
        {
            var quit = false;
            while (!quit)
            {
                var enemy = new Enemy(EnemyClass.AllClasses[0]);
                Console.WriteLine($"An enemy approaches!\n{enemy.GetStatus()}");

                Fight(hero, enemy);
                Console.WriteLine($"Fight results:\n{hero.GetStatus()}\n{enemy.GetStatus()}");

                Console.WriteLine("Continue?");
                var options = new List<MenuOption>
                {
                    new MenuOption("Continue", "Keep adventuring!"),
                    new MenuOption("Quit", "Exits the current playthrough.")
                };
                var choice = UserInput.ChooseOption(options);

                switch (choice.ToLower())
                {
                    case "continue":
                        Console.WriteLine("Your hero presses on!\n");
                        break;
                    case "quit":
                        Console.WriteLine("Your hero retires from advenutring...");
                        quit = true;
                        break;
                }

            }
        }

        private void Fight(Hero hero, Enemy enemy)
        {
            var options = new List<MenuOption>
            {
                new MenuOption("Attack", $"Use a melee attack against the {enemy.EnemyClass.Name}"),
                new MenuOption("Run", $"Run away from the {enemy.EnemyClass.Name}")
            };

            while (true)
            {
                var choice = UserInput.ChooseOption(options);

                switch (choice.ToLower())
                {
                    case "attack":
                        var damageTaken = enemy.TakeDamage(hero.GetAttack(), ignoreDefense: false);
                        Console.WriteLine($"{hero.Name} dealt {damageTaken} damage to the {enemy.EnemyClass.Name}!");
                        break;
                    case "run":
                        Console.WriteLine("You get away!");
                        return;
                    default:
                        throw new ArgumentOutOfRangeException("That's not... what?\n");
                }

                if (enemy.Health > 0)
                {
                    var damageTaken = hero.TakeDamage(enemy.Attack, ignoreDefense: false);
                    Console.WriteLine($"{enemy.EnemyClass.Name} attacked {hero.Name} for {damageTaken} damage!");
                }

                if (hero.Health <= 0 || enemy.Health <= 0)
                {
                    break;
                }
            }
        }

        private Hero CreateHero()
        {
            Console.WriteLine("What is your name?");
            var name = UserInput.GetHeroName();

            Console.WriteLine("Which class do you want?");
            var heroClass = UserInput.ChooseHeroClass();

            var armor = new Armor("No Armor", 0, "Yer naked", 0, 0);
            var weapon = new Weapon("No Weapon", 0, "Just flail around a bit", 0, 0);

            return new Hero(name, heroClass, armor, weapon);
        }

        private IItem FindLoot()
        {
            var lootChance = Random.Next(4);
            switch (lootChance)
            {
                case 0:
                    return GetLootFrom(Food.AllFood);
                case 1:
                    return GetLootFrom(Potion.AllPots);
                case 2:
                    return GetLootFrom(Weapon.AllWeapons);
                case 3:
                    return GetLootFrom(Armor.AllArmorSets);
                default:
                    return GetLootFrom(Food.AllFood);
            }
        }

        private T GetLootFrom<T>(List<T> items)
        {
            var index = Random.Next(items.Count);
            return items[index];
        }
    }
}
