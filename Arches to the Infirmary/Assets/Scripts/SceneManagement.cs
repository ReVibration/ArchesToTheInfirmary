using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // OnPlayButton this method will occur when the user presses the 
    // play button it will change to the game scene
    public void PlayGame()
    {
        //LOAD the game scene
        SceneManager.LoadScene("1 Level");
    }

    // Exit this method will exit the game to the main screen
    public void Exit()
    {
        //QUIT the game 
        Application.Quit();
    }

    // Died this method will load the game over scene
    public void Died()
    {
        SceneManager.LoadScene("3 Game Over");
    }

    // BackToMenu this method will take the player back to the menu from settings
    public void BackToMenu()
    {
        SceneManager.LoadScene("0 Menu");
    }

    // Settings this method will take the player to the settings menu
    public void Settings()
    {
        SceneManager.LoadScene("5 Settings");
    }

    // LoadLevel2 This will load the second level of the game 
    public void LoadLevel2()
    {
        SceneManager.LoadScene("2 Level");
    }

    // Win this will load the player in the winning page 
    public void Win()
    {
        SceneManager.LoadScene("4 Win");
    }

}
