using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixEuler : MonoBehaviour
{
    Vector3 vector, acceleration, position;
    float dt = 60;
    float checkTime = 0;
    GameObject obj;
    int frameCount=0;
    float nextTime,fps,prevtime;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("GameController");
        vector = new Vector3(1f, 0, 1f);
        position = this.transform.position;
        nextTime = Time.time + 1;
        fps = 133;
    }

    // Update is called once per frame
    void Update()
    {
        //FixEulerText();
        FixMyEuler();
        frameCount++;
        if (Time.time >= nextTime)
        {
            fps = frameCount;
            //print(frameCount);
            frameCount = 0;
            nextTime += 1;
            print(this.transform.position);
        }
    }
    void FixEulerText()
    {
        position = this.transform.position;
        position = (position + 0.5f*(vector + (vector - position * dt)) * dt)/3600;
        this.transform.position += position;
    }
    void FixMyEuler()
    {
        position = this.transform.position;
        position = position + 0.5f * (position/dt + (position + vector*dt) / dt) * dt;
        position /= (fps*dt);
        this.transform.position += position;
    }
}
