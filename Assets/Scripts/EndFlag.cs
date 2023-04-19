using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFlag : MonoBehaviour
{ 
    public GameObject player1;
    public GameObject player2;

    public GameObject winScreen;

    private bool player1Triggered = false;
    private bool player2Triggered = false;

    // This method is called when a player enters the trigger area
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player1)
        {
            Debug.Log("area entered by p1");
            player1Triggered = true;
        }
        else if (other.gameObject == player2)
        {
            Debug.Log("area entered by p2");
            player2Triggered = true;
        }

        // If both players have triggered the win condition, show the win screen
        if (player1Triggered && player2Triggered)
        {
            player1.SetActive(false);
            player2.SetActive(false);
            winScreen.SetActive(true);
            
        }
    }
}
