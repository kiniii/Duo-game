using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanLightBraziers : MonoBehaviour
{ 
    [SerializeField] Torch torch;

    public void Update()
    {
        //drops the torch 
        if(Input.GetButton("joystick button 2"))
        {
            BroadcastMessage("TorchDropped");
        }
    }

    public void LightUpBrazierIfHoldingTorch(bool holdingTorch)
    {
        //looks if the player is holding the torch
        if(holdingTorch == true)
        {
            //sends the green light to the braziers
            BroadcastMessage("LightBrazier");
            return;
        }
    }
}
