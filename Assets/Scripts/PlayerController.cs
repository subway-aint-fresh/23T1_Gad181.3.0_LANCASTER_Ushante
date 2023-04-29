using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode jumpKey;

    private Rigidbody2D rb;
    private AudioSource jumpAudio;

    [SerializeField] private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        float moveDirection = 0f;

        if (Input.GetKey(leftKey))
        {
            moveDirection = -1f;
        }
        else if (Input.GetKey(rightKey))
        {
            moveDirection = 1f;
        }

        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(jumpKey) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
            jumpAudio.Play();
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}  
