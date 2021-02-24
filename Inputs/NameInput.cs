using System;
using Oakton;

namespace ConsoleCommands.Inputs
{
    public class NameInput
    {
        [Description("The name to be printed to the console output")]
        public string Name { get; set; }

        [Description("The color of the text. Default is black")]
        public ConsoleColor Color { get; set; } = ConsoleColor.Black;

        [Description("Optional title preceeding the name")]
        public string TitleFlag { get; set; }
    }
}
