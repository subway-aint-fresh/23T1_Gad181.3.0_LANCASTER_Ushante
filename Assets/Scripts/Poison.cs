using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.Build.Content;
using UnityEngine;

public class Poison : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;

    public GameObject endScreen; //end screen pop up

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerFeet"))
        {
            //endgame, throw up end screen
            Debug.Log("End game");

            p1.SetActive(false);
            p2.SetActive(false);
            endScreen.SetActive(true);

        }
    }
}
