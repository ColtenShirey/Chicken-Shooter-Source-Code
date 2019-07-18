using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour {

	// Use this for initialization
	public void OnCollisionEnter(Collision collision)
    {
        GameObject hit = collision.gameObject;
        Health health = hit.GetComponent<Health>();
        Debug.Log(collision.gameObject.name);
        if (health != null)
        {
            health.TakeDamage(100);
            Debug.Log("here2");
        }
    }
}
