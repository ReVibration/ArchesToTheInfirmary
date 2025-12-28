using UnityEngine;

public class Player_Input : MonoBehaviour
{
    // Class Variables 
    [SerializeField] float playerMoveSpeed = 10f; // This is how fast the character will move 
    [SerializeField] float playerLookSpeed = 10f; // This is the speed at which the player will be able to change the looking speed 
    [SerializeField] Vector3 playerJumpForce = new Vector3(0, 5, 0); // This is the vector at which the player will jump
    Rigidbody rb; // This is an reference to the rigidbody of the player 
    Animator animator; // REFERENCE the animator 
    bool Attacking = false; // INITILAISE a bool to stop multiple attacks happening at once 

    // This method will run at the start of the scene
    void Start()
    {
        // ASSIGN the required components from the player 
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // CHANGE the values every update to poke for updates
        Movement();
        look();
        jump();
        Attack();
        SpinAttack();
    }

    // Movement is a method that will use the axis method to get input and then use that input and speed to transform
    // The objects position
    void Movement()
    {
        // This get the axis input from user input
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        // NORMALIZE the vector for smooth movement 
        Vector3 velocity = new Vector3(x, 0, z).normalized;
        velocity *= playerMoveSpeed;
        // TRAMSLATE the velocity into the vector for transforming position
        velocity = transform.TransformDirection(velocity);
        // MAKE the y position relative to what it is currently
        velocity.y = rb.linearVelocity.y;
        // GHANGE the rigidbodies velocity to its new current using spped 
        rb.linearVelocity = velocity;
    }

    // LOOK is a method that will change the y rotation of the player 
    void look()
    {
        // GET & MULTIPLY the x axis of the mouse using the look speed
        float yRotation = Input.GetAxis("Mouse X") * playerLookSpeed;
        //TRANSFORM the rotation accoordingly
        transform.Rotate(0, yRotation, 0);
    }

    // JUMP is a method that will use raycasts and physics to make the object 
    // appear to jump
    void jump()
    {
        // GET the current position
        Vector3 from = transform.position;
        // GET the down direction from the object
        Vector3 dir = Vector3.down;
        // CHECK whether space has been pressed
        bool pressed = Input.GetKeyDown(KeyCode.Space);
        // CHECK whether the object is close to the ground and the user has pressed space
        if (Physics.Raycast(from, dir, 1.1f) && pressed)
        {
            // ADD the force to the object
            rb.AddForce(playerJumpForce, ForceMode.Impulse);
        }
    }

    // Attack: This method will start attacking animation
    void Attack()
    {
        // INITIALISE a variable that will check for the left mouse button 
        bool AttackPressed = Input.GetMouseButtonDown(0);
        // CHECK if it is pressed and whether the player isn't attacking already
        if (AttackPressed && !Attacking)
        {
            // RUN the animation 
            animator.SetTrigger("Attack");
            // SET attacking to true
            Attacking = true;
        }
    }

    // SpinAttack: This method will start the special attacking animation
    void SpinAttack()
    {
        // INITIALISE a variable that will check for the right mouse button 
        bool SAttackPressed = Input.GetMouseButtonDown(1);
        // CHECK if it is pressed and whether the player isn't attacking already
        if (SAttackPressed && !Attacking)
        {
            // RUN the animation 
            animator.SetTrigger("SpinAttack");
            // SET attacking to true
            Attacking = true;
        }
    }

    // StopAttacking: This method will reset the player's attacking to allow for another hit 
    // (This will be ran by the animation)
    void StopAttacking()
    {
        Attacking = false;
    }

}
