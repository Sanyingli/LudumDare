using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCtrl : MonoBehaviour {

    Rigidbody2D rg;
    public float force;

    public GameObject SpotLight;
    bool lightOn = false;

	// Use this for initialization
	void Start () {
        lightOn = false;
        rg = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space")&&SpotLight!= null)
        {
            if (!lightOn)
            {
                lightOn = true;
                SpotLight.SetActive(lightOn);
            }
            else
            {
                lightOn = false;
                SpotLight.SetActive(lightOn);
            }
        }

    }
    private void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rg.AddForce(new Vector2(1, 1) * force);
        }
        if (Input.GetKey("d"))
        {
            rg.AddForce(new Vector2(-1, 1) * force);
        }

    }
}
