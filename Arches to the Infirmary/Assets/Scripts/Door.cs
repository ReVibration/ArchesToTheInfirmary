using UnityEngine;

public class Door : MonoBehaviour
{
    // REFERENCE the animator 
    Animator animator;

    // This method is executed when the scene is loaded 
    private void Start()
    {
        // GET the animator component 
        animator = GetComponent<Animator>();
    }

    // TRIGGGER this method will trigger the open animation
    private void Trigger()
    {
        animator.SetBool("Open", true);
    }
}
