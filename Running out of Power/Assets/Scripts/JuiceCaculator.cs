using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JuiceCaculator : MonoBehaviour {

    public Text greenNum;
    public Text redNum;
    public Text blueNum;
    public Text greenValue;
    public Text redValue;
    public Text blueValue;
    public Text parkInfo;
    public Text totalValueText;
    int totalValue;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        greenNum.text = JuiceGM.greenStoneCount.ToString();
        redNum.text = JuiceGM.redStoneCount.ToString();
        blueNum.text = JuiceGM.blueStoneCount.ToString();

        greenValue.text = (JuiceGM.greenStoneCount*10).ToString();
        redValue.text = (JuiceGM.redStoneCount*20).ToString();
        blueValue.text = (JuiceGM.blueStoneCount*50).ToString();

        totalValue = JuiceGM.greenStoneCount * 10 + JuiceGM.redStoneCount * 20 + JuiceGM.blueStoneCount * 50;

        totalValueText.text = "Total power: "+ totalValue;

        if (JuiceGM.shipParked)
        {
            parkInfo.text = "Ship parked";
        }
        else
        {
            parkInfo.text = "Ship not parked";
        }

    }

    public void BackToStationButton()
    {
        GM.power += totalValue;
        if (JuiceGM.shipParked)
        {
            GM.shipNum += 1;
        }

        SceneManager.LoadScene(1);
    }
}
