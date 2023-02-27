using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotWithoutNavMesh : MonoBehaviour
{
    Rigidbody _rigidbody;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.002f);
        
    }
}
