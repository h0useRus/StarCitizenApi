namespace NSW.StarCitizen.API;
/// <summary>
/// The Star Citizen client.
/// </summary>
public class Client : RootFolder
{
    /// <summary>
    /// The binary folder name.
    /// </summary>
    public const string BinFolder = "bin";
    /// <summary>
    /// The clinet data folder name.
    /// </summary>
    public const string DataFolder = "data";
    /// <summary>
    /// The user data folder name.
    /// </summary>
    public const string UserFolder = "user";
    /// <summary>
    /// The client mode.
    /// </summary>
    public ClientMode Mode { get; init; }
    /// <summary>
    /// Create instance of <see cref="Client"/>. 
    /// </summary>
    /// <param name="rootPath">The root Star Citizen folder path.</param>
    /// <param name="mode">The client mode.</param>
    public Client(string rootPath, ClientMode mode) : base(Path.Combine(rootPath, mode.ToString()))
    {
        Mode = mode;
    }
}
