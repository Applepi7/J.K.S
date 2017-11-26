using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public int keyNum = 7;

	// Use this for initialization
	void Awake () {
        GameManager.instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
