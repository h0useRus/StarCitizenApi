namespace NSW.StarCitizen.API;
/// <summary>
/// The game launcher.
/// </summary>
public class Launcher : RootFolder
{
    /// <summary>
    /// The default launcher folder name.
    /// </summary>
    public const string DefaultFolderName = "RSI Launcher";
    /// <summary>
    /// Create instance of <see cref="Launcher"/>.
    /// </summary>
    /// <param name="rootPath">The launcher root path.</param>
    public Launcher(string rootPath) : base(rootPath) { }
}
