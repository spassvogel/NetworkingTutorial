using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkDiscovery : NetworkDiscovery
{

    void Start()
    {
        Initialize();

#if UNITY_EDITOR
        StartAsServer();
        showGUI = true;
        Debug.Log("Started as server");
#else
        showGUI = false;
        StartAsClient();
#endif
    }

    public override void OnReceivedBroadcast(string fromAddress, string data)
    {
        NetworkManager.singleton.networkAddress = fromAddress;
        NetworkManager.singleton.StartClient();
    }
}