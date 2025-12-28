using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // REFERENCE the object that the enemy is following
    [SerializeField] GameObject player;
    // INITIALISE how fast the enemy can move
    [SerializeField] float enemyMoveSpeed = 4f;
    // REFERENCE of the enemy's components 
    Rigidbody rb;
    Animator animator;
    // INITIALISE the different radii for the enemy
    [SerializeField] float attackRadius = 2f;
    [SerializeField] float lookRadius = 10f;
    // INITIALISE an attacking boolean to ensure that the enemy doesn't attack multiple times
    bool attacking = false;

    // Start is called before the first frame update
    void Start()
    {
        // GET all the components needed for the script 
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        // FREEZE the enemies rotation so that it doesn't topple over
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        // IF the player exists in the scene
        if (player != null)
        {
            // WORK out the distance between the enemy and the player 
            float distance = Vector3.Distance(player.transform.position, transform.position);

            // IF the enemy is not attacking and within the look radius
            if (!attacking && distance <= lookRadius)
            {
                // LOOK at player
                transform.LookAt(player.transform);
                // MOVE forward
                Vector3 move = new Vector3(0, 0, enemyMoveSpeed);
                // MOVE the enemy using that velocity
                rb.linearVelocity = transform.TransformDirection(move);
            }

            // IF the enemy is within attacking distance 
            if (distance <= attackRadius)
            {
                // START the attacking animation
                animator.SetTrigger("Attack");
                // SET attacking to true
                attacking = true;
            }
        }

    }
    // StopAttacking: This method will reset the player's attacking to allow for another hit 
    // (This will be ran by the animation)
    void StopAttacking()
    {
        attacking = false;
    }
}
