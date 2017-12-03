using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI : MonoBehaviour {

    public static GUI instance;

    public GameObject[] hearts;
    public GameObject heartLoseAnimation;

	// Use this for initialization
	void Start () {
        instance = this;
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].SetActive(true);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckHeart(int _h)
    {
        for (int i = 0; i < hearts.Length - _h; i++)
        {
            hearts[i].SetActive(false);
        }
        if(hearts.Length - _h < hearts.Length)
        {
            Instantiate(heartLoseAnimation, hearts[hearts.Length - _h].transform);
        }
    }
}
