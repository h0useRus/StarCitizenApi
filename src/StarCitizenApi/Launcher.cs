namespace NSW.StarCitizen.API;

public class Launcher
{
    public const string DefaultFolderName = "RSI Launcher";
    public string FolderPath { get; init; }
    public Launcher(string folderPath)
    {
        FolderPath = folderPath;
    }
}
