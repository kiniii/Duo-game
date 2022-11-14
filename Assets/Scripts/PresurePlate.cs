using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresurePlate : MonoBehaviour
{
    [SerializeField] public int plateNumber = 0;
    [SerializeField] GameObject cubeOnPlate;

    public bool placedObject = false;
    public bool cubeCheck = false;
    Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        cubeOnPlate.SetActive(false);
    }

    public void InteractPresurePlate()
    {
        if (Input.GetButton("joystick button 0") && placedObject == false)
        {
            player.AllBlocksInvisible();
            PlaceTheObject();
        }
        if(Input.GetButton("joystick button 0") && placedObject == true)
        {
            
        }
    }

    public void PutOnPlate()
    {
        placedObject = true;
    }

    public void PickOffPlate()
    {
        placedObject = false;
    }

    private void PlaceTheObject()
    {
        if(placedObject == true)
        {
            cubeOnPlate.SetActive(false);
        }
        if(placedObject == false)
        {
            cubeOnPlate.SetActive(true);
            player.AllBlocksInvisible();
        }
    }

    
}
