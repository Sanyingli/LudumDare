using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMagnet : MonoBehaviour {

    public GameObject gatherPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Stone")
        {
            Stone stone = collision.gameObject.GetComponent<Stone>();
            stone.MoveToShip(gatherPoint);
        }
    }
}
