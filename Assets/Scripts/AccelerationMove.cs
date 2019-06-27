using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationMove : MonoBehaviour
{
    Vector3 m_acceleration, m_vector, m_position, m_gravity;
    bool isStarted = false;
    [SerializeField]
    Vector3 m_force;
    [SerializeField]
    float m_time,m_mass,COR,k,c;
    // Start is called before the first frame update
    void Start(){
        m_gravity =new Vector3(0, -9.8f, 0);
        m_position = this.transform.position;
        m_acceleration = m_vector = Vector3.zero;
    }

    // Update is called once per frame
    void Update(){
        if (this.transform.position.y > 0) {
            Calculate();
        }
        if (this.transform.position.y < 0) {
            Vector3 force=Vector3.zero;
            force.y = k * (-this.transform.position.y) - c * m_vector.y;
            AddForce(force);
        }
        //if (this.transform.position.y <= 0) {
        //    this.transform.position -= new Vector3(m_vector.x - m_vector.x * COR, m_vector.y - m_vector.y * COR, m_vector.z * COR);
        //}
        if (isStarted) {
            return;
        }
        m_acceleration = m_force / m_mass;
        Calculate();
        isStarted = true;
        //Gravity();
        //if (this.transform.position.x <=0) print(Time.realtimeSinceStartup);
    }
    void Calculate(){
        m_acceleration += Gravity();
        m_vector = m_acceleration * Time.fixedDeltaTime;
        this.transform.position+= m_vector;
    }
    void AddForce(Vector3 force){
        m_acceleration += force;
    }
    Vector3 Gravity(){
        Vector3 vector;
        //vector = 0.5f * new Vector3(0, -9.8f, 0) * Mathf.Pow(Time.fixedDeltaTime,2)0;
        vector = new Vector3(0, -9.8f, 0) * Time.fixedDeltaTime;
        return vector;
    }
    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag == "ground") {
            print(1111);
            //m_acceleration = - 1 * Gravity();
            this.transform.position -= new Vector3(m_vector.x - m_vector.x * COR, m_vector.y - m_vector.y * COR, m_vector.z * COR);
            //Vector3 acceleration,vector;
            //acceleration= new Vector3(m_vector.x * (-0.8f), 10f, 0);
            //vector = acceleration * Time.fixedDeltaTime;
            //this.transform.position += vector;
            // Calculate();
        }
    }
}
