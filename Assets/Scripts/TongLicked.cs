using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongLicked : MonoBehaviour
{
    public GameObject tong;
    public GameObject TongPivot;

    public float tongTravelSpeed;
    public float playerTravelSpeed;

    public static bool fired;
    public bool licked;
    public GameObject lickedObj;

    public float maxDistance;
    private float currentDistance;

    public bool EnemyKilled;
    public GameObject ScaryEnemy;

    private void Update()
    {

        // Firing the tong
        if (Input.GetMouseButtonDown(0) && fired == false)
        {
            fired = true;
        }


        if (fired == true && licked == false)
        {
            tong.transform.Translate(Vector3.forward * Time.deltaTime * tongTravelSpeed);
            currentDistance = Vector3.Distance(transform.position, tong.transform.position);

            if (currentDistance >= maxDistance)
            {
                ReturnTong();
            }
        }
        // Transport player to Tong Posistion
        if (licked == true)
        {
            tong.transform.parent = lickedObj.transform;
            Vector3 tongPosition = Vector3.Scale(tong.transform.position, new Vector3(1, 0, 1));
            transform.position = Vector3.MoveTowards(transform.position, tongPosition, Time.deltaTime * playerTravelSpeed);
            float distanceToTong = Vector3.Distance(transform.position, tongPosition);

            this.GetComponent<Rigidbody>().useGravity = false;

            if(distanceToTong < 0.25)
            {
                ReturnTong();
            }
        } else {
            tong.transform.parent = TongPivot.transform;
            this.GetComponent<Rigidbody>().useGravity = true;
        }

        if (EnemyKilled == true && fired == true)
        {
            Destroy(ScaryEnemy);
            Debug.Log("Destroyed");
        }
    }
    // Returns Tong to Player
    void ReturnTong()
    {
        tong.transform.rotation = TongPivot.transform.rotation;
        tong.transform.position = TongPivot.transform.position;
        fired = false;
        licked = false;
    }
}
