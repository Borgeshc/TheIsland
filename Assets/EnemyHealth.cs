using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int baseHealth;
    public float fillAmount;
    public GameObject healthBar;
    int currentHealth;
    Image health;
	void Start ()
    {
        health = healthBar.GetComponent<Image>();
        currentHealth = baseHealth;
	}
	
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Arrow")
        {
            Destroy(other.gameObject);
            TookDamage();
        }
    }

	public void TookDamage ()
    {
        currentHealth--;
        health.fillAmount = health.fillAmount - fillAmount;
        if(currentHealth <= 0)
        {
            Died();
        }
	}

    public void Died()
    {
        Destroy(gameObject);
    }
}
