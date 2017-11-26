using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 100 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider col)
    {
        GameManager.instance.keyNum -= 1;
        gameObject.SetActive(false);
    }
}
