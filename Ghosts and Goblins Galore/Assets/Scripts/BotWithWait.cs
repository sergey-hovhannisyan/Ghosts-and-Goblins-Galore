using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotWithWait : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent _newNavMeshAgent;
    GameObject player;

    private bool chase = false;

    void Start()
    {
        _newNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void StartChase(){
        chase = true;
        StartCoroutine(ChasePlayer());
    }

    IEnumerator ChasePlayer()
    {
        while (chase)
        {
        _newNavMeshAgent.destination = player.transform.position;
        yield return new WaitForSeconds(1);
        }
    }
}
