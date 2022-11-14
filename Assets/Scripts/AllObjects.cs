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
    [SerializeField] PresurePlate plate;
    [SerializeField] ObjectPlate cube;
    [SerializeField] int objectType = 0;

    public void WhatObject()
    {
        switch (objectType)
        {
            
            case 0: //buttons
                hiddenButton.ButtonPressed();
                //plays the animation of the button
                GetComponent<Animator>().SetBool("press", true);
                break;
            case 1: //braziers
                brazier.WhatBrazier();
                break;
            case 2: //levers
                lever.WhatLever();
                break;
            case 3: //torches
                torch.WhatTorch();
                break;
            case 4: //plates
                cube.ObjectState();
                break;
            case 5: //objects
                plate.InteractPresurePlate();
                break;
            default:
                
                break;
        }
        
    }
}
