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

    void Update()
    {

        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        horizontal2 = Input.GetAxisRaw("Horizontal2") * rotationSpeed * Time.deltaTime;    //Rotate character
    }
    void FixedUpdate()
    {
        anim.SetFloat("vertical", vertical);
        anim.SetFloat("horizontal", horizontal);
        //anim.SetFloat("Horizon", horizontal);
      //  anim.SetFloat("Vertical", vertical);
        if(grounded)
        {
            Vector3 targetVelocity = new Vector3(horizontal, 0, vertical);
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

        if (vertical > .2f && vertical < .5f) //forward
        {
            anim.SetBool("isRunningRight", false);
            anim.SetBool("isWalkingRight", false);
            anim.SetBool("isRunningLeft", false);
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isRunningForward", false);
            anim.SetBool("isRunningBack", false);
            anim.SetBool("isWalkingBack", false);
            anim.SetBool("isIdle", false);

            anim.SetBool("isWalkingForward", true);
        }
        if (vertical < -.2f && vertical > -.5f)//back
        {
            anim.SetBool("isRunningRight", false);
            anim.SetBool("isWalkingRight", false);
            anim.SetBool("isRunningLeft", false);
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isRunningForward", false);
            anim.SetBool("isWalkingForward", false);
            anim.SetBool("isRunningBack", false);
            anim.SetBool("isIdle", false);

            anim.SetBool("isWalkingBack", true);
        }

        if (horizontal > .2f && horizontal < .5f) //right
        {
            anim.SetBool("isRunningRight", false);
            anim.SetBool("isRunningLeft", false);
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isRunningForward", false);
            anim.SetBool("isWalkingForward", false);
            anim.SetBool("isRunningBack", false);
            anim.SetBool("isWalkingBack", false);
            anim.SetBool("isIdle", false);

            anim.SetBool("isWalkingRight", true);
        }
        if (horizontal < -.2f && horizontal > -.5f)//left
        {
            anim.SetBool("isRunningRight", false);
            anim.SetBool("isWalkingRight", false);
            anim.SetBool("isRunningLeft", false);
            anim.SetBool("isRunningForward", false);
            anim.SetBool("isWalkingForward", false);
            anim.SetBool("isRunningBack", false);
            anim.SetBool("isWalkingBack", false);
            anim.SetBool("isIdle", false);

            anim.SetBool("isWalkingLeft", true);
        }


        if (vertical >= .5f)//run forward
        {
            anim.SetBool("isRunningRight", false);
            anim.SetBool("isWalkingRight", false);
            anim.SetBool("isRunningLeft", false);
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isWalkingForward", false);
            anim.SetBool("isRunningBack", false);
            anim.SetBool("isWalkingBack", false);
            anim.SetBool("isIdle", false);

            anim.SetBool("isRunningForward", true);
        }

        if (vertical <= -.5f)//run back
        {
            anim.SetBool("isRunningRight", false);
            anim.SetBool("isWalkingRight", false);
            anim.SetBool("isRunningLeft", false);
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isRunningForward", false);
            anim.SetBool("isWalkingForward", false);
            anim.SetBool("isWalkingBack", false);
            anim.SetBool("isIdle", false);

            anim.SetBool("isRunningBack", true);
        }
        if (horizontal >= .5f)//run right
        {
            anim.SetBool("isWalkingRight", false);
            anim.SetBool("isRunningLeft", false);
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isRunningForward", false);
            anim.SetBool("isWalkingForward", false);
            anim.SetBool("isRunningBack", false);
            anim.SetBool("isWalkingBack", false);
            anim.SetBool("isIdle", false);

            anim.SetBool("isRunningRight", true);
        }

        if (horizontal <= -.5f)//run left
        {
            anim.SetBool("isRunningRight", false);
            anim.SetBool("isWalkingRight", false);
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isRunningForward", false);
            anim.SetBool("isWalkingForward", false);
            anim.SetBool("isRunningBack", false);
            anim.SetBool("isWalkingBack", false);
            anim.SetBool("isIdle", false);

            anim.SetBool("isRunningLeft", true);
        }

        if (vertical <= .2f && vertical >= -.2f && horizontal <= .2f && horizontal >= -.2f)
        {
           // anim.SetBool("Shoot", false);
            anim.SetBool("isRunningRight", false);
            anim.SetBool("isWalkingRight", false);
            anim.SetBool("isRunningLeft", false);
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isRunningForward", false);
            anim.SetBool("isWalkingForward", false);
            anim.SetBool("isRunningBack", false);
            anim.SetBool("isWalkingBack", false);
            anim.SetBool("isIdle", true);
        }
    }

    void OnCollisionStay()
    {
        grounded = true;
    }
}
