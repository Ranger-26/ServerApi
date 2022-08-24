using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace ServerApiClient_Example.ClientCode
{
    public class ServerApiClient : MonoBehaviour
    {
        public IEnumerator AddServer(string serverName, string serverip, uint maxPlayers, uint currentNumPlayers,
            bool isPrivate)
        {
            yield return null;
        }
    }
}