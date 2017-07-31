using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour {

    public GameObject[] ships;
    public GameObject PowerHole;
    public Transform startPoint;
    public Transform landingPoint;

    public float movementSpeed = 100;
    public bool gasAddable = false;

    float lastTime;
    float GenerateTime = 5;


	// Use this for initialization
	void Start () {
        lastTime = 0;
        gasAddable = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (gasAddable)
        {
            PowerHole.SetActive(true);
        }
        else
        {
            PowerHole.GetComponent<AddGas>().playerEnter = false;
            PowerHole.SetActive(false);
        }

        if(Time.time - lastTime > GenerateTime)
        {
            Debug.Log("test");
            CreatCustomer();
            lastTime = Time.time;
            GenerateTime = Random.Range(15, 40);
        }
	}

    void CreatCustomer()
    {
        int i = Random.Range(0, ships.Length + 1);
        GameObject _ship = ships[i];
        _ship.GetComponent<CustomerShip>().GoPoint = landingPoint;
        _ship.GetComponent<CustomerShip>().awayPoint = startPoint;
        _ship.GetComponent<CustomerShip>().station = this.gameObject;
        Instantiate(_ship, startPoint.position,startPoint.rotation);
    }

}
