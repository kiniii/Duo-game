using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levers : MonoBehaviour
{
    LeverPuzzle rightLever;
    public AudioSource source;
    public AudioClip clip;

    public bool leverState = false;
    [SerializeField] public int leverNumber = 0;
    

    public void Start()
    {
        rightLever = FindObjectOfType<LeverPuzzle>();
    }

    public void WhatLever()
    {
        if (leverState == false)
        {
            PutLeverUp();
        }
        else if (leverState == true)
        {
            PutLeverDown();
        }
        //particles
        source.PlayOneShot(clip);
        //sound
        //correct sound

    }

    private void PutLeverUp()
    {
        //when the lever is put in the upstate
        leverState = true;
        GetComponent<Animator>().SetBool("leverstate", true);
    }

    private void PutLeverDown()
    {
        //when the lever is put in the downstate
        leverState = false;
        GetComponent<Animator>().SetBool("leverstate", false);
    }
}
