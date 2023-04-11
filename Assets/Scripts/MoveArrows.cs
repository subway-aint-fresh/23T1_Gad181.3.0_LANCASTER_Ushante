using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrows : MonoBehaviour
{
    public float Speed;

    float MovementX;
    float MovementY;

    private Rigidbody2D Rb;
    private Rigidbody2D Rb2;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Rb2 = transform.GetComponent<Rigidbody2D>();
        MovementX = 0;
        MovementY = 0;
    }

    // Update is called once per frame
    void Update()
    {
      Rb.velocity = new Vector2 ( MovementX * Speed * Time.deltaTime, MovementY * Speed * Time.deltaTime );
      
         //jump
        if (Input.GetKeyDown( KeyCode.UpArrow ) ) 
        {
            float jumpVelocity = 60f;
            Rb2.velocity = Vector2.up * jumpVelocity;
        }

        if (Input.GetKeyDown( KeyCode.LeftArrow ) )
        {
            MovementX = -1;
        }

        if (Input .GetKeyDown( KeyCode.RightArrow ) )
        {
            MovementX = 1;
        }


      //makes sure that the controller doesnt continue to move after the buttons finished being pushed

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            MovementX = 0;
        }
    }
}
