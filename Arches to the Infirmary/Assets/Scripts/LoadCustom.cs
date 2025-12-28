using UnityEngine;

public class LoadCustom : MonoBehaviour
{
    // REFERENCE a list of materails that the player can be 
    [SerializeField] Material[] playerMaterials;
    // REFERENCE the player render
    MeshRenderer playerMesh;

    // Start is called before the first frame update
    void Start()
    {
        // GET the player renderer component
        playerMesh = GetComponent<MeshRenderer>();
        // SET the players materail to use the project wide variable 
        playerMesh.material = playerMaterials[PlayerPrefs.GetInt("CurrentColourIndex")];
    }

}
