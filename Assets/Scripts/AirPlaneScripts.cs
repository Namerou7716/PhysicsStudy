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
        var forward = transform.TransformVector(Vector3.back);
        var hori_forward = new Vector3(forward.x,0f,forward.z).normalized;
        rb.AddTorque(Vector3.Cross(forward, Vector3.down));
        var force = (rb.mass * rb.drag * target_kmph / 3.6f) / (1f - rb.drag * Time.fixedDeltaTime);
        print(force);
        rb.AddRelativeForce(new Vector3(0f, force, 0f));
    }
}
