using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchToDie : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerStage")
        {
            GameManager.instace.GetHurt();
            AudioManager.instance.PlayHurts();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instace.GetHurt();
            AudioManager.instance.PlayHurts();
        }
    }
}
