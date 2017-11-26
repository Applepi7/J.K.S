using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float speed = 10.0f;

	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	void Update ()
    {
        float hAxis = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vAxis = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(hAxis, 0f, vAxis);
	}
}
