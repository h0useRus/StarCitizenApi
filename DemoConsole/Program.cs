// See https://aka.ms/new-console-template for more information

using NSW.StarCitizen.API;

Console.Write("Enter Star Citizen root path: ");
var path = Console.ReadLine();
if (string.IsNullOrEmpty(path))
    return;

var rsi = new RSI(path);

Console.WriteLine($"RSI path {rsi.RootPath} is valid {rsi.IsRootPathValid}");

Console.WriteLine($"Launcher path {rsi.Launcher.RootPath} is valid {rsi.Launcher.IsRootPathValid}");
if(rsi.Launcher.Executable.IsFilePathValid)
    Console.WriteLine($"Launcher exe {rsi.Launcher.Executable.FilePath} version {rsi.Launcher.Executable.Version?.ProductVersion}");

foreach (var client in rsi.Launcher.GetInstalledClients())
{
    Console.WriteLine($"Found {client.Mode} client");
    Console.WriteLine($"Path {client.RootPath} is valid {client.IsRootPathValid}");
    Console.WriteLine($"Exe {client.Executable.FilePath} version {client.Executable.Version?.ProductVersion}");
}

Console.ReadLine();
