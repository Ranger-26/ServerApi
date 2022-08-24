using System;
using Grapevine;
using ServerApi.Models;

namespace ServerApi.Core.Extensions
{
    public static class HttpContextExtensions
    {
        public static ServerInfo CreateServerInfo(this IHttpContext ctx)
        {
            var headers = ctx.Request.Headers;
            var serverName = headers[Constants.ServerIdentifier];
            var serverIdentifier = headers[Constants.ServerIdentifier];
            var serverIp = headers[Constants.ServerIp];
            uint maxPlayers = (uint)Int32.Parse(headers[Constants.MaxPlayers]);
            var currentNumberOfPlayers = (uint)Int32.Parse(headers[Constants.CurrentNumberOfPlayers]);
            var isPrivate = headers[Constants.IsPrivate];
            return new ServerInfo()
            {
                ServerName = serverName,
                ServerIdentifier = serverIdentifier,
                ServerIp = serverIp,
                MaxPlayers = maxPlayers,
                CurrentNumPlayers = currentNumberOfPlayers,
                IsPrivate = isPrivate == Constants.True
            };
        }

        public static RequestInfo CreateRequestInfo(this IHttpContext ctx)
        {
            var headers = ctx.Request.Headers;
            var serverName = headers[Constants.ServerIdentifier];
            var serverIp = headers[Constants.ServerIp];
            uint maxPlayers = (uint)Int32.Parse(headers[Constants.MaxPlayers]);
            var currentNumberOfPlayers = (uint)Int32.Parse(headers[Constants.CurrentNumberOfPlayers]);
            var isPrivate = headers[Constants.IsPrivate];
            return new RequestInfo()
            {
                ServerName = serverName,
                ServerIp = serverIp,
                MaxPlayers = maxPlayers,
                CurrentNumPlayers = currentNumberOfPlayers,
                IsPrivate = isPrivate == Constants.True
            };
        }
    }
}