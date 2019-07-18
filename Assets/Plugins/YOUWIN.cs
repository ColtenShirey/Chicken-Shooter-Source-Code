using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YOUWIN : MonoBehaviour {

    public Teams redScore;
    public Teams blueScore;

    public GameObject RedWin;
    public GameObject BlueWin;

    public int Wait = 5;
    public float EndStart;
    public bool canEnd;
    public bool oneTime;



	// Use this for initialization
	void Start () {

        redScore = GameObject.Find("DeathPlace").GetComponent<Teams>();
        blueScore = GameObject.Find("DeathPlace").GetComponent<Teams>();

        RedWin = GameObject.Find("RedWins");
        BlueWin = GameObject.Find("BlueWins");
        RedWin.SetActive(false);
        BlueWin.SetActive(false);
        canEnd = false;
        oneTime = true;
    }

    // Update is called once per frame
    void Update () {
		
        if (redScore.RedScore == 7500)
        {
            RedWin.SetActive(true);
            if (oneTime)
            {
                EndStart = Time.time;
                oneTime = false;
            }
            canEnd = true;

        }

        if (blueScore.BlueScore == 7500)
        {
            BlueWin.SetActive(true);
            if (oneTime)
            {
                EndStart = Time.time;
                oneTime = false;
            }
            canEnd = true;
        }

        if (canEnd && Time.time >=  EndStart + Wait)
        {
            SceneManager.LoadScene("The Deep Fry", LoadSceneMode.Single);
        }

	}
}
