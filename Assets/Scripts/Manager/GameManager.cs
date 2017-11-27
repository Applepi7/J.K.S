using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public int keyNum;

	// Use this for initialization
	void Awake () {
        GameManager.instance = this;
        keyNum = 0;
	}

    public void Cheat()
    {
        if(Input.GetKey(KeyCode.K))
        {
            keyNum += 1;
            if (keyNum + 1 >= 7) keyNum = 7;

            UIManager.instance.isShowText = true;
        }
    }
}
