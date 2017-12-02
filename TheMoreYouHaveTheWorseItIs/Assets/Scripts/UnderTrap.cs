using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderTrap : MonoBehaviour {

    public GameObject trap;
    bool trapOpen = false;
    float lastTime = 0f;
    // Use this for initialization
    void Start () {
        trap.SetActive(trapOpen);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTime >= 1f)
        {
            lastTime = Time.time;
            trapOpen = !trapOpen;
            trap.SetActive(trapOpen);

        }
    }
}
