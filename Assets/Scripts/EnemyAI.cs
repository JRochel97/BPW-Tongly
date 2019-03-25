using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject Player;
    public float movementSpeed = 4;
    public float range = 10;

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(Player.transform.position, transform.position) <= range)
        {
            transform.LookAt(Player.transform);
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
       
    }
}
