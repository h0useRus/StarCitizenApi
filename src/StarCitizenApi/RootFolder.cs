namespace NSW.StarCitizen.API;
/// <summary>
/// Base class for Star Citizen folders
/// </summary>
public abstract class RootFolder
{
    /// <summary>
    /// The root folder path.
    /// </summary>
    public string RootPath { get; init; }
    /// <summary>
    /// Check that <see cref="RootPath"/> is actual.
    /// </summary>
    public bool IsRootPathValid => Directory.Exists(RootPath);
    /// <summary>
    /// Base constructor
    /// </summary>
    /// <param name="rootPath">The root folder path</param>
    protected RootFolder(string rootPath)
    {
        RootPath = rootPath;
    }
}
