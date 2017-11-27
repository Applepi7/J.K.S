using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance;

    [SerializeField]
    private AudioSource pickUpSound;

	// Use this for initialization
	void Awake ()
    {
        SoundManager.instance = this;	
	}

    public void PlayPickUpSound()
    {
        pickUpSound.Play();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
