using ConsoleCommands.Inputs;
using Oakton;

namespace ConsoleCommands.Commands
{
    [Description("Print somebody's name")]
    public class NameCommand : OaktonCommand<NameInput>
    {
        public NameCommand()
        {
            Usage("Default Color")
                .Arguments(x => x.Name);
            Usage("Print name with specific color")
                .Arguments(x => x.Name, x => x.Color);
        }

        public override bool Execute(NameInput input)
        {
            var text = input.Name;

            if (!string.IsNullOrEmpty(input.TitleFlag))
            {
                text = $"{input.TitleFlag} {text}";
            }

            ConsoleWriter.Write(input.Color, text);

            return true;
        }
    }
}
