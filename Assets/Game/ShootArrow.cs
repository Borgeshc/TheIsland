using UnityEngine;
using System.Collections;

public class ShootArrow : MonoBehaviour
{
    public GameObject arrow;

    void OnEnable()
    {
        Instantiate(arrow, transform.position, transform.rotation);
    }
}
