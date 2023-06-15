using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.name=="player"){
            print("level comfgsgfspleted!!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);    
        } 

    }
}
