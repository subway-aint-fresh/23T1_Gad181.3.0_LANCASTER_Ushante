using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyPanel : MonoBehaviour
{
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode jumpKey;
    public bool leftKeyPress = false;
    public bool rightKeyPress = false;
    public bool jumpKeyPress = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(leftKey))
        {
            leftKeyPress = true;
        }
        if (Input.GetKeyDown(rightKey))
        {
            rightKeyPress = true;
        }
        if (Input.GetKeyDown(jumpKey))
        {
            jumpKeyPress = true; //If these three buttons are pressed, the panel will disappear
        }
        if (leftKeyPress == true && rightKeyPress == true && jumpKeyPress == true)
        {
            gameObject.SetActive(false);
        }
    }
}
