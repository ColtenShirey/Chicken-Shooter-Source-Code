using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Bullshit : NetworkManager {


    public class Message : NetworkMessage
    {
        public int ChosenTeam;
    }

    // Use this for initialization
    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
          
    }
}
