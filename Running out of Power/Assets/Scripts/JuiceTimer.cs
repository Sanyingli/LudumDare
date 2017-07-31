using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JuiceTimer : MonoBehaviour {
    
    public GameObject caculatorPanel;
    public Text timerText;
    public GameObject ship;

    public float timeLimit;
    public float timeLeft;

	// Use this for initialization
	void Start () {
        timeLimit += Time.time;
        timeLeft = timeLimit;
        caculatorPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft = timeLimit - Time.time;

        timerText.text = "power left: " + (int)timeLeft;

        if(timeLeft < 0)
        {
            timeLeft = 0;
            caculatorPanel.SetActive(true);
            ship.GetComponent<ShipCtrl>().SpotLight.SetActive(false);
            ship.GetComponent<ShipCtrl>().enabled = false;
            this.enabled = false;
        }
	}
}
