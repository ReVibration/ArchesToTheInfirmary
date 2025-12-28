using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    //REFERENCE the score manager and health manager 
    [SerializeField] GameObject scoreManager;
    [SerializeField] Health_Manager healthManager;

    //CHECK for collisions
    private void OnCollisionEnter(Collision collision)
    {
        //CHECK whether the game object has a coin tag
        if (collision.gameObject.CompareTag("Coin"))
        {
            //RUN the Add score method from scoreManager
            scoreManager.SendMessage("AddScore",1);
            //DESTROY the object its colided with
            Destroy(collision.gameObject);
        }

    }

    // CHECK whether the player has colided with an enemies weapon
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("EnemyWeapon"))
        {
            // REMOVE health from the player 
            healthManager.SendMessage("RemoveHealth", 1);
        }
    }


}
