using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Lift : MonoBehaviour
{
    //lift asset 1
    public Rigidbody2D elevator;

    public float speed;
    private float elevatorPosition;
    private bool isButtonPressed;

    private void Start()
    {
        elevatorPosition = 1;
        isButtonPressed = false;
    }

    private void Update()
    {
        if (isButtonPressed)
        {
            elevator.transform.position = new Vector2(transform.position.x, transform.position.y + elevatorPosition);
        }
    }

    //elevator moves up while button stepped on
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Button is being pressed");

            //move elevator
            isButtonPressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Button Left");

            //move elevator back
            isButtonPressed = false;
        }
    }
}
