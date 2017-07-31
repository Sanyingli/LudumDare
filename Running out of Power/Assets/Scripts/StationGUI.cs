using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StationGUI : MonoBehaviour {

    public Text money;
    public Text power;

    public GameObject[] planeImages;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        money.text = "Money: " + GM.money;
        power.text = "Power: " + GM.power;

        if(GM.shipNum == 0)
        {
            planeImages[0].SetActive(false);
            planeImages[1].SetActive(false);
            planeImages[2].SetActive(false);
        }
        else if(GM.shipNum == 1)
        {
            planeImages[0].SetActive(true);
            planeImages[1].SetActive(false);
            planeImages[2].SetActive(false);
        }
        else if (GM.shipNum == 2)
        {
            planeImages[0].SetActive(true);
            planeImages[1].SetActive(true);
            planeImages[2].SetActive(false);
        }
        else if (GM.shipNum == 3)
        {
            planeImages[0].SetActive(true);
            planeImages[1].SetActive(true);
            planeImages[2].SetActive(true);
        }
        else
        {
            planeImages[0].SetActive(true);
            planeImages[1].SetActive(true);
            planeImages[2].SetActive(true);
        }

    }

    public void GoMiningButton()
    {
        if(GM.shipNum > 0)
        {
            GM.shipNum -= 1;
            SceneManager.LoadScene(2);
        }

    }

    public void BuyShipButton()
    {
        if(GM.shipNum < 3 && GM.money >= 200)
        {
            GM.shipNum += 1;
            GM.money -= 200;
        }
    }

    public void BackMain()
    {
        SceneManager.LoadScene(0);
    }
}
