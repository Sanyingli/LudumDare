﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLvNext : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LevelManager.instance.EnterNextLv();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerStage")
        {
            LevelManager.instance.EnterNextLv();
        }
    }
}
