using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerlife : MonoBehaviour
{
    // Start is called before the first frame update
    bool dead = false;
    [SerializeField] AudioSource DeathSound;
    private void Update(){
        if(transform.position.y < -3f && !dead){
            die(); 
        }
    }

      private void OnCollisionEnter(Collision collisioned){
        if(collisioned.gameObject.CompareTag("Enemy Body") ){
        print("player lost");
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic =true;
            GetComponent<scripts>().enabled =false;

            die();
        }
    }

    void die(){
        // transform.position = new Vector3(0.04f,1.29f,-0.050f);
        Invoke(nameof(ReloadLevel),0.5f);  
        DeathSound.Play();
        dead = true;
        Debug.Log("dead");
        // ReloadLevel();
    } 
    void ReloadLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
