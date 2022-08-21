using System;
using System.Collections.Generic;
using System.Linq;
using Grapevine;
using ServerApi.Models;

namespace ServerApi.Database
{
    public class Database
    {
        private Dictionary<string, ServerInfo> Servers;

        private Random _random;
        
        public Database()
        {
            Servers = new Dictionary<string, ServerInfo>();
            _random = new Random();
        }

        public bool AddServer(RequestInfo info)
        {
            foreach (var server in Servers)
            {
                if (server.Value.ServerIp == info.ServerIp)
                {
                    return false;
                }
            }

            string code = _random.Next(1000, 10000).ToString();
            Servers.Add(code, new ServerInfo()
            {
                ServerName = info.ServerName,
                ServerIp = info.ServerIp,
                ServerIdentifier = code,
                MaxPlayers = info.MaxPlayers,
                CurrentNumPlayers = info.CurrentNumPlayers,
                IsPrivate = info.IsPrivate
            });
            return true;
        }

        public bool RemoveServer(string id)
        {
            if (Servers.ContainsKey(id))
            {
                Servers.Remove(id);
                return true;
            }
            return false;
        }

        public bool UpdateServer(ServerInfo newInfo)
        {
            if (Servers.ContainsKey(newInfo.ServerIdentifier))
            {
                Servers[newInfo.ServerIdentifier] = newInfo;
                return true;
            }

            return false;
        }

        public IEnumerable<ServerInfo> GetAllServers()
        {
            foreach (var server in Servers)
            {
                if (!server.Value.IsPrivate)
                {
                    yield return server.Value;
                }
            }
        }

        public string GetServerIp(string id)
        {
            if (Servers.ContainsKey(id))
            {
                return Servers[id].ServerIp;
            }

            return null;
        }
    }
}