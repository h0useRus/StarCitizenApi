namespace NSW.StarCitizen.API;
/// <summary>
/// The Star Citizen client.
/// </summary>
public class Client : RootFolder
{
    private readonly RSI _rsi;
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

    internal Client(RSI rsi, ClientMode mode) : base(Path.Combine(rsi.RootPath, mode.ToString()))
    {
        _rsi = rsi;
        Mode = mode;
    }
}
