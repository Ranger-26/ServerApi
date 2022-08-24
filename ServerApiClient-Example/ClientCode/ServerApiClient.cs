using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace ServerApiClient_Example.ClientCode
{
    public class ServerApiClient : MonoBehaviour
    {
        public string BaseUrl;
        public uint Port;
        public IEnumerator AddServer(string serverName, string serverip, uint maxPlayers, uint currentNumPlayers,
            bool isPrivate)
        {
            using (UnityWebRequest www = new UnityWebRequest($"{BaseUrl}{Port}", "POST"))
            {
                www.SetRequestHeader(Constants.ServerName, serverName);
                www.SetRequestHeader(Constants.ServerIp, serverip);
                www.SetRequestHeader(Constants.MaxPlayers, maxPlayers.ToString());
                www.SetRequestHeader(Constants.CurrentNumberOfPlayers, currentNumPlayers.ToString());
                www.SetRequestHeader(Constants.IsPrivate, isPrivate.ToString());
                www.downloadHandler = new DownloadHandlerBuffer();
                yield return www.SendWebRequest();
                Debug.Log($"{www.downloadHandler.text}");
            }
        }
    }
}