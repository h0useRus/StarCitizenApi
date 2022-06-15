namespace NSW.StarCitizen.API;
/// <summary>
/// The Star Citizen launcher.
/// </summary>
public class Launcher : RootFolder
{
    private readonly RSI _rsi;
    /// <summary>
    /// The default launcher folder name.
    /// </summary>
    public const string DefaultFolderName = "RSI Launcher";
    /// <summary>
    /// The <see cref="ClientMode.LIVE"/> client instance.
    /// </summary>
    public Client? LIVE => GetClient(ClientMode.LIVE);
    /// <summary>
    /// The <see cref="ClientMode.PTU"/> client instance.
    /// </summary>
    public Client? PTU => GetClient(ClientMode.PTU);
    internal Launcher(RSI rsi, string rootPath) : base(rootPath) 
    {
        _rsi = rsi;
    }
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
    public IEnumerable<Client> GetClients()
    {
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
