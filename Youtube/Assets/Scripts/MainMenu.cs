using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    LevelSelect levelselect;
    
    public void Start()
    {
        levelselect = FindObjectOfType<LevelSelect>().GetComponent<LevelSelect>();
        levelselect.SetLevel(1);
    }

    public void PlayGame()
    {
        PlayerPrefs.SetInt("levelReached", 1);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
