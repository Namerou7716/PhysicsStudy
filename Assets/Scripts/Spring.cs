using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    [SerializeField]
    Transform certain, myposition;
    float r;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        r = (this.GetComponent<Rigidbody>().mass * Mathf.Pow(this.GetComponent<Rigidbody>().drag, 2)) / 3;
        AddSpringForce(r);
    }
    void AddSpringForce(float r) {
        var diff = certain.position - myposition.position;
        var force = diff * r;
        this.GetComponent<Rigidbody>().AddForce(force);
    }
}
