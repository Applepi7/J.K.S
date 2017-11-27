using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager instance;

    [SerializeField]
    private AudioSource pickUpSound;

    [SerializeField]
    private AudioSource endingSound;

    [SerializeField]
    private AudioSource enemyAttackSound;

    // Use this for initialization
    void Awake()
    {
        SoundManager.instance = this;
    }

    public void PlayPickUpSound()
    {
        pickUpSound.Play();
    }

    public void PlayEndingSound()
    {
        endingSound.Play();
    }

    public void PlayEnemyAttackSound()
    {
        enemyAttackSound.Play();
    }

}
