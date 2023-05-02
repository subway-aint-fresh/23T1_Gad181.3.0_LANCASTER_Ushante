using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour
{
    public GameObject nextLevelButton;
    private void OnEnable()
    {
        int numberOfLevels = SceneManager.sceneCount;
        int indexOfCurrentScene = SceneManager.GetActiveScene().buildIndex;
        if (indexOfCurrentScene >= numberOfLevels + 1)
        {
            nextLevelButton.SetActive(false);
        }
    }
    public void OnNextLevelButtonPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void OnMenuButtonPress()
    {
        SceneManager.LoadScene("StartingMenu");
    }
        
}
