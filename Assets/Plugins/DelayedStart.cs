using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DelayedStart : NetworkBehaviour
{

    public Teams Players;

    public float DelayStart;
    public int Delay = 5;
    public bool canDelay;

    [SyncVar]
    public bool Respawn;

    // Use this for initialization
    void Start()
    {
        Respawn = false;
        canDelay = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Players.Players > 0 && canDelay)
        {

            /*if (Time.time >= DelayStart + Delay)
            {
                canDelay = false;
                Respawn = true;
            }*/
        }
    }
}
