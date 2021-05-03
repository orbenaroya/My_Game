﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coins : MonoBehaviour
{
    public TextMeshProUGUI textcoin;
    static int countCoin = 0;

    void Start()
    {
        textcoin.text = "Coins: " + countCoin;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            countCoin++;
            textcoin.text = "Coins: " + countCoin;
            Destroy(other.gameObject);
        }
    }
    public int GetCoin()
    {
        return countCoin;
    }
    public void SetCoin(int newCountcoin)
    {
        countCoin = newCountcoin;
    }
}
