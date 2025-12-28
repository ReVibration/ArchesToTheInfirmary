using UnityEngine;

public class Billboard : MonoBehaviour
{
    // REFERENCE the camera
    [SerializeField] Transform cam;

    // Update: This will transform the enemy health to look at the camera
    void LateUpdate()
    {
        // IF the camera exists
        if(cam != null)
        {
            // LOOK at the camera 
            transform.LookAt(transform.position + cam.forward);
        }

    }
}
