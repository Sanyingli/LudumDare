using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour {

    public GameObject[] ships;
    public GameObject PowerHole;
    public Transform startPoint;
    public Transform landingPoint;

    public float movementSpeed = 100;
    bool gasAddable = false;

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
            PowerHole.SetActive(false);
        }

        if(Time.time - lastTime > GenerateTime)
        {
            Debug.Log("test");
            CreatCustomer();
            lastTime = Time.time;
            GenerateTime = Random.Range(8, 15);
        }
	}

    void CreatCustomer()
    {
        int i = Random.Range(0, ships.Length);
        GameObject _ship = ships[i];
        _ship.GetComponent<CustomerShip>().GoPoint = landingPoint;
        Instantiate(_ship, startPoint.position,startPoint.rotation);
    }
}
