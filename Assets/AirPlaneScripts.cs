using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlaneScripts : MonoBehaviour
{
    public float target_kmph = 100f;
    private void FixedUpdate() {            
        var rb = GetComponent<Rigidbody>();
        var hori = Input.GetAxis("Horizontal");
        var vert = Input.GetAxis("Vertical");
        rb.AddRelativeTorque(0, hori, -hori);
        rb.AddRelativeTorque(vert, 0, 0);
        var left = transform.TransformVector(Vector3.left);
        var horizontal_left = new Vector3(left.x,0f,left.z).normalized;
        rb.AddTorque(Vector3.Cross(left, horizontal_left) * 2);

    }
}
