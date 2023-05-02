using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift3 : MonoBehaviour
{
    public float speed; // The speed of the platform
    public Transform targetPoint1; // The point the platform should move to
    public Transform targetPoint2; // The point the platform should move back to
    public GameObject button1; 

    private bool movePlatformUp;
    private bool movePlatformDown;

    public GameObject platform;

    private void Start()
    {
        movePlatformUp = false;
        button1.SetActive(true);
    }

    private void FixedUpdate()
    {
        if (movePlatformUp)
        {
            platform.transform.position = Vector2.MoveTowards(platform.transform.position, targetPoint1.position, speed * Time.deltaTime);

            if (platform.transform.position == targetPoint1.position)
            {
                movePlatformUp = false;
            }
        }

        if (movePlatformDown)
        {
            platform.transform.position = Vector2.MoveTowards(platform.transform.position, targetPoint2.position, speed * Time.deltaTime);

            if (platform.transform.position == targetPoint2.position)
            {
                movePlatformDown = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            // Set button 1 inactive
            button1.SetActive(false);

            // Set the movePlatform to true to start moving the platform
            movePlatformUp = true;
            movePlatformDown = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            // Set button 1 active again
            button1.SetActive(true);

            movePlatformUp = false;
            movePlatformDown = true;

        }
    }
}
