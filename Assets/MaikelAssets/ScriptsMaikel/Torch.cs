using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class Torch : MonoBehaviour
{
    CanLightBraziers lightThemUp;
    [SerializeField] ParticleSystem fireParticles;

    bool holdingTorch = false;

    public void Start()
    {
        lightThemUp = FindObjectOfType<CanLightBraziers>();
    }

    public void Update()
    {
        if (holdingTorch == true)
        {
            lightThemUp.LightUpBrazierIfHoldingTorch(holdingTorch);
        }
    }

    public void WhatTorch()
    {
        HoldingTheTorch();
        fireParticles.Play();
        //sound
    }

    public void HoldingTheTorch()
    {
        Debug.Log("Holding a torch");
        holdingTorch = true;
    }

    public void TorchDropped()
    {
        Debug.Log("Dropped a torch");
        holdingTorch = false;
    }
}