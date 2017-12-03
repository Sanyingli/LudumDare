using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    int index;

    // Use this for initialization
    void Start () {
        instance = this;
        index = SceneManager.GetActiveScene().buildIndex;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnterNextLv()
    {
        SceneManager.LoadScene(index +1);
    }

    public void RestartLv()
    {
        SceneManager.LoadScene(index);
    }

    public void ReturnMain()
    {
        SceneManager.LoadScene(0);
    }
}
