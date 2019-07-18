using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Shooting : NetworkBehaviour {

    public Transform Bullet;
    public Transform Gun;

	// Use this for initialization
	void Start () {
        Gun = GetComponent<Transform>().FindChild("Gun").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {



		if (Input.GetButtonDown ("Fire1")){
            Instantiate(Bullet, new Vector3(Gun.position.x, Gun.position.y, Gun.position.z), Gun.rotation);
        }
	}
}
