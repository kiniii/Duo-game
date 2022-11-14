using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractText : MonoBehaviour
{
    [SerializeField] Canvas text;
    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
    }

    public void PlayerNearObject()
    {
        text.enabled = true;
    }

    public void PlayerNotNearObject()
    {
        text.enabled = false;
    }
}
