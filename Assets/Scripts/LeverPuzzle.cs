using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class LeverPuzzle : MonoBehaviour
{

    public void LeverPuzzleChecker(bool lever1, bool lever2, bool lever3, bool lever4)
    {
        //Debug.Log(lever1);
        //Debug.Log(lever2);
        //Debug.Log(lever3);
        //Debug.Log(lever4);
        if (lever1 == true)
        {
            Debug.Log("Right sequenze");
            OpenDoor();
            BroadcastMessage("PuzzleSolved");
        }
        else
        {
            return;
        }
        
    }

    private void OpenDoor()
    {
        Debug.Log("doors opened");
    }
}
