using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class NetworkJoiner : MonoBehaviour {
    private NetworkManager _networkManager;

    // Use this for initialization
    void Start () {
        _networkManager = GetComponent<NetworkManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _networkManager.StartClient();
        }
	}
}
