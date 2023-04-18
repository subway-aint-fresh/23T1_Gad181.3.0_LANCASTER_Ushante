using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public float speed; // The speed of the platform
    public Transform targetPoint; // The point the platform should move to

    private bool movePlatform;
    private Vector3 initialPosition;

    public Rigidbody2D platform;

    private void Start()
    {
        initialPosition = platform.transform.position;
        movePlatform = false;
    }

    private void Update()
    {
        if (movePlatform)
        {
            platform.transform.position = Vector2.MoveTowards(platform.transform.position, targetPoint.position, speed * Time.deltaTime);

            if (platform.transform.position == targetPoint.position)
            {
                movePlatform = false;
            }
        }
    }

    private void FixedUpdate(){
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            // Set the movePlatform to true to start moving the platform
            movePlatform = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            // Set the movePlatform to false to stop moving the platform
            movePlatform = false;

            // Reset the platform's position to the initial position
            platform.transform.position = initialPosition;
        }
    }
}
