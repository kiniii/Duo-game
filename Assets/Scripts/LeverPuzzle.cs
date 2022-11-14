using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;


public class LeverPuzzle : MonoBehaviour
{
    OpeningDoors leverToOpenDoor;
    bool door2 = false;
    Levers[] levers;
    public CameraShake cameraShake;

    public void Start()
    {
        leverToOpenDoor = FindObjectOfType<OpeningDoors>();
        GetComponentsInChildren<Levers>();
        levers = GetComponentsInChildren<Levers>();
    }

    private void Update()
    {
        foreach (Levers leverCheck in levers)
        {
            //Debug.Log(leverCheck.leverNumber + leverCheck.leverState.ToString());
        }
        CheckDoorPuzzleLevers();
    }

    private void CheckDoorPuzzleLevers()
    {
        if (door2 == false)
        {
            if (levers[0].leverState == true &&
                        levers[1].leverState == false &&
                        levers[2].leverState == false &&
                        levers[3].leverState == false &&
                        levers[4].leverState == true &&
                        levers[5].leverState == true)
            {
                StartCoroutine(cameraShake.ScreenShake(6f));
                OpenDoor();
            }
        }
    }

    private void OpenDoor()
    {
        door2 = true;
        leverToOpenDoor.checkOpenDoors2(door2);
    }
}
