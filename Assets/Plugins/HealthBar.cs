using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class HealthBar : NetworkBehaviour {

    public Health health;
    public Slider slider;

    public void Start()
    {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        health = GetComponent<Health>();
    }

    public void Update()
    {

        if (!isLocalPlayer)
        {
            return;
        }

        slider.value = health.CurrHealth;

       /* if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            health.TakeDamage(10);
        }*/
    }
}
