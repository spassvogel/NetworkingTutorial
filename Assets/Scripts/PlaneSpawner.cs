

using System;
using UnityEngine;
using UnityEngine.Networking;
using Random = UnityEngine.Random;

public class PlaneSpawner : NetworkBehaviour
{

    public GameObject PlanePrefab;

    public override void OnStartServer()
    {
        NetworkServer.RegisterHandler(MsgType.Connect, OnConnected);

        //        for (int i = 0; i < numberOfEnemies; i++)
        //      {
    //    var spawnPosition = new Vector3(
    //            Random.Range(-8.0f, 8.0f),
    //            0.0f,
    //            Random.Range(-8.0f, 8.0f));

    //        var spawnRotation = Quaternion.Euler(
    //            0.0f,
    //            Random.Range(0, 180),
    //            0.0f);

    //        var enemy = (GameObject)Instantiate(PlanePrefab, spawnPosition, spawnRotation);
    //        NetworkServer.Spawn(enemy);
    ////    }
    }

    private void OnConnected(NetworkMessage netMsg)
    {
        Debug.Log("Player connected" + netMsg.conn.connectionId.ToString());
       // SpawnPlane();// Where?
    }




}