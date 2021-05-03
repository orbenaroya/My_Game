using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    Coins coins;
    public TextMeshProUGUI textcoin;

    void Start()
    {
        coins = FindObjectOfType<Coins>().GetComponent<Coins>();
        textcoin.text = "Coins: " + coins.GetCoin();
        Debug.Log(coins.GetCoin());
    }

    public void buy (int price)
    {
        if (coins.GetCoin() > price)
        {
            coins.SetCoin(price);
        }
    }
}
