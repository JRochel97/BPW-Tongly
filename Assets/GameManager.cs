using UnityEngine;

public class GameManager : MonoBehaviour
{
   public int EnemyNumberRemaining;
    public GameObject CompleteLevelUI;

   private void Update()
    {
        if(EnemyNumberRemaining <= 0)
        {
            Winning();
        }
    }

    void Winning()
    {
        CompleteLevelUI.SetActive(true);
    }
}
