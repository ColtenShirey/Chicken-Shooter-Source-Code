using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class Health : NetworkBehaviour {


    public const int SpawnTime = 5;
    public bool dead;
    public float DeadTime;

    public const int MaxHealth = 100;
    public GameObject player;

    public GameObject RedPlace;
    public GameObject BluePlace;
    public GameObject BlueSpawn;
    public GameObject RedSpawn;

    public bool onetime = true;

    public Playerteam MyTeam;

    public DelayedStart Spawn;

    [SyncVar]
    public int CurrHealth = MaxHealth;

    // Use this for initialization

    public void Start()
    {
        BluePlace = GameObject.Find("BluePlace");
        RedPlace = GameObject.Find("RedPlace");
        MyTeam = gameObject.GetComponent<Playerteam>();

        BlueSpawn = GameObject.Find("BlueSpawn");
        RedSpawn = GameObject.Find("RedSpawn");

        RpcRespawn();

        Spawn = GameObject.Find("DeathPlace").GetComponent<DelayedStart>();
        //RpcDie();

        Spawn.DelayStart = Time.time;
    } 

    public void Update()
    {


        if (dead)
        {
            if (onetime)
            {
                onetime = false;
                RpcDie();
                DeadTime = Time.time;
            }

            if (Time.time >= DeadTime + SpawnTime)
            {
                RpcRespawn();
                dead = false;
                onetime = true;
            }

           


        }
        if (Spawn.Respawn)
        {
            RpcRespawn();
            Spawn.Respawn = false;
        }
    } 

    public void TakeDamage (int Amount)
    {
        if (!isServer)
        {
            return;
        }

        CurrHealth -= Amount;
        if (CurrHealth <= 0)
        {
            dead = true;
            player = gameObject;
        }
    }

    [ClientRpc]
    void RpcRespawn()
    {
        //transform.position = Vector3.zero;
        CurrHealth = MaxHealth;

        if (MyTeam.Team == 1)
        {
            transform.position = BlueSpawn.transform.position;
        }

        if (MyTeam.Team == 2)
        {
            transform.position = RedSpawn.transform.position;
        }
    }

    [ClientRpc]
    void RpcDie()
    {
        if (MyTeam.Team == 1)
        {
            transform.position = BluePlace.transform.position;
        }

        if (MyTeam.Team == 2)
        {
            transform.position = RedPlace.transform.position;
        }       
    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.tag == "Die")
        {
            TakeDamage(100);
        }
    }
}
