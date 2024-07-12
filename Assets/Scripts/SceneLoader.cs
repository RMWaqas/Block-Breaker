using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentIndexScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndexScene + 1);
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }    
    public void QuitGame()
    {
        Application.Quit();
    }
}
