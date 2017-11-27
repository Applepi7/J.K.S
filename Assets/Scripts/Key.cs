using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 100 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider col)
    {
        UIManager.instance.isShowText = true;

        GameManager.instance.keyNum += 1;
        SoundManager.instance.PlayPickUpSound();
        Destroy(gameObject);
    }

}
