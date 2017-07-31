using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGas : MonoBehaviour {

    public bool playerEnter = false;

    float elapsed = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        elapsed += Time.deltaTime;
        if(elapsed >= 0.2f)
        {
            elapsed = elapsed % 0.2f;
            AddPower();
        }
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerEnter = true;
            collision.gameObject.transform.position = this.transform.position;
        }
    }


    void AddPower()
    {
        if (playerEnter &&GM.power > 0)
        {
            GM.power -= 1;
            GM.money += 10;
            Debug.Log(GM.power);
        }
    }
}
