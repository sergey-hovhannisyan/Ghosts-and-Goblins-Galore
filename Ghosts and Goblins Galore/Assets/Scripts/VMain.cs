using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VMain : MonoBehaviour
{
    public AudioClip fwSnd;
    public GameObject confetti;
    AudioSource _audioSource;


    IEnumerator Start()
    {
        _audioSource = GetComponent<AudioSource>();

        StartCoroutine(StopSound());
        InvokeRepeating("PlaySound", 1, 1);

        yield return new WaitForSeconds(9);
        Vector2 spawnPos = new Vector2(0, 12);
        Instantiate(confetti, spawnPos, Quaternion.identity);
        Instantiate(confetti, spawnPos, Quaternion.identity);
    }


    void PlaySound()
    {
        _audioSource.PlayOneShot(fwSnd);
    }


    IEnumerator StopSound(){
        yield return new WaitForSeconds(10);
        CancelInvoke();
    }
}
