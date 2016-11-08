using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
    //This script requires a collider.

    [Tooltip("How much health does this object have?")]
    public float health;
    [Tooltip("This is the tag that the projectile needs.")]
    public string projectileTag;

    private float currentHealth;

    void Start()
    {
        currentHealth = health;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == projectileTag)
        {
            TookDamage();
        }
    }

    public void TookDamage()
    {
        currentHealth--;
        if(currentHealth <= 0)
        {
            WasDestroyed();
        }
    }

    public void WasDestroyed()
    {
        Destroy(gameObject);
    }
}
