using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button[] LevelButtons;
    public static int NextLevel = 1;
    int levelReached = 1;

    void Start()
    {
        Debug.Log(NextLevel);
        Debug.Log(levelReached);
        for (int i = 0; i < LevelButtons.Length; i++)
        {
            if (i + 1 > NextLevel)
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
                SetLevel(levelReached++);
                SceneManager.LoadScene(1);
            }
        }
    }

    public void LevelSelection(int LevelNum)
    {
        SceneManager.LoadScene(LevelNum + 1);
    }

    public int GetLevel()
    {
        return levelReached;
    }

    public int SetLevel(int NewlevelReached)
    {
        NextLevel = NewlevelReached;
        return NextLevel;
    }
}
