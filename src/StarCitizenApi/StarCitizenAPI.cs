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
    /// Get Star Citizen launcher object.
    /// </summary>
    /// <param name="launcherFolderPath">Otional full folder path. If it is not defined, current <see cref="RootFolder"/> and <see cref="Launcher.DefaultFolderName"/> will used for path generation.</param>
    /// <returns>The Star Citizen launcher object.</returns>
    public Launcher GetLauncher(string? launcherFolderPath = null)
        => new(this, Path.Combine(RootPath, launcherFolderPath ?? Launcher.DefaultFolderName));
}
