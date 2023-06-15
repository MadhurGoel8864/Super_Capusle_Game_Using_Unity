 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public void startgame(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);    
    }    
    public void quitgame(){
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);    
            Application.Quit();
    }    
}
