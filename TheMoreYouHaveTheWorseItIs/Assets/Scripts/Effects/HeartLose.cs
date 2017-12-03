using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HeartLose : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.DOMove(Vector3.down, 4f);
        transform.DOScale(0, 0.5f);
        Destroy(gameObject,2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
