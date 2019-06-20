using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixEuler : MonoBehaviour
{
    Vector3 vector, acceleration, position;
    float dt=60;
    float checkTime = 60,times=0;
    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("GameController");
        vector = new Vector3(1f, 0, 1f);
        position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //FixEulerText();
        FixMyEuler();
        if (obj.GetComponent<CheckCollision>().time == checkTime)
        {
            print(this.transform.position);
            checkTime += 60;
            times += 1;
            print(times);
        }
    }
    void FixEulerText()
    {
        position = this.transform.position;
        position = (position + 0.5f*(vector + (vector - position * dt)) * dt)/3600;
        this.transform.position = position;
    }
    void FixMyEuler()
    {
        position = this.transform.position;
        position = position + 0.5f * (position/dt + (position + vector*dt) / dt) * dt;
        this.transform.position += position/3600;
    }
}
