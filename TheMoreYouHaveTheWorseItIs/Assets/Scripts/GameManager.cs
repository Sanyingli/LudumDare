﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instace;

    PlayerCtrl playerCtrl;

    public int stages = 0;
    public int foods = 0;
    public int scores = 0;

    public int health = 3;

    public bool hurtable = true;
    float lastTime = 0;

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
            foods = 2;
        }
        playerCtrl.CheckStage();
    }

    public void GetHurt()
    {
        if (Time.time - lastTime >= 2f && hurtable)
        {
            lastTime = Time.time;
            health -= 1;
            GUI.instance.CheckHeart(health);
            if (health <= 0)
            {
                Debug.Log("game over");
                //GameOver();
            }
            else
            {
                hurtable = false;
                Debug.Log("GetHurt() call");
                StartCoroutine(UnHurtable());
            }
        }
    }
    IEnumerator UnHurtable()
    {
        yield return new WaitForSeconds(2f);
        hurtable = true;
        playerCtrl.stages[stages].GetComponent<SpriteRenderer>().enabled = true;    
    }
}
