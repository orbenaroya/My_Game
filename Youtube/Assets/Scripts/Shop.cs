using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class Shop : MonoBehaviour
{
    Coins coins;
    public TextMeshProUGUI textcoin;

    void Start()
    {
        coins = FindObjectOfType<Coins>().GetComponent<Coins>();
        textcoin.text = "Coins: " + coins.GetCoin();
    }

    void update()
    {
        textcoin.text = "Coins: " + coins.GetCoin();
    }
    public void buy (int price)
    {
        if(coins.GetCoin() > price)
        {
            coins.SetCoin(coins.GetCoin() - price);
            textcoin.text = "Coins: " + coins.GetCoin();
        }
    }
}
