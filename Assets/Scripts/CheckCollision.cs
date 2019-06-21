using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    //int frameCount;
    //float nextTime;
    //public float dt;
    private void Start()
    {
        //frameCount = 0;
        //nextTime = Time.time+1;
    }
    private void Update()
    {
        //++frameCount;
        //float time = Time.realtimeSinceStartup - prevTime;
        //if (time >= 0.5f)
        //{
        //    dt = frameCount / time;
        //    frameCount = 0;
        //    prevTime = Time.realtimeSinceStartup;
        //}
        //frameCount++;
        //if (Time.time >= nextTime)
        //{
        //    dt = frameCount;
        //    print(frameCount);
        //    frameCount = 0;
        //    nextTime += 1;
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("Hit");
            print(Time.time);
        }
    }
}
