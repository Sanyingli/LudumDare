using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

    public float jumpForce = 10;
    Rigidbody2D rg;

    public GameObject[] stages;

    float lastTime = 0;
    public float jumpCD = 1f;
    public float jumpForceMax = 150;
    public bool mouseDowning = false;

    // Use this for initialization
    void Start () {
        rg = GetComponent<Rigidbody2D>();
        rg.mass = 0.5f;
        for (int i = 0; i < stages.Length; i++)
        {
            stages[i].SetActive(false);
        }
        stages[0].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Fire1"))
        {
            if (Time.time - lastTime >= jumpCD)
            {
                lastTime = Time.time;
                Jump();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            mouseDowning = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            mouseDowning = false;
            jumpForce = 0;
        }

        if (mouseDowning)
        {
            jumpForce += Time.deltaTime * 400;
            if (jumpForce >= jumpForceMax)
            {
                jumpForce = jumpForceMax;
            }
        }

	}

    public void Jump()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = mousePos - new Vector2(transform.position.x, transform.position.y);
        rg.AddForce(dir * jumpForce);
    }

    public void CheckStage()
    {
        for (int i = 0; i < stages.Length; i++)
        {
            stages[i].SetActive(false);
        }
        
        stages[GameManager.instace.stages].SetActive(true);
        //Debug.Log(((float)GameManager.instace.stages + 1) / 2);
        rg.mass = ((float)GameManager.instace.stages + 3) / 3;
        jumpForceMax = ((float)GameManager.instace.stages + 3) / 3 * 150;
    }
}
