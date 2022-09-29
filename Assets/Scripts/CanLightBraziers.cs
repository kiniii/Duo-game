using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanLightBraziers : MonoBehaviour
{ 
    [SerializeField] Torch torch;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            BroadcastMessage("TorchDropped");
        }
    }

    public void LightUpBrazierIfHoldingTorch()
    {
            BroadcastMessage("LightBrazier");
    }
}
