using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerShip : MonoBehaviour {

    Rigidbody2D rg;
    public float movementSpeed;
    public Transform GoPoint;

    // Use this for initialization
    void Start () {
        rg = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void MoveToShip(Transform _ship)
    {
        if(Vector3.Distance(_ship.position , transform.position) > 0.1)
        {
            Vector3 direction = (_ship.position - transform.position).normalized;
            rg.MovePosition(transform.position + direction * movementSpeed * Time.deltaTime);
        }
        else
        {
            //start count;
        }

    }

    private void FixedUpdate()
    {
        MoveToShip(GoPoint);
    }
}
