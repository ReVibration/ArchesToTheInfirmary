using UnityEngine;

public class GameManager : MonoBehaviour
{
    // REFERENCE the player and scene manager
    GameObject player;
    [SerializeField] GameObject sceneManager;

    // THIS will occur when the scene will start
    private void Start()
    {
        // FIND the player object and assign it 
        player = GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    void Update()
    {
        // IF the player object doesn't exist 
        if(player == null)
        {
            // SEND a message to the scene manager to load Game OVer
            sceneManager.SendMessage("Died");
        }
    }
}
