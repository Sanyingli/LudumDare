using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JuiceCaculator : MonoBehaviour {

    public Text greenNum;
    public Text redNum;
    public Text blueNum;
    public Text greenValue;
    public Text redValue;
    public Text blueValue;
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

        totalValueText.text = "total power: "+ totalValue;

    }
}
