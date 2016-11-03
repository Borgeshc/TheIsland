using System.Collections.Generic;
using UnityEngine;


public class CameraControl : MonoBehaviour
{
    public Transform target;
    public float startDistance = 10f;
    public float maxDistance = 20f;
    public float minDistance = 3f;
    public float zoomSpeed = 20f;
    public float targetHeight = 2.0f;
    public float camRotationSpeed = 70;
    public float rotationDamping = 3.0f;
    public float camXAngle = 15.0f;
    public bool fadeObjects = false;
    public List<int> layersToTransparent = new List<int>();
    public float alpha = 0.3f;

    private Transform myTransform;
    private Transform prevHit;
    private float minCameraAngle = 0.0f;
    private float maxCameraAngle = 90.0f;

    void Start()
    {
        myTransform = transform;
        myTransform.position = target.position;

        if (target == null)
        {
            Debug.LogWarning("No taget added!");
        }

    }

    void LateUpdate()
    {

        if (target == null)
        {
            return;
        }

        float mw = Input.GetAxis("Mouse ScrollWheel");
        if (mw > 0)
        {
            startDistance -= Time.deltaTime * zoomSpeed;
            if (startDistance < minDistance)
                startDistance = minDistance;
        }
        else if (mw < 0)
        {
            startDistance += Time.deltaTime * zoomSpeed;
            if (startDistance > maxDistance)
                startDistance = maxDistance;
        }

        if (Input.GetButton("Fire3"))
        {
            float v = Input.GetAxis("Mouse Y");
            if (v > 0)
            {
                camXAngle += camRotationSpeed * Time.deltaTime;
                if (camXAngle > maxCameraAngle)
                {
                    camXAngle = maxCameraAngle;
                }
            }
            else if (v < 0)
            {
                camXAngle += -camRotationSpeed * Time.deltaTime;
                if (camXAngle < minCameraAngle)
                {
                    camXAngle = minCameraAngle;
                }
            }
        }

        float wantedRotationAngle = target.eulerAngles.y;
        float currentRotationAngle = myTransform.eulerAngles.y;
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
        Quaternion currentRotation = Quaternion.Euler(camXAngle, currentRotationAngle, 0);

        myTransform.position = target.position;
        myTransform.position -= currentRotation * Vector3.forward * startDistance + new Vector3(0, -1 * targetHeight, 0);

        Vector3 targetToLookAt = target.position;
        targetToLookAt.y += targetHeight;
        myTransform.LookAt(targetToLookAt);

        if (fadeObjects)
        {
            Ray ray = new Ray(myTransform.position, (target.position - myTransform.position).normalized);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, maxDistance))
            {
                Transform objectHit = hit.transform;
                if (layersToTransparent.Contains(objectHit.gameObject.layer))
                {
                    if (prevHit != null)
                    {
                        prevHit.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                    }
                    if (objectHit.GetComponent<Renderer>() != null)
                    {
                        prevHit = objectHit;
                        prevHit.GetComponent<Renderer>().material.color = new Color(1, 1, 1, alpha);
                    }
                }
                else if (prevHit != null)
                {
                    prevHit.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                    prevHit = null;
                }
            }
        }


    }
}
