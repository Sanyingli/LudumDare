using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juicer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            Stone stone = collision.gameObject.GetComponent<Stone>();
            if (stone.stoneType == 1)
            {
                JuiceGM.greenStoneCount += 1;
            }
            else if (stone.stoneType == 2)
            {
                JuiceGM.redStoneCount += 1;
            }
            else if (stone.stoneType == 3)
            {
                JuiceGM.blueStoneCount += 1;
            }
            stone.moveable = false ;
        }
    }

}
