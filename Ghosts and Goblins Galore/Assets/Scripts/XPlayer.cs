using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class XPlayer : MonoBehaviour
{
    NavMeshAgent _newNavMeshAgent;
    Camera mainCam;

    void Start()
    {
        _newNavMeshAgent = GetComponent<NavMeshAgent>();
        mainCam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200))
            {
                // print(hit.point);
                _newNavMeshAgent.destination = hit.point;
            }
        }
    }
}
