using System;
using System.Threading.Tasks;
using Grapevine;
using ServerApi;
namespace ServerApi
{
    internal class Program
    {
        public Database.Database Database;

        public static Program Instance;
        
        public Program()
        {
            Database = new Database.Database();
        }

        public void StartServer()
        {
            Instance = this;
            using (var server = RestServerBuilder.UseDefaults().Build())
            {
                server.Start();

                Console.WriteLine("Press enter to stop the server");
                Console.ReadLine();
            }
        }


        public static void Main(string[] args) => new Program().StartServer();
    }
}