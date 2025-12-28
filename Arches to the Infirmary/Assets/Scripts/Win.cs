using UnityEngine;

public class Win : MonoBehaviour
{
    // REFERENCE the scenemanager 
    [SerializeField] GameObject sceneManager;

    // This method will check whether the player has colided with the teleporter
    // then send the win method to be complete in the scenemanger 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            sceneManager.SendMessage("Win");
        }
    }
}
