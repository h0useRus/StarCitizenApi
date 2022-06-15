namespace NSW.StarCitizen.API;
/// <summary>
/// Star Citizen API is the simple tool to access various local client APIs.
/// </summary>
public class StarCitizenAPI : RootFolder
{
    /// <summary>
    /// The game launcher.
    /// </summary>
    public Launcher Launcher { get; init; }
    /// <summary>
    /// Create instance of <see cref="StarCitizenAPI"/>.
    /// </summary>
    /// <param name="libraryPath">The root library path.</param>
    public StarCitizenAPI(string libraryPath) : base(libraryPath)
    {
        Launcher = GetLauncher();
    }
    /// <summary>
    /// Get game launcher object.
    /// </summary>
    /// <param name="launcherFolder">Otional full folder path. If it is not defined, current <see cref="RootFolder"/> and <see cref="Launcher.DefaultFolderName"/> will used for path generation.</param>
    /// <returns>The launcher object</returns>
    public Launcher GetLauncher(string? launcherFolderPath = null)
        => new(Path.Combine(RootPath, launcherFolderPath ?? Launcher.DefaultFolderName));
    

    public Client GetClient(ClientMode mode)
        => new(RootPath, mode);
    
}
