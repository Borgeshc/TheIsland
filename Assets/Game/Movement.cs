using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public float speed = 10.0f;
    public float gravity = 10.0f;
    public float maxVelocityChange = 10.0f;
    public float rotationSpeed;
    public bool canJump = true;
    public float jumpHeight = 2.0f;
    private bool grounded = false;

    [Header("Animation Variables")]
    public Animator anim;
    public float idleTimer;

    float horizontal;
    float horizontal2;
    float vertical;
    int timer;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        rb.useGravity = true;
    }

    void FixedUpdate()
    {
        vertical = Input.GetAxis("Vertical");

        horizontal2 = Input.GetAxis("Horizontal2") * rotationSpeed * Time.deltaTime;    //Rotate character

        if(vertical > 0 && grounded)
        {
            Vector3 targetVelocity = new Vector3(0, 0, vertical);
            targetVelocity = transform.TransformDirection(targetVelocity);
            targetVelocity *= speed;

            Vector3 velocity = rb.velocity;
            Vector3 velocityChange = (targetVelocity - velocity);
            velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
            velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
            velocityChange.y = 0;
            rb.AddForce(velocityChange, ForceMode.VelocityChange);
            
            if(!grounded)
            rb.AddForce(new Vector3(0, -gravity * rb.mass, 0));

            grounded = false;
        }

        transform.Rotate(0, horizontal2, 0);

        if (vertical > 0 && vertical < .5f)
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("isMoving", true);
        }
        if(vertical >= .5f)
        {
            anim.SetBool("isMoving", false);
            anim.SetBool("isRunning", true);
        }

        if(vertical <= 0)
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("isMoving", false);
            anim.SetBool("isIdle", true);
        }
    }

    void OnCollisionStay()
    {
        grounded = true;
    }
}
