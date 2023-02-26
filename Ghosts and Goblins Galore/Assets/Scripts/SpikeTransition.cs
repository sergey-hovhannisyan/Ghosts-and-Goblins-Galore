using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTransition : MonoBehaviour
{
    public Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other){

        if (other.CompareTag("Player")){
            myAnimator.Play("Open Trap");
        }
        

    }

    private void OnTriggerExit(Collider other){
        if(other.CompareTag("Player")){
            myAnimator.Play("Close Trap");
        }
        
    }


}
