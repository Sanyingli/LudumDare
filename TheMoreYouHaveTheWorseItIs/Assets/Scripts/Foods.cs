using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foods : MonoBehaviour {

    public bool isFruit = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PlayerStage")
        {
            if (isFruit)
            {
                GameManager.instace.foods += 1;
                GameManager.instace.CheckFoods();
                AudioManager.instance.PlayHurts();
                Destroy(gameObject);
            }
            else
            {
                GameManager.instace.foods -= 1;
                GameManager.instace.CheckFoods();
                AudioManager.instance.PlayAddCoins();
                Destroy(gameObject);
            }
        }
    }
}
