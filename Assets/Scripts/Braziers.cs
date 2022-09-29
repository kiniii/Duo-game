using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Braziers : MonoBehaviour
{
    [SerializeField] int brazierNumber = 0;
    [SerializeField] private Material myMaterial;

    bool canLightBrazier = false;

    private void Start()
    {
        myMaterial.color = Color.black;
    }

    public void LightBrazier()
    {
        canLightBrazier = true;
    }

    public void WhatBrazier()
    {
        if (canLightBrazier == true)
        {
            switch (brazierNumber)
            {
                case 0: //brazier 1
                    SetBrazierOnFire();
                    break;
                case 1: //brazier 2
                    SetBrazierOnFire();
                    break;
                case 2: //brazier 3
                    SetBrazierOnFire();
                    break;
                case 3: //brazier 4
                    SetBrazierOnFire();
                    break;
                default:

                    break;
            }
        }

        //particles
        //sound

    }

    private void SetBrazierOnFire()
    {
        Debug.Log("Lit");
        myMaterial.color = Color.red;
    }
}
