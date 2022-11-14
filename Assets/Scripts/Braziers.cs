using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Braziers : MonoBehaviour
{
    [SerializeField] GameObject lightOfBrazier;
    public AudioSource source;
    public AudioClip clip;

    bool canLightBrazier = false;

    private void Start()
    {
        lightOfBrazier.SetActive(false);
    }

    private void Update()
    {
        //when the torch is dropped
        if(Input.GetButton("joystick button 2"))
        {
            canLightBrazier = false;
        }
    }

    public void LightBrazier()
    {
        //knows that the player is holding a torch
        canLightBrazier = true;
    }

    public void WhatBrazier()
    {
        //looks which brazier the player is interacting with
        if (canLightBrazier == true)
        {
            SetBrazierOnFire();
        }
        //sound
    }

    private void SetBrazierOnFire()
    {
        //plays the sound and the particle effect
        lightOfBrazier.SetActive(true);
        source.Play();
    }
}
