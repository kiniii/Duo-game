using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDoor : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;
    public GameObject dustStorm;

    private void Start()
    {
        ParticleSystem dustParticles = GetComponent<ParticleSystem>();
        dustStorm.SetActive(false);
    }
    public void firstDoorOpen()
    {
        dustParticles.Play();
        dustStorm.SetActive(true);
        Debug.Log("doors opened");
        GetComponent<Animator>().SetBool("openDoor", true);
    }
}
