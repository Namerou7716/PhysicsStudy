using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    float velocity = 0.0f;
    float acceleration = 0.0f;
    float position = 0.0f;
    float gravity = -9.8f;
    float reaction = 0.7f;
    float dt = 1 / 60;
    Vector3 mytransform;
    private void Start()
    {
        mytransform = this.GetComponent<Transform>().position;
    }
    private void FixedUpdate()
    {
            velocity += gravity *dt;
        position += velocity *dt;
            mytransform.y += velocity;

            this.transform.position = mytransform;
        
        if (this.transform.position.y == 0.5f)
        {
            velocity *= -reaction;
            print(1);
        }
        //print(velocity);
        //print(mytransform);
    }
}
