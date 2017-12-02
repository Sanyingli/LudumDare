using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instace;

    PlayerCtrl playerCtrl;

    public int stages = 0;
    public int foods = 0;
    public int scores = 0;

    // Use this for initialization
    void Start () {
        playerCtrl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCtrl>();

        instace = this;
        stages = 0;
        foods = 0;
        scores = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckFoods()
    {
        if (foods <= 0)
        {
            foods = 0;
        }
        if (foods < 1)
        {
            stages = 0;
        }
        else if (foods == 1)
        {
            stages = 1;
        }
        else if (foods >= 2)
        {
            stages = 2;
        }
        playerCtrl.CheckStage();
    }
}
