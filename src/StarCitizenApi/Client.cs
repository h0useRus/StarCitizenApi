namespace NSW.StarCitizen.API;
/// <summary>
/// The Star Citizen client.
/// </summary>
public class Client : RootFolder
{
    private readonly StarCitizenAPI _api;
    /// <summary>
    /// The binary folder name.
    /// </summary>
    public const string BinFolderName = "bin64";
    /// <summary>
    /// The clinet data folder name.
    /// </summary>
    public const string DataFolderName = "data";
    /// <summary>
    /// The user data folder name.
    /// </summary>
    public const string UserFolderName = "user";
    /// <summary>
    /// The client mode.
    /// </summary>
    public ClientMode Mode { get; init; }   

    internal Client(StarCitizenAPI api, ClientMode mode) : base(Path.Combine(api.RootPath, mode.ToString()))
    {
        _api = api;
        Mode = mode;
    }
}
