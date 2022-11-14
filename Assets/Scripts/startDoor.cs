using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDoor : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public AudioClip clip2;

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
        source.PlayOneShot(clip);
        source.PlayOneShot(clip2);
        GetComponent<Animator>().SetBool("openDoor", true);
    }
}
