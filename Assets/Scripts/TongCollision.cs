using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Object")
        {
            Debug.Log("I can lick this");
        }

        if (collisionInfo.collider.tag == "Enemy")
        {
            Debug.Log("Doesn't taste good");
        }
    }
}
