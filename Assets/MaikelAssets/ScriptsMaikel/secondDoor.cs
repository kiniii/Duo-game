using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondDoor : MonoBehaviour
{
    public void secondDoorOpen()
    {
        Debug.Log("doors opened");
        GetComponent<Animator>().SetBool("openDoor", true);
    }
}
