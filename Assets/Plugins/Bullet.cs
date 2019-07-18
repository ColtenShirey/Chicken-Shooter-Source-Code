using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using Random = UnityEngine.Random;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class Bullet : MonoBehaviour {

    public Transform shooter;
    public Teams Score;


    private void Start()
    {
        Score = GameObject.Find("DeathPlace").GetComponent<Teams>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        GameObject hit = collision.gameObject;
        Health health = hit.GetComponent<Health>();
        Playerteam Team = hit.GetComponent<Playerteam>(); 
        int myTeam = shooter.GetComponent<Playerteam>().Team;
        //FirstPersonController fps = hit.GetComponent<FirstPersonController>();
        /*if (fps.pid.isLocalPlayer)
        {
            return;
        }*/

        if (collision.collider.transform != shooter)
        {


            if (health != null)
            {
                if (myTeam != Team.Team)
                {
                    health.TakeDamage(10);
                    if (Team.Team == 2)
                    {
                        Score.AddRed(10);
                    }

                    if (Team.Team == 1)
                    {
                        Score.AddBlue(10);
                    }
                }
            }
            Destroy(gameObject);
        }
       
    } 
}
