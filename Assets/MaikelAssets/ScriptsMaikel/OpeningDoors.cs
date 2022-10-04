using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class OpeningDoors : MonoBehaviour
{
    startDoor firstDoor;
    secondDoor leverDoor;

    public void Start()
    {
        firstDoor = FindObjectOfType<startDoor>();
        leverDoor = FindObjectOfType<secondDoor>();
    }

    public void checkOpenDoors(bool door1)
    {
        if (door1 == true)
        {
            firstDoor.firstDoorOpen();
        }
    }

    public void checkOpenDoors2(bool door2)
    {
        if (door2 == true)
        {
            leverDoor.secondDoorOpen();
        }
    }
}
