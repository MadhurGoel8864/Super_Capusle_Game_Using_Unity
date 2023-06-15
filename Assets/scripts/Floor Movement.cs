using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject[]  waypoints; 
    [SerializeField] float speed = 1f;  
    int currentWayPointIndex =0;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, waypoints[currentWayPointIndex].transform.position) < 0.1f){
            currentWayPointIndex++;
            if(currentWayPointIndex>=waypoints.Length){
                currentWayPointIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWayPointIndex].transform.position,speed * Time.deltaTime);
    
    
    }
}
