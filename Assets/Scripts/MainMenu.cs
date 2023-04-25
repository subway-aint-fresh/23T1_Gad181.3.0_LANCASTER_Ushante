using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
   public void onStartGameButtonPress()
    {
        //change this to initialize so it can be changed within editor
        SceneManager.LoadScene("Level_1");
    }
}
