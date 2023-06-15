using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemcollector : MonoBehaviour
{
    int coins = 0;
    [SerializeField] Text CoinsText;
    [SerializeField] AudioSource coinsCollectedSound;

      private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Coin")){
            Destroy(other.gameObject);
            coins++;
            coinsCollectedSound.Play(); 

            print("Coins: " +coins);
            CoinsText.text = "Coins:" + coins; 
        } 



        }
}
