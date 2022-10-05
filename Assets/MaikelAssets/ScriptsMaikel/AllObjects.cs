using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllObjects : MonoBehaviour
{
    [SerializeField] Torch torch;
    [SerializeField] HiddenButton hiddenButton;
    [SerializeField] Braziers brazier;
    [SerializeField] Levers lever;
    [SerializeField] int objectType = 0;

    public void WhatObject()
    {
        switch (objectType)
        {
            
            case 0: //buttons
                hiddenButton.ButtonPressed();
                break;
            case 1: //torches
                brazier.WhatBrazier();
                break;
            case 2: //levers
                lever.WhatLever();
                break;
            case 3: //braziers
                torch.WhatTorch();
                break;
            default:
                
                break;
        }
        
    }
}
