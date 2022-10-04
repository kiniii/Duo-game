using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levers : MonoBehaviour
{
    LeverPuzzle rightLever;


    bool leverState = false;
    [SerializeField] int leverNumber = 0;
    bool lever1 = false;
    bool lever2 = false;
    bool lever3 = false;
    bool lever4 = false;


    public void Start()
    {
        rightLever = FindObjectOfType<LeverPuzzle>();
    }

    public void Update()
    {
        rightLever.LeverPuzzleChecker(lever1, lever2, lever3, lever4);
    }

    public void WhatLever()
    {
        switch (leverNumber)
        {
            case 0: //lever 1
                if (leverState == false)
                {
                    PutLeverUp();
                    Debug.Log("Lever1 up");
                    lever1 = true;
                }
                else if (leverState == true)
                {
                    PutLeverDown();
                    Debug.Log("Lever1 down");
                    lever1 = false;
                }
                break;
            case 1: //lever 2
                if (leverState == false)
                {
                    PutLeverUp();
                    Debug.Log("Lever2 up");
                    lever2 = true;
                }
                else if (leverState == true)
                {
                    PutLeverDown();
                    Debug.Log("Lever2 down");
                    lever2 = false;
                }
                break;
            case 2: //lever 3
                if (leverState == false)
                {
                    PutLeverUp();
                    Debug.Log("Lever3 up");
                    lever3 = true;
                }
                else if (leverState == true)
                {
                    PutLeverDown();
                    Debug.Log("Lever3 down");
                    lever3 = false;
                }
                break;
            case 3: //lever 4
                if (leverState == false)
                {
                    PutLeverUp();
                    Debug.Log("Lever4 up");
                    lever4 = true;
                }
                else if (leverState == true)
                {
                    PutLeverDown();
                    Debug.Log("Lever4 down");
                    lever4 = false;
                }
                break;
            default:

                break;
        }
        //particles
        //sound
        //correct sound

    }

    private void PutLeverUp()
    {
        leverState = true;
        GetComponent<Animator>().SetBool("leverstate", true);
        //animation
    }

    private void PutLeverDown()
    {
        leverState = false;
        GetComponent<Animator>().SetBool("leverstate", false);
        //animation
    }

    public void PuzzleSolved()
    {
        Debug.Log("Hoera");
    }
}