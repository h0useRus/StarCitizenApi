using System.Diagnostics;

namespace NSW.StarCitizen.API;

/// <summary>
/// The base class for executable files
/// </summary>
public class ExecutableFile
{
    /// <summary>
    /// The executable file path
    /// </summary>
    public string FilePath { get; init; }
    /// <summary>
    /// Check that <see cref="FilePath"/> is valid executable file path.
    /// </summary>
    public bool IsFilePathValid => File.Exists(FilePath) && Path.HasExtension(FilePath) && Path.GetExtension(FilePath) == ".exe";
    /// <summary>
    /// An executable file version.
    /// </summary>
    public FileVersionInfo? Version => GetFileVersion();

    internal ExecutableFile(string filePath)
    {
        FilePath = filePath;
    }

    private FileVersionInfo? GetFileVersion()
    {
        return IsFilePathValid ? FileVersionInfo.GetVersionInfo(FilePath) : null;
    }

}
