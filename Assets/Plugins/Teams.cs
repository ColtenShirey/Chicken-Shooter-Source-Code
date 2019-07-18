using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Teams : NetworkBehaviour {

    

    [SyncVar]
    public int Players = 0;

    [SyncVar]
    public int BlueScore;

    [SyncVar]
    public int RedScore;


    public void AddRed(int Number)
    {
        RedScore = RedScore += Number;
    }

    public void AddBlue(int Number)
    {
        BlueScore = BlueScore += Number;
    }

    /* public void OnServerDisconnect(NetworkConnection conn)
     {
         Players = Players - 1;
     }*/

}
