using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisioned){
        // print("yes");
        if(collisioned.gameObject.name =="player"){
            collisioned.gameObject.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit(Collision collisioned){
        // print("no");
        if(collisioned.gameObject.name =="player"){
            collisioned.gameObject.transform.SetParent(null);
        }


    }
}
