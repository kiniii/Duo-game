using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class PresurePlatePuzzle : MonoBehaviour
{

    PresurePlate[] plates;
    PresurePlate plate;
    ObjectPlate[] cube;
    ObjectPlate cubes;
    Player player;

    bool door3 = false;
    bool puzzleSolved = false;

    // Start is called before the first frame update
    public void Start()
    {
        player = FindObjectOfType<Player>();
        GetComponentsInChildren<PresurePlate>();
        plates = GetComponentsInChildren<PresurePlate>();
        plate = GetComponentInChildren<PresurePlate>();
        GetComponentsInChildren<ObjectPlate>();
        cube = GetComponentsInChildren<ObjectPlate>();
        cubes = GetComponentInChildren<ObjectPlate>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (PresurePlate platesCheck in plates)
        {
            //Debug.Log(platesCheck.platePuzzle);
        }

        foreach (ObjectPlate cubeCheck in cube)
        {
            if (Input.GetButton("joystick button 2"))
            {
                cubes.DropTheCube(cubeCheck.cubeNumber);
            }
            //Debug.Log(cubeCheck.cubeNumber + cubeCheck.objectPickedUp.ToString());
            if (cube[cubeCheck.cubeNumber].objectPickedUp == true)
            {
                Debug.Log(cubeCheck.cubeNumber);
                //makes the cube visible in the players hand
                player.PlayerPicksUpACube(cubeCheck.cubeNumber);
                //destroys the cube when picked up
                cubes.DestroyTheCube(cubeCheck.cubeNumber);
                //let the code only do something when holding a cube
                //PutObjectOnPresurePlate();
            }
        }
    }

    public void HoldingACube(bool objectPickedUp)
    {
        if (objectPickedUp == true)
        {
            plate.PutOnPlate();
        }
        if (objectPickedUp == false)
        {
            plate.PickOffPlate();
        }
    }

    private void PutObjectOnPresurePlate()
    {
        //need fix
        if (puzzleSolved == true)
        {
            puzzleSolved = true;
            CheckDoorPuzzlePresurePlate();
        }
    }

    private void CheckDoorPuzzlePresurePlate()
    {
        if (door3 == false)
        {
            if (puzzleSolved == true)
            {
                OpenDoor();
            }
        }
    }

    private void OpenDoor()
    {
        door3 = true;
        //leverToOpenDoor.checkOpenDoors2(door2);
    }
}
