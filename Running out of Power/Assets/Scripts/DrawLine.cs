using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {

    public GameObject ship;
    LineRenderer lr;

    public Color c1 = Color.yellow;
    public Color c2 = Color.red;

    // Use this for initialization
    void Start () {
        lr = GetComponent<LineRenderer>();

        lr.widthMultiplier = 0.2f;
        lr.positionCount = 2;
        // A simple 2 color gradient with a fixed alpha of 1.0f.
        float alpha = 1.0f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(c1, 0.0f), new GradientColorKey(c2, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
            );
        lr.colorGradient = gradient;
    }
	
	// Update is called once per frame
	void Update () {
        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, ship.transform.position);
		
	}
}
