using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Playerteam : NetworkBehaviour {

    public Teams Players;

    public GameObject ChickenBlue;
    public GameObject ChickenRed;

    public GameObject Me;
    public MeshRenderer Teamcolorblue;
    public MeshRenderer Teamcolorred;

    private bool setup = true;

    public GameObject BlueTeamPrefab;
    public Transform Teamlocation;
    public GameObject RedTeamPrefab;


    [SyncVar]
    public int Team;

	// Use this for initialization
	public void Awake () {


        

    }


    // Update is called once per frame

    void Update()
    {
        if (setup) {
            Players = GameObject.Find("DeathPlace").GetComponent<Teams>();
            Players.Players++;
            if (Players.Players == 1 || Players.Players == 3 || Players.Players == 5 || Players.Players == 7 || Players.Players == 9)
            {
                Team = 1;
            }

            else if (Players.Players == 2 || Players.Players == 4 || Players.Players == 6 || Players.Players == 8 || Players.Players == 10)
            {
                Team = 2;
            }

            if (Team == 1)
            {
                CmdmakeBlue();
            }

            if (Team == 2)
            {
                CmdMakered();
            }
            setup = false;
           }
    }

    [Command]
    public void CmdmakeBlue()
    {
        GameObject BlueTeam = (GameObject)Instantiate(BlueTeamPrefab, new Vector3(transform.position.x + 0.05929f, transform.position.y - 0.9696f, transform.position.z + 0.10141f), Quaternion.identity);
        BlueTeam.transform.eulerAngles = new Vector3(BlueTeam.transform.eulerAngles.x, 86.98f, BlueTeam.transform.eulerAngles.z);
        BlueTeam.transform.SetParent(transform);
        NetworkServer.Spawn(BlueTeam);
        Debug.Log("here");
    }

    [Command]
    public void CmdMakered()
    {
        GameObject RedTeam = (GameObject)Instantiate(RedTeamPrefab, new Vector3(transform.position.x + 0.05929f, transform.position.y - 0.9696f, transform.position.z + 0.10141f), Quaternion.identity);
        RedTeam.transform.eulerAngles = new Vector3(RedTeam.transform.eulerAngles.x, 86.98f, RedTeam.transform.eulerAngles.z);
        RedTeam.transform.SetParent(transform);
        NetworkServer.Spawn(RedTeam);
        Debug.Log("here");
    }
}
