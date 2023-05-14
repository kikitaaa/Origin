using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int CoinValue = 1;
    public Shop coins;
    public AudioClip coinSound;
    [Range(0, 1)]
    public float coinVolume;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Kai>())
        {
            coins.AddCoins(CoinValue);
            coins.UpdateCoinsText();
            Debug.Log("Monedas añadidas.");
            Destroy(gameObject);
            AudioManager.instance.PlayAudio(coinSound, coinVolume);
        }
    }
}
