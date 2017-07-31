using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerShip : MonoBehaviour {

    Rigidbody2D rg;
    public float movementSpeed;
    public Transform GoPoint;
    public Transform awayPoint;
    public GameObject station;

    public float parkTime;
    public float lastTime;
    public int timeLeft;

    bool startCount = false;

    // Use this for initialization
    void Start () {
        rg = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!startCount)
        {
            lastTime = Time.time;
        }

        timer();

    }

    public void MoveToStation(Transform _station)
    {
        if(Vector3.Distance(_station.position , transform.position) > 0.1)
        {
            Vector3 direction = (_station.position - transform.position).normalized;
            rg.MovePosition(transform.position + direction * movementSpeed * Time.deltaTime);
            station.GetComponent<Station>().gasAddable = false;
        }
        else
        {
            station.GetComponent<Station>().gasAddable = true;
            startCount = true;
        }
    }

    private void FixedUpdate()
    {
        MoveToStation(GoPoint);
    }

    void FlyAway()
    {
        GoPoint = awayPoint;
        station.GetComponent<Station>().gasAddable = false;
    }

    void timer()
    {
        timeLeft = (int)(parkTime - (Time.time - lastTime));
        if (Time.time - lastTime > parkTime)
        {
            FlyAway();
            Destroy(this.gameObject, 5f);
        }
    }
}
