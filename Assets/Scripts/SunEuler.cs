using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunEuler : MonoBehaviour
{
    float dt=60,checkTime;
    float fps;
    float times = 0;
    Vector3 position,vector,acceleration;
    GameObject obj;
    int frameCount = 0;
    float nextTime;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        vector = new Vector3(1f, 0, 1f);
        obj = GameObject.FindGameObjectWithTag("GameController");
        nextTime = Time.time + 1;
        fps = 133;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTime)
        {
            fps = frameCount;
            //print(frameCount);
            frameCount = 0;
            nextTime += 1;
        }
        if (Time.time > checkTime)
        {
            print(this.transform.position);
            checkTime += 1;
        }
        //TextEuler();
        MyEuler();
        //VectorTextEuler();
        //VectorMyEuler();
        
        
    }
    public void TextEuler()
    {
        position = this.transform.position;
        position = (position + vector*dt)/(dt*dt);
        this.transform.position += position;
        position = Vector3.zero;
    }
    public void MyEuler()
    {
        position = this.transform.position;
        position = position + vector*dt;
        position /= (dt * fps);
        print(position);
        this.transform.position += position;
    }
    public void VectorTextEuler()
    {
        position = this.transform.position;
        vector = vector - position * dt;
        position += vector/(dt*dt);
        //print(vector);
        this.transform.position = position;
    }
    public void VectorMyEuler()
    {
        position = this.transform.position;
        acceleration = vector / dt;
        acceleration /= (dt*dt);
        vector = vector + acceleration * dt;
        //print(vector);
        position += vector/60;
        this.transform.position = position;
    }

}
