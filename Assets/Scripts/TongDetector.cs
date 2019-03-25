using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongDetector : MonoBehaviour
{
    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Object")
        {
            Player.GetComponent<TongLicked>().licked = true;
            Player.GetComponent<TongLicked>().lickedObj = other.gameObject;
        }

        if(other.tag == "Enemy")
        {
            Player.GetComponent<TongLicked>().EnemyKilled = true;
            Player.GetComponent<TongLicked>().ScaryEnemy = other.gameObject;
        }
    }
}
