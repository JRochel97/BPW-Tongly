using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public GameObject Player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Player.GetComponent<TongLicked>().EnemiesKilled.ToString() + " | 7";  
    }

}
