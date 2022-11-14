using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSwitch : MonoBehaviour
{
    public AudioMixerSnapshot inTemple;
    public AudioMixerSnapshot OutTemple;

    private float m_TransitionIn;
    private float m_TransitionOut;

    // Start is called before the first frame update
    void Start()
    {
        m_TransitionIn = 2f;
        m_TransitionOut = 2f;
    }

    void OnTriggerEnter(Collider temple)
    {
        if (temple.CompareTag("Temple") && temple)
        {
            inTemple.TransitionTo(m_TransitionIn);
        }
    }

    void OnTriggerExit(Collider temple)
    {
        if (temple.CompareTag("Temple") && temple)
        {
            OutTemple.TransitionTo(m_TransitionOut);
        }
    }
}
