using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpring : MonoBehaviour {
    Vector3 targetPos;
    Vector3 acc, vel, pos;

    void Start()
    {
        acc = vel = targetPos = pos = Vector3.zero;
        //targetPos = pos = new Vector3(0, 0, 0);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(this.pos, this.targetPos);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.pos = Camera.main.ScreenPointToRay(Input.mousePosition).origin;
            this.pos.z = 0;
        }
        else
        {
            Vector3 diff = this.targetPos - this.pos;
            this.acc = diff * 0.1f;
            this.vel += this.acc;
            this.vel *= 0.9f;
            this.pos += this.vel;
        }
        transform.position = this.pos;
    }
}
