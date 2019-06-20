using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    float velocity = 0.0f;
    float mass = 1;
    [SerializeField]float damper;
    float Force;
    float acceleration = 0.0f;
    float position = 0.0f;
    float gravity = -9.8f;
    [SerializeField]float reaction;
    float dt = 1f / 1200f;
    Vector3 mytransform;
    Vector3 cubeLength;
    private void Start()
    {
        mytransform = this.GetComponent<Transform>().position;
        cubeLength = this.GetComponent<Renderer>().bounds.size;
    }
    private void FixedUpdate()
    {
        Force += -9.8f;
        acceleration = Force;
        velocity += acceleration * dt;
        position = velocity *dt;
        mytransform.y += position;
        this.transform.position = mytransform;
        if (this.transform.position.y < 0.5f)
        {
            //Force += (reaction * (cubeLength.y / 2 - this.transform.position.y)-damper*velocity);
            //velocity = -velocity*0.8f;
            float returnVelocity;
            float Impulse;
            returnVelocity = -velocity * 0.5f;
            Impulse = returnVelocity - velocity;
            print(Impulse);
            Force += Impulse;
        }
       /* if (this.transform.position.y == 0.5f)
        {
            velocity *= -reaction;
            print(1);
        }
        */
        //print(velocity);
    }
}
