
using GuidGenerator;
using Spectre.Console.Cli;

var app = new CommandApp<GenerateGuidsCommand>();
app.Run(args);
