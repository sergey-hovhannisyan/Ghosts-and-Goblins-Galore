using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Main : MonoBehaviour
{
    public GameObject ball;

    void Start()
    {
        InvokeRepeating("DropBall", 2, 2);
    }

    void DropBall()
    {
        Vector3 spawnPos = new Vector3(13, 8, 8);
        Instantiate(ball, spawnPos, Quaternion.identity);
    }
}
