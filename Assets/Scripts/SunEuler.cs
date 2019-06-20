using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunEuler : MonoBehaviour
{
    [SerializeField] float dt,checkTime;
    float times = 0;
    Vector3 position,vector,acceleration;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        vector = new Vector3(1f, 0, 1f);
        obj = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        //TextEuler();
        MyEuler();
        //VectorTextEuler();
        //VectorMyEuler();
        if (obj.GetComponent<CheckCollision>().time == checkTime)
        {
            print(this.transform.position);
            checkTime += 60;
            times += 1;
            print(times);
            //print(vector);
        }
       // print(acceleration);
    }
    public void TextEuler()
    {
        position = this.transform.position;
        position = (position + vector*dt)/3600;
        this.transform.position += position;
        position = Vector3.zero;
    }
    public void MyEuler()
    {
        position = this.transform.position;
        position = (position + vector*dt)/3600;
        this.transform.position += position;
        //print(this.transform.position);
    }
    public void VectorTextEuler()
    {
        position = this.transform.position;
        vector = vector - position * dt;
        position += vector/3600;
        //print(vector);
        this.transform.position = position;
    }
    public void VectorMyEuler()
    {
        position = this.transform.position;
        acceleration = vector / dt;
        acceleration /= 3600;
        vector = vector + acceleration * dt;
        //print(vector);
        position += vector/60;
        this.transform.position = position;
    }
}
