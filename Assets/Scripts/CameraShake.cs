using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class CameraShake : MonoBehaviour
{
    PlayerIndex playerIndex;
    GamePadState state;
    GamePadState prevState;

    public IEnumerator ScreenShake (float duration)
    {
        Vector3 originalPos = transform.localPosition;
        float elapsed = 0.0f;

        //the loop for the duration of the screenshake
        if (Input.GetButton("joystick button 0"))
        {
            while(elapsed < duration)
            {
                float x = Random.Range(-.05f, .05f);
                float y = Random.Range( 0.60f, 0.65f);

                transform.localPosition = new Vector3(x, y, originalPos.z);

                //updating loop valuable
                elapsed += Time.deltaTime;

                //waiting for the next frame
                yield return null;

                GamePad.SetVibration(playerIndex, 1f, 1f);
            }
            GamePad.SetVibration(playerIndex, 0f, 0f);
        }

        transform.localPosition = originalPos;
    }
}
