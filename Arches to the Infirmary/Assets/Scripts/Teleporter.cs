using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // REFERENCE the scenemanager 
    [SerializeField] GameObject sceneManager;

    // This method will check whether the player has colided with the teleporter
    // then it will send a message to scene manager to load the next level
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            sceneManager.SendMessage("LoadLevel2");
        }
    }
}
