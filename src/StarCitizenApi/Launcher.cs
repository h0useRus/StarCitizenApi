namespace NSW.StarCitizen.API;
/// <summary>
/// The Star Citizen launcher.
/// </summary>
public class Launcher : RootFolder
{
    private readonly RSI _rsi;
    internal Launcher(RSI rsi, string rootPath) : base(rootPath)
    {
        _rsi = rsi;
    }
    /// <summary>
    /// The default launcher folder name.
    /// </summary>
    public const string DefaultFolderName = "RSI Launcher";
    /// <summary>
    /// The executive file name
    /// </summary>
    public const string ExecutableFileName = "RSI Launcher.exe";
    /// <summary>
    /// The <see cref="ClientMode.LIVE"/> client instance.
    /// </summary>
    public Client LIVE => GetClient(ClientMode.LIVE);
    /// <summary>
    /// The <see cref="ClientMode.PTU"/> client instance.
    /// </summary>
    public Client PTU => GetClient(ClientMode.PTU);
    /// <summary>
    /// The launcher executable file.
    /// </summary>
    public ExecutableFile Executable => new (Path.Combine(RootPath, ExecutableFileName));

    
    /// <summary>
    /// Get Star Citizen client object.
    /// </summary>
    /// <param name="mode">The client mode</param>
    /// <returns>The Star Citizen client object.</returns>
    public Client GetClient(ClientMode mode)
        => new(_rsi, mode);
    /// <summary>
    /// Get all installed Star Citizen clients.
    /// </summary>
    /// <returns>The enumerable of installed Star Citizen clients</returns>
    public IEnumerable<Client> GetInstalledClients()
    {
        var result = new List<Client>();
        if (IsRootPathValid)
        {
            foreach (ClientMode clientMode in Enum.GetValues(typeof(ClientMode)))
            {
                var client = GetClient(clientMode);
                if (client.IsRootPathValid)
                    yield return client;
            }
        }
    }
}
