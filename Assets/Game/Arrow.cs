using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour
{
    public float speed;

	void Update ()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Destroy(gameObject, 6);
	}
}
