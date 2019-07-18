using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {


    public Text BlueScore;
    public Text RedScore;

    public Text CountDown;

    public Teams Score;

    public DelayedStart DTime;
    public float Timer;

    public bool canTime;

	// Use this for initialization
	void Start () {
        canTime = true;
    }

    // Update is called once per frame
    void Update () {
        BlueScore.text = "" + Score.BlueScore;
        RedScore.text = "" + Score.RedScore;
        if (canTime)
        {
            Timer = 30 - (Time.time - DTime.DelayStart);
        }

        if (Timer <= 0)
        {
            CountDown.enabled = false;
            canTime = false;
        }

        CountDown.text = "Game Starts In " + Timer;
	}
}
