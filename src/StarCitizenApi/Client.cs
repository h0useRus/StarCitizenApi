namespace NSW.StarCitizen.API;
/// <summary>
/// The Star Citizen client.
/// </summary>
public class Client : RootFolder
{
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
