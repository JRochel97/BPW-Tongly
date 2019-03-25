using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera cam;

    public float lookSensX = 15f;
    public float lookSensY = 15f;
    public float maxAngle = 85f;
    public float maxAngleY = 85f;

    private float angleX = 0;
    private float angleY = 0;

    public Transform body;

    public GameObject TongPivot;
    public GameObject Tong;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // Let you look around with your Mouse.
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        angleX += mouseX * lookSensX;
        angleY += mouseY * lookSensY;
        angleY = Mathf.Clamp(angleY, -maxAngleY, maxAngleY);

        body.transform.rotation = Quaternion.Euler(-angleY + 0, angleX + 180, +0);  

        TongPivot.transform.rotation = Quaternion.Euler(-angleY + 0, angleX + 180, +0);

      
    }

    void OnCollisionEnter(Collision col)
    {
       // Reloading the scene when you've fallen off the Island
       if (col.gameObject.tag == "Death")
        {
            SceneManager.LoadScene("wha");
        }

       if( col.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("wha");
        }
    }

}
