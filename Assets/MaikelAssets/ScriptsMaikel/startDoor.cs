using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDoor : MonoBehaviour
{
    public void firstDoorOpen()
    {
        Debug.Log("doors opened");
        GetComponent<Animator>().SetBool("openDoor", true);
    }
}
