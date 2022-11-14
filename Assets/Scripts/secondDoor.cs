using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondDoor : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    [SerializeField] ParticleSystem dustParticles;
    public GameObject dustStorm;

    private void Start()
    {
        ParticleSystem dustParticles = GetComponent<ParticleSystem>();
        dustStorm.SetActive(false);
    }

    public void secondDoorOpen()
    {
        dustParticles.Play();
        dustStorm.SetActive(true);
        source.PlayOneShot(clip);
        GetComponent<Animator>().SetBool("openDoor", true);
        
    }
}
