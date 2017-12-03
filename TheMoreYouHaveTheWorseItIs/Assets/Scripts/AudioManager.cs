using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public static AudioManager instance;

    public AudioClip[] Hurts;
    public AudioClip[] AddCoins;

    AudioSource audioSource;
	// Use this for initialization
	void Start () {
        instance = this;
        audioSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayHurts()
    {
        audioSource.PlayOneShot(Hurts[Random.Range(0, Hurts.Length)]);
    }
    public void PlayAddCoins()
    {
        audioSource.PlayOneShot(AddCoins[Random.Range(0, Hurts.Length)]);
    }
}
