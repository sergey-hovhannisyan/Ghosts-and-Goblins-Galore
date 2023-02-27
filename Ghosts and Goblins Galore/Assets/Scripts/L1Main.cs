using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Main : MonoBehaviour
{
    public GameObject ball;

    void Start()
    {
        InvokeRepeating("DropBall", 1, 3);
    }

    void DropBall()
    {
        Vector3 spawnPos = new Vector3(13, 5, 8);
        Instantiate(ball, spawnPos, Quaternion.identity);
        Destroy(gameObject, 5);
    }
}
