using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour {

    [SerializeField]
    private Text keyText;

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        keyText.text = "Keys " + GameManager.instance.keyNum + "/7";
    }
}
