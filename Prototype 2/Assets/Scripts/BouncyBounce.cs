using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBounce : MonoBehaviour
{
    public float force;
    float actualForce;
    Rigidbody rigid;


    void Start()
    {
        rigid = GetComponent<Rigidbody>(); 
    }

    
    void FixedUpdate()
    {
        rigid.AddForce(Physics.gravity * TimeManaging.GetInstance().myTimeScale);

        Vector3 velocity = rigid.velocity * TimeManaging.GetInstance().myTimeScale;

        rigid.velocity = velocity;
    }
}
