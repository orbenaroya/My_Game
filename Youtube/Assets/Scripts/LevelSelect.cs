using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button[] LevelButtons;
    public int NextLevel = 2;


    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for (int i = 0; i < LevelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                LevelButtons[i].interactable = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 10)
        {
            {
                SceneManager.LoadScene(1);
                PlayerPrefs.SetInt("levelReached", NextLevel);
            }
        }
    }

    public void LevelSelection(int LevelNum)
    {
        SceneManager.LoadScene(LevelNum + 1);
    }

}
