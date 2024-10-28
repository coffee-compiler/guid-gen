using System.ComponentModel;
using Spectre.Console;
using Spectre.Console.Cli;
using Spectre.Console.Rendering;

namespace GuidGenerator
{
    internal sealed class GenerateGuidsCommand : Command<GenerateGuidsCommand.Settings>
    {
        public sealed class Settings : CommandSettings
        {
            [CommandArgument(0, "<amount>")]
            [Description("The number of GUIDs to generate.")]
            public uint Amount { get; set; }

            [CommandOption("--table")]
            [Description("Whether to display a table.")]
            public bool RenderTable { get; set; }

            [CommandOption("--v7")]
            [Description("Whether to generate v7 GUIDs.")]
            public bool UseVersion7 { get; set; }

            public override ValidationResult Validate()
            {
                return Amount < 1
                    ? ValidationResult.Error("Enter a number higher than 0.")
                    : ValidationResult.Success();
            }
        }

        public override int Execute(CommandContext context, Settings settings)
        {
            IRenderable renderObj = settings.RenderTable
                ? CreateTable(settings)
                : CreateRows(settings);

            AnsiConsole.Write(renderObj);

            return 0;
        }

        private Rows CreateRows(Settings settings)
        {
            var guidEntries = new List<Text>();

            for (var i = 0; i < settings.Amount; i++)
            {
                var guid = settings.UseVersion7
                    ? Guid.CreateVersion7()
                    : Guid.NewGuid();

                guidEntries.Add(new Text(guid.ToString()));
            }

            return new Rows(guidEntries);
        }

        private Table CreateTable(Settings settings)
        {
            var table = new Table();
            table.Border = TableBorder.Minimal;
            table.BorderStyle = new Style(Color.Red);
            table.AddColumn("Index", (c) => c.Alignment = Justify.Center);
            table.AddColumn("GUID", (c) => c.Alignment = Justify.Center);

            for (var i = 0; i < settings.Amount; i++)
            {
                var guid = settings.UseVersion7
                    ? Guid.CreateVersion7()
                    : Guid.NewGuid();

                table.AddRow(i.ToString(), guid.ToString());
            }

            return table;
        }
    }
}
