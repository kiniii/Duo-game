using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject cube1;
    [SerializeField] GameObject cube2;
    [SerializeField] GameObject cube3;
    [SerializeField] GameObject cube4;
    [SerializeField] GameObject torch;

    public AudioSource source;

    public AudioClip clip;
    public AudioClip clip2;

    private void Start()
    {
        AllBlocksInvisible();
        DropTorch();
    }

    private void Update()
    {
        if (Input.GetButton("joystick button 2"))
        {
            AllBlocksInvisible();
            DropTorch();
        }
    }

    public void HoldTorch()
    {
        torch.SetActive(true);
    }

    public void DropTorch()
    {
        torch.SetActive(false);
    }

    public void AllBlocksInvisible()
    {
        cube1.SetActive(false);
        cube2.SetActive(false);
        cube3.SetActive(false);
        cube4.SetActive(false);
    }

    public void PlayerPicksUpACube(int cube)
    {
            switch (cube)
            {
                case 0:
                    cube1.SetActive(true);
                    cube2.SetActive(false);
                    cube3.SetActive(false);
                    cube4.SetActive(false);
                break;
                case 1:
                    cube2.SetActive(true);
                    cube1.SetActive(false);
                    cube3.SetActive(false);
                    cube4.SetActive(false);
                break;
                case 2:
                    cube3.SetActive(true);
                    cube2.SetActive(false);
                    cube1.SetActive(false);
                    cube4.SetActive(false);
                break;
                case 3:
                    cube4.SetActive(true);
                    cube2.SetActive(false);
                    cube3.SetActive(false);
                    cube1.SetActive(false);
                break;
                default:

                    break;
            }
        
    }

    private void OnTriggerEnter(Collider hint)
    {
        if (hint.CompareTag("Hint") && hint)
        {
            inRoom = true;
            StartCoroutine(TimeForHintToStart());
        }
    }

    private void OnTriggerExit(Collider hint)
    {
        if (hint.CompareTag("Hint") && hint)
        {
            inRoom = false;
        }
    }

    IEnumerator TimeForHintToStart()
    {
        Debug.Log("entered the puzzle room");
        //wait 60 seconds for first hint
        yield return new WaitForSeconds(60);
        if (inRoom == true)
        {
            PlayAudioHint1();
        }
        //wait 60 seconds for second hint
        yield return new WaitForSeconds(60);
        if (inRoom == true)
        {
            PlayAudioHint2();
        }

    }

    private void PlayAudioHint1()
    {
        Debug.Log("gives player first hint");
        source.PlayOneShot(clip);
    }

    private void PlayAudioHint2()
    {
        Debug.Log("gives player second hint hint");
        source.PlayOneShot(clip2);
    }
    private bool inRoom = false;
}
