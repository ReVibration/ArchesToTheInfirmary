using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerUIManager : MonoBehaviour
{
    //REFERENCE the score text field
    [SerializeField] Text scoreText;
    [SerializeField] Slider healthBar;
    [SerializeField] SceneManagement sceneManager;

    // OnPlayButton this method will occur when the user presses the 
    // play button it will change to the game scene
    public void PlayGame()
    {
        //LOAD the game scene
        sceneManager.SendMessage("PlayGame");
    }

    // Exit this method will exit the game to the main screen
    public void Exit()
    {
        //QUIT the game 
        sceneManager.SendMessage("Exit");
    }


    // UpdateScore this method will update the score with the given value 
    void UpdateScore(int score)
    {
        // UPDATE the score
        scoreText.text = "Score: " + score;
    }

    // UpdateHealth this method will update the players health with a given value 
    void UpdateHealth(int health)
    {
        // UPDATE the health bar 
        healthBar.value = health;
    }
}
