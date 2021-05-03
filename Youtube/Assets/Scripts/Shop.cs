using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class Shop : MonoBehaviour
{
    void Start()
    {
        Debug.Log("");
    }

    public void buy (int price)
    {

=======
using UnityEngine.SceneManagement;
using TMPro;



public class Shop : MonoBehaviour
{
    Coins coins;
    public TextMeshProUGUI textcoin;

    void Start()
    {
        coins = FindObjectOfType<Coins>().GetComponent<Coins>();
    }

    void Update()
    {
        textcoin.text = "Coins: " + coins.GetCoin();
    }

    public void buy (int price)
    {
        if(coins.GetCoin() > price)
        {
            coins.SetCoin(coins.GetCoin() - price);
    
        }
>>>>>>> parent of 7990a2f (no shop)
    }
}
