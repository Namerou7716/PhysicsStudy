using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRigidbody : MonoBehaviour
{
    public Vector3 acceleration;
    public Vector3 velocity;
    //public Vector3 COR;
    public Vector3 position;
    const float dt = 1 / 60f;
    public void AddForce(Vector3 force)
    {
        acceleration += force;    
    }
    private void Start()
    {
        position = transform.position;
    }
    private void FixedUpdate()
    {
        velocity += acceleration * dt;
        position += velocity * dt;
        if (position.y < 0.5f)
        {
            velocity = -velocity;
        }
        transform.position = position;
        acceleration = Vector3.zero;
    }

}
