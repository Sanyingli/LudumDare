using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapZone : MonoBehaviour {

    public GameObject trapFall;

    public GameObject[] fruits;

    public bool isFallingTrap;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerStage")
        {
            if(isFallingTrap&&trapFall != null)
            {
                trapFall.GetComponent<Rigidbody2D>().AddForce(Vector2.down * 100);
                Destroy(trapFall, 5f);
            }

            if (!isFallingTrap)
            {
                Debug.Log("Test");
                Vector3 target = GameObject.FindGameObjectWithTag("Player").transform.position;
                Vector3 dirction = target - transform.position;
                GameObject fruit = Instantiate(fruits[(int)Random.Range(0, fruits.Length)],transform.parent,false);
                fruit.GetComponent<Rigidbody2D>().AddForce(dirction*40);
                if(fruit != null)
                {
                    Destroy(fruit, 5f);
                }
            }
        }
    }
}
