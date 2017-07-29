using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GUIInfo : MonoBehaviour {

    public Text greenNum;
    public Text redNum;
    public Text blueNum;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        greenNum.text = JuiceGM.greenStoneCount.ToString();
        redNum.text = JuiceGM.redStoneCount.ToString();
        blueNum.text = JuiceGM.blueStoneCount.ToString();
    }
}
