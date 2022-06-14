namespace NSW.StarCitizen.API;

public class StarCitizenAPI
{
    public string LibraryPath { get; init; }    

    public Launcher Launcher { get; init; }  

    public StarCitizenAPI(string libraryPath)
    {
        if(!Directory.Exists(libraryPath))
            throw new ArgumentException("Incorrect folder name", nameof(libraryPath));

        LibraryPath = libraryPath;
        Launcher = GetLauncher();
    }

    public Launcher GetLauncher(string? launcherFolder = null)
    {
        return new Launcher(Path.Combine(LibraryPath, launcherFolder ?? Launcher.DefaultFolderName));
    }
}
