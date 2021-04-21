using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;
    public Transform player;
    public int NextLevel = 2;
    void WinLevel()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("levelReached", NextLevel);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            player.transform.position = respawnPoint.transform.position;
        }
        if (other.gameObject.layer == 10)
        {
            WinLevel();
        }
    }
}
