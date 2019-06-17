using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoyancy : MonoBehaviour
{
    float y;
    public float ro ;
    [SerializeField] GameObject obj;
    Rigidbody rb;
    private void Start()
    {
        rb = obj.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if (transform.position.y < 0)
        {
            float t = -transform.position.y;
            float r = -0.2f;
            float V = -(t * t * t / 3 + r * r + 2 / 3 * r * r * r) * Mathf.PI;
            Vector3 p = new Vector3(0, V * 9.8f, 0);
            rb.AddForceAtPosition(-ro*p, transform.position);
         }
    }
}
