using UnityEngine;

public class Score_Manager : MonoBehaviour
{
    int score = 0;
    //REFERENCE the ui manager 
    [SerializeField] GameObject uiManager;

    // AddScore is a method that will increment the score 
    void AddScore(int amount)
    {
        //INCREMENT the score 
        score += amount;
        //RUN the update score method from the uiManager
        uiManager.SendMessage("UpdateScore",score);
    }
}
