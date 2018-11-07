using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetManager : NetworkManager
{
    void  Start()
    {
#if UNITY_EDITOR
        this.StartHost();
#else
        this.GetComponent<NetworkManagerHUD>().enabled = false;
#endif
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        Debug.Log("Client disconnect");
        base.OnClientDisconnect(conn);
    }

    public override void OnDropConnection(bool success, string extendedInfo)
    {
        Debug.Log("Client dropped " + extendedInfo);
        base.OnDropConnection(success, extendedInfo);
    }

    public override void OnStopClient()
    {
        Debug.Log("Client stopped");
    }
}
