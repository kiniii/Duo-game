using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiddenButton : MonoBehaviour
{
    OpeningDoors pressedButton;
    public CameraShake cameraShake;
    public AudioSource source;
    public AudioClip clip;

    bool door1 = false;

    private void Start()
    {
        pressedButton = FindObjectOfType<OpeningDoors>();
    }

    public void ButtonPressed()
    { 
        //sound
        source.PlayOneShot(clip);
        //Doing the camerashake and the duration of the shake
        StartCoroutine(cameraShake.ScreenShake(5f));
        OpenDoor();
    }

    private void OpenDoor()
    {
        //communicates with the door script
        door1 = true;
        pressedButton.checkOpenDoors(door1);
    }
}
