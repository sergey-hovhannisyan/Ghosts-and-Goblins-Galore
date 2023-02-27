using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject player;
    
    Vector3 offset;

    private void Start(){
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
    }

    private void LateUpdate(){
        transform.position = player.transform.position + offset;
        // transform.LookAt(player.transform.position);
    }
}
