using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Coins coinsCount;
    void Start()
    {
        coinsCount = FindObjectOfType<Coins>;
        Debug.Log("");
    }

    public void buy (int price)
    {

    }
}
