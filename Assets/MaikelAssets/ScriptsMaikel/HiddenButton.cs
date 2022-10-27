using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiddenButton : MonoBehaviour
{
    //[SerializeField] ParticleSystem dustParticles;
    OpeningDoors pressedButton;
    bool door1 = false;

    public void Start()
    {
        pressedButton = FindObjectOfType<OpeningDoors>();
    }

    public void ButtonPressed()
    {
        GetComponent<Animator>().SetBool("press", true);
        //sound
        OpenDoor();
    }

    public void OpenDoor()
    {
        //particles
        //dustParticles.Play();
        //vibration
        //sound
        door1 = true;
        pressedButton.checkOpenDoors(door1);
    }
}
