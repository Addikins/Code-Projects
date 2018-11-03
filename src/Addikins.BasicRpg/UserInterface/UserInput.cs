using System;
using System.Collections.Generic;

namespace Addikins.BasicRpg.UserInterface
{
    internal class UserInput
    {
        public string GetHeroName()
        {
            const int minLength = 3;
            const int maxLength = 15;
            while (true)
            {
                var input = Console.ReadLine();
                if (input.Length >= minLength && input.Length <= maxLength)
                {
                    return input;
                }

                Console.WriteLine($"Hero name must between {minLength} and {maxLength} characters.");
            }
        }

        public HeroClass ChooseHeroClass()
        {
            var heroClasses = HeroClass.AllClasses;

            var i = 0;
            foreach (var heroClass in heroClasses)
            {
                Console.WriteLine($"({++i}) {heroClass.ToString()}");
            }

            while (true)
            {
                var input = Console.ReadLine().ToLower();
                if (int.TryParse(input, out var number))
                {
                    number--;
                    if (number >= 0 && number < heroClasses.Count)
                    {
                        return heroClasses[number];
                    }
                }

                foreach (var heroClass in heroClasses)
                {
                    if (input == heroClass.Name.ToLower())
                    {
                        return heroClass;
                    }
                }

                Console.WriteLine("Invalid input");
            }
        }

        internal string ChooseOption(List<MenuOption> options)
        {
            var i = 0;
            foreach (var option in options)
            {
                Console.WriteLine($"({++i}) {option.ToString()}");
            }

            while (true)
            {
                var input = Console.ReadLine().ToLower();
                if (int.TryParse(input, out var number))
                {
                    number--;
                    if (number >= 0 && number < options.Count)
                    {
                        return options[number].Identifier;
                    }
                }

                foreach (var option in options)
                {
                    if (input == option.Identifier.ToLower())
                    {
                        return option.Identifier;
                    }
                }

                Console.WriteLine("Invalid input");
            }
        }
    }
}
