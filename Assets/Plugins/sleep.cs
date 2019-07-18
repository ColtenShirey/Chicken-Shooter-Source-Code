using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using Random = UnityEngine.Random;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class sleep : NetworkBehaviour {

    private NetworkIdentity thisNI;
    private Camera CameraView;
    private FirstPersonController FPSController;
	// Use this for initialization
	void Start () {
        thisNI = GetComponent<NetworkIdentity>();
        CameraView = GetComponent<Transform>().FindChild("FirstPersonCharacter").GetComponent<Camera>();
        FPSController = GetComponent<FirstPersonController>(); 
        if (!thisNI.hasAuthority)
        {
            CameraView.enabled = false;
            FPSController.enabled = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
