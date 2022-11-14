using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionWithObject : MonoBehaviour
{
    //range to need close by for the player
    [SerializeField] float playerNearby = 2f;
    Transform target;
    AllObjects obj;
    float distanceToTarget = Mathf.Infinity;
    bool isTextOwner = false;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<Player>().transform;
        obj = GetComponent<AllObjects>();
    }

    // Update is called once per frame
    void Update()
    {
        //looking at the players location
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        //if the player is nearby an object
        if (distanceToTarget <= playerNearby)
        {
            target.GetComponent<InteractText>().PlayerNearObject();
            isTextOwner = true;
            if (Input.GetButton("joystick button 0"))
            {
                obj.GetComponent<AllObjects>().WhatObject();
            }
        }

        //if the player is not nearby an object
        if(distanceToTarget >= playerNearby && isTextOwner)
        {
            target.GetComponent<InteractText>().PlayerNotNearObject();
            isTextOwner = false;
        }
    }

    //seeing the range of the object
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, playerNearby);
    }
}
