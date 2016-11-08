using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{
    public float shootFreq;
    Animator anim;
    float timer;

	void Start () {
        anim = GetComponent<Animator>();
	}

	void Update ()
    {
        if(Input.GetButton("Fire1"))
        {
            print("IsAiming");
            anim.SetBool("Aim", true);
            if (Input.GetButtonDown("Fire2") && Time.time > timer + shootFreq)
            {
                print("Shot");
                timer = Time.time;
                anim.SetBool("Shoot", true);
            }
            else
            {
                anim.SetBool("Shoot", false);
            }
        }
        else
        {
            anim.SetBool("Aim", false);
        }
	}

    IEnumerator WaitForAnim()
    {
        yield return new WaitForSeconds(1);
    }
}
