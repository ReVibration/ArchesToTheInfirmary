using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    // REFERENCE the door game object 
    [SerializeField] GameObject door;
    // INITILAISE a boolean to check whether the pressure plate has been triggered
    bool triggered = false;

    // This method will check whether the player has triggered the pressure plate 
    private void OnTriggerEnter(Collider other)
    {
        // IF the player has pressed the presure plate and it hasn't been triggered before
        if (other.gameObject.CompareTag("Player") && triggered == false)
        {
            // SET triggered to true to avoid retriggering 
            triggered = true;
            // MOVE the pressure plate down
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
            // SEND a message to trigger the door 
            door.SendMessage("Trigger");
        }
    }
}
