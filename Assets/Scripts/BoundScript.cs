using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundScript : MonoBehaviour
{
    private void FixedUpdate()
    {
        var rb = GetComponent<MyRigidbody>();
       rb.AddForce(new Vector3(0, -9.8f, 0));
    }
}
