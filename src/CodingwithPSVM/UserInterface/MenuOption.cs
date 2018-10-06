using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingwithPSVM.UserInterface
{
    public class MenuOption
    {
        public MenuOption(string identifier, string description)
        {
            Identifier = identifier;
            Description = description;
        }

        public string Identifier { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Identifier} - {Description}";
        }
    }
}
