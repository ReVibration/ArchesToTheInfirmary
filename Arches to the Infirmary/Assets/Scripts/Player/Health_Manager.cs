using UnityEngine;

public class Health_Manager : MonoBehaviour
{
    // INITIALISE the amount of health for the player 
    [SerializeField] int health = 10;
    //REFERENCE the ui manager 
    [SerializeField] GameObject healthUi;
    private void Update()
    {
        // If the player's health drops to 0
        if(health <= 0)
        {
            // DESTROY the player 
            Destroy(gameObject);
        }
    }
    // AddHealth is a method that will increment the health
    void AddHealth(int amount)
    {
        //INCREMENT the health 
        health += amount;
        //RUN the update health method from the uiManager
        healthUi.SendMessage("UpdateHealth", health);
    }

    // RemoveHealth is a method that will decrease the health
    void RemoveHealth(int amount)
    {
        //DECREASE the health 
        health -= amount;
        //RUN the update health method from the uiManager
        healthUi.SendMessage("UpdateHealth", health);
    }

}

