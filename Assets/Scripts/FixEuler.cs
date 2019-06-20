using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixEuler : MonoBehaviour
{
    Vector3 vector, acceleration, position;
    float dt=60;
    float checkTime = 60;
    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("GameController");
        vector = new Vector3(0, 0, 1f);
        position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
