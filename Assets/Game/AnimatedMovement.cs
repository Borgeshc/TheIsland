using UnityEngine;
using System.Collections;

public class AnimatedMovement : MonoBehaviour
{
    float horizontal;
    float vertical;
    float running;
    
    Animator anim;

    void Start ()
    {
        anim = GetComponent<Animator>();   
	}
	
	void Update ()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        Running();
        if(vertical > 0 || horizontal > 0)
        {
            print("ishappening");
        }
	}

    void FixedUpdate()
    {
        anim.SetFloat("Vertical", vertical);
        anim.SetFloat("Horizontal", horizontal);
        anim.SetFloat("Run", running);
    }

    void Running()
    {
        if(Input.GetButton("Fire2"))
        {
            running = 0.2f;
        }
        else
        {
            running = 0.0f;
        }
    }
}
