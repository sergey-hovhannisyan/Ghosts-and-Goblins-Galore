using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class PlayerController: MonoBehaviour
{
    private NavMeshAgent _newNavMeshAgent;
    private Camera mainCam;

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
                _newNavMeshAgent.destination = hit.point;
            }
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Key"))
    //    {
    //        int keyNum = Int32.Parse(other.name.Substring(3)); // all key must be named "Key" andm numner "Key0"
    //        Destroy(other.gameObject);
    //        PublicVars.hasKey[keyNum] = true;
    //    }
}