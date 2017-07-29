using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    Rigidbody2D rg;
    public float movementSpeed;
    public bool moveable;

    public int stoneType;//green is 1, red is 2, blue is 3;


	// Use this for initialization
	void Start () {
        moveable = true;
        rg = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void MoveToShip(GameObject _ship)
    {
        if (moveable)
        {
            Vector3 direction = (_ship.transform.position - transform.position).normalized;
            rg.MovePosition(transform.position + direction * movementSpeed * Time.deltaTime);
        }
    }
}
