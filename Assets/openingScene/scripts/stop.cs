using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stop : MonoBehaviour {

    public Animator bucket;
    public Animator mainCam;
    public Animator trash;
    public Animator lid;
    public Animator pistol;
    public GameObject clickPlay;

    // Use this for initialization
    void Start () {

        bucket = GameObject.Find("Bucket").GetComponent<Animator>();
        mainCam = GameObject.Find("Camera").GetComponent<Animator>();
        trash = GameObject.Find("Trashcan").GetComponent<Animator>();
        lid = GameObject.Find("Trashcanlid").GetComponent<Animator>();
        pistol = GameObject.Find("Gun").GetComponent<Animator>();
        clickPlay = GameObject.Find("Canvas");

        

    }

    

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            bucket.enabled = true;
            mainCam.enabled = true;
            trash.enabled = true;
            lid.enabled = true;
            pistol.enabled = true;
            clickPlay.SetActive(false);
        }
		
	}
}
