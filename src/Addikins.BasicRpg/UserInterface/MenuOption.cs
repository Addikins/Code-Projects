using System;

namespace Addikins.BasicRpg.UserInterface
{
    public class MenuOption
    {
        public MenuOption(string actionName, string description)
        {
            ActionName = actionName;
            Description = description;
        }

        public string ActionName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{ActionName} - {Description}";
        }
    }
}
