using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coins : MonoBehaviour
{
    public TextMeshProUGUI textcoin;
    public static int countCoin = 0;


    void Start()
    {
        textcoin.text = "Coins: " + countCoin;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            SetCoin(countCoin + 1);
            textcoin.text = "Coins: " + GetCoin();
            Destroy(other.gameObject);
        }
    }

    public int GetCoin()
    {
        return countCoin;
    }

    public int SetCoin(int NewCoin)
    {
        countCoin = NewCoin;
        return countCoin;
    }
}
