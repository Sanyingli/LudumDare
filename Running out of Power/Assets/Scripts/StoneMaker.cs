using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMaker : MonoBehaviour {

    public GameObject greenStone;
    public GameObject redStone;
    public GameObject blueStone;

    int greenNum;
    int redNum;
    int blueNum;
    // Use this for initialization
    void Start () {
        GenerateStone();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void MakeStone(GameObject _stone)
    {
        float _x = Random.Range(transform.position.x - 4, transform.position.x + 8);
        Instantiate(_stone, new Vector3(_x,transform.position.y,0),transform.rotation);
    }

    void GenerateStone()
    {
        greenNum = Random.Range(3, 11);
        redNum = Random.Range(2, 9);
        blueNum = Random.Range(1, 6);

        for (int i = 0; i < greenNum; i++)
        {
            MakeStone(greenStone);
        }
        for (int i = 0; i < redNum; i++)
        {
            MakeStone(redStone);
        }
        for (int i = 0; i < blueNum; i++)
        {
            MakeStone(blueStone);
        }
    }
}
