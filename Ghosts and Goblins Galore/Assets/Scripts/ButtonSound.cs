using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonSound : MonoBehaviour
{
    public AudioSource soundPlayer;

    public void playThisSoundEffect()
    {
        soundPlayer.Play();
    }
}
