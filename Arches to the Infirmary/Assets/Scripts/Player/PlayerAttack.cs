using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //REFERENCE the health manager 
    Health_Manager healthManager;

    //CHECK for collisions
    private void OnTriggerEnter(Collider collision)
    {
        //CHECK whether the game object has a Enemy tag
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // GEt the objects health manager 
            healthManager = collision.gameObject.GetComponent<Health_Manager>();

            //RUN the removehealth for the object that it has colided with
            healthManager.SendMessage("RemoveHealth", 1);
        }

    }
}
