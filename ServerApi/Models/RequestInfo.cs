namespace ServerApi.Models
{
    public struct RequestInfo
    {
        public string ServerName;
        public string ServerIp;
        //info about the server --> add under here
        public uint MaxPlayers;
        public uint CurrentNumPlayers;
        public bool IsPrivate;
    }
}