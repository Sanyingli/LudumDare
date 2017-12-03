using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraOffset : MonoBehaviour {

    public float yOffset;

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
            Camera.main.gameObject.GetComponent<CameraFellow>().yOffSet = yOffset;
        }
    }
}
