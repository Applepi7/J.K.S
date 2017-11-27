using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameManager.instance.Cheat();
    }

    private void OnTriggerEnter(Collider col)
    {
        if(GameManager.instance.keyNum == 7)
        {
            UIManager.instance.isClear = true;
        }
    }
}
