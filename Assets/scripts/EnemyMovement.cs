using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject[] enemyWayPoints;
    [SerializeField]float speed = 2f;
    int current_box_index = 0;


    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, enemyWayPoints[current_box_index].transform.position) < 0.1f){
            current_box_index++;
            if(current_box_index>=enemyWayPoints.Length){
                current_box_index = 0;
            }
        }


         transform.position = Vector3.MoveTowards(transform.position, enemyWayPoints[current_box_index].transform.position,speed * Time.deltaTime);


    }
}
