using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundSimulation : MonoBehaviour
{
    Vector3 gravity, acceleration, vector, position, force;
    float dt, fps;
    // Start is called before the first frame update
    void Start()
    {
        dt = 1 / 60f;
        gravity = new Vector3(0f, -9.8f, 0f);
        position = this.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AddForce(gravity);
        vector += acceleration * dt;
        position += vector * dt;
        if(position.y < 0.5f)
        {
            vector = -vector;
        }
        this.transform.position = position;
        acceleration = Vector3.zero;
        //force = Vector3.zero;
    }
    void AddForce(Vector3 hogeforce)
    {
        acceleration += hogeforce;
    }
    //private void OnCollisionEnter(Collision collision)
    //{
        //if (collision.gameObject.tag == "ground")
        //{
        //    print(1);
        //    //Vector3 afteVector = -0.8f * vector;
        //    //Vector3 Impulse;
        //    //Impulse = afteVector - vector;
        //    //AddForce(Impulse);
        //    vector = vector * (-0.8f);
        //}
    //}
}
