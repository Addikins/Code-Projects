using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG_Code
{
    public class Hero
    {
        public int Health { get; set; }
        public int Magic { get; set; }
        public int Armor { get; set; }
        public int Attack { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
    }
    public class Enemy
    {
        public int Health { get; set; }
        public int Magic { get; set; }
        public int Armor { get; set; }
        public int Attack { get; set; }
        public int Exp { get; set; }
    }
    public class GetMethods
    {
        public static string GetYesNo()
        {
            String receivedResponse = Console.ReadLine();
            if (string.Equals(receivedResponse, "yes", StringComparison.CurrentCultureIgnoreCase) || string.Equals(receivedResponse, "y", StringComparison.CurrentCultureIgnoreCase))
            {
                return "y";
            }
            else if (string.Equals(receivedResponse, "no", StringComparison.CurrentCultureIgnoreCase) || string.Equals(receivedResponse, "n", StringComparison.CurrentCultureIgnoreCase))
            {
                return "n";
            }
            else
            {
                Console.WriteLine("I don't understand, please tell me yes or no.");
                return "error";
            }
        }
        public static int GetNumber()
        {
            bool correctInput = true;
            int returnedNumber;
            do
            {
                string receivedNumber = Console.ReadLine();
                correctInput = int.TryParse(receivedNumber, out returnedNumber);
                if (!correctInput)
                {
                    Console.WriteLine("Incorrect Input");
                }
            } while (!correctInput);
            return returnedNumber;
        }
        public static int GetHeroClass()
        {
            String receivedResponse = Console.ReadLine();
            Console.Clear();
            if (string.Equals(receivedResponse, "Paladin", StringComparison.CurrentCultureIgnoreCase) || string.Equals(receivedResponse, "1", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("You chose the Paladin!");
                return 1;
            }
            else if (string.Equals(receivedResponse, "Warrior", StringComparison.CurrentCultureIgnoreCase) || string.Equals(receivedResponse, "2", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("You chose the Warrior!");
                return 2;
            }
            else if (string.Equals(receivedResponse, "Thief", StringComparison.CurrentCultureIgnoreCase) || string.Equals(receivedResponse, "3", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("You chose the Thief!");
                return 3;
            }
            else if (string.Equals(receivedResponse, "Knight", StringComparison.CurrentCultureIgnoreCase) || string.Equals(receivedResponse, "4", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("You chose the Knight!");
                return 4;
            }
            else if (string.Equals(receivedResponse, "Sorcerer", StringComparison.CurrentCultureIgnoreCase) || string.Equals(receivedResponse, "5", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("You chose the Sorcerer!");
                return 5;
            }
            else
            {
                Console.WriteLine("Incorrect input, please choose a class!");
                return 6;
            }
        }
    }
    public class Game //Main Game Mode
    {
        string hname = "NA"; //Hero's name
        string Classname = "NA"; //Hero's adventure class
        int StartingAttack = 0; //Constant starting attack of the hero
        int StartingArmor = 0; //Constant starting armor of the hero
        int StartingHP = 0; //Constant starting HP of the hero
        int StartingMP = 0; //Constant starting MP of the hero
        int heroAttackChance; //Chance of hero attack connecting
        int enemyAttackChance; //Chance of enemy attack connecting
        Random random = new Random(); //Random int for chance events
        string turnChoice; //The user input for choosing the turn action
        int heroclass; //Int that assigns the hero's adventure class
        string enemyName; //Current Enemy
        bool RunChance; // Hero escape bool
        int RunSuccess; //Decides if the hero escapes
        bool back = false; //Option for user to go back in menu screen
        int Levelup; //Alerts the user if they level up!
        int generateNumber;
        int generateEvent;
        int[] inventoryValue = new int[4];
        string[] inventoryString = new string[4];
        int itemValue = 0;
        int healingpot;
        bool PotChoice = false;
        string itemType = "NA";
        string itemName = "NA";
        string PotMinor = "Minor Healing Potion";
        string PotMeduim = "Meduim Healing Potion";
        string PotMajor = "Major Healing Potion";
        string PotSuper = "Super Healing Potion";
        int healingNumber;
        string inventoryChoice;
        int inventorySlotFull = 0;
        string inventorySpace = null;
        bool InputSuccess = false;
        bool userChoice = false;
        Hero hero = new Hero(); //Main field of the Hero Class
        Enemy enemy = new Enemy(); //Main field of the Enemy Class
        public int HeroClass() // Sets the name & class the hero chooses
        {
            Console.WriteLine("Hello, let's begin an adventure!\nFirst off, choose a name for your hero!");
            do
            {
                hname = Console.ReadLine();
                int nameLength = hname.Length;
                if (nameLength > 25)
                {
                    Console.WriteLine("Your hero name must be 25 characters or less!");
                }
                else if (nameLength < 3)
                {
                    Console.WriteLine("Your hero name must be 3 characters or more!");
                }
                else
                {
                    Console.WriteLine("\nGreat! Now, choose a class for " + hname + "!");
                    InputSuccess = true;
                }
            } while (!InputSuccess);
            do
            {
                Console.WriteLine("\n (1) The Holy Paladin\n (500)HP   (200)MP   (25)Armor   (20)Attack\n\n (2) The Savage Warrior\n (400)HP   (0)MP   (15)Armor   (30)Attack\n\n" +
                    " (3) The Cunning Thief\n (250)HP   (200)MP   (5)Armor   (40)Attack\n\n (4) The Valiant Knight\n (300)HP   (100)MP   (10)Armor   (35)Attack\n\n " +
                    "(5) The Powerful Sorcerer\n (250)HP   (600)MP   (0)Armor   (10)Attack\n");
                heroclass = GetMethods.GetHeroClass();
            } while (heroclass == 6);
            return heroclass; //returns the case # from 1-5
        }
        public string StartTurn()
        {
            hero.Level = 1;
            HeroClass(); //runs the HeroClass method
            switch (heroclass) //Sets the basic specs for the Hero class
            {
                case 1:
                    Classname = "Paladin";
                    hero.Health = 500;
                    hero.Armor = 25;
                    hero.Attack = 20;
                    hero.Magic = 200;
                    StartingMP = hero.Magic;
                    StartingAttack = hero.Attack;
                    StartingArmor = hero.Armor;
                    StartingHP = hero.Health;
                    break;
                case 2:
                    Classname = "Warrior";
                    hero.Health = 400;
                    hero.Armor = 15;
                    hero.Attack = 30;
                    hero.Magic = 0;
                    StartingMP = hero.Magic;
                    StartingAttack = hero.Attack;
                    StartingArmor = hero.Armor;
                    StartingHP = hero.Health;
                    break;
                case 3:
                    Classname = "Thief";
                    hero.Health = 250;
                    hero.Armor = 5;
                    hero.Attack = 40;
                    hero.Magic = 200;
                    StartingMP = hero.Magic;
                    StartingAttack = hero.Attack;
                    StartingArmor = hero.Armor;
                    StartingHP = hero.Health;
                    break;
                case 4:
                    Classname = "Knight";
                    hero.Health = 300;
                    hero.Armor = 10;
                    hero.Attack = 35;
                    hero.Magic = 100;
                    StartingMP = hero.Magic;
                    StartingAttack = hero.Attack;
                    StartingArmor = hero.Armor;
                    StartingHP = hero.Health;
                    break;
                case 5:
                    Classname = "Sorcerer";
                    hero.Health = 250;
                    hero.Armor = 0;
                    hero.Attack = 10;
                    hero.Magic = 600;
                    StartingMP = hero.Magic;
                    StartingAttack = hero.Attack;
                    StartingArmor = hero.Armor;
                    StartingHP = hero.Health;
                    break;
            }
            Console.WriteLine(String.Format("{0} will start as a Level({1}) {2} with:\n ({3})HP   ({4})MP   ({5})Armor   ({6})Attack\n",
                hname, hero.Level, Classname, hero.Health, hero.Magic, hero.Armor, hero.Attack));
            while (hero.Health > 0)
            {
                do
                {
                    Console.WriteLine(String.Format("\n{0} explores the area...\n (1) Search nearby Ruins\n (2) Check Inventory\n (3) Check Status\n", hname));
                    turnChoice = Console.ReadLine();
                    Console.Clear();
                    if (turnChoice == "1" || turnChoice == "2" || turnChoice == "3")
                    {
                        userChoice = true;
                        switch (turnChoice)
                        {
                            case "1":
                                break;
                            case "2":
                                Console.WriteLine(hname + " reaches into their bag....\n");
                                inventorySpace = InvoSizeCheck();
                                if (inventorySpace == "Empty")
                                {
                                    Console.WriteLine(String.Format("But {0}'s inventory is empty!", hname));
                                }
                                else
                                {
                                    hero.Health = ViewInventory();
                                }
                                userChoice = false;
                                break;
                            case "3":
                                CheckStatus();
                                userChoice = false;
                                break;
                        }
                    }
                    else { userChoice = false; Console.WriteLine(String.Format("{0} is not an option! Please choose:\n", turnChoice)); }
                } while (userChoice == false);
                Levelup = hero.Level;
                generateNumber = random.Next(0, 100);
                generateEvent = generateNumber > 84 ? 3 : generateNumber > 25 ? 0 : generateNumber > 15 ? 1 : 2;
                switch (generateEvent)
                {
                    case 0:
                        hero.Health = Fight();
                        break;
                    case 1:
                        hero.Armor = ArmorTreasure();
                        break;
                    case 2:
                        hero.Attack = WeaponTreasure();
                        break;
                    case 3:
                        hero.Health = HealEvent();
                        break;
                    default:
                        Console.Write("Turn Error");
                        break;
                }
                hero.Level = hero.Exp < 300 ? 0 : hero.Exp < 600 ? 1 : hero.Exp < 1000 ? 2 : hero.Exp < 1500 ? 3 : hero.Exp < 2000 ? 4 : hero.Exp < 2500 ? 5 : 6;
                switch (hero.Level)
                {
                    case 0:
                        hero.Level = hero.Exp / 100 + 1;
                        break;
                    case 1:
                        hero.Level = hero.Exp / 120 + 1;
                        break;
                    case 2:
                        hero.Level = hero.Exp / 150 + 1;
                        break;
                    case 3:
                        hero.Level = hero.Exp / 200 + 1;
                        break;
                    case 4:
                        hero.Level = hero.Exp / 220 + 1;
                        break;
                    case 5:
                        hero.Level = hero.Exp / 250 + 1;
                        break;
                    case 6:
                        hero.Level = hero.Exp / 300 + 1;
                        break;
                }
                if (hero.Health > 0)
                {
                    if (hero.Level > Levelup && hero.Level > 1) { Console.WriteLine("\n" + hname + " leveled up!!!\n"); }
                    CheckStatus();
                }
            }
            return (hname + " the Level " + hero.Level + " " + Classname + " died!\n");
        }
        public int GetTurnChoice() //Returns the user input for mid-battle selection
        {
            do
            {
                Console.WriteLine(String.Format("\n{0} VS {1}\n (1) Attack\n (2) Magic & Skills\n (3) Items\n (4) Hero Status\n (5) Run", hname, enemyName));
                turnChoice = Console.ReadLine();
                Console.WriteLine();
                if (turnChoice == "1" || turnChoice == "2" || turnChoice == "3" || turnChoice == "4" || turnChoice == "5")
                {
                    userChoice = true;
                    switch (turnChoice)
                    {
                        case "1":
                            Console.Clear();
                            hero.Health = Attack();
                            break;
                        case "2":
                            Console.Clear();
                            MagicSkills();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine(hname + " reaches into their bag....\n");
                            inventorySpace = InvoSizeCheck();
                            if (inventorySpace == "Empty")
                            {
                                Console.WriteLine(String.Format("But {0}'s inventory is empty!", hname));
                            }
                            else
                            {
                                hero.Health = ViewInventory();
                            }
                            break;
                        case "4":
                            Console.Clear();
                            CheckStatus();
                            break;
                        case "5":
                            Console.Clear();
                            Run();
                            break;
                    }
                }
                else { Console.WriteLine("Incorrect input\n Select from (1) (2) (3) (4) (5)"); userChoice = false; }
            } while (userChoice == false);
            return hero.Health;
        }
        public int Attack()
        {
            if (heroAttackChance < 90 && enemy.Health > 0)
            {
                enemy.Health += enemy.Armor - hero.Attack;
                Console.WriteLine(String.Format("{0} dealt {1} damage to the {2}", hname, hero.Attack - enemy.Armor, enemyName));
            }
            else { Console.WriteLine(hname + " missed!"); }
            if (enemyAttackChance < 90 && enemy.Health > 0)
            {
                hero.Health += hero.Armor - enemy.Attack;
                Console.WriteLine(String.Format("The {0} dealt {1} damage to {2}", enemyName, enemy.Attack - hero.Armor, hname));
            }
            else if (enemy.Health > 0) { Console.WriteLine("The " + enemyName + " missed!"); }

            if (enemy.Health <= 0) { Console.WriteLine(String.Format("{0} vanquished the {1}!\n +{2}Exp!", hname, enemyName, enemy.Exp)); }
            return hero.Health; //returns result of the battle including hp of hero
        }
        public int MagicSkills()
        {
            do
            {
                Console.WriteLine("Magic & Skills:\n (1) Examine Enemy\n (2) First Aid\n (3) Dazzle!!!\n (4) Back");
                turnChoice = Console.ReadLine();
                Console.WriteLine();
                if (turnChoice == "1" || turnChoice == "2" || turnChoice == "3" || turnChoice == "4")
                {
                    userChoice = true;
                    switch (turnChoice)
                    {
                        case "1":
                            Console.WriteLine(String.Format("{0} peers into the {1}'s soul...\n{1}:\n ({2})HP ({3})Armor ({4})Attack\n", hname, enemyName, enemy.Health, enemy.Armor, enemy.Attack));
                            break;
                        case "2":
                            Console.WriteLine(hname + " attempts to bandage their wounds mid-combat...");
                            int healChance = random.Next(1, 10);
                            int addHP;
                            if (healChance < 4) { addHP = 0; Console.WriteLine("But they were busy getting smacked around!"); }
                            else if (healChance < 7) { addHP = 50; hero.Health += addHP; Console.WriteLine(String.Format("And they managed to get a couple bandaids in place.\n +{0}HP!", addHP)); CheckStatus(); Console.WriteLine(); }
                            else if (healChance < 10) { addHP = 100; hero.Health += addHP; Console.WriteLine(String.Format("And they patched themselves up nicely!\n +{0}HP!", addHP)); CheckStatus(); Console.WriteLine(); }
                            else if (healChance == 10) { addHP = 200; hero.Health += addHP; Console.WriteLine(String.Format("Dr.{0} was successfully able to add 5min to their lifespan!\n +{1}HP!", hname, addHP)); CheckStatus(); Console.WriteLine(); }
                            break;
                        case "3":
                            Console.WriteLine(String.Format("{0} throws glitter at the {1}!\nIt's not very effective...\nBut some gets in the {1}'s face!\n", hname, enemyName));
                            enemyAttackChance = random.Next(80, 120);
                            break;
                        case "4":
                            break;
                    }
                }
                else { Console.WriteLine(String.Format("{0} is not an option! Please choose:/n", turnChoice)); userChoice = false; }
            } while (userChoice == false);
                if (enemyAttackChance < 90 && enemy.Health > 0)
                {
                    hero.Health += hero.Armor - enemy.Attack;
                    Console.WriteLine(String.Format("The {0} dealt {1} damage to {2}", enemyName, enemy.Attack - hero.Armor, hname));
                }
                else if (enemy.Health > 0)
                {
                    Console.WriteLine("The " + enemyName + " missed!");
                    if (turnChoice == "3")
                    {
                        Console.WriteLine(String.Format("{0} Seizes the opportunity and attacks the {1}!\n", hname, enemyName));
                        if (heroAttackChance < 85 && enemy.Health > 0)
                        {
                            enemy.Health += enemy.Armor - hero.Attack;
                            Console.WriteLine(String.Format("{0} dealt {1} damage to the {2}", hname, hero.Attack - enemy.Armor, enemyName));
                        }
                        else { Console.WriteLine(hname + " missed!"); }
                    }
                }
            return hero.Health;
        }
        public string InvoSizeCheck()
        {
            if (inventoryString[0] == null && inventoryString[1] == null && inventoryString[2] == null && inventoryString[3] == null)
            {
                return inventorySpace = "Empty";
            }
            else if (inventoryString[0] == null || inventoryString[1] == null || inventoryString[2] == null || inventoryString[3] == null)
            {
                return inventorySpace = "!Full";
            }
            else
            {
                return inventorySpace = "Full";
            }
        }
        public string addToInventory()
        {
            inventorySpace = InvoSizeCheck();
            if (inventorySpace == "Full")
            {
                Console.WriteLine(String.Format("{0}'s inventory is too full to fit a {1}!", hname, itemName));
                return inventorySpace;
            }
            else
            {
                    Console.WriteLine(String.Format("The {0} was successfully added to {1}'s inventory!", itemName, hname));
                inventorySlotFull = inventoryString[0] == null ? 1 : inventoryString[1] == null ? 2 : inventoryString[2] == null ? 3 : inventoryString[3] == null ? 4 : 5;
                switch (inventorySlotFull)
                {
                    case 1:
                        inventoryValue[0] = itemValue;
                        inventoryString[0] = itemName;
                        break;
                    case 2:
                        inventoryValue[1] = itemValue;
                        inventoryString[1] = itemName;
                        break;
                    case 3:
                        inventoryValue[2] = itemValue;
                        inventoryString[2] = itemName;
                        break;
                    case 4:
                        inventoryValue[3] = itemValue;
                        inventoryString[3] = itemName;
                        break;
                    case 5:
                        Console.WriteLine("Error adding item");
                        break;
                }
                return inventorySpace;
            }
        }
        public bool Potmethod()
        {
            Console.WriteLine(String.Format("(1) Use {0}\n(2) Store {0}", itemName));
            inventoryChoice = Console.ReadLine();
            if (string.Equals(inventoryChoice, "Use", StringComparison.CurrentCultureIgnoreCase) || string.Equals(inventoryChoice, "1", StringComparison.CurrentCultureIgnoreCase))
            {
                if (StartingHP * hero.Level > hero.Health)
                {
                    Console.WriteLine(String.Format("{1} used the {0}!\n +{2}{3}!", itemName, hname, itemValue, itemType));
                    hero.Health += itemValue;
                    return true;
                }
                else
                { Console.WriteLine(String.Format(hname + " is too full to drink the {0}. +0{1}", itemName, itemType)); }
                return false;
            }
            else if (string.Equals(inventoryChoice, "Store", StringComparison.CurrentCultureIgnoreCase) || string.Equals(inventoryChoice, "2", StringComparison.CurrentCultureIgnoreCase))
            {
                inventorySpace = addToInventory();
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect input!");
                return false;
            }
        }
        public int ViewInventory()
        {
            do
            {
                int itemCount=0;
                foreach (var item in inventoryString)
                {
                    itemCount++;
                    Console.WriteLine(String.Format("({1}) {0}", item,itemCount));
                }
                Console.WriteLine("(5) Back\n");
                turnChoice = Console.ReadLine();
                Console.Clear();
                if (turnChoice == "1" || turnChoice == "2" || turnChoice == "3" || turnChoice == "4" || turnChoice == "5")
                {
                    userChoice = true;
                    switch (turnChoice)
                    {
                        case "1":
                            if (inventoryString[0] == null)
                            {
                                userChoice = false;
                            }
                            else
                            {
                                Console.WriteLine(String.Format("{0} uses the {1}\n+({2}){3}!", hname, inventoryString[0], inventoryValue[0], itemType));
                                hero.Health += inventoryValue[0];
                                inventoryValue[0] = 0;
                                inventoryString[0] = null;
                            }
                            break;
                        case "2":
                            if (inventoryString[1] == null)
                            {
                                userChoice = false;
                            }
                            else
                            {
                                Console.WriteLine(String.Format("{0} uses the {1}\n+({2}){3}!", hname, inventoryString[1], inventoryValue[1], itemType));
                                hero.Health += inventoryValue[1];
                                inventoryValue[1] = 0;
                                inventoryString[1] = null;
                            }
                            break;
                        case "3":
                            if (inventoryString[2] == null)
                            {
                                userChoice = false;
                            }
                            else
                            {
                                Console.WriteLine(String.Format("{0} uses the {1}\n+({2}){3}!", hname, inventoryString[2], inventoryValue[2], itemType));
                                hero.Health += inventoryValue[2];
                                inventoryValue[2] = 0;
                                inventoryString[2] = null;
                            }
                            break;
                        case "4":
                            if (inventoryString[3] == null)
                            {
                                userChoice = false;
                            }
                            else
                            {
                                Console.WriteLine(String.Format("{0} uses the {1}\n+({2}){3}!", hname, inventoryString[3], inventoryValue[3], itemType));
                                hero.Health += inventoryValue[3];
                                inventoryValue[3] = 0;
                                inventoryString[3] = null;
                            }
                            break;
                        case "5":
                            break;
                    }
                    if (userChoice == false) { Console.WriteLine(String.Format("There's nothing in that slot! Please choose:\n", turnChoice)); }
                }
                else { Console.WriteLine(String.Format("{0} is not an option! Please choose:\n", turnChoice)); userChoice = false; }
            } while (userChoice == false);
            return hero.Health;
        }
        public bool Run()
        {
            Console.WriteLine(String.Format("{0} tries to sneak away from the {1}...", hname, enemyName));
            RunSuccess = random.Next(1, 10);
            if (RunSuccess < 5)
            { RunChance = true; Console.WriteLine(String.Format("{0} used a distraction and got away!", hname)); }
            else
            {
                RunChance = false; Console.WriteLine(String.Format("but the {0} got in the way!", enemyName));
                if (enemyAttackChance < 90 && enemy.Health > 0)
                {
                    hero.Health += hero.Armor - enemy.Attack;
                    Console.WriteLine(String.Format("The {0} dealt {1} damage to {2}", enemyName, enemy.Attack - hero.Armor, hname));
                }
                else if (enemy.Health > 0)
                {
                    Console.WriteLine("The " + enemyName + " missed!");
                }
            }
            return RunChance;
        }
        public int ArmorTreasure()
        {
            Dictionary<string, int> armor = new Dictionary<string, int>
            {
                {"a Tattered Cloak", 2},
                {"a Fur Pelt", 4},
                {"a Leather Chestpiece", 6},
                {"an Iron Chestplate", 8},
                {"a Reinforced Iron Chestplate", 10},
                {"a Steel Chestplate", 12},
                {"a Reinforced Steel Chestplate", 14},
                {"an Enchanted Steel Chestplate", 16},
                {"a Mythrill Armorset", 20},
                {"a Unicorn Armorset", 24 },
                {"The Armor of the Heavens", 28 }
            };
            int ArmorNumber = random.Next(0, armor.Count);
            Console.WriteLine(String.Format(hname + " finds {0}...", armor.ElementAt(ArmorNumber).Key,
                armor.ElementAt(ArmorNumber).Value));
            if (armor.ElementAt(ArmorNumber).Value + StartingArmor > hero.Armor)
            {
                hero.Armor += armor.ElementAt(ArmorNumber).Value;
                Console.WriteLine("and decided to equip it!");
            }
            else
            {
                Console.WriteLine("but has better armor...");
            }
            return hero.Armor;
        }
        public int WeaponTreasure()
        {
            Dictionary<string, int> weapon = new Dictionary<string, int>
            {
                {"a Dagger", 10},
                {"a Short Sword", 12},
                {"a Long Sword", 14},
                {"a Mace", 16},
                {"a pair of Twin Daggers",18},
                {"a Broad Sword", 20},
                {"a Battle Axe", 22},
                {"a Heavy Mace", 24},
                {"a Great Sword", 26},
                {"a Mace of Fire", 28},
                {"a Necromancer's Axe", 30},
                {"a Spear of Frost", 32},
                {"an Enchanted Great Sword", 34},
                {"The Sword of Evil's Bane", 50 }
            };
            int WeaponNumber = random.Next(0, weapon.Count);
            Console.WriteLine(String.Format(hname + " finds {0}...", weapon.ElementAt(WeaponNumber).Key,
                weapon.ElementAt(WeaponNumber).Value));
            if (weapon.ElementAt(WeaponNumber).Value + StartingAttack > hero.Attack)
            {
                hero.Attack += weapon.ElementAt(WeaponNumber).Value;
                Console.WriteLine("and decided to equip it!");
            }
            else
            {
                Console.WriteLine("but has a better weapon...");
            }
            return hero.Attack;
        }
        public int HealEvent()
        {
            itemType = "HP";
            healingNumber = hero.Level * 2 + random.Next(0, 100);
            healingpot = healingNumber < 45 ? 1 : healingNumber < 80 ? 2:  healingNumber < 95 ? 3 : 4;
            switch (healingpot)
            {
                case 1:
                    itemName = PotMinor;
                    itemValue = 150;
                    break;
                case 2:
                    itemName = PotMeduim;
                    itemValue = 300;
                    break;
                case 3:
                    itemName = PotMajor;
                    itemValue = 450;
                    break;
                case 4:
                    itemName = PotSuper;
                    itemValue = 600;
                    break;
            }
            Console.WriteLine(String.Format(hname + " finds a {0}", itemName));
            // input if condition for inventory full bool and hp max int
            do { 
            PotChoice = Potmethod();
            } while (!PotChoice);
            return hero.Health;
        }
        public int EnemyEncounter()
        {
            int generateEnemy;
            if (hero.Level < 6)
            {
                generateEnemy = random.Next(0, 100);
                generateEnemy = generateEnemy < 55 ? 0 : generateEnemy < 75 ? 1 : generateEnemy < 95 ? 2 : generateEnemy < 97 ? 3 : 4;
            }
            else if (hero.Level < 13)
            {
                generateEnemy = random.Next(0, 100);
                generateEnemy = generateEnemy < 7 ? 1 : generateEnemy < 14 ? 2 : generateEnemy < 45 ? 3 : generateEnemy < 76 ? 4 : generateEnemy < 96 ? 5 : generateEnemy < 100 ? 5 : 6;
            }
            else
            {
                generateEnemy = random.Next(0, 100);
                generateEnemy = generateEnemy < 5 ? 3 : generateEnemy < 10 ? 4 : generateEnemy < 26 ? 5 : generateEnemy < 51 ? 6 : generateEnemy < 76 ? 7 : 8;
            }
            switch (generateEnemy)
            {
                case 0:
                    enemyName = "Goblin"; enemy.Health = 75; enemy.Armor = 1; enemy.Attack = 25; enemy.Exp = 25;
                    Console.Clear();
                    Console.WriteLine(String.Format("A {0} pops out of the grass!", enemyName));
                    break;
                case 1:
                    enemyName = "Skeleton"; enemy.Health = 100; enemy.Armor = 2; enemy.Attack = 35; enemy.Exp = 50;
                    Console.Clear();
                    Console.WriteLine(String.Format("\nA {0} shambles out of the dark...", enemyName));
                    break;
                case 2:
                    enemyName = "Zombie"; enemy.Health = 300; enemy.Armor = 5; enemy.Attack = 40; enemy.Exp = 75;
                    Console.Clear();
                    Console.WriteLine(String.Format("\nA {0} lurks towards you!", enemyName));
                    break;
                case 3:
                    enemyName = "Orc"; enemy.Health = 400; enemy.Armor = 10; enemy.Attack = 70; enemy.Exp = 150;
                    Console.Clear();
                    Console.WriteLine(String.Format("\nAs {0} walks out of a cave they fall right into an {1} ambush!", hname, enemyName));
                    break;
                case 4:
                    enemyName = "Troll"; enemy.Health = 200; enemy.Armor = 4; enemy.Attack = 60; enemy.Exp = 175;
                    Console.Clear();
                    Console.WriteLine(String.Format("\nA {0} attacks {1} from the treetops!", enemyName, hname));
                    break;
                case 5:
                    enemyName = "Siren"; enemy.Health = 300; enemy.Armor = 5; enemy.Attack = 60; enemy.Exp = 200;
                    Console.Clear();
                    Console.WriteLine(String.Format("\n{0} is lured by the call of a {1}...", hname, enemyName));
                    break;
                case 6:
                    enemyName = "Warlock"; enemy.Health = 250; enemy.Magic = 500; enemy.Armor = 2; enemy.Attack = 100; enemy.Exp = 250;
                    Console.Clear();
                    Console.WriteLine(String.Format("\nFrom the ground a cloud of darkness appears.. Suddenly a {0} emerges!", enemyName));
                    break;
                case 7:
                    enemyName = "Minotaur"; enemy.Health = 600; enemy.Armor = 15; enemy.Attack = 80; enemy.Exp = 350;
                    Console.Clear();
                    Console.WriteLine(String.Format("\nA {0} stampedes toward {1}!", enemyName, hname));
                    break;
                case 8:
                    enemyName = "Gargoyle"; enemy.Health = 550; enemy.Armor = 25; enemy.Attack = 70; enemy.Exp = 400;
                    Console.Clear();
                    Console.WriteLine(String.Format("\nA dark figure crashes down from the sky... A demonic {0} bares its stone mace!", enemyName));
                    break;
            }
            return hero.Health;
        }
        public int Fight()
        {
            hero.Health = EnemyEncounter();
            while (enemy.Health > 0 && hero.Health > 0)
            {
                if (hero.Armor < enemy.Attack)
                {
                    heroAttackChance = random.Next(0, 100); //defines the chance of the hero connecting an attack this turn
                    enemyAttackChance = random.Next(0, 100); //defines the chance of the enemy connecting an attack this turn
                    hero.Health = GetTurnChoice();
                    if (RunChance == true)
                    { break; }
                }
                else
                {
                    enemy.Health = 0;
                    Console.WriteLine(String.Format("{0} easily handled the {1}!\n +{2}Exp!", hname, enemyName, enemy.Exp));
                }
            }
            if (enemy.Health <= 0)
            { hero.Exp += enemy.Exp; }
            return hero.Health;
        }
        public void CheckStatus()
        {
            Console.WriteLine(String.Format("\nCurrent Status\n {0}: Level({1}) {2}\n ({3})HP   ({4})MP   ({5})Armor   ({6})Attack\n", hname, hero.Level, Classname, hero.Health, hero.Magic, hero.Armor, hero.Attack));
        }
        class Program
        {
            static void Main(string[] args)
            {
                string answer;
                bool playAgain = true;
                Game game = new Game();
                do
                {
                    Console.Write(game.StartTurn());
                    do
                    {
                        Console.WriteLine("Would you like to begin a new adventure?\n");
                        answer = GetMethods.GetYesNo();
                        Console.Clear();
                        switch (answer)
                        {
                            case "y":
                                Console.WriteLine("You awaken once more...");
                                playAgain = true;
                                break;
                            case "n":
                                Console.WriteLine("Your hero begins their eternal slumber...");
                                playAgain = false;
                                break;
                        }
                    } while (answer == "error");
                } while (playAgain == true);
            }
        }
    }
}
