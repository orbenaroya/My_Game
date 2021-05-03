using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button[] LevelButtons;
<<<<<<< HEAD
    public static int NextLevel = 1;
    int levelReached = 1;
    static int levelReachedmax = 1;
=======
    public int NextLevel = 2;
>>>>>>> parent of 7990a2f (no shop)


    void Start()
    {
<<<<<<< HEAD
        if (levelReached > levelReachedmax)
        {
            levelReachedmax = levelReached;
        }

        for (int i = 0; i < LevelButtons.Length; i++)
        {
            if (i + 1 > levelReachedmax)
=======
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for (int i = 0; i < LevelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
>>>>>>> parent of 7990a2f (no shop)
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
<<<<<<< HEAD
                levelReached = NextLevel;
=======
>>>>>>> parent of 7990a2f (no shop)
                SceneManager.LoadScene(1);
                PlayerPrefs.SetInt("levelReached", NextLevel);
            }
        }
    }

    public void LevelSelection(int LevelNum)
    {
        SceneManager.LoadScene(LevelNum + 1);
    }
<<<<<<< HEAD
=======

>>>>>>> parent of 7990a2f (no shop)
}
