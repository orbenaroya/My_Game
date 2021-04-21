using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;
    public Transform player;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            player.transform.position = respawnPoint.transform.position;
        }
    }
}
