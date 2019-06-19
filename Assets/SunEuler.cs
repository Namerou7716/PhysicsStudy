using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunEuler : MonoBehaviour
{
    [SerializeField] float dt,checkTime;
    Vector3 position,vector,acceleration;
    float nextFrame=0;
    CheckCollision check;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        vector = new Vector3(1f, 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        TextEuler();
        //MyEuler();
        if (GameObject.Find("Cube").GetComponent<CheckCollision>().time == checkTime+nextFrame)
        {
            print(this.transform.position);
            nextFrame += 60;
        }
       // print(acceleration);
    }
    public void TextEuler()
    {
        position = this.transform.position;
        //vector = vector - position* dt;
        position = (position + vector*dt)/3600;
        this.transform.position += position;
        //vector = Vector3.zero;
        position = Vector3.zero;
    }
    public void MyEuler()
    {
        position = this.transform.position;
        //acceleration = vector / dt;
       // vector = vector + acceleration*dt;
        position = (position + vector*dt)/3600;
        this.transform.position += position;
        //vector = Vector3.zero;
        acceleration = Vector3.zero;

    }
}
