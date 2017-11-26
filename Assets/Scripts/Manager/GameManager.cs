using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public int keyNum;

	// Use this for initialization
	void Awake () {
        GameManager.instance = this;
        keyNum = 2;
	}
}
