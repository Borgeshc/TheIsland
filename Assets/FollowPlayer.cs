using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
    public float speed;
    GameObject target;
    NavMeshAgent nav;

	void Start () {
        target = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update ()
    {
        transform.LookAt(target.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
      //  transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
	}
}
