using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button[] LevelButtons;
    // Start is called before the first frame update
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

    public void Select(int levelNum)
    {
        SceneManager.LoadScene(levelNum + 1);
    }
}
