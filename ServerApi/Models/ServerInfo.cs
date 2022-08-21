namespace ServerApi.Models
{
    public struct ServerInfo
    {
        public string ServerName;
        public string ServerIdentifier;
        public string ServerIp;
        //info about the server --> add under here
        public uint MaxPlayers;
        public uint CurrentNumPlayers;
        public bool IsPrivate;
    }
}