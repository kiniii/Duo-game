using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class Torch : MonoBehaviour
{
    CanLightBraziers lightThemUp;

    bool holdingTorch = false;

    public void Start()
    {
        lightThemUp = GetComponent<CanLightBraziers>();
    }

    public void Update()
    {
        if (holdingTorch == true)
        {
            lightThemUp.LightUpBrazierIfHoldingTorch();
        }
    }

    public void WhatTorch()
    {
        HoldingTheTorch();
        //particles
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