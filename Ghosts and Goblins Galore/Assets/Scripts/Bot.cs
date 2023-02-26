using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent _newNavMeshAgent;
    GameObject player;

    void Start()
    {
        _newNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(ChasePlayer());
    }

    IEnumerator ChasePlayer()
    {
        while (true)
        {
        yield return new WaitForSeconds(1);
        _newNavMeshAgent.destination = player.transform.position;
        }
    }
}
