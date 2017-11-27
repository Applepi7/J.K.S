using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    private Transform destination;

    [SerializeField]
    private Transform defaultPos;

    NavMeshAgent nav;

    bool seePlayer;

	void Start ()
    {
        seePlayer = false;
	}

    void SetDestination()
    {
        if (destination != null && seePlayer)
        {
            Vector3 targetVector = destination.transform.position;
            nav.SetDestination(targetVector);
        }
        else
            nav.SetDestination(defaultPos.transform.position);
    }
	
	void Update ()
    {
        nav = this.GetComponent<NavMeshAgent>();
        if (nav == null)
        {
            print("ㅠㅠ");
        }
        else
        {
            SetDestination();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        seePlayer = true;
        SoundManager.instance.PlayEnemyAttackSound();
    }

    private void OnTriggerExit(Collider other)
    {
        seePlayer = false;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (LayerMask.LayerToName(col.gameObject.layer) == "Player")
        {
            UIManager.instance.isDead = true;
        }
    }
}
