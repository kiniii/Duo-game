using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObjectPlate : MonoBehaviour
{
    public bool objectPickedUp = false;
    [SerializeField] public int cubeNumber = 0;
    Player player;
    PresurePlatePuzzle platePuzzle;
    public GameObject[] cubies;

    int whatCube = 0;
    private float i = 0.5f;

    // Start is called before the first frame update
    public void Start()
    {
        player = FindObjectOfType<Player>();
        platePuzzle = GetComponentInParent<PresurePlatePuzzle>();
    }

    private void Update()
    {
        if (Input.GetButton("joystick button 2") && objectPickedUp == true)
        {
            objectPickedUp = false;
        }
    }

    // Update is called once per frame
    public void ObjectState()
    {
        if(objectPickedUp == false)
        {
            objectPickedUp = true;
            platePuzzle.HoldingACube(objectPickedUp);
        }
        
    }

    public void DestroyTheCube(int cube)
    {
        switch (cube)
        {
            case 0:
                whatCube = 0;
                break;
            case 1:
                whatCube = 1;
                break;
            case 2:
                whatCube = 2;
                break;
            case 3:
                whatCube = 3;
                break;
            default:

                break;
        }
        cubies[whatCube].transform.position = new Vector3(-50, 0, 0);
    }

    public void DropTheCube(int cube)
    {
        if(objectPickedUp == true)
        {
            Debug.Log("Dropped");
            cubies[whatCube].transform.position = new Vector3(player.transform.position.x, player.transform.position.y - i, player.transform.position.z + -2);
        }
    }
}
