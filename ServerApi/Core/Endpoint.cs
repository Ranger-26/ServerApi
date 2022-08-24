using System;
using System.Threading.Tasks;
using Grapevine;
using ServerApi.Core.Extensions;
using ServerApi.Models;

namespace ServerApi.Core
{
    [RestResource]
    public class Endpoint
    {
        [RestRoute("Post", "/serverApi/addServer")]
        public async Task AddServer(IHttpContext ctx)
        {
            var reqInfo = ctx.CreateRequestInfo();
            if (Program.Instance.Database.AddServer(reqInfo, out string identifier))
            {
                await ctx.Response.SendResponseAsync($"Server succesfully Added! Code is {identifier}");
            }
        }

        [RestRoute("Post", "/serverApi/removeServer")]
        public async Task RemoveServer(IHttpContext ctx)
        {
            if (Program.Instance.Database.RemoveServer(ctx.Request.Headers[Constants.ServerIdentifier]))
            {
                await ctx.Response.SendResponseAsync("Server succesfully Removed!");
                return;
            }
            await ctx.Response.SendResponseAsync("Something went wrong when removing the server!");
        }

        [RestRoute("Post", "/serverApi/updateServer")]
        public async Task UpdateServer(IHttpContext ctx)
        {
            if (Program.Instance.Database.UpdateServer(ctx.CreateServerInfo()))
            {
                await ctx.Response.SendResponseAsync("Server succesfully updated!");
                return;
            }

            await ctx.Response.SendResponseAsync("Problem when updating server!");
        }

        [RestRoute("Get", "/serverApi/updateServer")]
        public async Task GetServers(IHttpContext ctx)
        {
            
        }
    }
}