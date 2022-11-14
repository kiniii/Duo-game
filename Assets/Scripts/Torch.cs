using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class Torch : MonoBehaviour
{
    CanLightBraziers lightThemUp;
    Player player;

    bool holdingTorch = false;
    public AudioSource source;
    public AudioClip clip;

    public void Start()
    {
        lightThemUp = FindObjectOfType<CanLightBraziers>();
        player = FindObjectOfType<Player>();
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
    }

    public void HoldingTheTorch()
    {
        player.HoldTorch();
        source.Play();
        holdingTorch = true;
    }

    public void TorchDropped()
    {
        player.DropTorch();
        holdingTorch = false;
    }
}
