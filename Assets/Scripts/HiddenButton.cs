using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiddenButton : MonoBehaviour
{
   
    public void ButtonPressed()
    {
        //GetComponent<Animator>().SetBool("press", true);
        //sound
        OpenDoor();
    }

    private void OpenDoor()
    {
        //particles
        //vibration
        //sound
        //GetComponent<Animator>().SetBool("openDoor", true);
        Debug.Log("Opened door");
    }
}
