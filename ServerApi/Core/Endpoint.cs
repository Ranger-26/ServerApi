using System.Threading.Tasks;
using Grapevine;
using ServerApi.Models;

namespace ServerApi.Core
{
    [RestResource]
    public class Endpoint
    {
        [RestRoute("Post", "/serverApi/addServer")]
        public async Task AddServer(IHttpContext ctx)
        {
            
        }

        [RestRoute("Post", "/serverApi/removeServer")]
        public async Task RemoveServer(IHttpContext ctx)
        {
            
        }

        [RestRoute("Post", "/serverApi/updateServer")]
        public async Task UpdateServer(IHttpContext ctx)
        {
            
        }

        [RestRoute("Get", "/serverApi/updateServer")]
        public async Task GetServers(IHttpContext ctx)
        {
            
        }
    }
}