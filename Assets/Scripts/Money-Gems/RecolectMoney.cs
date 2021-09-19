using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecolectMoney : MonoBehaviour
{
    private float coins = 0;
    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.transform.tag == "Coins")
        {
            coins++;
            textCoins.text = coins.ToString();
            Destroy(other.gameObject);
        }
    }
}
