using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraFellow : MonoBehaviour {

    public Transform target;
    public float xOffSet;
    public float yOffSet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 pos = transform.position;
        transform.DOMove(new Vector3(target.position.x - xOffSet, target.position.y - yOffSet, -10),0.5f);
        //transform.position = new Vector3(Mathf.Lerp(pos.x, target.position.x,0.5f) - xOffSet, pos.y, -10);
    }
}
